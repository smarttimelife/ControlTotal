using Conexiones;
using ModelCartera;
using NegociosCartera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Cartera
{
    public class negPresupuesto : NegConsultasCartera
    {
        #region Propiedades      
        public event DlgtStringExit ErrorString_Event_Presupuesto;
        public event DlgtStringExit OkString_Event_Presupuesto;
        public event Conexiones.DlgtDataTableExit ErrorTable_EventPresupuesto;
        public DatosPresupuesto EntDatosPresupuesto = new DatosPresupuesto();
        public DataTable DtRangoCartera = new DataTable();
        CadenaConexionMysql CadenaConexion;
        public seguimiento EntSeguimiento = new seguimiento();
        #endregion

        #region Constructores
        public negPresupuesto(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }
        #endregion

        #region Disparadores

        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event_Presupuesto(mensaje);
        }

        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_Presupuesto(mensaje);
        }

        #endregion



        #region Metodos
        public DataTable CnsDtRangoCartera()
        {
            DtRangoCartera = ConexionMysql.MtdTableAdapter("select * from rangocartera");
            return DtRangoCartera;
        }

        public void MtdActualizarRango()
        {
            ConexionMysql.MtdActualizarAdapter(DtRangoCartera);
        }

        public DataTable BorradorPresupuesto()
        {
            MtdValidar();
            DataTable DtBorrador = new DataTable();
            if (CuentaErrores > 0)
            {
                ErrorTable_EventPresupuesto(Stb.ToString(), DtBorrador);
            }
            else
            {
                DtBorrador = CnsDtConsultaFecha("BorradorPresupuesto", EntDatosPresupuesto.FechaInicial, EntDatosPresupuesto.FechaFinal);

            }
            return DtBorrador;
        }

        public void MontarPresupuesto()
        {
            MtdValidar();

            if (CuentaErrores > 0)
            {
                ErrorString_Event_Presupuesto(Stb.ToString());
            }
            else
            {
                try
                {
                    string[] Para = { "StrNombre", "FechaInicial", "FechaFinal" };
                    object[] ObjePara = { "MontarPresupuesto", EntDatosPresupuesto.FechaInicial, EntDatosPresupuesto.FechaFinal };
                    ConexionMysql.MtdEjecutarProce("ConsultaFecha", Para, ObjePara);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_Presupuesto(ex.Message);
                }
            }
        }

        public void MtdValidar()
        {

            CuentaErrores = 0;
            Stb.Clear();

            if (EntDatosPresupuesto.FechaInicial == null || EntDatosPresupuesto.FechaInicial == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Inicial");
            }

            if (EntDatosPresupuesto.FechaFinal == null || EntDatosPresupuesto.FechaFinal == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Final");
            }

            if (EntDatosPresupuesto.FechaFinal < EntDatosPresupuesto.FechaInicial)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Fecha Final No Puede Ser Menor a Fecha Inicial");
            }

        }

        public void MtdValidarSeguimiento()
        {

            CuentaErrores = 0;
            Stb.Clear();

            if (string.IsNullOrEmpty(EntSeguimiento.Accion))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Accion");
            }
            if (string.IsNullOrEmpty(EntSeguimiento.Objecion))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Objecion");
            }
            if (EntSeguimiento.Compromiso != null)
            {
                if (EntSeguimiento.FechaCompromiso == null || EntSeguimiento.FechaCompromiso == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha Compromiso");
                }
            }

        }

        public DataTable CnsDtSeguimiento()
        {
            string[] Parametro = { "VarPeriodo", "VarIdUsuario", "Opcion" };
            object[] ObjParametro = { 202005, CadenaConexion.Logeo.Usuario, 1 };
            return ConexionMysql.MtdDataTableAdapterProce("Seguimiento", Parametro, ObjParametro);
        }

        public DataTable CnsDtPresupuesto()
        {

            string[] Parametro = { "VarPeriodo", "VarIdUsuario", "Opcion" };
            object[] ObjParametro = { 202005, CadenaConexion.Logeo.Usuario, 2 };
            return ConexionMysql.MtdDataTableAdapterProce("Seguimiento", Parametro, ObjParametro);
        }

        public void AddSeguimiento()
        {

            MtdValidarSeguimiento();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_Presupuesto(Stb.ToString());
            }
            else
            {

                string[] consulta = new string[1];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                string resultado = string.Empty;

                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntSeguimiento));
                valparametros.Add(CadenaConexion.MtdValParametros(EntSeguimiento));
                consulta[0] = CadenaConexion.mtdCrearInsert("seguimiento", CadenaConexion.MtdCrearParametro(EntSeguimiento));

                resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
        } 

        public DataTable DtCnsSeguimientoFecha()
        {
            DataTable dt = new DataTable();
            MtdValidar();
            if(CuentaErrores>0)
            {
                ErrorTable_EventPresupuesto(Stb.ToString(), dt);
            }
            else
            {
             return   CnsDtConsultaFecha("Seguimiento", EntDatosPresupuesto.FechaInicial, EntDatosPresupuesto.FechaFinal);
            }return dt;
        }

        public DataTable DtCnsPresuestoPeriodo()
        {
            DataTable dt = new DataTable();
            if (EntDatosPresupuesto.Periodo == 0)
            {
                ErrorTable_EventPresupuesto("Falta Seleccionar Periodo", dt);
            }
            else
            {
                string[] Parametro = { "VarPeriodo", "VarIdUsuario", "Opcion" };
                object[] ObjParametro = { EntDatosPresupuesto.Periodo, CadenaConexion.Logeo.Usuario, 3 };
                return ConexionMysql.MtdDataTableAdapterProce("Seguimiento", Parametro, ObjParametro);
            }
            return dt;
        }
        #endregion
    }
}

public class DatosPresupuesto
{
    public int Periodo { get; set; }
    public DateTime FechaInicial { get; set; }
    public DateTime FechaFinal { get; set; }
}

