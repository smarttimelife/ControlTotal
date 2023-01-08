using Conexiones;
using Microsoft.EntityFrameworkCore;
using ModelCartera;
using System;
using System.Collections.Generic;
using System.Data;

namespace NegociosCartera
{
    public class negRadicacion : NegConsultasCartera
    {
        #region Propiedades

        public DataTable dtComision = new DataTable();
        public DataTable DTComisionAuto = new DataTable();
        CadenaConexionMysql CadenaConexion;
        public string IdAdjudicacion = string.Empty;
        public event DlgtDataTableExit DataError_Event_Radica;
        public event DlgtStringExit OkString_Evente_Radica;
        public event DlgtStringExit ErrorString_Evente_Radica;
        private DbSet<viewadjudicacion> viewAdjudicacion { get; set; }
        public viewadjudicacion EntviewAdjudicacion = new viewadjudicacion();
        #endregion

        #region Constructores
        public negRadicacion(CadenaConexionMysql cadenaConexion, string idAdjudicacion) : base(cadenaConexion)
        {
            IdAdjudicacion = idAdjudicacion;
            Event_ErrorTableNgConsultas += NegRadicacion_Event_ErrorTableNgConsultas;
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            EntviewAdjudicacion = viewAdjudicacion.Find(IdAdjudicacion);

        }
        public negRadicacion(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            Event_ErrorTableNgConsultas += NegRadicacion_Event_ErrorTableNgConsultas;            
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;

        }
        #endregion

