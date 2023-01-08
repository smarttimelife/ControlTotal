namespace NegociosCartera
{
    using Cartera;
    #region Librerias
    using Conexiones;
    using ModelCartera;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using Utilidades;
    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //Agosto 27 2020
    #endregion
    public class negRecaudos : NegConsultasCartera
    {
        #region Propiedades
        public int CuotasVencidas = 0, DiasMoras = 0;
        public DataTable DtAdjudicacion = new DataTable();
        public DataTable DtCuotas = new DataTable();
        public DataTable DtExtracto = new DataTable();
        public DataTable DtFormaPagoCartera = new DataTable();
        public DataTable DtOperacion = new DataTable();
        public DataTable DtReservas = new DataTable();
        public DataTable DtFuentes = new DataTable();
        public datosrecaudos EntDatosRecaudos = new datosrecaudos();
        public recaudosjuridicos EntRecaudosJuridico = new recaudosjuridicos();
        public noradicados EntNoRadicados = new noradicados();
        public decimal SaldoCuotaVda = 0, SaldoMora = 0, PagoMinimo = 0, TotalPagar = 0, InteresCteVdo = 0, SdoCapital = 0, SdoCapitalVdo = 0;
        private CadenaConexionMysql CadenaConexion;
        private CadenaConexionMysql CadenaConexionContabilidad;
        private MysqlContext ConexionMysqlContab;
        public event DlgtDataTableExit Event_ErrorTableNgRecaudos;
        public event DlgtStringExit EventErrorString;
        public event DlgtStringExit EventOkString;
        #endregion

        #region Constructores

        public negRecaudos(CadenaConexionMysql cadenaConexion, string IdAdjudicacion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            EntDatosRecaudos.IdAdjudicacion = IdAdjudicacion;
            EntRecaudosJuridico.IdAdjudicacion = IdAdjudicacion;
            CadenaConexionContabilidad = new CadenaConexionMysql(cadenaConexion.StrServidor, cadenaConexion.Logeo.BaseDatosContab,
                                        cadenaConexion.StrPuerto, cadenaConexion.StrUsurioServer, cadenaConexion.StrClaveServer);
           
            ConexionMysqlContab = new MysqlContext(CadenaConexionContabilidad);
            ConexionMysqlContab.EventDataErrorTableMysql += ConexionMysqlContab_EventDataErrorTableMysql;
            ConexionMysqlContab.EventErrorStringMysql += ConexionMysqlContab_EventErrorStringMysql;

            ConexionMysql.EventDataErrorTableMysql += ConexionMysql_EventDataErrorTableMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            Event_ErrorTableNgConsultas += NegRecaudos_Event_ErrorTableNgConsultas;
            MtdCartera();
        }

        public negRecaudos(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;           
            CadenaConexionContabilidad = new CadenaConexionMysql(cadenaConexion.StrServidor, cadenaConexion.Logeo.BaseDatosContab,
                                        cadenaConexion.StrPuerto, cadenaConexion.StrUsurioServer, cadenaConexion.StrClaveServer);

            ConexionMysqlContab = new MysqlContext(CadenaConexionContabilidad);
            ConexionMysqlContab.EventDataErrorTableMysql += ConexionMysqlContab_EventDataErrorTableMysql;
            ConexionMysqlContab.EventErrorStringMysql += ConexionMysqlContab_EventErrorStringMysql;
            ConexionMysql.EventDataErrorTableMysql += ConexionMysql_EventDataErrorTableMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            Event_ErrorTableNgConsultas += NegRecaudos_Event_ErrorTableNgConsultas;
           
            DtOperacion.Columns.Add("Id", typeof(string));
            DtOperacion.Columns.Add("Operacion", typeof(string));
            DtOperacion.Rows.Add("CI", "Cuota Incial");
            DtOperacion.Rows.Add("FN", "Finaniacion");
            DtOperacion.Rows.Add("CE", "Cuota Extra");
        }

        

        #endregion

        #region Disparadores

        private void ConexionMysql_EventDataErrorTableMysql(string mensaje, DataTable dataTable)
        {
            Event_ErrorTableNgRecaudos(mensaje, dataTable);
        }

        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            EventErrorString(mensaje);
        }

        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            EventOkString(mensaje);
        }

        private void ConexionMysqlContab_EventDataErrorTableMysql(string mensaje, DataTable dataTable)
        {
            Event_ErrorTableNgRecaudos(mensaje, dataTable);
        }

        private void ConexionMysqlContab_EventErrorStringMysql(string mensaje)
        {
            EventErrorString(mensaje);
        }

        private void NegRecaudos_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            Event_ErrorTableNgRecaudos(mensaje, dataTable);
        }
        #endregion

        #region Metodos
        public void MtdCartera()
        {
            DtAdjudicacion = CnsDtConsultaStrId("ViewAdjudicacion", EntDatosRecaudos.IdAdjudicacion);
            DtFuentes =CnsDtCombox("Fuente");
            DtOperacion = CnsDtConsultaStrId("Operacion", EntDatosRecaudos.IdAdjudicacion);
            DiasMoras = 0; SaldoMora = 0; CuotasVencidas = 0; PagoMinimo = 0; SaldoCuotaVda = 0; TotalPagar = 0; InteresCteVdo = 0; SdoCapital = 0;
            DtExtracto = CnsDtConsultaStrId("Saldo", EntDatosRecaudos.IdAdjudicacion);


            for (int i = 0; i < DtExtracto.Rows.Count; i++)
            {
                if (Convert.ToInt32(DtExtracto.Rows[i]["Mora"]) > DiasMoras)
                {
                    DiasMoras = Convert.ToInt32(DtExtracto.Rows[i]["Mora"]);
                }

                if (Convert.ToDateTime(DtExtracto.Rows[i]["Fecha"]) <= DateTime.Now)
                {
                    CuotasVencidas += 1;
                    SdoCapitalVdo += Convert.ToDecimal(DtExtracto.Rows[i]["SdoCapital"]);
                    SaldoCuotaVda += Convert.ToDecimal(DtExtracto.Rows[i]["SdoCuota"]);
                    InteresCteVdo += Convert.ToDecimal(DtExtracto.Rows[i]["SdoInteres"]);
                }
                SaldoMora += Convert.ToDecimal(DtExtracto.Rows[i]["VrMora"]);
                SdoCapital += Convert.ToDecimal(DtExtracto.Rows[i]["SdoCapital"]);
            }
            PagoMinimo = SaldoCuotaVda + SaldoMora;
            TotalPagar = SaldoMora + InteresCteVdo + SdoCapital;
        }
        public DataTable  CnsCuotas(string Cto,string IdAdjudicacion)
        {
            DtCuotas= CnsDtConsultaStrId(Cto, IdAdjudicacion);
            return DtCuotas;
        }

        public DataTable CnsFormaPago(string Fuente)
        {
            string consulta = "Select Operacion FormaPago,Debe from datoscuenta Where Documento=@Fuente";
            string[] Parametro = { "Fuente", };
            object[] ObjParametro = { Fuente };
            return ConexionMysqlContab.MtdDataTableReaderText(consulta, Parametro, ObjParametro);
        }

        public void MtdAdicionar(string strFuente)
        {

            MtdValidar();
            if (string.IsNullOrEmpty(strFuente))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fuente de Recibos");
            }
            if (CuentaErrores > 0)
            {
                EventErrorString(Stb.ToString());
            }
            else
            {
                try
                {
                    int numcuota = 0;
                    for (int i = 0; i < (DtCuotas.Rows.Count); i++)
                    {
                        if (Convert.ToDecimal(DtCuotas.Rows[i]["RcdCuota"]) > 0)
                        {
                            numcuota += 1;
                        }
                    }
                    int a = 0;
                    int IdRecaudos = cnsConcecutivo("Recaudos");
                    int IdDocumento = Convert.ToInt32(ConexionMysqlContab.MtdBscDatosText("Select Consecutivo from documentomanual where IdComprobante=@IdComprobante", "IdComprobante", strFuente));
                    string resultado = string.Empty;
                    DataTable dtFuentes = ConexionMysqlContab.MtdDataTableReaderText("Select * from datoscuenta where Documento=@Documento", "Documento", strFuente);
                    string[] consulta = new string[numcuota + 6];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    #region  Transacciones
                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Adicionar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Recaudos";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    EntTransacciones.Registro = "Rcd" + IdRecaudos;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                    a += 1;
                    #endregion Add Transacciones

                    #region TransaccionContable

                    transaccionCont transaccionCont = new transaccionCont();
                    string cnsConta = "SELECT if(max(IdTransaccion)is null,1,max(IdTransaccion)+1)as Id FROM transacciones";
                    DataTable dtCns = ConexionMysqlContab.MtdDataTableReaderText(cnsConta);
                    transaccionCont.IdTransaccion = Convert.ToInt32(ConexionMysqlContab.MtdBscDatosText(cnsConta));
                    transaccionCont.Fecha = DateTime.Now;
                    transaccionCont.Fuente = strFuente;
                    transaccionCont.Registro = IdDocumento;
                    transaccionCont.Registro = EntTransacciones.Id;
                    transaccionCont.Transaccion = "Add";
                    transaccionCont.Usuario = CadenaConexion.Logeo.Usuario;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(transaccionCont));
                    valparametros.Add(CadenaConexion.MtdValParametros(transaccionCont));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(transaccionCont), CadenaConexion.Logeo.BaseDatosContab);
                    a += 1;
                    #endregion

                    #region DatosRecaudos
                    EntDatosRecaudos.Estado = 1;
                    EntDatosRecaudos.IdTercero = DtAdjudicacion.Rows[0]["IdTercero1"].ToString();
                    EntDatosRecaudos.IdRecaudo = "Rcd" + IdRecaudos;
                    EntDatosRecaudos.IdTransacion = EntTransacciones.Id;
                    EntDatosRecaudos.TransaccionContab = transaccionCont.IdTransaccion;
                    EntDatosRecaudos.IdRecaudo = "Rcd" + IdRecaudos;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDatosRecaudos));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntDatosRecaudos));
                    consulta[a] = CadenaConexion.mtdCrearInsert("datosrecaudos", CadenaConexion.MtdCrearParametro(EntDatosRecaudos));
                    a += 1;
                    #endregion

                    #region Recaudos
                    recaudos EntRecaudos = new recaudos();
                    EntRecaudos.Recibo = EntDatosRecaudos.Recibo;
                    EntRecaudos.Fecha = EntDatosRecaudos.Fecha;
                    EntRecaudos.FechaOperacion = DateTime.Now;
                    EntRecaudos.IdAdjudicacion = EntDatosRecaudos.IdAdjudicacion;
                    EntRecaudos.Periodo = CadenaConexion.MtdCalPeriodo(EntDatosRecaudos.Fecha);
                    EntRecaudos.IdRecaudo = EntDatosRecaudos.IdRecaudo;
                    EntRecaudos.Estado = "Aprobado";
                    EntRecaudos.Usuario = CadenaConexion.Logeo.Usuario;

                    for (int i = 0; i < (DtCuotas.Rows.Count); i++)
                    {
                        if (Convert.ToDecimal(DtCuotas.Rows[i]["RcdCuota"]) > 0)
                        {
                            EntRecaudos.Concepto = DtCuotas.Rows[i]["Concepto"].ToString();
                            EntRecaudos.Capital = Convert.ToDecimal(DtCuotas.Rows[i]["RcdCapital"]);
                            EntRecaudos.CuotaNumero = Convert.ToInt16(DtCuotas.Rows[i]["CuotaNumero"]);
                            EntRecaudos.InteresCte = Convert.ToDecimal(DtCuotas.Rows[i]["RcdInteres"]);
                            EntRecaudos.InteresMora = Convert.ToDecimal(DtCuotas.Rows[i]["RcdMora"]);
                            EntRecaudos.FechaCuota = Convert.ToDateTime(DtCuotas.Rows[i]["Fecha"]);
                            EntRecaudos.IdFinanciacion = DtCuotas.Rows[i]["IdFinanciacion"].ToString();
                            nomparametros.Add(CadenaConexion.MtdCrearParametro(EntRecaudos));
                            valparametros.Add(CadenaConexion.MtdValParametros(EntRecaudos));
                            consulta[a] = CadenaConexion.mtdCrearInsert("recaudos", CadenaConexion.MtdCrearParametro(EntRecaudos));
                            a += 1;
                        }

                    }
                    #endregion

                    #region Diario
                    diario EntDiario = new diario();

                    EntDiario.Fecha = EntDatosRecaudos.Fecha;
                    EntDiario.Beneficiario = DtAdjudicacion.Rows[0]["TitularPrincipal"].ToString();
                    EntDiario.CentroCostos = 1;
                    EntDiario.Cheque = EntDatosRecaudos.Recibo;
                    EntDiario.Detalle = EntDatosRecaudos.Detalle;
                    EntDiario.Motivo = "Recaudo de Cartera IdAdjudicacion " + EntDatosRecaudos.IdAdjudicacion + " Cliente" + EntDiario.Beneficiario + "Pagado en " + EntDatosRecaudos.FormaPago;
                    EntDiario.Estado = 1;
                    EntDiario.Factura = EntDatosRecaudos.Recibo;
                    EntDiario.Fuente = strFuente;
                    EntDiario.IdTercero = DtAdjudicacion.Rows[0]["IdTercero1"].ToString();
                    EntDiario.Matricula = DtAdjudicacion.Rows[0]["IdInmueble"].ToString();
                    EntDiario.Transaccion = transaccionCont.IdTransaccion;
                    EntDiario.SubCentro = 1;
                    EntDiario.SubSubCentro = "Recaudos";
                    EntDiario.IdDocumento = IdDocumento;

                    EntDiario.Consecutivo = 1;
                    EntDiario.Cuenta = dtFuentes.Rows[0]["Debe"].ToString(); ;
                    EntDiario.Debe = EntDatosRecaudos.Valor;
                    EntDiario.Haber = 0;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDiario));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntDiario));
                    consulta[a] = CadenaConexion.mtdCrearInsert("diario", CadenaConexion.MtdCrearParametro(EntDiario), CadenaConexion.Logeo.BaseDatosContab);
                    a += 1;

                    EntDiario.Consecutivo = 1;
                    EntDiario.Cuenta = dtFuentes.Rows[0]["Haber"].ToString(); ;
                    EntDiario.Debe = 0;
                    EntDiario.Haber = EntDatosRecaudos.Valor;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDiario));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntDiario));
                    consulta[a] = CadenaConexion.mtdCrearInsert("diario", CadenaConexion.MtdCrearParametro(EntDiario), CadenaConexion.Logeo.BaseDatosContab);
                    a += 1;
                    #endregion

                    #region Cambio Concecutivos
                    string[] nombrepar1 = { "Idcomprobante" };
                    object[] valpar1 = { strFuente };
                    nomparametros.Add(nombrepar1);
                    valparametros.Add(valpar1);
                    consulta[a] = "update " + CadenaConexion.Logeo.BaseDatosContab + ".documentomanual set Consecutivo=Consecutivo+1 where Idcomprobante=@Idcomprobante ";
                    a += 1;
                    #endregion

                    ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    EventErrorString(ex.Message);
                }
            }
        }

        public void MtdEliminar(string IdAdj,string IdRcd,string IdTranContable)
        {
            
            try
            {

                string[] para5 = { "IdRecaudo" };
                object[] Obj5 = { IdRcd };


                RecaudosDetallados recaudo = new RecaudosDetallados();
               recaudo.DatosRecaudos =(datosrecaudos) Entidades.ConvertDataTable<datosrecaudos>(
                ConexionMysql.MtdDataTableReaderText("Select * from datosrecaudos where IdRecaudo=@IdRecaudo", para5, Obj5)).Data;

                recaudo.Recaudos =(List<recaudos>)
                Entidades.ConvertDataTable<recaudos>(
                ConexionMysql.MtdDataTableReaderText("Select * from recaudos where IdRecaudo=@IdRecaudo", para5, Obj5)).Data;



                string strFuente = ConexionMysqlContab.MtdBscDatosText("Select Fuente From diario Where Transaccion =@Transaccion Limit 1", "Transaccion", IdTranContable);

                string[] consulta = new string[6];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };                


                #region  Transacciones
                transacciones EntTransacciones = new transacciones();
                EntTransacciones.Accion = "Eliminar";
                EntTransacciones.Fecha = DateTime.Now;
                EntTransacciones.Modulo = "Recaudos";
                EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                EntTransacciones.Id = cnsConcecutivo("Transacciones");
                EntTransacciones.Registro = "Rcd" + IdRcd;
                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                consulta[0] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                #endregion Add Transacciones

                #region Eliminar Recaudos
                string[] Para = { "IdRecaudo" };
                object[] ObPara = { IdRcd };

                consulta[1] = "Delete From recaudos   Where IdRecaudo=@IdRecaudo";
                nomparametros.Add(Para);
                valparametros.Add(ObPara);

                consulta[2] = "Delete From  datosrecaudos  Where IdRecaudo=@IdRecaudo";
                nomparametros.Add(Para);
                valparametros.Add(ObPara); 
                #endregion

                #region TransaccionContable

            transaccionCont transaccionCont = new transaccionCont();
            string cnsConta = "SELECT if(max(IdTransaccion)is null,1,max(IdTransaccion)+1)as Id FROM transacciones";
            DataTable dtCns = ConexionMysqlContab.MtdDataTableReaderText(cnsConta);
            transaccionCont.IdTransaccion = Convert.ToInt32(ConexionMysqlContab.MtdBscDatosText(cnsConta));
            transaccionCont.Fecha = DateTime.Now;
            transaccionCont.Fuente = strFuente;            
            transaccionCont.Registro = EntTransacciones.Id;
            transaccionCont.Transaccion = "Del";
            transaccionCont.Usuario = CadenaConexion.Logeo.Usuario;

            nomparametros.Add(CadenaConexion.MtdCrearParametro(transaccionCont));
            valparametros.Add(CadenaConexion.MtdValParametros(transaccionCont));
            consulta[3] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(transaccionCont), CadenaConexion.Logeo.BaseDatosContab);

                #endregion

                #region Eliminar Diario
                string[] Para1 = { "Transaccion" };
                object[] ObPara1 = { IdTranContable };
                consulta[4] = "Update " + CadenaConexion.Logeo.BaseDatosContab + ".diario  set Estado= 3 Where Transaccion=@Transaccion";
                nomparametros.Add(Para1);
                valparametros.Add(ObPara1);
                #endregion

                #region Log
                Log EntidadLog = new Log();
                EntidadLog.Fecha = DateTime.Now;
                EntidadLog.Accion = "Eliminar";
                EntidadLog.Modulo = "Recaudos";
                EntidadLog.Registro = IdRcd;
                EntidadLog.Usuario = CadenaConexion.Logeo.Usuario;
                EntidadLog.Logs =(string) Serializaciones.SerializarJson<RecaudosDetallados>(recaudo).Data;
                consulta[5] = CadenaConexion.mtdCrearInsert("log", CadenaConexion.MtdCrearParametro(EntidadLog));
                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntidadLog));
                valparametros.Add(CadenaConexion.MtdValParametros(EntidadLog));
            

                #endregion

                ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
            catch (Exception ex)
            {
                EventErrorString(ex.Message);
            }

           
        }

        public void MtdAdNoRadicados(string strFuente)
        {
            MtdValidarNoRadicados();
            if (string.IsNullOrEmpty(strFuente))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fuente de Recibos");
            }
            if (CuentaErrores > 0)
            {
                EventErrorString(Stb.ToString());
            }
            else
            {
                try
                {
                    DtReservas = CnsDtConsultaStrId("Reservas", EntNoRadicados.IdReserva);
                    int a = 0;
                    int IdRecaudos = cnsConcecutivo("NoRadicados");
                    int IdDocumento = Convert.ToInt32(ConexionMysqlContab.MtdBscDatosText("Select Consecutivo from documentomanual where IdComprobante=@IdComprobante", "IdComprobante", strFuente));
                    string resultado = string.Empty;
                    DataTable dtFuentes = ConexionMysqlContab.MtdDataTableReaderText("Select * from datoscuenta where Documento=@Documento", "Documento", strFuente);
                    string[] consulta = new string[6];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    #region  Transacciones
                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Adicionar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Recaudos No Radicados";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    EntTransacciones.Registro = "Rcd" + IdRecaudos;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                    a += 1;
                    #endregion Add Transacciones

                    #region TransaccionContable

                    transaccionCont transaccionCont = new transaccionCont();
                    string cnsConta = "SELECT if(max(IdTransaccion)is null,1,max(IdTransaccion)+1)as Id FROM transacciones";
                    DataTable dtCns = ConexionMysqlContab.MtdDataTableReaderText(cnsConta);
                    transaccionCont.IdTransaccion = Convert.ToInt32(ConexionMysqlContab.MtdBscDatosText(cnsConta));
                    transaccionCont.Fecha = DateTime.Now;
                    transaccionCont.Fuente = strFuente;
                    transaccionCont.Registro = IdDocumento;
                    transaccionCont.Registro = EntTransacciones.Id;
                    transaccionCont.Transaccion = "Add";
                    transaccionCont.Usuario = CadenaConexion.Logeo.Usuario;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(transaccionCont));
                    valparametros.Add(CadenaConexion.MtdValParametros(transaccionCont));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(transaccionCont), CadenaConexion.Logeo.BaseDatosContab);
                    a += 1;
                    #endregion

                    #region DatosRecaudos
                    EntNoRadicados.Estado = 1;
                    EntNoRadicados.IdTercero = DtReservas.Rows[0]["IdTercero"].ToString();
                    EntNoRadicados.IdRecaudo = "Rcd" + IdRecaudos;
                    EntNoRadicados.IdTransacion = EntTransacciones.Id;
                    EntNoRadicados.TransaccionContab = transaccionCont.IdTransaccion;
                    EntNoRadicados.IdRecaudo = "Rcd" + IdRecaudos;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntNoRadicados));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntNoRadicados));
                    consulta[a] = CadenaConexion.mtdCrearInsert("noradicados", CadenaConexion.MtdCrearParametro(EntNoRadicados));
                    a += 1;
                    #endregion


                    #region Diario
                    diario EntDiario = new diario();

                    EntDiario.Fecha = EntNoRadicados.Fecha;
                    EntDiario.Beneficiario = DtReservas.Rows[0]["Cliente"].ToString();
                    EntDiario.CentroCostos = 1;
                    EntDiario.Cheque = EntNoRadicados.Recibo;
                    EntDiario.Detalle = EntNoRadicados.Detalle;
                    EntDiario.Motivo = "Recaudo Negocio No Radicado Reserva N " + EntNoRadicados.IdReserva + " Cliente" + EntDiario.Beneficiario + "Pagado en " + EntNoRadicados.FormaPago;
                    EntDiario.Estado = 1;
                    EntDiario.Factura = EntNoRadicados.Recibo;
                    EntDiario.Fuente = strFuente;
                    EntDiario.IdTercero = DtReservas.Rows[0]["IdTercero"].ToString();
                    EntDiario.Matricula = DtReservas.Rows[0]["IdInmueble"].ToString();
                    EntDiario.Transaccion = transaccionCont.IdTransaccion;
                    EntDiario.SubCentro = 1;
                    EntDiario.SubSubCentro = "Recaudos";
                    EntDiario.IdDocumento = IdDocumento;

                    EntDiario.Consecutivo = 1;
                    EntDiario.Cuenta = dtFuentes.Rows[0]["Debe"].ToString(); ;
                    EntDiario.Debe = EntNoRadicados.Valor;
                    EntDiario.Haber = 0;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDiario));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntDiario));
                    consulta[a] = CadenaConexion.mtdCrearInsert("diario", CadenaConexion.MtdCrearParametro(EntDiario), CadenaConexion.Logeo.BaseDatosContab);
                    a += 1;

                    EntDiario.Consecutivo = 1;
                    EntDiario.Cuenta = dtFuentes.Rows[0]["Haber"].ToString(); ;
                    EntDiario.Debe = 0;
                    EntDiario.Haber = EntNoRadicados.Valor;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDiario));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntDiario));
                    consulta[a] = CadenaConexion.mtdCrearInsert("diario", CadenaConexion.MtdCrearParametro(EntDiario), CadenaConexion.Logeo.BaseDatosContab);
                    a += 1;
                    #endregion

                    #region Cambio Concecutivos
                    string[] nombrepar1 = { "Idcomprobante" };
                    object[] valpar1 = { strFuente };
                    nomparametros.Add(nombrepar1);
                    valparametros.Add(valpar1);
                    consulta[a] = "update " + CadenaConexion.Logeo.BaseDatosContab + ".documentomanual set Consecutivo=Consecutivo+1 where Idcomprobante=@Idcomprobante ";
                    a += 1;
                    #endregion

                    ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    EventErrorString(ex.Message);
                }
            }
        }

        public void MtdAddJuridicos(string strFuente)
        {
            MtdValidarJuridicos();
            if (string.IsNullOrEmpty(strFuente))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fuente de Recibos");
            }
            if (CuentaErrores > 0)
            {
                EventErrorString(Stb.ToString());
            }
            else
            {
                try
                {
                  
                    int a = 0;
                    int IdRecaudos = cnsConcecutivo("Juridicos");
                    int IdDocumento = Convert.ToInt32(ConexionMysqlContab.MtdBscDatosText("Select Consecutivo from documentomanual where IdComprobante=@IdComprobante", "IdComprobante", strFuente));
                    string resultado = string.Empty;
                    DataTable dtFuentes = ConexionMysqlContab.MtdDataTableReaderText("Select * from datoscuenta where Documento=@Documento", "Documento", strFuente);
                    string[] consulta = new string[6];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    #region  Transacciones
                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Adicionar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Recaudos Juridicos";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    EntTransacciones.Registro = "Rcd" + IdRecaudos;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                    a += 1;
                    #endregion Add Transacciones

                    #region TransaccionContable

                    transaccionCont transaccionCont = new transaccionCont();
                    string cnsConta = "SELECT if(max(IdTransaccion)is null,1,max(IdTransaccion)+1)as Id FROM transacciones";
                    DataTable dtCns = ConexionMysqlContab.MtdDataTableReaderText(cnsConta);
                    transaccionCont.IdTransaccion = Convert.ToInt32(ConexionMysqlContab.MtdBscDatosText(cnsConta));
                    transaccionCont.Fecha = DateTime.Now;
                    transaccionCont.Fuente = strFuente;
                    transaccionCont.Registro = IdDocumento;
                    transaccionCont.Registro = EntTransacciones.Id;
                    transaccionCont.Transaccion = "Add";
                    transaccionCont.Usuario = CadenaConexion.Logeo.Usuario;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(transaccionCont));
                    valparametros.Add(CadenaConexion.MtdValParametros(transaccionCont));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(transaccionCont), CadenaConexion.Logeo.BaseDatosContab);
                    a += 1;
                    #endregion

                    #region DatosRecaudosJuridico
                   
                    EntRecaudosJuridico.Estado = 1;
                    EntRecaudosJuridico.IdTercero =  DtAdjudicacion.Rows[0]["IdTercero1"].ToString();
                    EntRecaudosJuridico.IdRecaudo = "Rcd" + IdRecaudos;
                    EntRecaudosJuridico.IdTransacion = EntTransacciones.Id;
                    EntRecaudosJuridico.TransaccionContab = transaccionCont.IdTransaccion;
                    EntRecaudosJuridico.IdRecaudo = "Rcd" + IdRecaudos;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntRecaudosJuridico));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntRecaudosJuridico));
                    consulta[a] = CadenaConexion.mtdCrearInsert("recaudosjuridicos", CadenaConexion.MtdCrearParametro(EntRecaudosJuridico));
                    a += 1;
                    #endregion


                    #region Diario
                    diario EntDiario = new diario();

                    EntDiario.Fecha = EntRecaudosJuridico.Fecha;
                    EntDiario.Beneficiario = DtAdjudicacion.Rows[0]["TitularPrincipal"].ToString();
                    EntDiario.CentroCostos = 1;
                    EntDiario.Cheque = EntRecaudosJuridico.Recibo;
                    EntDiario.Detalle = EntRecaudosJuridico.Detalle;
                    EntDiario.Motivo = "Recaudo Juridico Adjudicacion " + EntRecaudosJuridico.IdAdjudicacion + " Cliente" + EntDiario.Beneficiario + "Pagado en " + EntRecaudosJuridico.FormaPago;
                    EntDiario.Estado = 1;
                    EntDiario.Factura = EntRecaudosJuridico.Recibo;
                    EntDiario.Fuente = strFuente; 
                    EntDiario.IdTercero = DtAdjudicacion.Rows[0]["IdTercero1"].ToString();
                    EntDiario.Matricula = DtAdjudicacion.Rows[0]["IdInmueble"].ToString();
                    EntDiario.Transaccion = transaccionCont.IdTransaccion;
                    EntDiario.SubCentro = 1;
                    EntDiario.SubSubCentro = "Recaudos";
                    EntDiario.IdDocumento = IdDocumento;

                    EntDiario.Consecutivo = 1;
                    EntDiario.Cuenta = dtFuentes.Rows[0]["Debe"].ToString(); ;
                    EntDiario.Debe = EntRecaudosJuridico.Valor;
                    EntDiario.Haber = 0;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDiario));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntDiario));
                    consulta[a] = CadenaConexion.mtdCrearInsert("diario", CadenaConexion.MtdCrearParametro(EntDiario), CadenaConexion.Logeo.BaseDatosContab);
                    a += 1;

                    EntDiario.Consecutivo = 1;
                    EntDiario.Cuenta = dtFuentes.Rows[0]["Haber"].ToString(); ;
                    EntDiario.Debe = 0;
                    EntDiario.Haber = EntRecaudosJuridico.Valor;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDiario));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntDiario));
                    consulta[a] = CadenaConexion.mtdCrearInsert("diario", CadenaConexion.MtdCrearParametro(EntDiario), CadenaConexion.Logeo.BaseDatosContab);
                    a += 1;
                    #endregion

                    #region Cambio Concecutivos
                    string[] nombrepar1 = { "Idcomprobante" };
                    object[] valpar1 = { strFuente };
                    nomparametros.Add(nombrepar1);
                    valparametros.Add(valpar1);
                    consulta[a] = "update " + CadenaConexion.Logeo.BaseDatosContab + ".documentomanual set Consecutivo=Consecutivo+1 where Idcomprobante=@Idcomprobante ";
                    a += 1;
                    #endregion

                    ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception ex)
                {
                    EventErrorString(ex.Message);
                }
            }
        }

        public void MtdValidar()
        {

            CuentaErrores = 0;
            Stb.Clear();
            if (EntDatosRecaudos.Fecha == null || EntDatosRecaudos.Fecha == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Del Recaudo");
            }
            if (string.IsNullOrEmpty(EntDatosRecaudos.Operacion))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Operacion");
            }
            if (string.IsNullOrEmpty(EntDatosRecaudos.FormaPago))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Forma de Pago");
            }

            if (EntDatosRecaudos.FormaPago=="Cheque")
            {
                if (string.IsNullOrEmpty(EntDatosRecaudos.CodBanco))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Codigo del Banco");
                }
            }
            if (string.IsNullOrEmpty(EntDatosRecaudos.Recibo))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Recibo de Caja");
            }

            if (EntDatosRecaudos.Valor==0)
            {                
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Del Recaudo");                 
            }
            if (EntDatosRecaudos.Valor > TotalPagar)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Valor del Recaudo Mayor Saldo Pagar");
            }         
          
           
           
            if (string.IsNullOrEmpty(EntDatosRecaudos.Detalle))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Concepto");
            }

        }

        public void MtdValidarNoRadicados()
        {
            CuentaErrores = 0;
            Stb.Clear();

            if (string.IsNullOrEmpty(EntNoRadicados.IdReserva))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Reserva");
            }
            if (EntNoRadicados.Fecha == null || EntNoRadicados.Fecha == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Del Recaudo");
            }
            if (string.IsNullOrEmpty(EntNoRadicados.Operacion))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Operacion");
            }
            if (string.IsNullOrEmpty(EntNoRadicados.FormaPago))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Forma de Pago");
            }

            if (EntNoRadicados.FormaPago == "Cheque")
            {
                if (string.IsNullOrEmpty(EntNoRadicados.CodBanco))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Codigo del Banco");
                }
            }
            if (string.IsNullOrEmpty(EntNoRadicados.Recibo))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Recibo de Caja");
            }

            if (EntNoRadicados.Valor == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Valor Del Recaudo");
            }
            
            if (string.IsNullOrEmpty(EntNoRadicados.Detalle))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Concepto");
            }
        }

        public void MtdValidarJuridicos()
        {

            CuentaErrores = 0;
            Stb.Clear();
          
            if (EntRecaudosJuridico.Fecha == null || EntRecaudosJuridico.Fecha == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Del Recaudo");
            }
            if (string.IsNullOrEmpty(EntRecaudosJuridico.Operacion))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Operacion");
            }
            if (string.IsNullOrEmpty(EntRecaudosJuridico.FormaPago))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Forma de Pago");
            }

            if (EntRecaudosJuridico.FormaPago == "Cheque")
            {
                if (string.IsNullOrEmpty(EntRecaudosJuridico.CodBanco))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Codigo del Banco");
                }
            }
            if (string.IsNullOrEmpty(EntRecaudosJuridico.Recibo))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Recibo de Caja");
            }

            if (EntRecaudosJuridico.Valor == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Valor Del Recaudo");
            }
            if (EntRecaudosJuridico.Valor > TotalPagar)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Valor del Recaudo Mayor Saldo Pagar");
            }

            if (string.IsNullOrEmpty(EntRecaudosJuridico.Detalle))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Concepto");
            }
        }

        public decimal MtdSaldo(string strIdAdjudicacion)
        {
            decimal decSaldo = 0;
            DataTable dt = new DataTable();
            dt = CnsDtConsultaStrId("SaldoCartera", strIdAdjudicacion);
            decSaldo = Convert.ToDecimal(dt.Rows[0]["Saldo"]);
            return decSaldo;          
        }

       
        #endregion

    }
    public class RecaudosDetallados
    {
        public datosrecaudos DatosRecaudos { get; set; }
        public List<recaudos> Recaudos { get; set; }
        public RecaudosDetallados()
        {
            DatosRecaudos = new datosrecaudos();
            Recaudos = new List<recaudos>();
        }
    }
    }
