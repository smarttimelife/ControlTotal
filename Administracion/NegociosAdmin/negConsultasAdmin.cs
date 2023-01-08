namespace Administracion.NegociosAdmin
{
    using Conexiones;
    #region Librerias

    using ModelAdmin;
    using System;
    using System.Data;
    using System.Globalization;
    using System.Text;
    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //ABRIL 10 2020
    #endregion Librerias

    public abstract class negConsultasAdmin : EntityContexto
    {
        #region Propiedades

        public MysqlContext ConexionMysql;
        public int CuentaErrores = 0;
        public StringBuilder Stb = new StringBuilder();
        private CadenaConexionMysql CadenaConexion;
        public event DlgtDataTableExit Event_ErrorTableNgConsultas;
        //public DbSet<empresas> empresas { get; set; }
        //public DbSet<roldetalles> DbRolDetallet { get; set; }
        //public DbSet<roles> DbRoles { get; set; }
        //public DbSet<usuarios> DbsUsuarios { get; set; }

        #endregion Propiedades

        #region Constructores

        public negConsultasAdmin(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql = new MysqlContext(CadenaConexion);
            ConexionMysql.EventDataErrorTableMysql += ConexionMysql_EventDataErrorTableMysql;
        }

        #endregion Constructores

        #region Disparadores

        private void ConexionMysql_EventDataErrorTableMysql(string mensaje, System.Data.DataTable dataTable)
        {
            Event_ErrorTableNgConsultas(mensaje, dataTable);
        }

        #endregion Disparadores

        #region Metodos

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

        public int CnsCantClientes(string StrIdTerceros, int IntTipoTercero)
        {
            string[] StrParametros = { "StrNombre", "StrId", "IntId" };
            object[] ObjParametros = { "CantTipoTercero", StrIdTerceros, IntTipoTercero };
            DataTable Cantidad = ConexionMysql.MtdDataTableAdapterProce("ConsultaStrIdIntId", StrParametros, ObjParametros);
            return Convert.ToInt16(Cantidad.Rows[0][0]);
        }
        public int cnsConcecutivoTransass()
        {
            DataTable data = ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", "ConcecutivoTrans");
            return Convert.ToInt32(data.Rows[0][0]);
        }
        public string CnsPassword(string StrClave)
        {
            string[] StrParametros = { "StrNombre", "StrId" };
            object[] ObjParametros = { "Password", StrClave };
            DataTable data = ConexionMysql.MtdDataTableAdapterProce("ConsultaStrId", StrParametros, ObjParametros);
            return data.Rows[0][0].ToString();
        }
        public int cnsConcecutivoRoles()
        {
            DataTable data = ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", "ConcecutivoRoles");
            return Convert.ToInt32(data.Rows[0][0]);
        }
        public DataTable CnsCorreoDesde()
        {
            return ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", "CorreoDesde");
        }
        public DataTable CnsDatos_Proyectos()
        {
            return ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", "Proyecto");
        }
        public DataTable CnsDatos_Software(string StrIdUsuario, int IntIdProyectos)
        {
            object[] ObjParametros = { StrIdUsuario, IntIdProyectos };
            string[] StrParametros = { "StrIdUsuario", "IntIdProyecto" };
            return ConexionMysql.MtdDataTableAdapterProce("spSoftware", StrParametros, ObjParametros);
        }
        public DataTable CnsDatos_Usuarios(string StgrUsuario, string StrClave)
        {
            string[] StrParametros = { "StrIdUsuario", "StrClave" };
            object[] ObjParametros = { StgrUsuario, StrClave };
            return ConexionMysql.MtdDataTableAdapterProce("SpValidarUsuarios", StrParametros, ObjParametros);
        }
        public DataTable CnsDatos_Usuarios_Proyectos(string StrIdUsuario, int IntIdProyectos)
        {
            string[] StrParametros = { "StrIdUsuario", "IntIdProyecto" };
            object[] ObjParametros = { StrIdUsuario, IntIdProyectos };
            return ConexionMysql.MtdDataTableAdapterProce("SpUsuarioProyecto", StrParametros, ObjParametros);
        }
        public DataTable CnsDatos_Usuarios_Proyectos(int IdUsuario)
        {
            string[] StrParametros = { "StrNombre", "IntId" };
            object[] ObjParametros = { "UsuarioProyecto", IdUsuario };
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaId", StrParametros, ObjParametros);
        }
        public DataTable CnsEmpresas()
        {
            return ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", "Empresas");
        }
        public DataTable CnsProyectosIdEmpresa(int IdEmpresa)
        {
            string[] StrParametros = { "StrNombre", "IntId" };
            object[] ObjParametros = { "Proyectos", IdEmpresa };
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaId", StrParametros, ObjParametros);
        }
        public DataTable CnsRoles()
        {
            return ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", "Roles");
        }

        public DataTable CnsDetalleRol(int IdRol)
        {
            string[] StrParametros = { "StrNombre", "IntId" };
            object[] ObjParametros = { "DetalleRol", IdRol };
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaId", StrParametros, ObjParametros);
        }

        public DataTable CnsDetalleRol()
        {
            return ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", "DetalleRol");
        }
        public DataTable CnsSoftware()
        {
            return ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", "Software");
        }
        public DataTable CnsTerceros(string StrIdTerceros)
        {
            string[] StrParametros = { "StrNombre", "StrId" };
            object[] ObjParametros = { "Terceros", StrIdTerceros };
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaStrId", StrParametros, ObjParametros);
        }
        public DataTable CnsTercerosTipo(string StrIdTerceros)
        {
            string[] StrParametros = { "StrNombre", "StrId" };
            object[] ObjParametros = { "TipoCliente", StrIdTerceros };
            return ConexionMysql.MtdDataTableAdapterProce("ConsultaStrId", StrParametros, ObjParametros);
        }
        public DataTable CnsTipoDocumento()
        {
            return ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", "TipoDocumento");
        }
        public DataTable CnsTipoPersonas()
        {
            return ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", "TipoPersonas");
        }
        public DataTable CnsTipoTercero()
        {
            return ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", "TipoTercero");
        }
        public DataTable CnsUsuarios_Vigentes()
        {
            return ConexionMysql.MtdDataTableAdapterProce("Consulta", "StrNombre", "Usuarios");
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
        public roldetalles MtdPermisosVer(string Accio, string Modulo)
        {
            return CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == Modulo);
        }
        public string NombrePropio(String texto, CultureInfo culture)
        {
            texto = texto.ToLower();
            TextInfo ti = culture.TextInfo;
            return ti.ToTitleCase(texto);
        }
        public string ToNombrePropio(String texto, CultureInfo culture)
        {
            texto = texto.ToLower();
            TextInfo ti = culture.TextInfo;
            return ti.ToTitleCase(texto);
        }
        #endregion Metodos
    }
}