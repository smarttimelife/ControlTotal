namespace NegociosCartera
{
    #region Librerias

    using Conexiones;
    using Microsoft.EntityFrameworkCore;
    using ModelCartera;
    using System;
    using System.Collections.Generic;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //14 DE ABRIL 2020 12;13 PM

    #endregion Librerias

    public class neginmuebles : NegConsultasCartera
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;

        public event DlgtStringExit OkString_Event_inmuebles;

        public event DlgtStringExit ErrorString_Event_inmuebles;

        public bool bolEstadobtn = true;
        public DbSet<inmuebles> inmuebles { get; set; }
        public inmuebles Entinmuebles = new inmuebles();

        private string IdInmueble = string.Empty;

        #endregion Propiedades

        #region Constructores

        public neginmuebles(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }

        public neginmuebles(CadenaConexionMysql cadenaConexion, string idInmueble) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            IdInmueble = idInmueble;
            Entinmuebles = inmuebles.Find(IdInmueble);
        }

        #endregion Constructores

        #region Disparadore

        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_inmuebles(mensaje);
        }

        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event_inmuebles(mensaje);
        }

        #endregion Disparadore

        #region Metodos

        public void MtdAdicionar()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_inmuebles(Stb.ToString());
            }
            else
            {
                try
                {
                    bolEstadobtn = true;
                    string resultado = string.Empty;
                    string[] consulta = new string[2];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Adicionar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Inmuebles";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    EntTransacciones.Registro = Entinmuebles.IdInmueble;

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));

                    Entinmuebles.IdTransaccion = EntTransacciones.Id;
                    Entinmuebles.Estado = "Libre";
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(Entinmuebles));
                    valparametros.Add(CadenaConexion.MtdValParametros(Entinmuebles));
                    consulta[1] = CadenaConexion.mtdCrearInsert("inmuebles", CadenaConexion.MtdCrearParametro(Entinmuebles));
                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_inmuebles(ex.Message);
                }
            }
        }

        public void MtdModificar()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_inmuebles(Stb.ToString());
            }
            else
            {
                try
                {
                    string[] strWhre = { "Id" };
                    bolEstadobtn = true;
                    string resultado = string.Empty;
                    string[] consulta = new string[2];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Modificar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Inmuebles";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    EntTransacciones.Registro = Entinmuebles.IdInmueble;

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));

                    Entinmuebles.IdTransaccion = EntTransacciones.Id;

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(Entinmuebles));
                    valparametros.Add(CadenaConexion.MtdValParametros(Entinmuebles));
                    consulta[1] = CadenaConexion.mtdCrearUpdate("inmuebles", CadenaConexion.MtdCrearParametro(Entinmuebles), strWhre);
                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_inmuebles(ex.Message);
                }
            }
        }

        public void MtdBloquear()
        {
            try
            {
                string[] strWhre = { "Id" };
                bolEstadobtn = true;
                string resultado = string.Empty;
                string[] consulta = new string[2];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                transacciones EntTransacciones = new transacciones();
                EntTransacciones.Accion = "Bloquear";
                EntTransacciones.Fecha = DateTime.Now;
                EntTransacciones.Modulo = "Inmuebles";
                EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                EntTransacciones.Id = cnsConcecutivo("Transacciones");
                EntTransacciones.Registro = Entinmuebles.IdInmueble;

                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));

                Entinmuebles.IdTransaccion = EntTransacciones.Id;
                Entinmuebles.Estado = "Bloqueado";

                nomparametros.Add(CadenaConexion.MtdCrearParametro(Entinmuebles));
                valparametros.Add(CadenaConexion.MtdValParametros(Entinmuebles));
                consulta[1] = CadenaConexion.mtdCrearUpdate("inmuebles", CadenaConexion.MtdCrearParametro(Entinmuebles), strWhre);
                resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
            catch (Exception ex)
            {
                ErrorString_Event_inmuebles(ex.Message);
            }
        }

        public void MtdEliminar()
        {
            try
            {
                string[] strWhre = { "Id" };
                bolEstadobtn = true;
                string resultado = string.Empty;
                string[] consulta = new string[2];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                transacciones EntTransacciones = new transacciones();
                EntTransacciones.Accion = "Eliminar";
                EntTransacciones.Fecha = DateTime.Now;
                EntTransacciones.Modulo = "Inmuebles";
                EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                EntTransacciones.Id = cnsConcecutivo("Transacciones");
                EntTransacciones.Registro = Entinmuebles.IdInmueble;

                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));

                Entinmuebles.IdTransaccion = EntTransacciones.Id;
                Entinmuebles.Estado = "Eliminado";

                nomparametros.Add(CadenaConexion.MtdCrearParametro(Entinmuebles));
                valparametros.Add(CadenaConexion.MtdValParametros(Entinmuebles));
                consulta[1] = CadenaConexion.mtdCrearUpdate("inmuebles", CadenaConexion.MtdCrearParametro(Entinmuebles), strWhre);
                resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
            catch (Exception ex)
            {
                ErrorString_Event_inmuebles(ex.Message);
            }
        }

        public void MtdDesbloquear()
        {
            try
            {
                string[] strWhre = { "Id" };
                bolEstadobtn = true;
                string resultado = string.Empty;
                string[] consulta = new string[2];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                transacciones EntTransacciones = new transacciones();
                EntTransacciones.Accion = "Desbloquear";
                EntTransacciones.Fecha = DateTime.Now;
                EntTransacciones.Modulo = "Inmuebles";
                EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                EntTransacciones.Id = cnsConcecutivo("Transacciones");
                EntTransacciones.Registro = Entinmuebles.IdInmueble;

                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));

                Entinmuebles.IdTransaccion = EntTransacciones.Id;
                Entinmuebles.Estado = "Libre";

                nomparametros.Add(CadenaConexion.MtdCrearParametro(Entinmuebles));
                valparametros.Add(CadenaConexion.MtdValParametros(Entinmuebles));
                consulta[1] = CadenaConexion.mtdCrearUpdate("inmuebles", CadenaConexion.MtdCrearParametro(Entinmuebles), strWhre);
                resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
            catch (Exception ex)
            {
                ErrorString_Event_inmuebles(ex.Message);
            }
        }

        private void MtdValidar()
        {
            CuentaErrores = 0;
            Stb.Clear();
            if (string.IsNullOrEmpty(Entinmuebles.IdInmueble))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Codigo de Inmueble");
            }
            if (string.IsNullOrEmpty(Entinmuebles.IdProyecto))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Proyecto");
            }

            if (string.IsNullOrEmpty(Entinmuebles.Manzana))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Codigo de Manzana");
            }
            if (string.IsNullOrEmpty(Entinmuebles.Lote))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Codigo de Lote");
            }
        }

        #endregion Metodos
    }
}