        #region Disparadores
        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Evente_Radica(mensaje);
        }
        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Evente_Radica(mensaje);
        }
        private void NegRadicacion_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            DataError_Event_Radica(mensaje, dataTable);
        }
        #endregion

        #region Metodos
        public void Inicio()
        {
            DTComisionAuto = CnsDtConsulta("CargosAuto");
            dtComision.Columns.Add("IdCargo", typeof(string));
            dtComision.Columns.Add("IdTercero", typeof(string));
            dtComision.Columns.Add("Com1", typeof(decimal));
            dtComision.Columns.Add("Com2", typeof(decimal));
            dtComision.PrimaryKey = new DataColumn[] { dtComision.Columns["IdCargo"] };
            dtComision.Columns["IdCargo"].AllowDBNull = true;

        }

        public void Inicio(string IdAdj)
        {
            dtComision= CnsDtConsultaStrId("ModComision", IdAdj);
            EntviewAdjudicacion = viewAdjudicacion.Find(IdAdjudicacion);
        }

        public void MtdAdicionar()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                ErrorString_Evente_Radica(Stb.ToString());
            }
            else
            {
                try
                {

                    DataTable Dt = new DataTable();
                    Dt = dtComision.Copy();
                    Dt.Merge(DTComisionAuto);

                    int a = 0;

                    string resultado = string.Empty;
                    string[] consulta = new string[(Dt.Rows.Count + 2)];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    #region Add Transacciones

                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Adicionar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Radicacion";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones"); 
                    EntTransacciones.Registro = IdAdjudicacion;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                    a += 1;
                    #endregion Add Transacciones

                    #region Comisiones
                    comision EntComision = new comision();

                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {
                        EntComision.Comision1 = Convert.ToDecimal(Dt.Rows[i]["Com1"]);
                        EntComision.Comision2 = Convert.ToDecimal(Dt.Rows[i]["Com2"]);
                        EntComision.Estado = "Pendiente";
                        EntComision.Fecha = DateTime.Now;
                        EntComision.IdAdjudicacion = IdAdjudicacion;
                        EntComision.IdCargo = Dt.Rows[i]["IdCargo"].ToString();
                        EntComision.IdGestor = Dt.Rows[i]["IdTercero"].ToString();
                        EntComision.Id = EntComision.IdCargo + EntComision.IdAdjudicacion;
                        EntComision.IdTransaccion = EntTransacciones.Id;

                        nomparametros.Add(CadenaConexion.MtdCrearParametro(EntComision));
                        valparametros.Add(CadenaConexion.MtdValParametros(EntComision));
                        consulta[a] = CadenaConexion.mtdCrearInsert("comision", CadenaConexion.MtdCrearParametro(EntComision));
                        a += 1;
                    }
                    #endregion

                    #region Mod Estado Radicado Adjudicacion
                    string[] strpara = { "IdAdjudicacion", "Radicado", "Fecha", "Usuario" };
                    object[] objpara = { IdAdjudicacion, "Radicado", DateTime.Now, CadenaConexion.Logeo.Usuario };
                    nomparametros.Add(strpara);
                    valparametros.Add(objpara);
                    consulta[a] = "update adjudicacion set Radicado=@Radicado,FechaRadicacion=@Fecha,UsuarioRadica=@Usuario Where IdAdjudicacion=@IdAdjudicacion";
                    #endregion
                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    ErrorString_Evente_Radica(ex.Message);
                }
            }
        }

        public void MtdModificar()
        {
            MtdValidar();

            DataTable xDataTable = dtComision.GetChanges();

            
            if (xDataTable is null)
            {
                CuentaErrores += 1;
                Stb.AppendLine("No Ahy Cambios En las Comisines");
            }
            if (CuentaErrores > 0)
            {
                ErrorString_Evente_Radica(Stb.ToString());
            }
            else
            {
                try
                {
                    int a = 0;
                    string resultado = string.Empty;
                    string[] consulta = new string[(dtComision.Rows.Count + 3)];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    #region Add Transacciones

                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Modificar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Radicacion";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    EntTransacciones.Registro = IdAdjudicacion;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                    a += 1;
                    #endregion Add Transacciones

                    #region Eliminar Comision
                    string[] strpara = { "IdAdjudicacion" };
                    object[] objpara = { IdAdjudicacion };
                    nomparametros.Add(strpara);
                    valparametros.Add(objpara);
                    consulta[a] = "delete from comision Where IdAdjudicacion=@IdAdjudicacion";
                    a += 1;
                    #endregion

                    #region Comisiones
                    comision EntComision = new comision();

                    for (int i = 0; i < dtComision.Rows.Count; i++)
                    {
                        EntComision.Comision1 = Convert.ToDecimal(dtComision.Rows[i]["Com1"]);
                        EntComision.Comision2 = Convert.ToDecimal(dtComision.Rows[i]["Com2"]);
                        EntComision.Estado = "Pendiente";
                        EntComision.Fecha = DateTime.Now;
                        EntComision.IdAdjudicacion = IdAdjudicacion;
                        EntComision.IdCargo = dtComision.Rows[i]["IdCargo"].ToString();
                        EntComision.IdGestor = dtComision.Rows[i]["IdTercero"].ToString();
                        EntComision.Id = EntComision.IdCargo + EntComision.IdAdjudicacion;
                        EntComision.IdTransaccion = EntTransacciones.Id;

                        nomparametros.Add(CadenaConexion.MtdCrearParametro(EntComision));
                        valparametros.Add(CadenaConexion.MtdValParametros(EntComision));
                        consulta[a] = CadenaConexion.mtdCrearInsert("comision", CadenaConexion.MtdCrearParametro(EntComision));
                        a += 1;
                    }
                    #endregion

                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {

                    ErrorString_Evente_Radica(ex.Message);
                }


            }
        }

        private void MtdValidar()
        {
            CuentaErrores = 0;
            Stb.Clear();
            int count = 0;
            for (int i = 0; i < dtComision.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dtComision.Rows[i]["Com1"]) > 0 && Convert.ToDecimal(dtComision.Rows[i]["Com2"]) > 0)
                {
                    count += 1;

                    if (dtComision.Rows[i]["IdCargo"].ToString() == null)
                    {
                        {
                            CuentaErrores += 1;
                            Stb.AppendLine("Falta Cargo Asesores");
                        }
                    }

                    if (dtComision.Rows[i]["IdTercero"].ToString() == null)
                    {
                        {
                            CuentaErrores += 1;
                            Stb.AppendLine("Falta Seleccionar Asesor");
                        }
                    }
                }
            }

            if (count == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("No ahy Registros de Comisiones");
            }

         if(string.IsNullOrEmpty(IdAdjudicacion))
            {
                CuentaErrores += 1;
                Stb.AppendLine("No ahy Seleccionado Adjudicacin");
            }
        }    

        public viewadjudicacion ViewAdjudicacion(string IdAdj)
        {
          return   viewAdjudicacion.Find(IdAdj);
        }
        #endregion
    }
}
