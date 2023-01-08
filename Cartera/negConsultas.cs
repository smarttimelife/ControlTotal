using Conexiones;
using ModelCartera;
using NegociosCartera;
using System;
using System.Collections.Generic;
using System.Data;

namespace Cartera
{
   public class negConsultas : NegConsultasCartera
    {
        #region Propiedades
        private CadenaConexionMysql CadenaConexion;
        public datosconsulta EntDatosConsultas = new datosconsulta();
        public event DlgtStringExit Ok_Event_String_negConsultas;
        public event DlgtStringExit Error_Event_String_negConsultas;
        #endregion

        #region Constructor
        public negConsultas(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        } 
        #endregion

        #region Disparadores
        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            Ok_Event_String_negConsultas(mensaje);
        }

        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            Error_Event_String_negConsultas(mensaje);
        }
        #endregion


        public DataTable CnsComisionFecha()
        {
            DataTable Dt = new DataTable();
            MtdValidarFechas();
            if(CuentaErrores>0)
            {
                Error_Event_String_negConsultas(Stb.ToString());
            }
            else
            {
                return CnsDtConsultaFecha("CnsPagoComision", EntDatosConsultas.FechaInicial, EntDatosConsultas.FechaFinal);
            }
            return Dt;
        }

        public DataTable CnsComisionAsesor()
        {
            DataTable Dt = new DataTable();
            MtdValidarFechas();
            if (CuentaErrores > 0)
            {
                Error_Event_String_negConsultas(Stb.ToString());
            }
            else
            {
                return CnsDtConsultaFechaString("PagoComisionAsesor", EntDatosConsultas.FechaInicial, EntDatosConsultas.FechaFinal,EntDatosConsultas.IdTercero);
            }
            return Dt;
        }

        public void MtdValidarFechas()
        {
            CuentaErrores = 0;
            Stb.Clear();

            if (EntDatosConsultas.FechaInicial == null || EntDatosConsultas.FechaInicial == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Inicial");
            }

            if (EntDatosConsultas.FechaFinal == null || EntDatosConsultas.FechaFinal == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Final");
            }

            if (EntDatosConsultas.FechaFinal < EntDatosConsultas.FechaInicial)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Fecha Final No Puede Ser Menor a Fecha Inicial");
            }

        }

        public void MtdValidarFechasAsesor()
        {
            CuentaErrores = 0;
            Stb.Clear();

            if (EntDatosConsultas.FechaInicial == null || EntDatosConsultas.FechaInicial == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Inicial");
            }

            if (EntDatosConsultas.FechaFinal == null || EntDatosConsultas.FechaFinal == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Final");
            }

            if (EntDatosConsultas.FechaFinal < EntDatosConsultas.FechaInicial)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Fecha Final No Puede Ser Menor a Fecha Inicial");
            }

            if (string.IsNullOrEmpty(EntDatosConsultas.IdTercero))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Asesor");
            }

        }

         
    }
}
