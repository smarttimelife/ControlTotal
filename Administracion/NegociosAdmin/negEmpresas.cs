using Conexiones;
using Microsoft.EntityFrameworkCore;
using ModelAdmin;
using System;

namespace Administracion.NegociosAdmin
{
    public class negEmpresas : negMenuGeneral
    {
        #region Propiedades
        public DbSet<empresas> empresas { get; set; }
        public roldetalles MysPermisos = new roldetalles();
        public empresas EntEmpresas = new empresas();
        private string StrOperacion = string.Empty;
        public event DlgtStringExit OkString_Event__Empresas;
        public event DlgtStringExit ErrorString_Event_Empresas;
        private CadenaConexionMysql CadenaConexion;

        #endregion Propiedades

        #region Constructores

        public negEmpresas(CadenaConexionMysql cadenaConexion, string StrModulo) : base(cadenaConexion)
        {
            MysPermisos = cadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo);
            StrOperacion = "Adicionar";
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }
        public negEmpresas(CadenaConexionMysql cadenaConexion, string StrModulo, string strOperacion, int IdEmpresa) : base(cadenaConexion)
        {
            EntEmpresas = empresas.Find(IdEmpresa);
            StrOperacion = strOperacion;
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }

        #endregion Constructores

        #region Disparadores

        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_Empresas(mensaje);
        }
        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event__Empresas(mensaje);
        }

        #endregion

        #region Metodos
        public void MtdAdicionar()
        {
            MtdValidar();
            if (CuentaErrores == 0)
            {
                Stb.Clear();

                EntEmpresas.FechaOperacion = DateTime.Now;
                EntEmpresas.UsuarioAutoriza = CadenaConexion.Logeo.Usuario;
                EntEmpresas.Estado = "Vigente";
                try
                {
                    string resultado;
                    string consulta = string.Empty;
                    string[] nomparametros = (CadenaConexion.MtdCrearParametro(EntEmpresas));
                    object[] valparametros = (CadenaConexion.MtdValParametros(EntEmpresas));
                    consulta = CadenaConexion.mtdCrearInsert("empresas", nomparametros);
                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_Empresas(ex.Message);
                }
            }
            else
            {
                ErrorString_Event_Empresas(Stb.ToString());
            }
        }
        public void MtdModificar()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_Empresas(Stb.ToString());
            }
            else
            {
                try
                {
                    EntEmpresas.FechaModificacion = DateTime.Now;
                    EntEmpresas.UsuarioModifica = CadenaConexion.Logeo.Usuario;
                    string[] strWhre = { "Id" };
                    string resultado;
                    string consulta = string.Empty;
                    string[] nomparametros = (CadenaConexion.MtdCrearParametro(EntEmpresas));
                    object[] valparametros = (CadenaConexion.MtdValParametros(EntEmpresas));
                    consulta = CadenaConexion.mtdCrearUpdate("empresas", CadenaConexion.MtdCrearParametro(EntEmpresas), strWhre);
                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_Empresas(ex.Message);
                }
            }

        }
        public void MtdEliminar()
        {
            try
            {
                EntEmpresas.FechaOperacion = DateTime.Now;
                EntEmpresas.Estado = "Eliminado";
                EntEmpresas.UsuarioModifica = CadenaConexion.Logeo.Usuario;
                string[] parametroWhere = { "Id" };
                string[] nombreparametro = (CadenaConexion.MtdCrearParametro(EntEmpresas));
                object[] valparametro = (CadenaConexion.MtdValParametros(EntEmpresas));
                string consulta = CadenaConexion.mtdCrearUpdate("empresas", nombreparametro, parametroWhere);
                string ms = ConexionMysql.MtdEjecutarText(consulta, nombreparametro, valparametro);
            }
            catch (Exception ex)
            {
                ErrorString_Event_Empresas(ex.Message);
            }
        }
        private void MtdValidar()
        {
            CuentaErrores = 0;
            Stb.Clear();
            if (string.IsNullOrEmpty(EntEmpresas.Nit))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Nit");
            }

            if (string.IsNullOrEmpty(EntEmpresas.NombreEmpresa))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Nombre de Empresa");
            }

            if (string.IsNullOrEmpty(EntEmpresas.Direccion))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Direccion");
            }
        }
        #endregion
    }
}