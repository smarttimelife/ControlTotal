namespace Cartera
{
    #region Librerias
    using Conexiones;
    using ModelCartera;
    using NegociosCartera; 
    //JAVIER ENRIQUE VILLALBA ESPINOSA
    #endregion

   public class negAnticipos : NegConsultasCartera
    {


        #region Propiedades      
        public event DlgtStringExit ErrorString_Event_Anticipos;
        public event DlgtStringExit OkString_Event_Anticipos;
        CadenaConexionMysql CadenaConexion;
        private pagocomision entPagocomision = new pagocomision();
        private diario entidaddiario = new diario();
        #endregion

        #region Constructores
        public negAnticipos(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }
        #endregion

        #region Disparadores
        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event_Anticipos(mensaje);
        }

        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_Anticipos(mensaje);
        }
        #endregion
    }
}
