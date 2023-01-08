namespace Administracion.NegociosAdmin
{
    #region Librerias
    using Conexiones;
    using Microsoft.EntityFrameworkCore;
    using ModelAdmin;
    using System;
    using System.Collections.Generic;
    using System.Data;
    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //12 DE ABRIL 2020 21:15 PM
    #endregion
    public class negRoles : negConsultasAdmin
    {
        #region Propiedades
        public DataTable DtRolDetalle = new DataTable();
        public roles EntRoles = new roles();
        public DbSet<roles> roles { get; set; }
        public roldetalles MysPermisos = new roldetalles();
        private CadenaConexionMysql CadenaConexion;
        private string StrModulo = string.Empty;
        public event DlgtStringExit ErrorString_Event_Roles;
        public event DlgtStringExit OkString_Event__Roles;

        #endregion

        #region Constructores
        public negRoles(CadenaConexionMysql cadenaConexion, string strModulo) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            StrModulo = strModulo;
            MysPermisos = cadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo);
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }
        public negRoles(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            DtRolDetalle = CnsDetalleRol();
            MtdMarcar(false);
        }
        public negRoles(CadenaConexionMysql cadenaConexion, int IdRol) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            EntRoles = roles.Find(IdRol);
            DtRolDetalle = CnsDetalleRol(IdRol);
        }
        #endregion

        #region Disparadores
        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event__Roles(mensaje);
        }
        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_Roles(mensaje);
        }
        #endregion

        #region Metodos

        public void MtdMarcar(bool Accion)
        {
            for (int i = 0; i < DtRolDetalle.Rows.Count; i++)
            {
                DtRolDetalle.Rows[i]["Ver"] = Accion;
                DtRolDetalle.Rows[i]["Adicionar"] = Accion;
                DtRolDetalle.Rows[i]["Modificar"] = Accion;
                DtRolDetalle.Rows[i]["Eliminar"] = Accion;
                DtRolDetalle.Rows[i]["Aprobar"] = Accion;
                DtRolDetalle.Rows[i]["Desaprobar"] = Accion;
                DtRolDetalle.Rows[i]["Cerrar"] = Accion;
                DtRolDetalle.Rows[i]["Imprimir"] = Accion;
            }
        }
        public void MtdAdicionar()
        {
            if (string.IsNullOrEmpty(EntRoles.NombreRol))
            {
                ErrorString_Event_Roles("Falta Nombre del Rol");
            }
            else
            {
                try
                {
                    roldetalles EntRoldetalles = new roldetalles();
                    int a1 = DtRolDetalle.Rows.Count + 1;
                    int a = 0;
                    string[] consulta = new string[a1];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    EntRoles.Id = cnsConcecutivoRoles();
                    EntRoles.FechaOperacion = DateTime.Now;
                    EntRoles.Estado = "Vigente";
                    EntRoles.UsuarioAutoriza = CadenaConexion.Logeo.Usuario;

                    consulta[a] = CadenaConexion.mtdCrearInsert("roles", CadenaConexion.MtdCrearParametro(EntRoles)); ;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntRoles));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntRoles));
                    a += 1;

                    EntRoldetalles.IdRol = EntRoles.Id;
                    EntRoldetalles.FechaOperacion = DateTime.Now;
                    EntRoldetalles.UsuarioAutoriza = CadenaConexion.Logeo.Usuario;

                    for (int i = 0; i < DtRolDetalle.Rows.Count; i++)
                    {
                        EntRoldetalles.IdFormulario = DtRolDetalle.Rows[i]["IdFormulario"].ToString();
                        EntRoldetalles.Ver = Convert.ToBoolean(DtRolDetalle.Rows[i]["Ver"]);
                        EntRoldetalles.Adicionar = Convert.ToBoolean(DtRolDetalle.Rows[i]["Adicionar"]);
                        EntRoldetalles.Modificar = Convert.ToBoolean(DtRolDetalle.Rows[i]["Modificar"]);
                        EntRoldetalles.Eliminar = Convert.ToBoolean(DtRolDetalle.Rows[i]["Eliminar"]);
                        EntRoldetalles.Imprimir = Convert.ToBoolean(DtRolDetalle.Rows[i]["Imprimir"]);
                        EntRoldetalles.Aprobar = Convert.ToBoolean(DtRolDetalle.Rows[i]["Aprobar"]);
                        EntRoldetalles.Desaprobar = Convert.ToBoolean(DtRolDetalle.Rows[i]["Desaprobar"]);
                        EntRoldetalles.Cerrar = Convert.ToBoolean(DtRolDetalle.Rows[i]["Cerrar"]);
                        nomparametros.Add(CadenaConexion.MtdCrearParametro(EntRoldetalles));
                        valparametros.Add(CadenaConexion.MtdValParametros(EntRoldetalles));
                        consulta[a] = CadenaConexion.mtdCrearInsert("roldetalles", CadenaConexion.MtdCrearParametro(EntRoldetalles));
                        a += 1;
                    }
                    string ms = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_Roles(ex.Message);
                }
            }
        }
        public void MtdModificar()
        {

            if (string.IsNullOrEmpty(EntRoles.NombreRol))
            {
                ErrorString_Event_Roles("Falta Nombre del Rol");
            }

            else
            {
                try
                {
                    roldetalles EntRoldetalles = new roldetalles();
                    int a1 = DtRolDetalle.Rows.Count + 1;
                    int a = 0;
                    string[] consulta = new string[a1];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    EntRoles.FechaOperacion = DateTime.Now;
                    EntRoles.Estado = "Vigente";
                    EntRoles.UsuarioAutoriza = CadenaConexion.Logeo.Usuario;
                    string[] Nomparametros = { "Id" };

                    consulta[a] = CadenaConexion.mtdCrearUpdate("roles", CadenaConexion.MtdCrearParametro(EntRoles), Nomparametros);
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntRoles));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntRoles));
                    a += 1;


                    EntRoldetalles.FechaOperacion = DateTime.Now;
                    EntRoldetalles.UsuarioAutoriza = CadenaConexion.Logeo.Usuario;
                    EntRoldetalles.IdRol = EntRoles.Id;
                    for (int i = 0; i < DtRolDetalle.Rows.Count; i++)
                    {

                        EntRoldetalles.Id = Convert.ToInt32(DtRolDetalle.Rows[i]["Id"]);
                        EntRoldetalles.IdFormulario = DtRolDetalle.Rows[i]["IdFormulario"].ToString();
                        EntRoldetalles.Ver = Convert.ToBoolean(DtRolDetalle.Rows[i]["Ver"]);
                        EntRoldetalles.Adicionar = Convert.ToBoolean(DtRolDetalle.Rows[i]["Adicionar"]);
                        EntRoldetalles.Modificar = Convert.ToBoolean(DtRolDetalle.Rows[i]["Modificar"]);
                        EntRoldetalles.Eliminar = Convert.ToBoolean(DtRolDetalle.Rows[i]["Eliminar"]);
                        EntRoldetalles.Imprimir = Convert.ToBoolean(DtRolDetalle.Rows[i]["Imprimir"]);
                        EntRoldetalles.Aprobar = Convert.ToBoolean(DtRolDetalle.Rows[i]["Aprobar"]);
                        EntRoldetalles.Desaprobar = Convert.ToBoolean(DtRolDetalle.Rows[i]["Desaprobar"]);
                        EntRoldetalles.Cerrar = Convert.ToBoolean(DtRolDetalle.Rows[i]["Cerrar"]);

                        nomparametros.Add(CadenaConexion.MtdCrearParametro(EntRoldetalles));
                        valparametros.Add(CadenaConexion.MtdValParametros(EntRoldetalles));
                        consulta[a] = CadenaConexion.mtdCrearUpdate("roldetalles", CadenaConexion.MtdCrearParametro(EntRoldetalles), Nomparametros);
                        a += 1;
                    }
                    string ms = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_Roles(ex.Message);
                }
            }
        }
        public void MtdEliminar()
        {
            try
            {
                EntRoles.FechaOperacion = DateTime.Now;
                EntRoles.Estado = "Eliminado";
                EntRoles.UsuarioAutoriza = CadenaConexion.Logeo.Usuario;
                string[] parametroWhere = { "Id" };
                string[] nombreparametro = (CadenaConexion.MtdCrearParametro(EntRoles));
                object[] valparametro = (CadenaConexion.MtdValParametros(EntRoles));
                string consulta = CadenaConexion.mtdCrearUpdate("roles", nombreparametro, parametroWhere);
                string ms = ConexionMysql.MtdEjecutarText(consulta, nombreparametro, valparametro);
            }
            catch (Exception ex)
            {
                ErrorString_Event_Roles(ex.Message);
            }
        }
        #endregion
    }

}
