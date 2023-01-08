namespace NegociosCartera
{
    #region Librerias

    using Conexiones;    
    using System;
    using System.Data;
    using System.Globalization;
    using System.Text;

    #endregion Librerias

    public abstract class NegConsultasCartera : EntityContexto
    {
        #region Propiedades

        public MysqlContext ConexionMysql;
        public int CuentaErrores = 0;
        public StringBuilder Stb = new StringBuilder();
        private CadenaConexionMysql CadenaConexion;
        public event DlgtDataTableExit Event_ErrorTableNgConsultas;

        #endregion Propiedades

        #region Constructores

        public NegConsultasCartera(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql = new MysqlContext(CadenaConexion);
            ConexionMysql.EventDataErrorTableMysql += ConexionMysql_EventDataErrorTableMysql;
        }

        public DataTable DtTipoCartera()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("TipoCartera", typeof(string));
            dt.Rows.Add(1, "Comercial");
            dt.Rows.Add(2, "Administrativa");
            dt.Rows.Add(3, "Otras");           
            return dt;
        }

        #endregion Constructores

        #region Disparadores

        private void ConexionMysql_EventDataErrorTableMysql(string mensaje, System.Data.DataTable dataTable)
        {
            Event_ErrorTableNgConsultas(mensaje, dataTable);
        }

        #endregion Disparadores        

        #region Metodos Prcedimientos Almacenados           

        /// <summary>
        /// Consulta De Consecutivos por Procedimiento Almacenado ConsultaConsecutivos
        /// </summary>
        /// <param name="StrTabla">
        /// Nombre de La Tabla de Para Nuevo Concecutivo
        /// </param>
        /// <returns></returns>
        public int cnsConcecutivo(string StrTabla)
        {
            DataTable data = ConexionMysql.MtdDataTableAdapterProce("ConsultaConsecutivos", "StrNombre", StrTabla);
            return Convert.ToInt32(data.Rows[0][0]);
        }
       

      
        /// <summary>
        /// Consulta General De Los Procedimiento Almacenado ConsultaStrId
        /// </summary>
        /// <param name="StrNombre">
        /// Nombre de la Comsulta en el procedimiento
        /// </param>
        /// <param name="StrId">
        /// Id de la Consula o Llave Principal
        /// </param>
        /// <returns></returns>
        /// 
        public DataTable CnsDtConsultaStrId(string StrNombre,object StrId)
        {
            string[] Parametro = { "StrNombre", "VarId" };
            object[] ObjParametro = { StrNombre, StrId };
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaStrId", Parametro, ObjParametro);
        }

        public DataTable CnsDtConsultaFecha(string StrNombre, DateTime FechaInicial,DateTime FechaFinal)
        {
            string[] Parametro = { "StrNombre", "FechaInicial" ,"FechaFinal"};
            object[] ObjParametro = { StrNombre, FechaInicial, FechaFinal };
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaFecha", Parametro, ObjParametro);
        }
        public DataTable CnsDtConsultaFechaString(string StrNombre, DateTime FechaInicial, DateTime FechaFinal,string VarId)
        {
            string[] Parametro = { "StrNombre", "FechaInicial", "FechaFinal" ,"VarId"};
            object[] ObjParametro = { StrNombre, FechaInicial, FechaFinal,VarId };
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaFechaString", Parametro, ObjParametro);
        }

        /// <summary>
        /// Consulta General De Los Procedimiento Almacenado Consulta
        /// </summary>
        /// <param name="StrNombre">
        /// Nombre de la Comsulta en el procedimiento
        /// </param>
        /// <returns></returns>
        public DataTable CnsDtConsulta(string StrNombre)
        {
            return ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", StrNombre);
        }



        /// <summary>
        /// Consulta General de una Tabla Especifica
        /// </summary>
        /// <param name="StrNombre">
        /// Nombre tabla a Consultar procedimiento
        /// </param>
        /// <returns></returns>
        public DataTable CnsDtConsultaTabla(string StrTabla)
        {
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaTabla", "StrTabla", StrTabla);
        }

        /// <summary>
        /// Consulta General De Los Procedimiento Almacenado ConsultaDuoStrId
        /// </summary>
        /// <param name="StrNombre">
        /// Nombre de la Consulta
        /// </param>
        /// <param name="VarId"></param>
        /// Nombre Del Parametro VarId
        /// <param name="VarTrans"></param>
        /// Numero de Transaccion
        /// <returns></returns>
        public DataTable ConsultaDuoStrId(string StrNombre,string VarId,string VarTrans)
        {
            string[] Parametro = { "StrNombre", "VarId", "VarTrans" };
            object[] ObjParametro = { StrNombre, VarId, VarTrans };
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaDuoStrId", Parametro, ObjParametro);
        }

        /// <summary>
        /// Consulta Procedimientos Almacenado Para Llenar ComboBox
        /// </summary>
        /// <param name="StrTabla">
        /// Nombre de La Tabla para Combobox
        /// </param>
        /// <returns></returns>
        public DataTable CnsDtCombox(string StrTabla)
        {
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaCombos", "StrNombre", StrTabla);
        }

        #endregion 

        #region Metodos Propios
        public DataTable ConsultaCuotasFija(decimal Capital, decimal Tasa, decimal Plazo, string Cto, int Periodo, DateTime FechaInicio)
        {
            string[] Parametro = { "Capital", "Tasa", "Plazo", "VarConcepto", "VarFecha", "VarPeriodo" };
            object[] ObjParametro = { Capital, Tasa, Plazo, Cto, FechaInicio, Periodo };
            return ConexionMysql.MtdDataTableAdapterProce("CuotasFija", Parametro, ObjParametro);
        }

        public DataTable DtFormaPago()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("FormaPago", typeof(string));
            dt.Rows.Add(1, "Credito");
            dt.Rows.Add(2, "Extraordinario");
            dt.Rows.Add(3, "Contado");
            dt.Rows.Add(4, "CrediContado");
            return dt;
        }

        public DataTable DtPeriodo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Periodo", typeof(int));
            dt.Rows.Add("Mensual", 30);
            dt.Rows.Add("Bimensual", 60);
            dt.Rows.Add("Trimestral", 90);
            dt.Rows.Add("Cuatrimestral", 120);
            dt.Rows.Add("Semestral", 180);
            dt.Rows.Add("Anual", 360);

            return dt;
        }

        public string MtdBaseDatos(string StrSoftware, DataTable DtProyectos)
        {
            string resultado = string.Empty;
            var query = (
            from Permisos in DtProyectos.AsEnumerable()
            where Permisos.Field<string>("NombreSoftware") == StrSoftware
            select new
            {
                resul = Permisos.Field<string>("BaseDatos")
            });

            foreach (var order in query)
            {
                resultado = order.resul;
            }
            return resultado;
        }

        public decimal MtdCalcularCapital(double Cuota, double Plazo, double TasaInteres, double Periodo)
        {
            double Capital;

            Periodo = (30 / Periodo) * 12;
            double a, b, x;
            a = (1 + TasaInteres / (Periodo * 100));
            b = Plazo;
            x = Math.Pow(a, b);
            x = 1 / x;
            x = 1 - x;
            Capital = (Cuota) / (TasaInteres / (Periodo * 100)) * x;
            return Convert.ToDecimal(Math.Round(Capital, CadenaConexion.Logeo.Decimales));
        }

        public decimal MtdCalculoCuota(double Valor, double Tasa, int Periodo, int Plazo)
        {
            double CuotaFijaCalculada;
            double PeriodoC = Periodo;
            DataTable table = new DataTable();

            if (Plazo == 0)
            {
                Event_ErrorTableNgConsultas("Plazo No Puede ser 0", table);
                return 0;
            }
            else
            {
                try
                {
                    PeriodoC = (30 / PeriodoC) * 12;
                    if (Tasa > 0)
                    {
                        double a, b, x;
                        a = (1 + Tasa / (PeriodoC * 100));
                        b = Plazo;
                        x = Math.Pow(a, b);
                        x = 1 / x;
                        x = 1 - x;
                        CuotaFijaCalculada = Valor * (Tasa / (PeriodoC * 100)) / x;
                    }
                    else
                    {
                        CuotaFijaCalculada = Math.Round((Valor / Plazo), CadenaConexion.Logeo.Decimales);
                    }
                    return Convert.ToDecimal(Math.Round(CuotaFijaCalculada, CadenaConexion.Logeo.Decimales));
                }
                catch (Exception ex)
                {
                    Event_ErrorTableNgConsultas(ex.Message, table);
                    return 0;
                }
            }
        }

        public DataTable MtdCuotas(double tasaInteres, int plazo, double capital, int periodo, DateTime fechaInicio, string concepto, string Adj)
        {
            #region Variables

            decimal CapitalCuota = 0, InteresCuota = 0, SaldoCuota = 0, CuotaCuota = 0, Tasa = 0, CuotaFija = 0;
            DateTime Fecha;
            DataTable table = new DataTable();

            #endregion Variables

            try
            {
                #region Asignacion Valor Variables

                SaldoCuota = Convert.ToDecimal(capital);
                CuotaFija = MtdCalculoCuota(capital, tasaInteres, periodo, plazo);
                Tasa = Convert.ToDecimal(tasaInteres);

                #endregion Asignacion Valor Variables

                #region Creacion DataTable Para Datos Cuotas

                table.Columns.Add("IdFinanciacion", typeof(string));
                table.Columns.Add("IdAdjudicacion", typeof(string));
                table.Columns.Add("Concepto", typeof(string));
                table.Columns.Add("CuotaNumero", typeof(int));
                table.Columns.Add("Fecha", typeof(DateTime));
                table.Columns.Add("Capital", typeof(double));
                table.Columns.Add("Interes", typeof(double));
                table.Columns.Add("Cuota", typeof(double));

                #endregion Creacion DataTable Para Datos Cuotas

                #region Llenado de Tabla de Cuotas

                for (int i = 1; i < (plazo + 1); i++)
                {
                    Fecha = fechaInicio.AddMonths(periodo / 30 * (i - 1));
                    InteresCuota = Math.Round(((SaldoCuota * (periodo) * Tasa) / 36000), CadenaConexion.Logeo.Decimales);
                    CapitalCuota = Math.Round((CuotaFija - InteresCuota), CadenaConexion.Logeo.Decimales);
                    if (i == plazo)
                    {
                        CuotaCuota = Math.Round((SaldoCuota + InteresCuota), CadenaConexion.Logeo.Decimales);
                        table.Rows.Add((concepto + i + "ADJ" + Adj), Adj, concepto, i, Fecha, SaldoCuota, InteresCuota, CuotaCuota);
                        SaldoCuota = 0;
                    }
                    else
                    {
                        CuotaCuota = Math.Round((CapitalCuota + InteresCuota), CadenaConexion.Logeo.Decimales);
                        SaldoCuota = Math.Round((SaldoCuota - CapitalCuota), CadenaConexion.Logeo.Decimales);
                        table.Rows.Add((concepto + i + "ADJ" + Adj), Adj, concepto, i, Fecha, CapitalCuota, InteresCuota, CuotaCuota);
                    }
                }

                #endregion Llenado de Tabla de Cuotas

                return table;
            }
            catch (Exception ex)
            {
                Event_ErrorTableNgConsultas(ex.Message, table);
                return table;
            }
        }


        public DataTable MtdCuotas(double tasaInteres, int plazo, double capital, int periodo, DateTime fechaInicio, string concepto, string Adj, int NumCuota)
        {
            #region Variables

            decimal CapitalCuota = 0, InteresCuota = 0, SaldoCuota = 0, CuotaCuota = 0, Tasa = 0, CuotaFija = 0;
            DateTime Fecha;
            DataTable table = new DataTable();

            #endregion Variables

            try
            {
                #region Asignacion Valor Variables

                SaldoCuota = Convert.ToDecimal(capital);
                CuotaFija = MtdCalculoCuota(capital, tasaInteres, periodo, plazo);
                Tasa = Convert.ToDecimal(tasaInteres);

                #endregion Asignacion Valor Variables

                #region Creacion DataTable Para Datos Cuotas

                table.Columns.Add("IdFinanciacion", typeof(string));
                table.Columns.Add("IdAdjudicacion", typeof(string));
                table.Columns.Add("Concepto", typeof(string));
                table.Columns.Add("CuotaNumero", typeof(int));
                table.Columns.Add("Fecha", typeof(DateTime));
                table.Columns.Add("Capital", typeof(double));
                table.Columns.Add("Interes", typeof(double));
                table.Columns.Add("Cuota", typeof(double));
                table.Columns.Add("SdoCapital", typeof(double));
                table.Columns.Add("SdoInteres", typeof(double));
                table.Columns.Add("SdoCuota", typeof(double));

                #endregion Creacion DataTable Para Datos Cuotas

                #region Llenado de Tabla de Cuotas

                for (int i = 1; i < (plazo + 1); i++)
                {
                    Fecha = fechaInicio.AddMonths(periodo / 30 * (i - 1));
                    InteresCuota = Math.Round(((SaldoCuota * (periodo) * Tasa) / 36000), CadenaConexion.Logeo.Decimales);
                    CapitalCuota = Math.Round((CuotaFija - InteresCuota), CadenaConexion.Logeo.Decimales);
                    if (i == plazo)
                    {
                        CuotaCuota = Math.Round((SaldoCuota + InteresCuota), CadenaConexion.Logeo.Decimales);
                        table.Rows.Add((concepto + (i + NumCuota) + "ADJ" + Adj), Adj, concepto, (i + NumCuota), Fecha, SaldoCuota, InteresCuota, CuotaCuota, SaldoCuota, InteresCuota, CuotaCuota);
                        SaldoCuota = 0;
                    }
                    else
                    {
                        CuotaCuota = Math.Round((CapitalCuota + InteresCuota), CadenaConexion.Logeo.Decimales);
                        SaldoCuota = Math.Round((SaldoCuota - CapitalCuota), CadenaConexion.Logeo.Decimales);
                        table.Rows.Add((concepto + (i + NumCuota) + "ADJ" + Adj), Adj, concepto, (i + NumCuota), Fecha, CapitalCuota, InteresCuota, CuotaCuota, CapitalCuota, InteresCuota, CuotaCuota);
                    }
                }

                #endregion Llenado de Tabla de Cuotas

                return table;
            }
            catch (Exception ex)
            {
                Event_ErrorTableNgConsultas(ex.Message, table);
                return table;
            }
        }
        public bool MtdPermisos(string Modulo, DataTable DtRoles, string Accion)
        {
            bool resultado = false;
            var query = (
            from Permisos in DtRoles.AsEnumerable()
            where Permisos.Field<string>("IdFormulario") == Modulo
            select new
            {
                resul = Permisos.Field<bool>(Accion)
            });
            foreach (var order in query)
            {
                resultado = order.resul;
            }
            return resultado;
        }

        public string NombrePropio(String texto, CultureInfo culture)
        {
            texto = texto.ToLower();
            TextInfo ti = culture.TextInfo;
            return ti.ToTitleCase(texto);
        } 
        #endregion
    }
}