using Administracion.NegociosAdmin;
using Conexiones;
using Microsoft.EntityFrameworkCore;
using ModelAdmin;
using System;

namespace Administracion
{
    public class negClaves : negConsultasAdmin
    {
        #region Propiedades
        CadenaConexionMysql CadenaConexion;
        public roldetalles MysPermisos = new roldetalles();
        public event DlgtStringExit OkString_Event_Claves;
        public event DlgtStringExit ErrorString_Event_Claves;
        private usuarios EntUsuarios = new usuarios();
        public claves EntClaves = new claves();
        public DbSet<usuarios> usuarios { get; set; }
        #endregion

        #region Constructores
        public negClaves(CadenaConexionMysql cadenaConexion, string StrModulo, int IntIdUsuario) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            MysPermisos = cadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo);
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql; ;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            EntUsuarios = usuarios.Find(IntIdUsuario);
            EntClaves.IdUsuario = EntUsuarios.IdUsuario;
            EntClaves.NombreUsuario = EntUsuarios.NombreUsuario;
        }

        public negClaves(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;

            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql; ;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            EntClaves.IdUsuario = CadenaConexion.Logeo.Usuario;
            EntClaves.NombreUsuario = cadenaConexion.Logeo.NombreUsuario;

        }
        #endregion
        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event_Claves(mensaje);
        }
        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_Claves(mensaje);
        }

        public void MtdReasignarClave()
        {
            MtdValidarClaves();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_Claves(Stb.ToString());
            }
            else
            {
                EntUsuarios.FechaModificacion = DateTime.Now;
                EntUsuarios.UsuarioAutoriza = CadenaConexion.Logeo.Usuario;
                EntUsuarios.Clave = CnsPassword(EntClaves.Clave);
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
                    ErrorString_Event_Claves(ex.Message);
                }
            }
        }
        public void MtdCambiarClave()
        {
            MtdValidarCambioClaves();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_Claves(Stb.ToString());
            }
            else
            {
                EntUsuarios.FechaModificacion = DateTime.Now;
                EntUsuarios.UsuarioAutoriza = CadenaConexion.Logeo.Usuario;
                EntUsuarios.Clave = CnsPassword(EntClaves.Clave);
                EntUsuarios.IdUsuario = CadenaConexion.Logeo.Usuario;
                string consulta = string.Empty;
                try
                {
                    string[] parametroWhere = { "IdUsuario" };
                    string[] nombreparametro = (CadenaConexion.MtdCrearParametro(EntUsuarios));
                    object[] valparametro = (CadenaConexion.MtdValParametros(EntUsuarios));
                    consulta = "UPDATE usuarios Set Clave = @Clave,FechaModificacion = @FechaModificacion,UsuarioModifica = @UsuarioModifica WHERE IdUsuario = @IdUsuario";
                    string ms = ConexionMysql.MtdEjecutarText(consulta, nombreparametro, valparametro);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_Claves(ex.Message);
                }
            }
        }
        private void MtdValidarClaves()
        {
            CuentaErrores = 0;
            Stb.Clear();
            if (string.IsNullOrEmpty(EntClaves.IdUsuario))
            {
                Stb.AppendLine("Falta IdUsuario");
                CuentaErrores += 1;
            }
            if (string.IsNullOrEmpty(EntClaves.Clave))
            {
                Stb.AppendLine("Falta  Clave");
                CuentaErrores += 1;
            }
            if (string.IsNullOrEmpty(EntClaves.ConfirmarClave))
            {
                Stb.AppendLine("Falta Confirmacion de Clave");
                CuentaErrores += 1;
            }

            if (EntClaves.Clave != EntClaves.ConfirmarClave)
            {
                Stb.AppendLine("Clave no Coincide con Confirmacion de Claves");
                CuentaErrores += 1;
            }
        }

        private void MtdValidarCambioClaves()
        {
            CuentaErrores = 0;
            Stb.Clear();
            if (string.IsNullOrEmpty(EntClaves.Clave))
            {
                Stb.AppendLine("Falta   Clave");
                CuentaErrores += 1;
            }
            if (string.IsNullOrEmpty(EntClaves.ConfirmarClave))
            {
                Stb.AppendLine("Falta Confirmacion de Clave");
                CuentaErrores += 1;
            }
            if (EntClaves.ClaveActual != CadenaConexion.Logeo.Clave)
            {
                Stb.AppendLine("Rectificar Clave Actual");
                CuentaErrores += 1;
            }

            if (EntClaves.Clave != EntClaves.ConfirmarClave)
            {
                Stb.AppendLine("Clave no Coincide con Confirmacion de Claves");
                CuentaErrores += 1;
            }
        }
    }
}
