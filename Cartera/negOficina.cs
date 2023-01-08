namespace Cartera
{
    #region Librerias

    using Conexiones;
    using Microsoft.EntityFrameworkCore;
    using ModelCartera;
    using NegociosCartera;
    using System;
    using System.Collections.Generic;

    //Fecha Elaboracion Marzo 18 2020 2:30pm
    //Usuario JAVIER VILLALBA ESPINOSA

    #endregion Librerias
   public class negOficina : NegConsultasCartera
    {
        #region Propiedades

        private CadenaConexionMysql CadenasConexion;
        public event DlgtStringExit OkString_Event_factor;
        public event DlgtStringExit ErrorString_Event_factor;
        public oficina entOficina = new oficina();
        public DbSet<oficina> oficina { get; set; }

        #endregion Propiedades

        #region Constructores

        public negOficina(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenasConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }

        public negOficina(CadenaConexionMysql cadenaConexion, int Id) : base(cadenaConexion)
        {
            CadenasConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            entOficina = oficina.Find(Id);
        }

        #endregion Constructores

        #region Disparadores

        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_factor(mensaje);
        }

        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event_factor(mensaje);
        }

        #endregion Disparadores

        #region Metodos

        public void Adicionar()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_factor(Stb.ToString());
            }
            else
            {
                transacciones entTransacciones = new transacciones();
                entTransacciones.Id = cnsConcecutivo("Transacciones");
                entTransacciones.Fecha = DateTime.Now;
                entTransacciones.Accion = "Add";
                entTransacciones.Modulo = "Oficina";
                entTransacciones.Registro = entOficina.Id.ToString();
                string[] consulta = new string[2];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                string resultado = string.Empty;

                nomparametros.Add(CadenasConexion.MtdCrearParametro(entTransacciones));
                valparametros.Add(CadenasConexion.MtdValParametros(entTransacciones));
                consulta[0] = CadenasConexion.mtdCrearInsert("transacciones", CadenasConexion.MtdCrearParametro(entTransacciones));

               
                nomparametros.Add(CadenasConexion.MtdCrearParametro(entOficina));
                valparametros.Add(CadenasConexion.MtdValParametros(entOficina));
                consulta[1] = CadenasConexion.mtdCrearInsert("oficina", CadenasConexion.MtdCrearParametro(entOficina));

                resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
        }

        public void Modificar()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_factor(Stb.ToString());
            }
            else
            {
                transacciones entTransacciones = new transacciones();
                entTransacciones.Id = cnsConcecutivo("Transacciones");
                entTransacciones.Fecha = DateTime.Now;
                entTransacciones.Accion = "Mod";
                entTransacciones.Modulo = "Oficina";
                entTransacciones.Registro = entOficina.Id.ToString();
                string[] consulta = new string[2];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                string resultado = string.Empty;
                string[] para1 = { "Id" };
                

                nomparametros.Add(CadenasConexion.MtdCrearParametro(entOficina));
                valparametros.Add(CadenasConexion.MtdValParametros(entOficina));
                consulta[0] = CadenasConexion.mtdCrearUpdate("oficina", CadenasConexion.MtdCrearParametro(entOficina), para1);

                nomparametros.Add(CadenasConexion.MtdCrearParametro(entTransacciones));
                valparametros.Add(CadenasConexion.MtdValParametros(entTransacciones));
                consulta[1] = CadenasConexion.mtdCrearInsert("transacciones", CadenasConexion.MtdCrearParametro(entTransacciones));       

                resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
        }

        private void MtdValidar()
        {
            Stb.Clear();
            CuentaErrores = 0;
             
            if (string.IsNullOrEmpty(entOficina.NombreOficina))
            {
                Stb.AppendLine("Falta Nombre de Oficina");
                CuentaErrores += 1;
            }
        }

        #endregion Metodos
    }
}
