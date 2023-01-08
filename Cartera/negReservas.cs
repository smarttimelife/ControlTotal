namespace NegociosCartera
{
    using Conexiones;
    using Microsoft.EntityFrameworkCore;
    using ModelCartera;
    using System;
    using System.Collections.Generic;
    using System.Data;

    public class negReservas : NegConsultasCartera
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        public reservas EntReservas = new reservas();
        public event DlgtStringExit OkString_Event_reservas;
        public event DlgtStringExit ErrorString_Event_reservas;
        public DbSet<reservas> reservas { get; set; }
        public bool bolEstadobtn = true;
        private string IdInmueble = string.Empty;

        #endregion Propiedades

        #region Constructores

        public negReservas(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }

        public negReservas(CadenaConexionMysql cadenaConexion, int IdReservas) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            EntReservas = reservas.Find(IdReservas);
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            IdInmueble = EntReservas.IdInmueble;
        }

        #endregion Constructores

        #region Disparadores

        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event_reservas(mensaje);
        }

        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_reservas(mensaje);
        }

        #endregion Disparadores

        #region Metodos
       
        public void MtdAdicionar()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_reservas(Stb.ToString());
            }
            else
            {
                try
                {
                    bolEstadobtn = true;
                    int IdRerserva = cnsConcecutivo("reservas");
                    string resultado = string.Empty;
                    string[] consulta = new string[3];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    #region Add Transacciones

                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Adicionar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Reservas";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    EntTransacciones.Registro = "Rsv" + IdRerserva;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));

                    #endregion Add Transacciones

                    #region Add Reservas

                    EntReservas.IdTransaccion = EntTransacciones.Id;
                    EntReservas.Estado = "Pendiente";
                    EntReservas.IdReserva = "Rsv" + IdRerserva;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntReservas));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntReservas));
                    consulta[1] = CadenaConexion.mtdCrearInsert("reservas", CadenaConexion.MtdCrearParametro(EntReservas));

                    #endregion Add Reservas

                    #region Mod Inmueble

                    string[] strpara = { "IdInmueble" };
                    object[] objpara = { EntReservas.IdInmueble };
                    nomparametros.Add(strpara);
                    valparametros.Add(objpara);
                    consulta[2] = "update inmuebles set Estado='Reservado' Where IdInmueble=@IdInmueble";

                    #endregion Mod Inmueble

                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_reservas(ex.Message);
                }
            }
        }

        public void MtdModificar()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_reservas(Stb.ToString());
            }
            else
            {
                try
                {
                    string[] consulta;
                    if (EntReservas.IdInmueble != IdInmueble)
                    {
                        consulta = new string[4];
                    }
                    else
                    {
                        consulta = new string[2];
                    }
                    string[] strWhre = { "Id" };
                    bolEstadobtn = true;
                    string resultado = string.Empty;

                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Modificar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Reservas";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    EntTransacciones.Registro = EntReservas.IdReserva;

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));

                    EntReservas.IdTransaccion = EntTransacciones.Id;

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntReservas));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntReservas));
                    consulta[1] = CadenaConexion.mtdCrearUpdate("reservas", CadenaConexion.MtdCrearParametro(EntReservas), strWhre);

                    if (EntReservas.IdInmueble != IdInmueble)
                    {
                        string[] strpara = { "IdInmueble" };
                        object[] objpara = { EntReservas.IdInmueble };
                        nomparametros.Add(strpara);
                        valparametros.Add(objpara);
                        consulta[2] = "update inmuebles set Estado='Reservado' Where IdInmueble=@IdInmueble";

                        string[] strpara1 = { "IdInmueble" };
                        object[] objpara1 = { IdInmueble };
                        nomparametros.Add(strpara1);
                        valparametros.Add(objpara1);
                        consulta[3] = "update inmuebles set Estado='Libre' Where IdInmueble=@IdInmueble";
                    }

                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_reservas(ex.Message);
                }
            }
        }

        public void MtdEliminar()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_reservas(Stb.ToString());
            }
            else
            {
                try
                {
                    string[] consulta = new string[3];

                    string[] strWhre = { "Id" };
                    bolEstadobtn = true;
                    string resultado = string.Empty;

                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Eliminar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Reservas";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    EntTransacciones.Registro = EntReservas.IdReserva;

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));

                    EntReservas.IdTransaccion = EntTransacciones.Id;
                    EntReservas.Estado = "Eliminado";
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntReservas));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntReservas));
                    consulta[1] = CadenaConexion.mtdCrearUpdate("reservas", CadenaConexion.MtdCrearParametro(EntReservas), strWhre);

                    string[] strpara = { "IdInmueble" };
                    object[] objpara = { EntReservas.IdInmueble };
                    nomparametros.Add(strpara);
                    valparametros.Add(objpara);
                    consulta[2] = "update inmuebles set Estado='Libre' Where IdInmueble=@IdInmueble";

                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Event_reservas(ex.Message);
                }
            }
        }

        private void MtdValidar()
        {
            CuentaErrores = 0;
            Stb.Clear();
            if (EntReservas.Fecha == null || EntReservas.Fecha == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Fecha Contrato");
            }
            if (string.IsNullOrEmpty(EntReservas.Contrato))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Contrato");
            }
            if (string.IsNullOrEmpty(EntReservas.Letra))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Documentos En Garantia");
            }

            if (string.IsNullOrEmpty(EntReservas.IdInmueble))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Inmueble");
            }
            if (string.IsNullOrEmpty(EntReservas.IdTercero))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Cliente");
            }
            if (string.IsNullOrEmpty(EntReservas.IdGestor))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Asesor");
            }
            if (EntReservas.FechaInicio == null || EntReservas.FechaInicio == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Fecha Primer Pago");
            }

            if (EntReservas.ValorContrato == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Valor Contrato");
            }
        }

        #endregion Metodos
    }
}