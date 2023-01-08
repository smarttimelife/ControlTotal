namespace NegociosCartera
{
    #region Librerias

    using Conexiones;
    using Microsoft.EntityFrameworkCore;
    using ModelCartera;
    using System;
    using System.Collections.Generic;

    //Fecha Elaboracion Marzo 18 2020 2:30pm
    //Usuario JAVIER VILLALBA ESPINOSA

    #endregion Librerias

    public class negFactores : NegConsultasCartera
    {
        #region Propiedades

        private CadenaConexionMysql CadenasConexion;

        public event DlgtStringExit OkString_Event_factor;

        public event DlgtStringExit ErrorString_Event_factor;

        public factores entFactores = new factores();
        public DbSet<factores> factores { get; set; }

        #endregion Propiedades

        #region Constructores

        public negFactores(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenasConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }

        public negFactores(CadenaConexionMysql cadenaConexion, int Id) : base(cadenaConexion)
        {
            CadenasConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            entFactores = factores.Find(Id);
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
                entTransacciones.Modulo = "Factor";
                entTransacciones.Registro = entFactores.Id.ToString();
                string[] consulta = new string[2];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                string resultado = string.Empty;

                nomparametros.Add(CadenasConexion.MtdCrearParametro(entTransacciones));
                valparametros.Add(CadenasConexion.MtdValParametros(entTransacciones));
                consulta[0] = CadenasConexion.mtdCrearInsert("transacciones", CadenasConexion.MtdCrearParametro(entTransacciones));

                entFactores.Estado = 1;
                nomparametros.Add(CadenasConexion.MtdCrearParametro(entFactores));
                valparametros.Add(CadenasConexion.MtdValParametros(entFactores));
                consulta[1] = CadenasConexion.mtdCrearInsert("factores", CadenasConexion.MtdCrearParametro(entFactores));

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
                entTransacciones.Modulo = "Factor";
                entTransacciones.Registro = entFactores.Id.ToString();
                string[] consulta = new string[3];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                string resultado = string.Empty;
                string[] para1 = { "Id" };
                entFactores.Estado = 2;

                nomparametros.Add(CadenasConexion.MtdCrearParametro(entFactores));
                valparametros.Add(CadenasConexion.MtdValParametros(entFactores));
                consulta[0] = CadenasConexion.mtdCrearUpdate("factores", CadenasConexion.MtdCrearParametro(entFactores), para1);

                nomparametros.Add(CadenasConexion.MtdCrearParametro(entTransacciones));
                valparametros.Add(CadenasConexion.MtdValParametros(entTransacciones));
                consulta[1] = CadenasConexion.mtdCrearInsert("transacciones", CadenasConexion.MtdCrearParametro(entTransacciones));

                entFactores.Id = cnsConcecutivo("factores");
                entFactores.Estado = 1;
                nomparametros.Add(CadenasConexion.MtdCrearParametro(entFactores));
                valparametros.Add(CadenasConexion.MtdValParametros(entFactores));
                consulta[2] = CadenasConexion.mtdCrearInsert("factores", CadenasConexion.MtdCrearParametro(entFactores));

                resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
        }

        private void MtdValidar()
        {
            Stb.Clear();
            CuentaErrores = 0;
            if (entFactores.Plazo <= 0)
            {
                Stb.AppendLine("Falta Validar el Campo Plazo");
                CuentaErrores += 1;
            }
            if (entFactores.Tasa <= 0)
            {
                Stb.AppendLine("Falta Validar el Campo Tasa");
                CuentaErrores += 1;
            }
        }

        #endregion Metodos
    }
}