namespace Cartera
{
    #region Librerias
    using Conexiones;
    using Microsoft.EntityFrameworkCore;
    using ModelCartera;
    using NegociosCartera;
    using System;
    using System.Collections.Generic;
    using System.Data;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    #endregion

    public class negComisiones : NegConsultasCartera
    {
        #region Propiedades      
        public event DlgtStringExit ErrorString_Event_Comision;
        public event DlgtStringExit OkString_Event_Comision;
        public pagocomision EntPagoComision = new pagocomision();
        public DatosComsion EntDatosComision = new DatosComsion();
        public DataTable DtComision = new DataTable();
        private MysqlContext ConexionMysqlContab;
        public DataTable DtBaseAnticipo = new DataTable();
        private CadenaConexionMysql CadenaConexionContabilidad;
        public DataTable DtAnticipo = new DataTable();
        CadenaConexionMysql CadenaConexion;
        #endregion

        #region Constructores
        public negComisiones(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            CadenaConexionContabilidad = new CadenaConexionMysql(cadenaConexion.StrServidor, cadenaConexion.Logeo.BaseDatosContab,
                                      cadenaConexion.StrPuerto, cadenaConexion.StrUsurioServer, cadenaConexion.StrClaveServer);

            ConexionMysqlContab = new MysqlContext(CadenaConexionContabilidad);
            ConexionMysqlContab.EventDataErrorTableMysql += ConexionMysqlContab_EventDataErrorTableMysql;
            ConexionMysqlContab.EventErrorStringMysql += ConexionMysqlContab_EventErrorStringMysql;
        }

        private void ConexionMysqlContab_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_Comision(mensaje);
        }

        private void ConexionMysqlContab_EventDataErrorTableMysql(string mensaje, DataTable dataTable)
        {
            ErrorString_Event_Comision(mensaje);
        }
        #endregion

