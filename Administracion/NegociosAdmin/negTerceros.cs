namespace Administracion.NegociosAdmin
{
    #region Librerias

    using Conexiones;
    using Microsoft.EntityFrameworkCore;
    using ModelAdmin;
    using System;
    using System.Collections.Generic;
    using System.Data;

    //Creado Por Javier Villalba Espinosa
    //Marzo 28 2020 13:25 PM

    #endregion Librerias

    public class negTerceros : negMenuGeneral
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        public terceros EntTerceros = new terceros();
        public event DlgtStringExit Event_OkStringTerceros;
        public event DlgtStringExit Event_ErrorStringTerceros;
        public event DlgtStringExit Event_ValidateStringTerceros;

        private int Tipotercero = 0;
        private string strTipoTercero;
        public bool BoolEstado = false;
        public virtual DbSet<terceros> terceros { get; set; }

        #endregion Propiedades

        #region Constructor

        public negTerceros(CadenaConexionMysql cadenaConexion, int tipotercero) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            Tipotercero = tipotercero;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            switch (Tipotercero)
            {
                case 1:
                    strTipoTercero = "Clientes";
                    break;

                case 2:
                    strTipoTercero = "Provedores";
                    break;

                case 3:
                    strTipoTercero = "Empleados";
                    break;

                case 4:
                    strTipoTercero = "Asesores";
                    break;

                default:
                    break;
            }
        }

        public negTerceros(CadenaConexionMysql cadenaConexion, int tipotercero,string StrId) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            Tipotercero = tipotercero;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            switch (Tipotercero)
            {
                case 1:
                    strTipoTercero = "Clientes";
                    break;

                case 2:
                    strTipoTercero = "Provedores";
                    break;

                case 3:
                    strTipoTercero = "Empleados";
                    break;

                case 4:
                    strTipoTercero = "Asesores";
                    break;

                default:
                    break;
            }
            EntTerceros = terceros.Find(StrId);
            BoolEstado = true ;
        }

        #endregion Constructor

        #region Disparadores

        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            BoolEstado = false;
            Event_ErrorStringTerceros(mensaje);
        }

        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            BoolEstado = false;
            Event_OkStringTerceros(mensaje);
        }

        #endregion Disparadores

        #region Metodos

        public void MtdAdicionarTerceros()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                BoolEstado = true;
                Event_ErrorStringTerceros(Stb.ToString());
            }
            else
            {
                try
                {
                    transacciones transacciones = new transacciones();
                    int IdTransaccion = cnsConcecutivoTransass();
                    transacciones.Accion = "Add";
                    transacciones.Fecha = DateTime.Now;
                    transacciones.Id = IdTransaccion;
                    transacciones.Modulo = "Clientes";
                    transacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTerceros.Id = 0;
                    EntTerceros.IdTransaccion = IdTransaccion;

                    tercerotipotercero terceroTipoTercero = new tercerotipotercero();
                    terceroTipoTercero.IdTercero = EntTerceros.IdTercero;
                    terceroTipoTercero.IdTipoTercero = Tipotercero;

                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };
                    string[] consulta = new string[3];

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(transacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(transacciones));
                    consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(transacciones));

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTerceros));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTerceros));
                    consulta[1] = CadenaConexion.mtdCrearInsert("terceros", CadenaConexion.MtdCrearParametro(EntTerceros));

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(terceroTipoTercero));
                    valparametros.Add(CadenaConexion.MtdValParametros(terceroTipoTercero));
                    consulta[2] = CadenaConexion.mtdCrearInsert("tercerotipotercero", CadenaConexion.MtdCrearParametro(terceroTipoTercero));

                    string resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    BoolEstado = true;
                    Event_ErrorStringTerceros(ex.Message);
                }
            }
        }

        public void MtdModTerceros()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                BoolEstado = true;
                Event_ErrorStringTerceros(Stb.ToString());
            }
            else
            {
                try
                {
                    transacciones transacciones = new transacciones();
                    int IdTransaccion = cnsConcecutivoTransass();
                    transacciones.Accion = "Mod";
                    transacciones.Fecha = DateTime.Now;
                    transacciones.Id = IdTransaccion;
                    transacciones.Modulo = "Clientes";
                    transacciones.Usuario = CadenaConexion.Logeo.Usuario;

                   
                    EntTerceros.IdTransaccion = IdTransaccion;

                  

                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };
                    string[] consulta = new string[2];

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(transacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(transacciones));
                    consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(transacciones));

                    string[] Whr = { "IdTercero" };
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTerceros));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTerceros));
                    consulta[1] = CadenaConexion.mtdCrearUpdate("terceros", CadenaConexion.MtdCrearParametro(EntTerceros), Whr);

                   

                    string resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    BoolEstado = true;
                    Event_ErrorStringTerceros(ex.Message);
                }
            }
        }

        public void MtdDelTerceros()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                BoolEstado = true;
                Event_ErrorStringTerceros(Stb.ToString());
            }
            else
            {
                try
                {
                    transacciones transacciones = new transacciones();
                    int IdTransaccion = cnsConcecutivoTransass();
                    transacciones.Accion = "Del";
                    transacciones.Fecha = DateTime.Now;
                    transacciones.Id = IdTransaccion;
                    transacciones.Modulo = "Clientes";
                    transacciones.Usuario = CadenaConexion.Logeo.Usuario;


                    EntTerceros.IdTransaccion = IdTransaccion;



                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };
                    string[] consulta = new string[3];

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(transacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(transacciones));
                    consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(transacciones));



                    string DelTipo = "delete from tercerotipotercero where IdTipoTercero=@IdTipoTercero and IdTercero=@IdTercero";
                    string[] para = { "IdTipoTercero", "IdTercero" };
                    object[] varpara = { Tipotercero, EntTerceros.IdTercero };

                    nomparametros.Add(para);
                    valparametros.Add(varpara);
                    consulta[1] = DelTipo;

                    string[] Whr = { "IdTercero" };
                    
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTerceros));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTerceros));
                    consulta[2] = CadenaConexion.mtdCrearDelete("terceros",Whr);



                    string resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    BoolEstado = true;
                    Event_ErrorStringTerceros(ex.Message);
                }
            }
        }

        private void MtdValidar()
        {
            CuentaErrores = 0;
            Stb.Clear();

            if (string.IsNullOrEmpty(EntTerceros.IdTercero))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Numero Identificacion");
            }

            if (EntTerceros.TipoPersona == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar TipoPersona");
            }

            if (EntTerceros.IdTipoDocumento == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Tipo Documento");
            }

            if (string.IsNullOrEmpty(EntTerceros.Nombres))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Nombres");
            }

            if (EntTerceros.TipoPersona == 1)
            {
                if (string.IsNullOrEmpty(EntTerceros.Apellidos))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Apellidos");
                }
            }

            if (EntTerceros.FechaNacimiento == null || EntTerceros.FechaNacimiento == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha de Nacimiento");
            }

            if (CuentaErrores == 0)
            {
            }
        }

        public terceros MtdEntTerceros()
        {
            BoolEstado = false;
            DataTable dt = CnsTerceros(EntTerceros.IdTercero);
            terceros terceros = new terceros();
            foreach (DataRow fila in dt.Rows)
            {
                terceros.Id = Convert.ToInt32(fila["Id"].ToString());
                terceros.IdTercero = fila["IdTercero"].ToString();
                terceros.TipoPersona = Convert.ToInt32(fila["TipoPersona"].ToString());
                terceros.IdTipoDocumento = Convert.ToInt32(fila["IdTipoDocumento"].ToString());
                terceros.Nombres = fila["Nombres"].ToString();
                terceros.Apellidos = fila["Apellidos"].ToString();
                if (!DBNull.Value.Equals(fila["FechaNacimiento"]))
                {
                    terceros.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"].ToString());
                }
                terceros.Direccion = fila["Direccion"].ToString();
                terceros.Barrio = fila["Barrio"].ToString();
                terceros.Ciudad = fila["Ciudad"].ToString();
                terceros.Departamento = fila["Departamento"].ToString();
                terceros.Telefono1 = fila["Telefono1"].ToString();
                terceros.Telefono2 = fila["Telefono2"].ToString();
                terceros.Celular = fila["Celular"].ToString();
                terceros.CorreoElectronico = fila["CorreoElectronico"].ToString();
                terceros.PaginaWeb = fila["PaginaWeb"].ToString();
                terceros.Contacto = fila["Contacto"].ToString();
                terceros.NombreCompleto = fila["NombreCompleto"].ToString();
                if (!DBNull.Value.Equals(fila["IdTransaccion"]))
                {
                    terceros.IdTransaccion = Convert.ToInt32(fila["IdTransaccion"].ToString());
                }
            }
            return terceros;
        }

        public void MtdLlenarTercero()
        {
            if (!string.IsNullOrEmpty(EntTerceros.IdTercero))
            {
                int CantClientes = 0;
                DataTable dt = CnsTerceros(EntTerceros.IdTercero);
                CantClientes = CnsCantClientes(EntTerceros.IdTercero, Tipotercero);
                BoolEstado = false;
                if (dt.Rows.Count == 0)
                {
                    BoolEstado = true;
                }
                else
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        EntTerceros.IdTercero = fila["IdTercero"].ToString();
                        EntTerceros.Id = Convert.ToInt32(fila["Id"]);
                        EntTerceros.TipoPersona = Convert.ToInt32(fila["TipoPersona"]);
                        EntTerceros.IdTipoDocumento = Convert.ToInt32(fila["IdTipoDocumento"]);
                        EntTerceros.Nombres = fila["Nombres"].ToString();
                        EntTerceros.Apellidos = fila["Apellidos"].ToString();
                        if (!DBNull.Value.Equals(fila["FechaNacimiento"]))
                        {
                            EntTerceros.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"].ToString());
                        }
                        EntTerceros.Direccion = fila["Direccion"].ToString();
                        EntTerceros.Barrio = fila["Barrio"].ToString();
                        EntTerceros.Ciudad = fila["Ciudad"].ToString();
                        EntTerceros.Departamento = fila["Departamento"].ToString();
                        EntTerceros.Telefono1 = fila["Telefono1"].ToString();
                        EntTerceros.Telefono2 = fila["Telefono2"].ToString();
                        EntTerceros.Celular = fila["Celular"].ToString();
                        EntTerceros.CorreoElectronico = fila["CorreoElectronico"].ToString();
                        EntTerceros.PaginaWeb = fila["PaginaWeb"].ToString();
                        EntTerceros.Contacto = fila["Contacto"].ToString();
                        EntTerceros.NombreCompleto = fila["NombreCompleto"].ToString();
                        if (!DBNull.Value.Equals(fila["IdTransaccion"]))
                        {
                            EntTerceros.IdTransaccion = Convert.ToInt32(fila["IdTransaccion"]);
                        }
                    }
                    if (CantClientes == 0)
                    {
                        Event_ValidateStringTerceros("Tercero Ya Existe. Quiere Asociarlo Como " + strTipoTercero + "?");
                    }
                    else
                    {
                        Event_ErrorStringTerceros(strTipoTercero + " Ya Existe");
                    }
                }
            }
        }

        private terceros EntTercero()
        {
            return terceros.Find(EntTerceros.IdTercero);
        }

        public void MtdAddTipoTerceros()
        {
            tercerotipotercero terceroTipoTercero = new tercerotipotercero();
            terceroTipoTercero.IdTercero = EntTerceros.IdTercero;
            terceroTipoTercero.IdTipoTercero = Tipotercero;
            try
            {
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };
                nomparametros.Add(CadenaConexion.MtdCrearParametro(terceroTipoTercero));
                valparametros.Add(CadenaConexion.MtdValParametros(terceroTipoTercero));
                string consulta = CadenaConexion.mtdCrearInsert("tercerotipotercero", CadenaConexion.MtdCrearParametro(terceroTipoTercero));
                string resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
            catch (Exception ex)
            {
                Event_ErrorStringTerceros(ex.Message);
            }
        }

        #endregion Metodos
    }
}