namespace NegociosCartera
{
    using Conexiones;
    using ModelCartera;
    using System;
    using System.Data;
    public class negReportes : NegConsultasCartera
    {
        #region Propiedades
        public DataTable DtAdjudicacion = new DataTable();
        public DataTable DtFinanciacion = new DataTable();
        public DataTable DtComision = new DataTable();
        public consultaFecha EntConsultaFecha = new consultaFecha();
        public string StrIdAdjudicacion = string.Empty;
        public event DlgtDataTableExit Event_ErrorTableReporte;
        public event DlgtDataTableExit Event_OkTableReporte;
        #endregion


        #region Constructores
        public negReportes(CadenaConexionMysql cadenaConexion, string idAdjudicacion) : base(cadenaConexion)
        {
            DtAdjudicacion = cnsAdjudicacion(idAdjudicacion);
            DtFinanciacion = cnsFinanciacion(idAdjudicacion);
            DtComision = cnsComision(idAdjudicacion);
            StrIdAdjudicacion = idAdjudicacion;
        }

        public negReportes(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {

        }
        #endregion


        #region Metodos
        public DataTable cnsComision(string IdAdjudicacion)
        {
            return CnsDtConsultaStrId("Comision", IdAdjudicacion);
        }
        public DataTable cnsFinanciacion(string Id)
        {
            return CnsDtConsultaStrId("Financiacion", Id);
        }
        public DataTable cnsAdjudicacion(string IdAdjudicacion)
        {
            return CnsDtConsultaStrId("Adjudicacion", IdAdjudicacion);
        } 

        public void CnsRecaudoFecha()
        {
            DataTable dt = new DataTable();
            MtdValidarFechas();
            if (CuentaErrores > 0)
            {
                Event_ErrorTableReporte(Stb.ToString(),dt);
            }
            else
            {
                dt = CnsDtConsultaFecha("Recaudos", EntConsultaFecha.FechaInicial, EntConsultaFecha.FechaFinal);
                Event_OkTableReporte("Ok", dt);

            }
             
        }

        public void MtdValidarFechas()
        {

            CuentaErrores = 0;
            Stb.Clear();
            if (EntConsultaFecha.FechaInicial == null || EntConsultaFecha.FechaInicial == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Inicial");
            }
            if (EntConsultaFecha.FechaFinal == null || EntConsultaFecha.FechaFinal == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Final");
            }

            if (EntConsultaFecha.FechaInicial>EntConsultaFecha.FechaFinal)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Fecha Inicial Mayor a Fecha Final");
            }

        }

        #endregion
    }
}
