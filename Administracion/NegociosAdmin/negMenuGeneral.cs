using Conexiones;

namespace Administracion.NegociosAdmin
{
    public class negMenuGeneral : negConsultasAdmin
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;

        #endregion Propiedades

        #region Cnstructor

        public negMenuGeneral(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }

        #endregion Cnstructor
    }
}