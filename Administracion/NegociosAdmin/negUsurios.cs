namespace Administracion
{
    #region Librerias
    //@Javier Villalba Espinosa
    using Administracion.NegociosAdmin;
    using Conexiones;
    using Microsoft.EntityFrameworkCore;
    using ModelAdmin;
    using System;
    using System.Data;
    using System.Text; 
    #endregion
    public class negUsurios : negConsultasAdmin
    {
        #region Propiedades

        public roldetalles MysPermisos = new roldetalles();
        public usuarios EntUsuarios = new usuarios();
        public string ConfirmarClave { get; set; }
        public DataTable DtRoles = new DataTable();
        private EnviarCorreo Correo;       
        private StringBuilder Stb1 = new StringBuilder();
        private StringBuilder Stb2 = new StringBuilder();
        private CadenaConexionMysql CadenaConexion;
        public event DlgtStringExit OkString_Event__Usuarios;
        public event DlgtStringExit ErrorString_Event_Usuarios;
        private string ContraSena = string.Empty;
        private string StrOperacion = string.Empty;
        public claves EntClaves = new claves();
        public DbSet<usuarios_proyectos> usuarios_proyectos { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
        #endregion Propiedades

        #region Constructor

        public negUsurios(CadenaConexionMysql cadenaConexion, string StrModulo) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            MysPermisos = cadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo);
            DtRoles = CnsRoles();
            Correo = new EnviarCorreo(CnsCorreoDesde());
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            Correo.MesError += Correo_MesError;
            Correo.MesOk += Correo_MesOk;
            StrOperacion = "Adicionar";
        }
        public negUsurios(CadenaConexionMysql cadenaConexion, string StrModulo, string strOperacion, int IntIdUsuario) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            MysPermisos = cadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo);
            DtRoles = CnsRoles();
            Correo = new EnviarCorreo(CnsCorreoDesde());
            EntUsuarios = usuarios.Find(IntIdUsuario);
            StrOperacion = strOperacion;
        }

        #endregion Constructor

        #region Disparadores

        private void Correo_MesOk(string mensaje)
        {
            OkString_Event__Usuarios("Usuarios Creado Correctamente");
        }
        private void Correo_MesError(string mensaje)
        {
            Stb2.Clear();
            Stb2.AppendLine("Usuarios Creado Correctamente");
            Stb2.AppendLine("Correo no enviado a usuario la clave es: " + ContraSena);
            OkString_Event__Usuarios(Stb2.ToString());
        }
        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            if (StrOperacion == "Adicionar")
            {
                Correo.MtdEnviarCorreo(EntUsuarios.CorreoElectronico, "Envio Clave Usuario", Stb1.ToString());
            }
            else
                OkString_Event__Usuarios(mensaje);
        }
        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_Usuarios(mensaje);
        }

        #endregion Disparadoes

        #region Metodos


        public void MtdAdicionar()
        {
            MtdValidar();
            if (CuentaErrores == 0)
            {
                Stb1.Clear();
                ContraSena = MtdContraseña(12);
                EntUsuarios.FechaOperacion = DateTime.Now;
                EntUsuarios.UsuarioAutoriza = CadenaConexion.Logeo.Usuario;
                EntUsuarios.Estado = "Vigente";
                try
                {
                    EntUsuarios.Clave = ContraSena;
                    Stb1.AppendLine("Se ha creado usuario exitosamente.");
                    Stb1.AppendLine("Su Usuario es:" + EntUsuarios.IdUsuario);
                    Stb1.AppendLine("Se Clave es: " + ContraSena);
                    string resultado;
                    string consulta = string.Empty;
                    string[] nomparametros = (CadenaConexion.MtdCrearParametro(EntUsuarios));
                    object[] valparametros = (CadenaConexion.MtdValParametros(EntUsuarios));
                    consulta = RscAdmin.AddUsuarios;
                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_Usuarios(ex.Message);
                }
            }
            else
            {
                ErrorString_Event_Usuarios(Stb.ToString());
            }
        }
        public void MtdModificar()
        {
            MtdValidar();
            if (CuentaErrores == 0)
            {
                try
                {
                    EntUsuarios.FechaModificacion = DateTime.Now;
                    EntUsuarios.UsuarioModifica = CadenaConexion.Logeo.Usuario;
                    string[] strWhre = { "Id" };
                    string resultado;
                    string consulta = string.Empty;
                    string[] nomparametros = (CadenaConexion.MtdCrearParametro(EntUsuarios));
                    object[] valparametros = (CadenaConexion.MtdValParametros(EntUsuarios));
                    consulta = CadenaConexion.mtdCrearUpdate("usuarios", CadenaConexion.MtdCrearParametro(EntUsuarios), strWhre);
                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_Usuarios(ex.Message);
                }
            }
            else
            {
                ErrorString_Event_Usuarios(Stb.ToString());
            }
        }
        public void MtdEliminar()
        {
            EntUsuarios.FechaModificacion = DateTime.Now;
            EntUsuarios.UsuarioModifica = CadenaConexion.Logeo.Usuario;
            EntUsuarios.Estado = "Eliminado";
            string consulta = string.Empty;
            try
            {
                string[] parametroWhere = { "Id" };
                string[] nombreparametro = (CadenaConexion.MtdCrearParametro(EntUsuarios));
                object[] valparametro = (CadenaConexion.MtdValParametros(EntUsuarios));
                consulta = CadenaConexion.mtdCrearUpdate("usuarios", nombreparametro, parametroWhere);
                string ms = ConexionMysql.MtdEjecutarText(consulta, nombreparametro, valparametro);
            }
            catch (Exception ex)
            {
                ErrorString_Event_Usuarios(ex.Message);
            }
        }
        public void MtdDesbloquear()
        {
            EntUsuarios.FechaModificacion = DateTime.Now;
            EntUsuarios.UsuarioModifica = CadenaConexion.Logeo.Usuario;
            EntUsuarios.Estado = "Vigente";
            string consulta = string.Empty;
            try
            {
                string[] parametroWhere = { "Id" };
                string[] nombreparametro = (CadenaConexion.MtdCrearParametro(EntUsuarios));
                object[] valparametro = (CadenaConexion.MtdValParametros(EntUsuarios));
                consulta = CadenaConexion.mtdCrearUpdate("usuarios", nombreparametro, parametroWhere);
                string ms = ConexionMysql.MtdEjecutarText(consulta, nombreparametro, valparametro);
            }
            catch (Exception ex)
            {
                ErrorString_Event_Usuarios(ex.Message);
            }
        }
        public void MtdBloquear()
        {
            EntUsuarios.FechaModificacion = DateTime.Now;
            EntUsuarios.UsuarioModifica = CadenaConexion.Logeo.Usuario;
            EntUsuarios.Estado = "Bloqueado";
            string consulta = string.Empty;
            try
            {
                string[] parametroWhere = { "Id" };
                string[] nombreparametro = (CadenaConexion.MtdCrearParametro(EntUsuarios));
                object[] valparametro = (CadenaConexion.MtdValParametros(EntUsuarios));
                consulta = CadenaConexion.mtdCrearUpdate("usuarios", nombreparametro, parametroWhere);
                string ms = ConexionMysql.MtdEjecutarText(consulta, nombreparametro, valparametro);
            }
            catch (Exception ex)
            {
                ErrorString_Event_Usuarios(ex.Message);
            }
        }
        private string MtdContraseña(int longitudContrasenia)
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;

            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contraseniaAleatoria += letra.ToString();
            }
            return contraseniaAleatoria;
        }
        private void MtdValidar()
        {
            CuentaErrores = 0;
            Stb.Clear();
            if (string.IsNullOrEmpty(EntUsuarios.IdUsuario))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta IdUsuario");
            }

            if (string.IsNullOrEmpty(EntUsuarios.NombreUsuario))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Nombre de Usuario");
            }

            if (string.IsNullOrEmpty(EntUsuarios.CorreoElectronico))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Correo Electronico");
            }

            if (EntUsuarios.IdRol == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Rol de Usuario");
            }
        }


        #endregion Metodos
    }
}