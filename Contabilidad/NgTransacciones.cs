
namespace Contabilidad
{
    #region Librerias
    using Conexiones;
    using ModelContabilidad;
    using NegociosContabilidad;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Reflection; 
    #endregion

    public abstract class NgTransacciones : NegConsulta_Contabilidad, IOperaciones
    {
        #region Propiedades
        public diario diario = new diario();
        public DataTable DtRegistros;
        private CadenaConexionMysql CadenaConexion;
        public event DlgtStringExit ErrorString_Event_Transaccion;
        public event DlgtStringExit OkString_Event_Transaccion;
        #endregion

        #region Constructor
        public NgTransacciones(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }
        public NgTransacciones(CadenaConexionMysql cadenaConexion,string IdTransaccion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }
        #endregion

        #region Disparadores
        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_Transaccion(mensaje);
        }
        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event_Transaccion(mensaje);
        } 
        #endregion

        #region Metodos
        public void MtdAdicionar()
        {
            string[] consulta = new string[2];
            string resultado = string.Empty;
            List<string[]> nomparametros = new List<string[]> { };
            List<object[]> valparametros = new List<object[]> { };
            MtdValidar();
            if(CuentaErrores>0)
            {
                ErrorString_Event_Transaccion(Stb.ToString());
            }
            else
            {
                try
                {
                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_Transaccion(ex.Message);
                }
            }
        }
        public void MtdEliminar()
        {
           
        }
        public void MtdModfiicar()
        {
            
        }
        public void MtdValidar()
        {
            Stb.Clear();
            CuentaErrores = 0;
            if (diario.Fecha == null || diario.Fecha == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta seleccionar Fecha");
            }

            if (diario.Motivo == null || diario.Motivo == string.Empty)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Concepto");
            }

            if (diario.IdTercero == null || diario.IdTercero == string.Empty)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Tercero ");
            }

            if (diario.CentroCostos == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Centro de Costo");
            }

            if (diario.SubCentro == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta SubCentro de Costo");
            }

            if (string.IsNullOrEmpty(diario.SubSubCentro))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar El SubSubCentro");
            }

        } 
        #endregion
    }
}