        #region Disparadores
        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event_Comision(mensaje);
        }

        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_Comision(mensaje);
        }
        #endregion


        public void PagarComision()
        {
            MtdValidar();
            if (string.IsNullOrEmpty( EntDatosComision.IdAdjudicacion))
            {
                CuentaErrores += 1;
                Stb.AppendLine("No Ha Seleccionado Adjudicacion");
            }
            if (CuentaErrores > 0)
            {
                ErrorString_Event_Comision(Stb.ToString());
            }
            else
            {
                try
                {
                    int numcuota = 0;
                    int numdcto = 0;
                    for (int i = 0; i < (DtComision.Rows.Count); i++)
                    {
                        if (Convert.ToDecimal(DtComision.Rows[i]["TotalPagar"]) > 0)
                        {
                            numcuota += 1;

                        }
                        if (Convert.ToDecimal(DtComision.Rows[i]["SaldoAnticipo"]) > 0)
                        {
                            numdcto += 1;
                        }
                    }
                    int a = 0;
                    DataTable dtdatosdescuento= ConexionMysqlContab.MtdDataTableReaderText("Select * from datoscuenta where Operacion=@Operacion", "Operacion", "Anticipo Comision");
                    DataTable dtdatoscuenta = ConexionMysqlContab.MtdDataTableReaderText("Select * from datoscuenta where Operacion=@Operacion", "Operacion", "PagoComision");
                    DataTable dtdocumentomanual = ConexionMysqlContab.MtdDataTableReaderText("Select * from documentomanual where IdComprobante=@IdComprobante", "IdComprobante", dtdatoscuenta.Rows[0]["Documento"].ToString());
                    string resultado = string.Empty;

                    string[] consulta = new string[(numcuota * 3) + 3+numdcto];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    #region  Transacciones
                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Adicionar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Comisiones";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    //EntTransacciones.Registro = "Rcd" + IdRecaudos;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                    a += 1;
                    #endregion Add Transacciones

                    #region TransaccionContable

                    transaccionCont transaccionCont = new transaccionCont();
                    string cnsConta = "SELECT if(max(IdTransaccion)is null,1,max(IdTransaccion)+1)as Id FROM transacciones";
                    transaccionCont.IdTransaccion = Convert.ToInt32(ConexionMysqlContab.MtdBscDatosText(cnsConta));
                    transaccionCont.Fecha = DateTime.Now;
                    transaccionCont.Fuente = dtdatoscuenta.Rows[0]["Documento"].ToString();
                    transaccionCont.Registro = EntTransacciones.Id;
                    transaccionCont.Transaccion = "Add";
                    transaccionCont.Usuario = CadenaConexion.Logeo.Usuario;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(transaccionCont));
                    valparametros.Add(CadenaConexion.MtdValParametros(transaccionCont));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(transaccionCont), CadenaConexion.Logeo.BaseDatosContab);
                    a += 1;
                    #endregion

                    #region Comision
                   
                    EntPagoComision.Fecha = EntDatosComision.Fecha;
                    EntPagoComision.IdTransaccion = EntTransacciones.Id;

                    for (int i = 0; i < (DtComision.Rows.Count); i++)
                    {
                        if (Convert.ToDecimal(DtComision.Rows[i]["TotalPagar"]) > 0)
                        {
                            EntPagoComision.IdAdjudicacion = DtComision.Rows[i]["IdAdjudicacion"].ToString();
                            EntPagoComision.IdComision = DtComision.Rows[i]["Id"].ToString();
                            EntPagoComision.Idgestor = DtComision.Rows[i]["IdGestor"].ToString();
                            EntPagoComision.IdCargo = DtComision.Rows[i]["IdCargo"].ToString();                              
                            EntPagoComision.TasaComision =Convert.ToDecimal( DtComision.Rows[i]["Comision1"]);
                            EntPagoComision.Comision = Convert.ToDecimal(DtComision.Rows[i]["TotalComision"]);
                            EntPagoComision.DctoAnticipo= Convert.ToDecimal(DtComision.Rows[i]["SaldoAnticipo"]);
                            EntPagoComision.PagoNeto= Convert.ToDecimal(DtComision.Rows[i]["TotalPagar"]);
                            nomparametros.Add(CadenaConexion.MtdCrearParametro(EntPagoComision));
                            valparametros.Add(CadenaConexion.MtdValParametros(EntPagoComision));
                            consulta[a] = CadenaConexion.mtdCrearInsert("pagocomision", CadenaConexion.MtdCrearParametro(EntPagoComision));
                            a += 1;
                        }
                    }
                    #endregion

                    #region Diario
                    diario EntDiario = new diario();
                    int cnd = 1;
                    EntDiario.Fecha = EntDatosComision.Fecha;
                    EntDiario.CentroCostos = 1;
                    EntDiario.Estado = 1;
                    EntDiario.Fuente = transaccionCont.Fuente;
                    EntDiario.Transaccion = transaccionCont.IdTransaccion;
                    EntDiario.IdDocumento = Convert.ToInt32(dtdocumentomanual.Rows[0]["Consecutivo"].ToString());
                    for (int i = 0; i < (DtComision.Rows.Count); i++)
                    {
                        if (Convert.ToDecimal(DtComision.Rows[i]["TotalPagar"]) > 0)
                        {
                            EntDiario.Beneficiario = DtComision.Rows[i]["Gestor"].ToString();
                            EntDiario.Motivo = "Pago Comision " + DtComision.Rows[i]["IdAdjudicacion"].ToString() + " Cliente" + DtComision.Rows[i]["Cliente"].ToString();

                            EntDiario.Detalle = "Pago Comision " + DtComision.Rows[i]["IdAdjudicacion"].ToString() + " Cliente" + DtComision.Rows[i]["Cliente"].ToString();
                            EntDiario.Factura = CadenaConexion.MtdCalPeriodo(EntDatosComision.Fecha) + DtComision.Rows[i]["IdCargo"].ToString() +
                                                 DtComision.Rows[i]["IdAdjudicacion"].ToString();
                            EntDiario.Cheque = EntDiario.Factura;
                            EntDiario.IdTercero = DtComision.Rows[i]["IdGestor"].ToString();
                            EntDiario.SubCentro = 1;
                            EntDiario.SubSubCentro = "Comisiones";
                            EntDiario.Consecutivo =cnd;
                            EntDiario.Cuenta = dtdatoscuenta.Rows[0]["Debe"].ToString(); ;
                            EntDiario.Debe = Convert.ToDecimal(DtComision.Rows[i]["TotalComision"]);
                            EntDiario.Haber = 0;
                            nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDiario));
                            valparametros.Add(CadenaConexion.MtdValParametros(EntDiario));
                            consulta[a] = CadenaConexion.mtdCrearInsert("diario", CadenaConexion.MtdCrearParametro(EntDiario), CadenaConexion.Logeo.BaseDatosContab);
                            a += 1;
                            cnd += 1;

                            if (Convert.ToDecimal(DtComision.Rows[i]["SaldoAnticipo"]) > 0)
                                {
                                EntDiario.Consecutivo = cnd;
                                EntDiario.Cuenta = dtdatosdescuento.Rows[0]["Debe"].ToString(); ;
                                EntDiario.Haber = Convert.ToDecimal(DtComision.Rows[i]["SaldoAnticipo"]);
                                EntDiario.Debe = 0;
                                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDiario));
                                valparametros.Add(CadenaConexion.MtdValParametros(EntDiario));
                                consulta[a] = CadenaConexion.mtdCrearInsert("diario", CadenaConexion.MtdCrearParametro(EntDiario), CadenaConexion.Logeo.BaseDatosContab);
                                a += 1;
                                cnd += 1;
                            }
                            EntDiario.Consecutivo = cnd;
                            EntDiario.Cuenta = dtdatoscuenta.Rows[0]["Haber"].ToString(); ;
                            EntDiario.Haber = Convert.ToDecimal(DtComision.Rows[i]["TotalPagar"]);
                            EntDiario.Debe = 0;
                            nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDiario));
                            valparametros.Add(CadenaConexion.MtdValParametros(EntDiario));
                            consulta[a] = CadenaConexion.mtdCrearInsert("diario", CadenaConexion.MtdCrearParametro(EntDiario), CadenaConexion.Logeo.BaseDatosContab);
                            a += 1;
                            cnd += 1;
                        }
                    }

                    #endregion

                    #region Cambio Concecutivos
                    string[] nombrepar1 = { "Idcomprobante" };
                    object[] valpar1 = { transaccionCont.Fuente };
                    nomparametros.Add(nombrepar1);
                    valparametros.Add(valpar1);
                    consulta[a] = "update " + CadenaConexion.Logeo.BaseDatosContab + ".documentomanual set Consecutivo=Consecutivo+1 where Idcomprobante=@Idcomprobante ";
                    a += 1;
                    #endregion

                    ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);

                }
                catch (Exception ex)
                {
                    ErrorString_Event_Comision(ex.Message);
                }
            }




        }

        public DataTable CnsBaseAnticipo()
        {
            DtBaseAnticipo = ConexionMysql.MtdTableAdapter("select * from baseanticipo");
            return DtBaseAnticipo;
        }

        public DataTable CnsAnticiposPdte()
        {
            DtAnticipo = CnsDtConsulta("AnticiposPdte");
            return DtAnticipo;
        }

        public void MtdActulizarTablaAnticipo()
        {
           ConexionMysql.MtdActualizarAdapter(DtBaseAnticipo);            
        }


        public  void PagarAnticipo()
        {
            MtdValidar();
            if (CuentaErrores > 0)
            {
                ErrorString_Event_Comision(Stb.ToString());
            }
            else
            {
                try
                {
                    int numcuota = 0;
                for (int i = 0; i < (DtAnticipo.Rows.Count); i++)
                {
                    if (Convert.ToDecimal(DtAnticipo.Rows[i]["TotalPagar"]) > 0)
                    {
                        numcuota += 1;
                    }
                }
                int a = 0;
                DataTable dtdatoscuenta = ConexionMysqlContab.MtdDataTableReaderText("Select * from datoscuenta where Operacion=@Operacion", "Operacion", "Anticipo Comision");
                DataTable dtdocumentomanual = ConexionMysqlContab.MtdDataTableReaderText("Select * from documentomanual where IdComprobante=@IdComprobante", "IdComprobante", dtdatoscuenta.Rows[0]["Documento"].ToString());
                string resultado = string.Empty;
               
                string[] consulta = new string[(numcuota*3) + 3];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                #region  Transacciones
                transacciones EntTransacciones = new transacciones();
                EntTransacciones.Accion = "Adicionar";
                EntTransacciones.Fecha = DateTime.Now;
                EntTransacciones.Modulo = "Anticipos";
                EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                EntTransacciones.Id = cnsConcecutivo("Transacciones");
                //EntTransacciones.Registro = "Rcd" + IdRecaudos;
                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                a += 1;
                #endregion Add Transacciones

                #region TransaccionContable

                transaccionCont transaccionCont = new transaccionCont();
                string cnsConta = "SELECT if(max(IdTransaccion)is null,1,max(IdTransaccion)+1)as Id FROM transacciones";                
                transaccionCont.IdTransaccion = Convert.ToInt32(ConexionMysqlContab.MtdBscDatosText(cnsConta));
                transaccionCont.Fecha = DateTime.Now;
                transaccionCont.Fuente = dtdatoscuenta.Rows[0]["Documento"].ToString();               
                transaccionCont.Registro = EntTransacciones.Id;
                transaccionCont.Transaccion = "Add";
                transaccionCont.Usuario = CadenaConexion.Logeo.Usuario;
                nomparametros.Add(CadenaConexion.MtdCrearParametro(transaccionCont));
                valparametros.Add(CadenaConexion.MtdValParametros(transaccionCont));
                consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(transaccionCont), CadenaConexion.Logeo.BaseDatosContab);
                a += 1;
                #endregion               

                #region Anticipo
                anticipocms EntAntComision = new anticipocms();             
                EntAntComision.Fecha = EntDatosComision.Fecha;                
                EntAntComision.IdTransaccion = EntTransacciones.Id;              

                for (int i = 0; i < (DtAnticipo.Rows.Count); i++)
                {
                    if (Convert.ToDecimal(DtAnticipo.Rows[i]["TotalPagar"]) > 0)
                        {
                            EntAntComision.IdAdjudicacion = DtAnticipo.Rows[i]["IdAdjudicacion"].ToString();
                            EntAntComision.IdCargo = DtAnticipo.Rows[i]["IdCargo"].ToString();
                            EntAntComision.IdGestor = DtAnticipo.Rows[i]["IdGestor"].ToString();
                            EntAntComision.IdAnticpo = EntAntComision.IdCargo + EntAntComision.IdAdjudicacion;
                            EntAntComision.Valor=Convert.ToDecimal( DtAnticipo.Rows[i]["TotalPagar"]);
                            nomparametros.Add(CadenaConexion.MtdCrearParametro(EntAntComision));
                            valparametros.Add(CadenaConexion.MtdValParametros(EntAntComision));
                            consulta[a] = CadenaConexion.mtdCrearInsert("anticipocms", CadenaConexion.MtdCrearParametro(EntAntComision));
                            a += 1;
                        }
                }
                #endregion

                #region Diario
                diario EntDiario = new diario();

                EntDiario.Fecha = EntDatosComision.Fecha;
                EntDiario.CentroCostos = 1;                
                EntDiario.Estado = 1;
                EntDiario.Fuente = transaccionCont.Fuente;
                EntDiario.Transaccion = transaccionCont.IdTransaccion;
                EntDiario.IdDocumento =Convert.ToInt32( dtdocumentomanual.Rows[0]["Consecutivo"].ToString());
                for (int i = 0; i < (DtAnticipo.Rows.Count); i++)
                {
                    if (Convert.ToDecimal(DtAnticipo.Rows[i]["TotalPagar"]) > 0)
                        {
                            EntDiario.Beneficiario = DtAnticipo.Rows[i]["Gestor"].ToString();
                            EntDiario.Motivo = "Pago Anticipo de Comision " + DtAnticipo.Rows[i]["IdAdjudicacion"].ToString() + " Cliente" + DtAnticipo.Rows[i]["Cliente"].ToString();

                            EntDiario.Detalle = "Pago Anticipo de Comision " + DtAnticipo.Rows[i]["IdAdjudicacion"].ToString() + " Cliente" + DtAnticipo.Rows[i]["Cliente"].ToString();
                            EntDiario.Factura = CadenaConexion.MtdCalPeriodo(EntDatosComision.Fecha) + DtAnticipo.Rows[i]["IdCargo"].ToString() +
                                                 DtAnticipo.Rows[i]["IdAdjudicacion"].ToString();
                            EntDiario.Cheque = EntDiario.Factura;
                            EntDiario.IdTercero = DtAnticipo.Rows[i]["IdGestor"].ToString();
                            EntDiario.SubCentro = 1;
                            EntDiario.SubSubCentro = "Comisiones";
                            EntDiario.Consecutivo = i + 1;
                            EntDiario.Cuenta = dtdatoscuenta.Rows[0]["Debe"].ToString(); ;
                            EntDiario.Debe = Convert.ToDecimal(DtAnticipo.Rows[i]["TotalPagar"]);
                            EntDiario.Haber = 0;
                            nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDiario));
                            valparametros.Add(CadenaConexion.MtdValParametros(EntDiario));
                            consulta[a] = CadenaConexion.mtdCrearInsert("diario", CadenaConexion.MtdCrearParametro(EntDiario), CadenaConexion.Logeo.BaseDatosContab);
                            a += 1;
                            EntDiario.Consecutivo = i + 2;
                            EntDiario.Cuenta = dtdatoscuenta.Rows[0]["Haber"].ToString(); ;
                            EntDiario.Haber = Convert.ToDecimal(DtAnticipo.Rows[i]["TotalPagar"]);
                            EntDiario.Debe = 0;
                            nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDiario));
                            valparametros.Add(CadenaConexion.MtdValParametros(EntDiario));
                            consulta[a] = CadenaConexion.mtdCrearInsert("diario", CadenaConexion.MtdCrearParametro(EntDiario), CadenaConexion.Logeo.BaseDatosContab);
                            a += 1;
                        }
                }                  
             
                #endregion

                #region Cambio Concecutivos
                string[] nombrepar1 = { "Idcomprobante" };
                object[] valpar1 = { transaccionCont.Fuente };
                nomparametros.Add(nombrepar1);
                valparametros.Add(valpar1);
                consulta[a] = "update " + CadenaConexion.Logeo.BaseDatosContab + ".documentomanual set Consecutivo=Consecutivo+1 where Idcomprobante=@Idcomprobante ";
                a += 1;
                #endregion

                ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);

                }
                catch (Exception ex)
                {
                    ErrorString_Event_Comision(ex.Message);
                }
            }
          

           

        }

        public void MtdValidar()
        {

            CuentaErrores = 0;
            Stb.Clear();            
            
            if (EntDatosComision.TotalComision==0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("No Ha Seleccionado Pagos");
            }

            if (EntDatosComision.Fecha == null || EntDatosComision.Fecha == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Del Pago");
            }
        }
    }
}
