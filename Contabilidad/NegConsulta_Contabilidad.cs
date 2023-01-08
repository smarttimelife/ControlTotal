namespace NegociosContabilidad
{
    #region Librerias
    using Conexiones;
    using System;
    using System.Data;
    using System.Text; 
    #endregion
    interface  IOperaciones
    {        
        void MtdAdicionar();
        void MtdModfiicar();
        void MtdEliminar();
        void MtdValidar();
    }

    public abstract class NegConsulta_Contabilidad : EntityContexto
    {
        #region Propiedades
        public MysqlContext ConexionMysql;
        public int CuentaErrores = 0;
        public StringBuilder Stb = new StringBuilder();
        private CadenaConexionMysql CadenaConexion;
        public event DlgtDataTableExit Event_ErrorTableNgConsultas;
       
        #endregion Propiedades

        #region Constructor
        public NegConsulta_Contabilidad(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql = new MysqlContext(CadenaConexion);
            ConexionMysql.EventDataErrorTableMysql += ConexionMysql_EventDataErrorTableMysql;            
        }
        #endregion

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
        public DataTable cnsDtConsultaStrId(string StrNombre, object StrId)
        {
            string[] Parametro = { "StrNombre", "VarId" };
            object[] ObjParametro = { StrNombre, StrId };
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaStrId", Parametro, ObjParametro);
        }



        /// <summary>
        /// Consulta General De Los Procedimiento Almacenado Consulta
        /// </summary>
        /// <param name="StrNombre">
        /// Nombre de la Comsulta en el procedimiento
        /// </param>
        /// <returns></returns>
        public DataTable cnsDtConsulta(string StrNombre)
        {
            return ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", StrNombre);
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
        public DataTable consultaDuoStrId(string StrNombre, string VarId, string VarTrans)
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
        public DataTable cnsDtCombox(string StrTabla)
        {
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaCombos", "StrNombre", StrTabla);
        }

        #endregion 
    }
}
