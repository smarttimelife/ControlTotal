namespace Administracion.NegociosAdmin
{
    #region Libreriras
    using Conexiones;
    using Microsoft.EntityFrameworkCore;
    using ModelAdmin;
    using System;
    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //10 DE ABRIL 2020
    #endregion
    public class negUsuario_Proyecto : negConsultasAdmin
    {
        #region Propiedades
        private CadenaConexionMysql CadenaConexion;
        public DbSet<usuarios> usuarios { get; set; }
        public usuarios EntUsuarios = new usuarios();
        public usuarios_proyectos Entusuarios_Proyectos = new usuarios_proyectos();
        public event DlgtStringExit OkString_Event__UsrProye;
        public event DlgtStringExit ErrorString_Event__UsrProye;
        #endregion

        #region Constructores
        public negUsuario_Proyecto(CadenaConexionMysql cadenaConexion, int IdUsuario) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            EntUsuarios = usuarios.Find(IdUsuario);
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
        }
        #endregion

        #region Disparadores
        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event__UsrProye(mensaje);
        }
        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event__UsrProye(mensaje);
        }

        #endregion

        #region Metodos

        public void MtdAdicionar()
        {
            MtdValidar();
            if (CuentaErrores == 0)
            {
                Stb.Clear();
                try
                {
                    Entusuarios_Proyectos.IdUsuario = EntUsuarios.Id;
                    string resultado;
                    string consulta = string.Empty;
                    string[] nomparametros = (CadenaConexion.MtdCrearParametro(Entusuarios_Proyectos));
                    object[] valparametros = (CadenaConexion.MtdValParametros(Entusuarios_Proyectos));
                    consulta = CadenaConexion.mtdCrearInsert("usuarios_proyectos", nomparametros);
                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event__UsrProye(ex.Message);
                }
            }
            else
            {
                ErrorString_Event__UsrProye(Stb.ToString());
            }
        }
        public void MtdEliminar(int Id)
        {
            string[] nombrepar = { "Id", };
            object[] valpar = { Id };
            string consulta = string.Empty;
            try
            {
                consulta = CadenaConexion.mtdCrearDelete("usuarios_proyectos", nombrepar);
                string ms = ConexionMysql.MtdEjecutarText(consulta, nombrepar, valpar);
            }
            catch (Exception ex)
            {
                ErrorString_Event__UsrProye(ex.Message);
            }
        }
        private void MtdValidar()
        {
            CuentaErrores = 0;
            Stb.Clear();
            if (Entusuarios_Proyectos.IdProyecto == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Proyecto");
            }

            if (Entusuarios_Proyectos.IdSoftware == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Software");
            }

        }

        #endregion


    }
}
