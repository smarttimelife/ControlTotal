using Conexiones;
using Microsoft.EntityFrameworkCore;
using ModelAdmin;
using System;
using System.Data;
using System.Linq;

namespace Administracion.NegociosAdmin
{
    public class negLogin : negConsultasAdmin
    {
        #region Propiedades
        public DbSet<empresas> empresas { get; set; }
        public DataTable dtProyectos = new DataTable();
        public Logeo EntLogeo = new Logeo();
        private static CadenaConexionMysql CadenaConexion;
        private DataTable DtUsuario = new DataTable();
        public event DlgtStringExit Event_ErrorStringLogin;
        public event DlgtStringExit Event_OkStringLogin;
        public DbSet<roldetalles> roldetalles { get; set; }
        public DbSet<roles> roles { get; set; }
        #endregion Propiedades

        #region Constructores

        public negLogin(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
           
        }

        public negLogin(string StrServidor) : base(CadenaConexion)
        {
            CadenaConexion = new CadenaConexionMysql(StrServidor, "007guardian");
        }

        public negLogin(string StrServidor, string StrBaseDatos) : base(CadenaConexion)
        {
            CadenaConexion = new CadenaConexionMysql(StrServidor, StrBaseDatos);
        }

        public negLogin(string StrServidor, string StrBaseDatos, string StrPuerto) : base(CadenaConexion)
        {
            CadenaConexion = new CadenaConexionMysql(StrServidor, StrBaseDatos, StrPuerto);
        }

        #endregion Constructores

        #region Metodos

        public void MtdInicio()
        {
            EntLogeo.Fecha = DateTime.Now;
            dtProyectos = CnsDatos_Proyectos();
        }
        public void MtdLogin()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                Event_ErrorStringLogin(Stb.ToString());
            }
            else
            {
                EntLogeo.DtUsuario_Proyectos = CnsDatos_Usuarios_Proyectos(EntLogeo.Usuario, EntLogeo.IdProyecto);
                if (EntLogeo.DtUsuario_Proyectos.Rows.Count == 0)
                {
                    Event_ErrorStringLogin("Su Usuario No Tiene Permisos Para Este Proyectos");
                }
                else
                {
                    MtdSoftware();
                    Event_OkStringLogin("Bienvenidos al Sistema");
                }
            }
        }
        public bool MtdModulos(int StrIdSofware)
        {
            bool resultado = false;

            var query = (
            from Permisos in dtProyectos.AsEnumerable()
            where Permisos.Field<int>("IdFormulario") == StrIdSofware

            select new
            {
                resul = Permisos.Field<bool>("Ver")
            });

            foreach (var order in query)
            {
                resultado = order.resul;
            }
            return resultado;
        }
        private int IdEmpresa()
        {
            int resultado = 0;

            var query = (
            from Permisos in dtProyectos.AsEnumerable()
            where Permisos.Field<int>("Id") == EntLogeo.IdProyecto

            select new
            {
                resul = Permisos.Field<int>("IdEmpresa")
            });

            foreach (var order in query)
            {
                resultado = order.resul;
            }
            return resultado;
        }


        private string MtdBaseDatos(int StrIdSofware)
        {
            string resultado = string.Empty;
            var query = (
            from Permisos in EntLogeo.DtUsuario_Proyectos.AsEnumerable()
            where Permisos.Field<int>("IdSoftware") == StrIdSofware
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

        private string MtdBaseDeDatos(int IdSoftware,int IdProyecto)
        {
            string Sql = "SELECT BaseDatos  FROM conexiones WHERE IdProyecto = @IdProyecto AND IdSoftware = @IdSoftware";
            string[] para = { "IdProyecto", "IdSoftware" };
            object[] obPara = { IdProyecto, IdSoftware };
            return ConexionMysql.MtdBscDatosText(Sql, para, obPara);
        }




        private void MtdSoftware()
        {
            try
            {
                EntLogeo.EntEmpresas = empresas.Find(IdEmpresa());
                DataTable dt = CnsDatos_Software(EntLogeo.Usuario, EntLogeo.IdProyecto);
                EntLogeo.ModuloContab = Convert.ToBoolean(dt.Rows[0]["Activo"]);
                EntLogeo.ModuloCartera = Convert.ToBoolean(dt.Rows[1]["Activo"]);
                EntLogeo.ModuloAlttum = Convert.ToBoolean(dt.Rows[5]["Activo"]);
                EntLogeo.ModuloCompras = Convert.ToBoolean(dt.Rows[3]["Activo"]);
                EntLogeo.BaseDatosContab = MtdBaseDeDatos(1, EntLogeo.IdProyecto);
                EntLogeo.BaseDatosCartera = MtdBaseDeDatos(2, EntLogeo.IdProyecto);
                EntLogeo.IdEmpresa = EntLogeo.EntEmpresas.Id;
                EntLogeo.Logo = EntLogeo.EntEmpresas.Logo;
                EntLogeo.Imagen = EntLogeo.EntEmpresas.Imagen;
                EntLogeo.Decimales = EntLogeo.EntEmpresas.Decimales;
                EntLogeo.LstMyRoldetalles = roldetalles.ToList().Where(r => r.IdRol == EntLogeo.IdRol).ToList().OrderBy(r => r.IdFormulario).ToList();
                EntLogeo.EntRoles = roles.Find(EntLogeo.IdRol);
            }
            catch (Exception ex)
            {
                Event_ErrorStringLogin(ex.Message);
            }
        }
        private void MtdValidar()
        {
            CuentaErrores = 0;
            Stb.Clear();

            if (EntLogeo.IdProyecto == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Proyecto");
            }

            if (string.IsNullOrEmpty(EntLogeo.Usuario))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Usuario");
            }

            if (string.IsNullOrEmpty(EntLogeo.Clave))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Clave");
            }

            if (EntLogeo.Fecha == null || EntLogeo.Fecha == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Seleccione la Fecha");
            }

            if (CuentaErrores == 0)
            {
                DtUsuario = CnsDatos_Usuarios(EntLogeo.Usuario, EntLogeo.Clave);
                if (DtUsuario.Rows.Count == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Usuario o Clave Errada");
                }
                else
                {
                    EntLogeo.IdRol = Convert.ToInt32(DtUsuario.Rows[0]["IdRol"]);
                    EntLogeo.NombreRol = DtUsuario.Rows[0]["NombreRol"].ToString();
                    EntLogeo.NombreUsuario = DtUsuario.Rows[0]["NombreUsuario"].ToString();
                    EntLogeo.Skin = DtUsuario.Rows[0]["Skin"].ToString();
                    EntLogeo.StrUsuarioConextado = string.Format("Usuario Conextado:  {0} | Nombre Usuario:   {1} | Rol de Usuario:   {2} | Fecha Sistema:   {3}  ",
                                                                EntLogeo.Usuario, EntLogeo.NombreUsuario, EntLogeo.NombreRol, DateTime.Now.ToShortDateString());
                }
            }
        }
        #endregion Metodos
    }
}