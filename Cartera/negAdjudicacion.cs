namespace NegociosCartera
{
    #region Librerias
    using Conexiones;
    using Microsoft.EntityFrameworkCore;
    using ModelCartera;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    // 22 ABIRL 2020 15:30 
    #endregion

    public class negAdjudicacion : NegConsultasCartera
    {
        #region Propiedades
        public calculos CalculosExtraordinario = new calculos();
        public calculos CalculosFinanciacion = new calculos();
        public decimal Difencia = 0;
        public DataTable DtContado = new DataTable();
        public DataTable DtFinanciacion = new DataTable();
        public DataTable DtInicial = new DataTable();
        public adjudicacion EntAdjudicacion = new adjudicacion();
        public oficina EntOficina = new oficina();
        public List<financiacion> lstFinanciacion = new List<financiacion>();
        private CadenaConexionMysql CadenaConexion;
        private inmuebles EntInmuebles = new inmuebles();
        public event DlgtDataTableExit DataError_Event_Adjud;
        public event DlgtDataTableExit DataOK_Event_Adjud;
        public event DlgtStringExit ErrorString_Event_adjudicacion;
        public event DlgtStringExit OkString_Event_adjudicacion;
        public string IdReserva { get; set; }
        private DbSet<adjudicacion> adjudicacion { get; set; }
        private DbSet<inmuebles> inmuebles { get; set; }
        private DbSet<oficina> oficina { get; set; }
        #endregion

        #region Constructores
        public negAdjudicacion(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            EntOficina = oficina.Find(1);
            EntAdjudicacion.TasaExtra = EntOficina.IntCorriente;
            EntAdjudicacion.TasaFnc = EntOficina.IntCorriente;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
        }

        public negAdjudicacion(CadenaConexionMysql cadenaConexion, string Id) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            EntOficina = oficina.Find(1);
            EntAdjudicacion = adjudicacion.Find(Id);
            DtFinanciacion = cnsFinanciacion(EntAdjudicacion.IdAdjudicacion);
            DtContado = cnsContado(EntAdjudicacion.IdAdjudicacion);
            DtInicial = cnsCuotaInicial(EntAdjudicacion.IdAdjudicacion);
        }
        #endregion

        #region Disparadores
        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_adjudicacion(mensaje);
        }

        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event_adjudicacion(mensaje);
        }
        #endregion

        #region Metodos
        public void DatosFinanciacion(int idAdj, int IdTrans)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable table = new DataTable();

            table.Columns.Add("IdFinanciacion", typeof(string));
            table.Columns.Add("IdAdjudicacion", typeof(string));
            table.Columns.Add("Concepto", typeof(string));
            table.Columns.Add("CuotaNumero", typeof(int));
            table.Columns.Add("Fecha", typeof(DateTime));
            table.Columns.Add("Capital", typeof(double));
            table.Columns.Add("Interes", typeof(double));
            table.Columns.Add("Cuota", typeof(double));


            for (int i = 0; i < DtInicial.Rows.Count; i++)
            {
                if (Convert.ToDecimal(DtInicial.Rows[i]["Valor"]) > 0)
                {
                    table.Rows.Add(("CI" + (i + 1) + "ADJ" + idAdj), idAdj, "CI", (i + 1), DtInicial.Rows[i]["Fecha"], DtInicial.Rows[i]["Valor"], 0, DtInicial.Rows[i]["Valor"]);
                }
            }

            for (int i = 0; i < DtContado.Rows.Count; i++)
            {
                if (Convert.ToDecimal(DtContado.Rows[i]["Valor"]) > idAdj)
                {
                    table.Rows.Add(("CO" + (i + 1) + "ADJ" + idAdj), idAdj, "CO", (i + 1), DtContado.Rows[i]["Fecha"], DtContado.Rows[i]["Valor"], 0, DtContado.Rows[i]["Valor"]);
                }
            }

            double tasafnc = Convert.ToDouble(CalculosFinanciacion.Tasa);
            double financiacion = Convert.ToDouble(CalculosFinanciacion.Capital);
            int periodofnc = CalculosFinanciacion.Periodo;
            int plazofnc = CalculosFinanciacion.Plazo;
            string CtoFnc = string.Empty, CtoExtra = string.Empty;

            double tasaExt = Convert.ToDouble(CalculosExtraordinario.Tasa);
            double extraordinaria = Convert.ToDouble(CalculosExtraordinario.Capital);
            int periodoExtra = CalculosExtraordinario.Periodo;
            int plazoextra = CalculosExtraordinario.Plazo;

            if (CalculosFinanciacion.Capital > 0 & CalculosFinanciacion.Plazo > 0 & CalculosFinanciacion.Periodo > 0)
            {
                dt = MtdCuotas(tasafnc, plazofnc, financiacion, periodofnc, CalculosFinanciacion.Fecha, "FN", ("Adj" + idAdj));
            }

            if (CalculosExtraordinario.Capital > 0 & CalculosExtraordinario.Plazo > 0 & CalculosExtraordinario.Periodo > 0)
            {
                dt1 = MtdCuotas(tasaExt, plazoextra, extraordinaria, periodoExtra, CalculosExtraordinario.Fecha, "EX", ("Adj" + idAdj));
            }

            DtFinanciacion = dt.Copy();
            DtFinanciacion.Merge(dt1);
            DtFinanciacion.Merge(table);
            DtFinanciacion.DefaultView.Sort = "Fecha asc";
        }

        public DataTable DtCuotas(int idAdj)
        {
            DataTable dtFn = new DataTable();
            DataTable DtExt = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable table = new DataTable();
            table.Columns.Add("IdFinanciacion", typeof(string));
            table.Columns.Add("IdAdjudicacion", typeof(string));
            table.Columns.Add("Concepto", typeof(string));
            table.Columns.Add("CuotaNumero", typeof(int));
            table.Columns.Add("Fecha", typeof(DateTime));
            table.Columns.Add("Capital", typeof(double));
            table.Columns.Add("Interes", typeof(double));
            table.Columns.Add("Cuota", typeof(double));
            MtdValidarDatos();

            if (CuentaErrores > 0)
            {
                DataError_Event_Adjud(Stb.ToString(), DtFinanciacion);
            }
            else
            {
                for (int i = 0; i < DtInicial.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(DtInicial.Rows[i]["Valor"]) > 0)
                    {
                        table.Rows.Add(("CI" + (i + 1) + "ADJ" + idAdj), idAdj, "CI", (i + 1), DtInicial.Rows[i]["Fecha"], DtInicial.Rows[i]["Valor"], 0, DtInicial.Rows[i]["Valor"]);
                    }
                }

                for (int i = 0; i < DtContado.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(DtContado.Rows[i]["Valor"]) > 0)
                    {
                        table.Rows.Add(("CO" + (i + 1) + "ADJ" + idAdj), idAdj, "CO", (i + 1), DtContado.Rows[i]["Fecha"], DtContado.Rows[i]["Valor"], 0, DtContado.Rows[i]["Valor"]);
                    }
                }

                double tasafnc = Convert.ToDouble(CalculosFinanciacion.Tasa);
                double financiacion = Convert.ToDouble(CalculosFinanciacion.Capital);
                int periodofnc = CalculosFinanciacion.Periodo;
                int plazofnc = CalculosFinanciacion.Plazo;
                string CtoFnc = string.Empty, CtoExtra = string.Empty;

                double tasaExt = Convert.ToDouble(CalculosExtraordinario.Tasa);
                double extraordinaria = Convert.ToDouble(CalculosExtraordinario.Capital);
                int periodoExtra = CalculosExtraordinario.Periodo;
                int plazoextra = CalculosExtraordinario.Plazo;

                if (CalculosFinanciacion.Capital > 0 & CalculosFinanciacion.Plazo > 0 & CalculosFinanciacion.Periodo > 0)
                {
                    dtFn = MtdCuotas(tasafnc, plazofnc, financiacion, periodofnc, CalculosFinanciacion.Fecha, "FN", ("Adj" + idAdj));
                }

                if (CalculosExtraordinario.Capital > 0 & CalculosExtraordinario.Plazo > 0 & CalculosExtraordinario.Periodo > 0)
                {
                    DtExt = MtdCuotas(tasaExt, plazoextra, extraordinaria, periodoExtra, CalculosExtraordinario.Fecha, "EX", ("Adj" + idAdj));
                }

                DtFinanciacion = table.Copy();
                DtFinanciacion.Merge(dtFn);
                DtFinanciacion.Merge(DtExt);
                DataView dtV = DtFinanciacion.DefaultView;
                dtV.Sort = "Fecha ASC";
                DtFinanciacion = dtV.ToTable();
                DataOK_Event_Adjud("Registros Validados Correctamente", DtFinanciacion);
            }
            return DtFinanciacion;
        }

        public DataTable cnsFinanciacion(string Id)
        {           
            return CnsDtConsultaStrId("Financiacion", Id);
        }

        public DataTable DtCuotasMod(string idAdj)
        {
            DataTable dtFn = new DataTable();
            DataTable DtExt = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable table = new DataTable();
            table.Columns.Add("IdFinanciacion", typeof(string));
            table.Columns.Add("IdAdjudicacion", typeof(string));
            table.Columns.Add("Concepto", typeof(string));
            table.Columns.Add("CuotaNumero", typeof(int));
            table.Columns.Add("Fecha", typeof(DateTime));
            table.Columns.Add("Capital", typeof(double));
            table.Columns.Add("Interes", typeof(double));
            table.Columns.Add("Cuota", typeof(double));
            MtdValidarDatosMod();

            if (CuentaErrores > 0)
            {
                DataError_Event_Adjud(Stb.ToString(), DtFinanciacion);
            }
            else
            {
                for (int i = 0; i < DtInicial.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(DtInicial.Rows[i]["Valor"]) > 0)
                    {
                        table.Rows.Add(("CI" + (i + 1) + idAdj), idAdj, "CI", (i + 1), DtInicial.Rows[i]["Fecha"], DtInicial.Rows[i]["Valor"], 0, DtInicial.Rows[i]["Valor"]);
                    }
                }

                for (int i = 0; i < DtContado.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(DtContado.Rows[i]["Valor"]) > 0)
                    {
                        table.Rows.Add(("CO" + (i + 1) + idAdj), idAdj, "CO", (i + 1), DtContado.Rows[i]["Fecha"], DtContado.Rows[i]["Valor"], 0, DtContado.Rows[i]["Valor"]);
                    }
                }

                double tasafnc = Convert.ToDouble(CalculosFinanciacion.Tasa);
                double financiacion = Convert.ToDouble(CalculosFinanciacion.Capital);
                int periodofnc = CalculosFinanciacion.Periodo;
                int plazofnc = CalculosFinanciacion.Plazo;
                string CtoFnc = string.Empty, CtoExtra = string.Empty;

                double tasaExt = Convert.ToDouble(CalculosExtraordinario.Tasa);
                double extraordinaria = Convert.ToDouble(CalculosExtraordinario.Capital);
                int periodoExtra = CalculosExtraordinario.Periodo;
                int plazoextra = CalculosExtraordinario.Plazo;

                if (CalculosFinanciacion.Capital > 0 & CalculosFinanciacion.Plazo > 0 & CalculosFinanciacion.Periodo > 0)
                {
                    dtFn = MtdCuotas(tasafnc, plazofnc, financiacion, periodofnc, CalculosFinanciacion.Fecha, "FN", (idAdj));
                }

                if (CalculosExtraordinario.Capital > 0 & CalculosExtraordinario.Plazo > 0 & CalculosExtraordinario.Periodo > 0)
                {
                    DtExt = MtdCuotas(tasaExt, plazoextra, extraordinaria, periodoExtra, CalculosExtraordinario.Fecha, "EX", (idAdj));
                }

                DtFinanciacion = table.Copy();
                DtFinanciacion.Merge(dtFn);
                DtFinanciacion.Merge(DtExt);
                DataView dtV = DtFinanciacion.DefaultView;
                dtV.Sort = "Fecha ASC";
                DtFinanciacion = dtV.ToTable();
                DataOK_Event_Adjud("Registros Validados Correctamente", DtFinanciacion);
            }
            return DtFinanciacion;
        }
       
        public DataTable DtOrigenVenta()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("OrigenVenta", typeof(string));
            dt.Rows.Add(1, "Normal");
            dt.Rows.Add(2, "Canje");
            dt.Rows.Add(3, "Comercializadora");
            dt.Rows.Add(4, "Socios");
            dt.Rows.Add(5, "Director");
            return dt;
        }

        public void MtdAdicionar()
        {
            MtdValidarDatos();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_adjudicacion(Stb.ToString());
            }
            else
            {
                try
                {
                    int a = 0;
                    int IdAdjudicacion = cnsConcecutivo("adjudicacion");
                    string resultado = string.Empty;
                    string[] consulta = new string[(DtFinanciacion.Rows.Count + 4)];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    #region Add Transacciones

                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Adicionar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Adjudicacion";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    EntTransacciones.Registro = "ADJ" + IdAdjudicacion;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                    a += 1;
                    #endregion Add Transacciones

                    #region Add Adjudicacion


                    EntAdjudicacion.BaseComision = EntAdjudicacion.Valor;
                    EntAdjudicacion.Porcentaje = EntOficina.Porcentaje;
                    EntAdjudicacion.Oficina = EntOficina.NombreOficina;

                    EntAdjudicacion.PeriodoFnc = CalculosFinanciacion.Periodo;
                    EntAdjudicacion.PlazoFnc = CalculosFinanciacion.Plazo;
                    EntAdjudicacion.TasaFnc = CalculosFinanciacion.Tasa;
                    EntAdjudicacion.CuotaFnc = CalculosFinanciacion.Cuota;
                    EntAdjudicacion.InicioFnc = CalculosFinanciacion.Fecha;


                    EntAdjudicacion.PeriodoExtra = CalculosExtraordinario.Periodo;
                    EntAdjudicacion.PlazoExtra = CalculosExtraordinario.Plazo;
                    EntAdjudicacion.TasaExtra = CalculosExtraordinario.Tasa;
                    EntAdjudicacion.CuotaExtra = CalculosExtraordinario.Cuota;
                    EntAdjudicacion.InicioExtra = CalculosExtraordinario.Fecha;

                    EntAdjudicacion.Radicado = "Pendiente";
                    EntAdjudicacion.Inmueble_desistido = "NO";
                    EntAdjudicacion.IdTransaccion = EntTransacciones.Id;
                    EntAdjudicacion.Estado = "Pendiente";
                    EntAdjudicacion.IdAdjudicacion = "ADJ" + IdAdjudicacion;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntAdjudicacion));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntAdjudicacion));
                    consulta[a] = CadenaConexion.mtdCrearInsert("adjudicacion", CadenaConexion.MtdCrearParametro(EntAdjudicacion));
                    a += 1;
                    #endregion Add Reservas

                    #region Mod Inmueble

                    string[] strpara = { "IdInmueble" };
                    object[] objpara = { EntAdjudicacion.IdInmueble };
                    nomparametros.Add(strpara);
                    valparametros.Add(objpara);
                    consulta[a] = "update inmuebles set Estado='Adjudicado' Where IdInmueble=@IdInmueble";
                    a += 1;
                    #endregion Mod Inmueble

                    #region Mod Reservas
                    string[] strpara1 = { "IdAdjudicacion", "IdReserva" };
                    object[] objpara1 = { EntAdjudicacion.IdAdjudicacion, IdReserva };
                    nomparametros.Add(strpara1);
                    valparametros.Add(objpara1);
                    consulta[a] = "update reservas set Estado=@IdAdjudicacion Where IdReserva=@IdReserva";
                    a += 1;
                    #endregion

                    #region Financiacion
                    financiacion EntFinanciacion = new financiacion();
                    DtFinanciacion.DefaultView.Sort = "Fecha asc";
                    for (int i = 0; i < DtFinanciacion.Rows.Count; i++)
                    {
                        EntFinanciacion.Id = 0;
                        EntFinanciacion.Concepto = DtFinanciacion.Rows[i]["Concepto"].ToString();
                        EntFinanciacion.CuotaNumero = Convert.ToInt16(DtFinanciacion.Rows[i]["CuotaNumero"]);
                        EntFinanciacion.IdFinanciacion = EntFinanciacion.Concepto + EntFinanciacion.CuotaNumero + EntAdjudicacion.IdAdjudicacion;
                        EntFinanciacion.IdAdjudicacion = EntAdjudicacion.IdAdjudicacion;

                        EntFinanciacion.Fecha = Convert.ToDateTime(DtFinanciacion.Rows[i]["Fecha"]);
                        EntFinanciacion.Capital = Convert.ToDecimal(DtFinanciacion.Rows[i]["Capital"]);
                        EntFinanciacion.Interes = Convert.ToDecimal(DtFinanciacion.Rows[i]["Interes"]);
                        EntFinanciacion.Cuota = Convert.ToDecimal(DtFinanciacion.Rows[i]["Cuota"]);
                        EntFinanciacion.IdTransaccion = EntTransacciones.Id;
                        nomparametros.Add(CadenaConexion.MtdCrearParametro(EntFinanciacion));
                        valparametros.Add(CadenaConexion.MtdValParametros(EntFinanciacion));
                        consulta[a] = CadenaConexion.mtdCrearInsert("financiacion", CadenaConexion.MtdCrearParametro(EntFinanciacion));
                        a += 1;
                    }
                    #endregion

                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_adjudicacion(ex.Message);
                }
            }
        }

        public void MtdAprobar()
        {
            try
            {


                string resultado = string.Empty;
                string[] consulta = new string[2];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                transacciones EntTransacciones = new transacciones();
                EntTransacciones.Accion = "Aprobar";
                EntTransacciones.Fecha = DateTime.Now;
                EntTransacciones.Modulo = "Adjudicacion";
                EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                EntTransacciones.Id = cnsConcecutivo("Transacciones");
                EntTransacciones.Registro = EntAdjudicacion.IdAdjudicacion;

                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));

                string[] strpara = { "IdAdjudicacion" };
                object[] objpara = { EntAdjudicacion.IdAdjudicacion };
                nomparametros.Add(strpara);
                valparametros.Add(objpara);
                consulta[1] = "update adjudicacion set Estado='Aprobado' Where IdAdjudicacion=@IdAdjudicacion";
                resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
            catch (Exception ex)
            {
                ErrorString_Event_adjudicacion(ex.Message);
            }
        }

        public void MtdDesaprobar()
        {
            try
            {


                string resultado = string.Empty;
                string[] consulta = new string[2];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                transacciones EntTransacciones = new transacciones();
                EntTransacciones.Accion = "Desaprobar";
                EntTransacciones.Fecha = DateTime.Now;
                EntTransacciones.Modulo = "Adjudicacion";
                EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                EntTransacciones.Id = cnsConcecutivo("Transacciones");
                EntTransacciones.Registro = EntAdjudicacion.IdAdjudicacion;

                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));

                string[] strpara = { "IdAdjudicacion" };
                object[] objpara = { EntAdjudicacion.IdAdjudicacion };
                nomparametros.Add(strpara);
                valparametros.Add(objpara);
                consulta[1] = "update adjudicacion set Estado='Pendiente' Where IdAdjudicacion=@IdAdjudicacion";
                resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
            catch (Exception ex)
            {
                ErrorString_Event_adjudicacion(ex.Message);
            }
        }

        public decimal MtdDiferencia()
        {
            return (EntAdjudicacion.Valor - EntAdjudicacion.Financiacion - EntAdjudicacion.Contado -
                   EntAdjudicacion.Extraordinaria - EntAdjudicacion.CuotaInicial);
        }

        public void MtdEliminar()
        {
            try
            {


                string resultado = string.Empty;
                string[] consulta = new string[3];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                transacciones EntTransacciones = new transacciones();
                EntTransacciones.Accion = "Eliminar";
                EntTransacciones.Fecha = DateTime.Now;
                EntTransacciones.Modulo = "Adjudicacion";
                EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                EntTransacciones.Id = cnsConcecutivo("Transacciones");
                EntTransacciones.Registro = EntAdjudicacion.IdAdjudicacion;

                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));

                string[] strpara = { "IdAdjudicacion" };
                object[] objpara = { EntAdjudicacion.IdAdjudicacion };
                nomparametros.Add(strpara);
                valparametros.Add(objpara);
                consulta[1] = "update adjudicacion set Estado='Eliminado' Where IdAdjudicacion=@IdAdjudicacion";


                #region Mod Inmueble

                string[] strpara1 = { "IdInmueble" };
                object[] objpara1 = { EntAdjudicacion.IdInmueble };
                nomparametros.Add(strpara1);
                valparametros.Add(objpara1);
                consulta[2] = "update inmuebles set Estado='Libre' Where IdInmueble=@IdInmueble";

                #endregion Mod Inmueble

                resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
            catch (Exception ex)
            {
                ErrorString_Event_adjudicacion(ex.Message);
            }
        }

        public void MtdModificar()
        {
            MtdValidarDatosMod();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_adjudicacion(Stb.ToString());
            }
            else
            {
                try
                {
                    int a = 0;
                    string resultado = string.Empty;
                    string[] consulta = new string[(DtFinanciacion.Rows.Count + 3)];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    #region Add Transacciones

                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Modificar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Adjudicacion";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    EntTransacciones.Registro = EntAdjudicacion.IdAdjudicacion;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                    a += 1;
                    #endregion Add Transacciones

                    #region Eliminacion datos Financiacion
                    string[] strpara = { "IdAdjudicacion" };
                    object[] objpara = { EntAdjudicacion.IdAdjudicacion };
                    nomparametros.Add(strpara);
                    valparametros.Add(objpara);
                    consulta[a] = "delete from financiacion Where IdAdjudicacion=@IdAdjudicacion";
                    a += 1;
                    #endregion

                    #region Mod Adjudicacion

                    EntAdjudicacion.BaseComision = EntAdjudicacion.Valor;
                    EntAdjudicacion.Porcentaje = EntOficina.Porcentaje;
                    EntAdjudicacion.Oficina = EntOficina.NombreOficina;

                    EntAdjudicacion.PeriodoFnc = CalculosFinanciacion.Periodo;
                    EntAdjudicacion.PlazoFnc = CalculosFinanciacion.Plazo;
                    EntAdjudicacion.TasaFnc = CalculosFinanciacion.Tasa;
                    EntAdjudicacion.CuotaFnc = CalculosFinanciacion.Cuota;
                    EntAdjudicacion.InicioFnc = CalculosFinanciacion.Fecha;

                    EntAdjudicacion.PeriodoExtra = CalculosExtraordinario.Periodo;
                    EntAdjudicacion.PlazoExtra = CalculosExtraordinario.Plazo;
                    EntAdjudicacion.TasaExtra = CalculosExtraordinario.Tasa;
                    EntAdjudicacion.CuotaExtra = CalculosExtraordinario.Cuota;
                    EntAdjudicacion.InicioExtra = CalculosExtraordinario.Fecha;


                    EntAdjudicacion.IdTransaccion = EntTransacciones.Id;
                    EntAdjudicacion.Estado = "Pendiente";
                    string[] StrWhere = { "IdAdjudicacion" };
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntAdjudicacion));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntAdjudicacion));
                    consulta[a] = CadenaConexion.mtdCrearUpdate("adjudicacion", CadenaConexion.MtdCrearParametro(EntAdjudicacion), StrWhere);
                    a += 1;
                    #endregion Add Reservas                         

                    #region Financiacion
                    financiacion EntFinanciacion = new financiacion();
                    DtFinanciacion.DefaultView.Sort = "Fecha asc";
                    for (int i = 0; i < DtFinanciacion.Rows.Count; i++)
                    {
                        EntFinanciacion.Id = 0;
                        EntFinanciacion.Concepto = DtFinanciacion.Rows[i]["Concepto"].ToString();
                        EntFinanciacion.CuotaNumero = Convert.ToInt16(DtFinanciacion.Rows[i]["CuotaNumero"]);
                        EntFinanciacion.IdFinanciacion = EntFinanciacion.Concepto + EntFinanciacion.CuotaNumero + EntAdjudicacion.IdAdjudicacion;
                        EntFinanciacion.IdAdjudicacion = EntAdjudicacion.IdAdjudicacion;

                        EntFinanciacion.Fecha = Convert.ToDateTime(DtFinanciacion.Rows[i]["Fecha"]);
                        EntFinanciacion.Capital = Convert.ToDecimal(DtFinanciacion.Rows[i]["Capital"]);
                        EntFinanciacion.Interes = Convert.ToDecimal(DtFinanciacion.Rows[i]["Interes"]);
                        EntFinanciacion.Cuota = Convert.ToDecimal(DtFinanciacion.Rows[i]["Cuota"]);
                        EntFinanciacion.IdTransaccion = EntTransacciones.Id;
                        nomparametros.Add(CadenaConexion.MtdCrearParametro(EntFinanciacion));
                        valparametros.Add(CadenaConexion.MtdValParametros(EntFinanciacion));
                        consulta[a] = CadenaConexion.mtdCrearInsert("financiacion", CadenaConexion.MtdCrearParametro(EntFinanciacion));
                        a += 1;
                    }
                    #endregion

                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_adjudicacion(ex.Message);
                }
            }
        }

        public void MtdValidarDatos()
        {

            CuentaErrores = 0;
            decimal PorcCuotaInicial = 0;
            PorcCuotaInicial = Math.Round((EntAdjudicacion.Valor * EntOficina.Porcentaje), 2);
            Stb.Clear();

            if (string.IsNullOrEmpty(IdReserva))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Reserva");
            }

            else
            {
                EntInmuebles = inmuebles.Find(EntAdjudicacion.IdInmueble);
            }

            if (EntAdjudicacion.Fecha == null || EntAdjudicacion.Fecha == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Fecha");
            }
            if (EntAdjudicacion.FechaEntrega == null || EntAdjudicacion.FechaEntrega == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Fecha Entrega");
            }
            else
            if (EntInmuebles.FinObra > EntAdjudicacion.FechaEntrega)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Fecha de Entrega No Puede ser Menor que " + EntInmuebles.FinObra.ToShortDateString());
            }
            if (EntAdjudicacion.Valor == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Valor del Contrato");
            }

            if (string.IsNullOrEmpty(EntAdjudicacion.IdInmueble))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Codigo de Inmueble");
            }
            if (string.IsNullOrEmpty(EntAdjudicacion.Contrato))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Numero Contrato");
            }

            if (string.IsNullOrEmpty(EntAdjudicacion.IdTercero1))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Titular");
            }
            if (string.IsNullOrEmpty(EntAdjudicacion.FormaPago))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Forma de Pago");
            }
            if (string.IsNullOrEmpty(EntAdjudicacion.OrigenVenta))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Origen de Venta");
            }

            if (EntAdjudicacion.CuotaInicial + 5 < PorcCuotaInicial)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Cuota Inicial No Puede ser Menor que " + PorcCuotaInicial);
            }

            if (MtdDiferencia() != 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Documento Descuadrado");
            }

            if (EntAdjudicacion.FormaPago == "Extraordinario")
            {
                if (CalculosExtraordinario.Capital == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Extraordinaria");
                }
                if (CalculosExtraordinario.Plazo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Numero de Cuotas ExtraOrdinaria");
                }
                if (CalculosExtraordinario.Periodo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Selecionar Periodo");
                }
                if (CalculosExtraordinario.Fecha == null || CalculosExtraordinario.Fecha == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha ExtraOrdinaria");
                }
                if (CalculosFinanciacion.Capital == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Financiacion");
                }
                if (CalculosFinanciacion.Plazo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Numero de Cuotas Financiacion");
                }
                if (CalculosFinanciacion.Periodo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Selecionar Periodo Financiacion");
                }
                if (CalculosFinanciacion.Fecha == null || CalculosFinanciacion.Fecha == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha Financiacion");
                }
            }

            if (EntAdjudicacion.FormaPago == "Credito")
            {
                if (CalculosFinanciacion.Capital == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Financiacion");
                }
                if (CalculosFinanciacion.Plazo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Numero de Cuotas Financiacion");
                }
                if (CalculosFinanciacion.Periodo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Selecionar Periodo Financiacion");
                }
                if (CalculosFinanciacion.Fecha == null || CalculosFinanciacion.Fecha == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha Inicio Financiacion");
                }
            }

            if (EntAdjudicacion.FormaPago == "Contado" & EntAdjudicacion.Contado == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Datos Cuotas Contado");
            }

            if (EntAdjudicacion.FormaPago == "CrediContado")
            {
                if (CalculosFinanciacion.Capital == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Financiacion");
                }
                if (CalculosFinanciacion.Plazo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Numero de Cuotas Financiacion");
                }
                if (CalculosFinanciacion.Periodo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Selecionar Periodo Financiacion");
                }
                if (CalculosFinanciacion.Fecha == null || CalculosFinanciacion.Fecha == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha Inicio Financiacion");
                }
            }
        }

        public void MtdValidarDatosMod()
        {

            CuentaErrores = 0;
            decimal PorcCuotaInicial = 0;
            PorcCuotaInicial = Math.Round((EntAdjudicacion.Valor * EntOficina.Porcentaje), 2);
            Stb.Clear();


            if (EntAdjudicacion.Fecha == null || EntAdjudicacion.Fecha == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Fecha");
            }
            if (EntAdjudicacion.FechaEntrega == null || EntAdjudicacion.FechaEntrega == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Fecha Entrega");
            }
            else
            if (EntInmuebles.FinObra > EntAdjudicacion.FechaEntrega)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Fecha de Entrega No Puede ser Menor que " + EntInmuebles.FinObra.ToShortDateString());
            }
            if (EntAdjudicacion.Valor == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Valor del Contrato");
            }

            if (string.IsNullOrEmpty(EntAdjudicacion.IdInmueble))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Codigo de Inmueble");
            }
            if (string.IsNullOrEmpty(EntAdjudicacion.Contrato))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Numero Contrato");
            }

            if (string.IsNullOrEmpty(EntAdjudicacion.IdTercero1))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Titular");
            }
            if (string.IsNullOrEmpty(EntAdjudicacion.FormaPago))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Forma de Pago");
            }
            if (string.IsNullOrEmpty(EntAdjudicacion.OrigenVenta))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Origen de Venta");
            }

            if (EntAdjudicacion.CuotaInicial + 5 < PorcCuotaInicial)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Cuota Inicial No Puede ser Menor que " + PorcCuotaInicial);
            }

            if (MtdDiferencia() != 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Documento Descuadrado");
            }

            if (EntAdjudicacion.FormaPago == "Extraordinario")
            {
                if (CalculosExtraordinario.Capital == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Extraordinaria");
                }
                if (CalculosExtraordinario.Plazo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Numero de Cuotas ExtraOrdinaria");
                }
                if (CalculosExtraordinario.Periodo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Selecionar Periodo");
                }
                if (CalculosExtraordinario.Fecha == null || CalculosExtraordinario.Fecha == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha ExtraOrdinaria");
                }
                if (CalculosFinanciacion.Capital == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Financiacion");
                }
                if (CalculosFinanciacion.Plazo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Numero de Cuotas Financiacion");
                }
                if (CalculosFinanciacion.Periodo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Selecionar Periodo Financiacion");
                }
                if (CalculosFinanciacion.Fecha == null || CalculosFinanciacion.Fecha == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha Financiacion");
                }
            }

            if (EntAdjudicacion.FormaPago == "Credito")
            {
                if (CalculosFinanciacion.Capital == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Financiacion");
                }
                if (CalculosFinanciacion.Plazo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Numero de Cuotas Financiacion");
                }
                if (CalculosFinanciacion.Periodo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Selecionar Periodo Financiacion");
                }
                if (CalculosFinanciacion.Fecha == null || CalculosFinanciacion.Fecha == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha Financiacion");
                }
            }

            if (EntAdjudicacion.FormaPago == "CrediContado")
            {
                if (CalculosFinanciacion.Capital == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Financiacion");
                }
                if (CalculosFinanciacion.Plazo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Numero de Cuotas Financiacion");
                }

                if (CalculosFinanciacion.Periodo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Selecionar Periodo Financiacion");
                }
                if (CalculosFinanciacion.Fecha == null || CalculosFinanciacion.Fecha == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha Inicio Financiacion");
                }
            }

            if (EntAdjudicacion.FormaPago == "Contado" & EntAdjudicacion.Contado == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Datos Cuotas Contado");
            }
        }

        private DataTable cnsContado(string Id)
        {
            string[] Parametro = { "StrNombre", "VarId" };
            object[] ObjParametro = { "Contado", Id };
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaStrId", Parametro, ObjParametro);
        }

        private DataTable cnsCuotaInicial(string Id)
        {
            string[] Parametro = { "StrNombre", "VarId" };
            object[] ObjParametro = { "CuotaInicial", Id };
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaStrId", Parametro, ObjParametro);
        }

        private void MtdInicio()
        {

        }
        #endregion
    }
}