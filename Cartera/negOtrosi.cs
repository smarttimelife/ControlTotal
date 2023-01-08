namespace NegociosCartera
{
    #region Librerias
    using Conexiones;
    using Microsoft.EntityFrameworkCore;
    using ModelCartera;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    #endregion

    public class negOtrosi : NegConsultasCartera
    {
        #region Propiedades
        public otrosi EntOtrosi = new otrosi();
        public calculos CalculosExtraordinario = new calculos();
        public calculos CalculosFinanciacion = new calculos();
        private DbSet<oficina> oficina { get; set; }
        public oficina EntOficina = new oficina();
        public DataTable DtExtracto = new DataTable();
        public DataTable DtFinanciacion = new DataTable();
        public DataTable DtContado = new DataTable();
        public event DlgtDataTableExit DataError_Event_ValidacionOtrosi;
        public event DlgtDataTableExit DataOK_Event_ValidacionOtrosi;
        public event DlgtStringExit ErrorString_Event_Otrosi;
        public event DlgtStringExit OkString_Event_Otrosi;
        public DataTable DtInicial = new DataTable();
        public DataTable DtRecaudos = new DataTable();
        public DataTable DtRecaudosRsm = new DataTable();
        public viewadjudicacion Entviewadjudicacion = new viewadjudicacion();
        public DataTable DtAdjudicacion = new DataTable();
        public decimal SdoCi = 0, SdoCo = 0, SdoFn = 0, SdoCe = 0, SdoInteres = 0;
        public decimal RcdCi = 0, RcdCo = 0, RcdFn = 0, RcdCe = 0, SaldoMora = 0, SdoInteresTotal = 0;
        public int DiasMoras = 0;
        private int IdOtrosi = 0;
        private DbSet<viewadjudicacion> viewadjudicacion { get; set; }
        private DbSet<otrosi> otrosi { get; set; }
        private DbSet<adjudicacion> adjudicacion { get; set; }
        public bool BolInicial = false;
        CadenaConexionMysql CadenaConexion;
        #endregion

        #region Constructor
        public negOtrosi(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            EntOficina = oficina.Find(1);
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }

        public negOtrosi(CadenaConexionMysql cadenaConexion,int idOtrosi) : base(cadenaConexion)
        {
            EntOficina = oficina.Find(1);
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            IdOtrosi = idOtrosi;
            EntOtrosi = otrosi.Find(IdOtrosi);
            MtdOtrosiAprobado();
        }

        #endregion

        #region Disparadores
        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event_Otrosi(mensaje);
        }
        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_Otrosi(mensaje);
        } 
        #endregion

        #region Metodos
        public DataTable cnsViewAdjudicacion(string IdAdjudicacion)
        {
            return CnsDtConsultaStrId("ViewAdjudicacion", IdAdjudicacion);          
        }        

        public DataTable DtCuotas(string idAdj)
        {
            DataTable dtFn = new DataTable();
            DataTable DtExt = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable table = new DataTable();
            table.Columns.Add("IdFinanciacion", typeof(string));
            table.Columns.Add("IdAdjudicacion", typeof(string));
            table.Columns.Add("Concepto", typeof(string));
            table.Columns.Add("CuotaNumero", typeof(int));
            table.Columns.Add("Fecha", typeof(DateTime));
            table.Columns.Add("Capital", typeof(double));
            table.Columns.Add("Interes", typeof(double));
            table.Columns.Add("Cuota", typeof(double));
            table.Columns.Add("SdoCapital", typeof(double));
            table.Columns.Add("SdoInteres", typeof(double));
            table.Columns.Add("SdoCuota", typeof(double));
            MtdValidarDatos();           

            if (CuentaErrores > 0)
            {
                DataError_Event_ValidacionOtrosi(Stb.ToString(), DtFinanciacion);
            }
            else
            {

                if (BolInicial == true)

                {

                    for (int i = 0; i < DtRecaudosRsm.Rows.Count; i++)
                    {
                        if ((Convert.ToDecimal(DtRecaudosRsm.Rows[i]["Capital"]) > 0) || (Convert.ToDecimal(DtRecaudosRsm.Rows[i]["InteresCte"]) > 0))
                        {
                            table.Rows.Add(
                                DtRecaudosRsm.Rows[i]["IdFinanciacion"],
                                idAdj,
                                DtRecaudosRsm.Rows[i]["Concepto"],
                                DtRecaudosRsm.Rows[i]["CuotaNumero"],
                                DtRecaudosRsm.Rows[i]["FechaCuota"],
                                DtRecaudosRsm.Rows[i]["Capital"],
                                DtRecaudosRsm.Rows[i]["InteresCte"],
                                (Convert.ToDecimal(DtRecaudosRsm.Rows[i]["Capital"]) + Convert.ToDecimal(DtRecaudosRsm.Rows[i]["InteresCte"])),
                              0, 0, 0);
                        }
                    }

                    for (int i = 0; i < DtInicial.Rows.Count; i++)
                    {
                        if (Convert.ToDecimal(DtInicial.Rows[i]["Valor"]) > 0)
                        {
                            table.Rows.Add(("CI" + (i + Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCI"]) + 1) + idAdj),
                                idAdj,
                                "CI",
                               (i + Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCI"]) + 1),
                                DtInicial.Rows[i]["Fecha"],
                                DtInicial.Rows[i]["Valor"],
                                0,
                                DtInicial.Rows[i]["Valor"],
                                 DtInicial.Rows[i]["Valor"],
                                0,
                                DtInicial.Rows[i]["Valor"]

                                );
                        }
                    }
                }

                else

                {
                    for (int i = 0; i < DtExtracto.Rows.Count; i++)
                    {
                        if ((DtExtracto.Rows[i]["Concepto"].ToString().ToUpper())=="CI") 
                        {
                            table.Rows.Add(DtExtracto.Rows[i]["IdFinanciacion"].ToString(),
                                DtExtracto.Rows[i]["IdAdjudicacion"].ToString().ToUpper(),
                                DtExtracto.Rows[i]["Concepto"].ToString().ToUpper(),
                                DtExtracto.Rows[i]["CuotaNumero"],
                                DtExtracto.Rows[i]["Fecha"],
                                DtExtracto.Rows[i]["Capital"],
                                DtExtracto.Rows[i]["Interes"],
                                DtExtracto.Rows[i]["Cuota"],
                                DtExtracto.Rows[i]["SdoCapital"],
                                DtExtracto.Rows[i]["SdoInteres"],
                                DtExtracto.Rows[i]["SdoCuota"]
                                );
                        }
                    }


                    for (int i = 0; i < DtRecaudosRsm.Rows.Count; i++)
                    {
                        if ((Convert.ToDecimal(DtRecaudosRsm.Rows[i]["Capital"]) > 0) || (Convert.ToDecimal(DtRecaudosRsm.Rows[i]["InteresCte"]) > 0))
                        {
                            if(DtRecaudosRsm.Rows[i]["Concepto"].ToString().ToUpper() !="CI")
                            {

                                table.Rows.Add(
                               DtRecaudosRsm.Rows[i]["IdFinanciacion"],
                               idAdj,
                               DtRecaudosRsm.Rows[i]["Concepto"],
                               DtRecaudosRsm.Rows[i]["CuotaNumero"],
                               DtRecaudosRsm.Rows[i]["FechaCuota"],
                               DtRecaudosRsm.Rows[i]["Capital"],
                               DtRecaudosRsm.Rows[i]["InteresCte"],
                               (Convert.ToDecimal(DtRecaudosRsm.Rows[i]["Capital"]) + Convert.ToDecimal(DtRecaudosRsm.Rows[i]["InteresCte"])),
                             0, 0, 0);
                            }
                               
                        }
                    }

                    
                }

                for (int i = 0; i < DtContado.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(DtContado.Rows[i]["Valor"]) > 0)
                    {
                        table.Rows.Add(("CO" + (i + Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCO"]) + 1) + idAdj),
                            idAdj,
                            "CO",
                            (i + Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCO"]) + 1),
                            DtContado.Rows[i]["Fecha"],
                            DtContado.Rows[i]["Valor"],
                            0,
                            DtContado.Rows[i]["Valor"],
                             DtContado.Rows[i]["Valor"],
                            0,
                            DtContado.Rows[i]["Valor"]
                            );
                    }
                }

                if (EntOtrosi.AbonoCapital > 0)
                {
                    table.Rows.Add(("CE" + (Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCE"]) + 1) + idAdj),
                           idAdj,
                           "CE",
                          (Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCE"]) + 1),
                           EntOtrosi.FechaAbono,
                           EntOtrosi.AbonoCapital,
                           0,
                           EntOtrosi.AbonoCapital,
                           EntOtrosi.AbonoCapital,
                           0,
                           EntOtrosi.AbonoCapital
                           );
                }

                double tasafnc = Convert.ToDouble(CalculosFinanciacion.Tasa);
                double financiacion = Convert.ToDouble(CalculosFinanciacion.Capital);
                int periodofnc = CalculosFinanciacion.Periodo;
                int plazofnc = CalculosFinanciacion.Plazo;
                string CtoFnc = string.Empty, CtoExtra = string.Empty;

                double tasaExt = Convert.ToDouble(CalculosExtraordinario.Tasa);
                double extraordinaria = Convert.ToDouble(CalculosExtraordinario.Capital);
                int periodoExtra = CalculosExtraordinario.Periodo;
                int plazoextra = CalculosExtraordinario.Plazo;

                if (CalculosFinanciacion.Capital > 0 & CalculosFinanciacion.Plazo > 0 & CalculosFinanciacion.Periodo > 0)
                {
                    dtFn = MtdCuotas(tasafnc, plazofnc, financiacion, periodofnc, CalculosFinanciacion.Fecha, "FN", (idAdj), Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxFN"]));
                }

                if (CalculosExtraordinario.Capital > 0 & CalculosExtraordinario.Plazo > 0 & CalculosExtraordinario.Periodo > 0)
                {
                    DtExt = MtdCuotas(tasaExt, plazoextra, extraordinaria, periodoExtra, CalculosExtraordinario.Fecha, "EX", (idAdj), Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCE"]));
                }

                DtFinanciacion = table.Copy();
                DtFinanciacion.Merge(dtFn);
                DtFinanciacion.Merge(DtExt);
                DataView dtV = DtFinanciacion.DefaultView;
                dtV.Sort = "Fecha ASC";
                DtFinanciacion = dtV.ToTable();
                DataOK_Event_ValidacionOtrosi("Registros Validados Correctamente", DtFinanciacion);
            }
            return DtFinanciacion;
        }

        private void DtCuotas()
        {
            DataTable dtFn = new DataTable();
            DataTable DtExt = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable table = new DataTable();
            table.Columns.Add("IdFinanciacion", typeof(string));
            table.Columns.Add("IdAdjudicacion", typeof(string));
            table.Columns.Add("Concepto", typeof(string));
            table.Columns.Add("CuotaNumero", typeof(int));
            table.Columns.Add("Fecha", typeof(DateTime));
            table.Columns.Add("Capital", typeof(double));
            table.Columns.Add("Interes", typeof(double));
            table.Columns.Add("Cuota", typeof(double));
            table.Columns.Add("SdoCapital", typeof(double));
            table.Columns.Add("SdoInteres", typeof(double));
            table.Columns.Add("SdoCuota", typeof(double));
            MtdValidarDatos();

            

                if (BolInicial == true)

                {

                    for (int i = 0; i < DtRecaudosRsm.Rows.Count; i++)
                    {
                        if ((Convert.ToDecimal(DtRecaudosRsm.Rows[i]["Capital"]) > 0) || (Convert.ToDecimal(DtRecaudosRsm.Rows[i]["InteresCte"]) > 0))
                        {
                            table.Rows.Add(
                                DtRecaudosRsm.Rows[i]["IdFinanciacion"],
                                EntOtrosi.IdAdjudicacion,
                                DtRecaudosRsm.Rows[i]["Concepto"],
                                DtRecaudosRsm.Rows[i]["CuotaNumero"],
                                DtRecaudosRsm.Rows[i]["FechaCuota"],
                                DtRecaudosRsm.Rows[i]["Capital"],
                                DtRecaudosRsm.Rows[i]["InteresCte"],
                                (Convert.ToDecimal(DtRecaudosRsm.Rows[i]["Capital"]) + Convert.ToDecimal(DtRecaudosRsm.Rows[i]["InteresCte"])),
                              0, 0, 0);
                        }
                    }

                    for (int i = 0; i < DtInicial.Rows.Count; i++)
                    {
                        if (Convert.ToDecimal(DtInicial.Rows[i]["Valor"]) > 0)
                        {
                            table.Rows.Add(("CI" + (i + Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCI"]) + 1) + EntOtrosi.IdAdjudicacion),
                                 EntOtrosi.IdAdjudicacion,
                                "CI",
                               (i + Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCI"]) + 1),
                                DtInicial.Rows[i]["Fecha"],
                                DtInicial.Rows[i]["Valor"],
                                0,
                                DtInicial.Rows[i]["Valor"],
                                 DtInicial.Rows[i]["Valor"],
                                0,
                                DtInicial.Rows[i]["Valor"]

                                );
                        }
                    }
                }

                else

                {
                    for (int i = 0; i < DtExtracto.Rows.Count; i++)
                    {
                        if ((DtExtracto.Rows[i]["Concepto"].ToString().ToUpper()) == "CI")
                        {
                            table.Rows.Add(DtExtracto.Rows[i]["IdFinanciacion"].ToString(),
                                DtExtracto.Rows[i]["IdAdjudicacion"].ToString().ToUpper(),
                                DtExtracto.Rows[i]["Concepto"].ToString().ToUpper(),
                                DtExtracto.Rows[i]["CuotaNumero"],
                                DtExtracto.Rows[i]["Fecha"],
                                DtExtracto.Rows[i]["Capital"],
                                DtExtracto.Rows[i]["Interes"],
                                DtExtracto.Rows[i]["Cuota"],
                                DtExtracto.Rows[i]["SdoCapital"],
                                DtExtracto.Rows[i]["SdoInteres"],
                                DtExtracto.Rows[i]["SdoCuota"]
                                );
                        }
                    }


                    for (int i = 0; i < DtRecaudosRsm.Rows.Count; i++)
                    {
                        if ((Convert.ToDecimal(DtRecaudosRsm.Rows[i]["Capital"]) > 0) || (Convert.ToDecimal(DtRecaudosRsm.Rows[i]["InteresCte"]) > 0))
                        {
                            if (DtRecaudosRsm.Rows[i]["Concepto"].ToString().ToUpper() != "CI")
                            {

                                table.Rows.Add(
                               DtRecaudosRsm.Rows[i]["IdFinanciacion"],
                                EntOtrosi.IdAdjudicacion,
                               DtRecaudosRsm.Rows[i]["Concepto"],
                               DtRecaudosRsm.Rows[i]["CuotaNumero"],
                               DtRecaudosRsm.Rows[i]["FechaCuota"],
                               DtRecaudosRsm.Rows[i]["Capital"],
                               DtRecaudosRsm.Rows[i]["InteresCte"],
                               (Convert.ToDecimal(DtRecaudosRsm.Rows[i]["Capital"]) + Convert.ToDecimal(DtRecaudosRsm.Rows[i]["InteresCte"])),
                             0, 0, 0);
                            }

                        }
                    }


                }

                for (int i = 0; i < DtContado.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(DtContado.Rows[i]["Valor"]) > 0)
                    {
                        table.Rows.Add(("CO" + (i + Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCO"]) + 1) + EntOtrosi.IdAdjudicacion),
                             EntOtrosi.IdAdjudicacion,
                            "CO",
                            (i + Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCO"]) + 1),
                            DtContado.Rows[i]["Fecha"],
                            DtContado.Rows[i]["Valor"],
                            0,
                            DtContado.Rows[i]["Valor"],
                             DtContado.Rows[i]["Valor"],
                            0,
                            DtContado.Rows[i]["Valor"]
                            );
                    }
                }

                if (EntOtrosi.AbonoCapital > 0)
                {
                    table.Rows.Add(("CE" + (Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCE"]) + 1) + EntOtrosi.IdAdjudicacion),
                            EntOtrosi.IdAdjudicacion,
                           "CE",
                          (Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCE"]) + 1),
                           EntOtrosi.FechaAbono,
                           EntOtrosi.AbonoCapital,
                           0,
                           EntOtrosi.AbonoCapital,
                           EntOtrosi.AbonoCapital,
                           0,
                           EntOtrosi.AbonoCapital
                           );
                }

                double tasafnc = Convert.ToDouble(CalculosFinanciacion.Tasa);
                double financiacion = Convert.ToDouble(CalculosFinanciacion.Capital);
                int periodofnc = CalculosFinanciacion.Periodo;
                int plazofnc = CalculosFinanciacion.Plazo;
                string CtoFnc = string.Empty, CtoExtra = string.Empty;

                double tasaExt = Convert.ToDouble(CalculosExtraordinario.Tasa);
                double extraordinaria = Convert.ToDouble(CalculosExtraordinario.Capital);
                int periodoExtra = CalculosExtraordinario.Periodo;
                int plazoextra = CalculosExtraordinario.Plazo;

                if (CalculosFinanciacion.Capital > 0 & CalculosFinanciacion.Plazo > 0 & CalculosFinanciacion.Periodo > 0)
                {
                    dtFn = MtdCuotas(tasafnc, plazofnc, financiacion, periodofnc, CalculosFinanciacion.Fecha, "FN", (EntOtrosi.IdAdjudicacion), Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxFN"]));
                }

                if (CalculosExtraordinario.Capital > 0 & CalculosExtraordinario.Plazo > 0 & CalculosExtraordinario.Periodo > 0)
                {
                    DtExt = MtdCuotas(tasaExt, plazoextra, extraordinaria, periodoExtra, CalculosExtraordinario.Fecha, "EX", (EntOtrosi.IdAdjudicacion), Convert.ToInt16(DtAdjudicacion.Rows[0]["MaxCE"]));
                }

                DtFinanciacion = table.Copy();
                DtFinanciacion.Merge(dtFn);
                DtFinanciacion.Merge(DtExt);
                DataView dtV = DtFinanciacion.DefaultView;
                dtV.Sort = "Fecha ASC";
                DtFinanciacion = dtV.ToTable();
                
            
           
        }

        public void MtdOtrosi()
        {
            DiasMoras = 0;
            SdoCi = 0; SdoCo = 0; SdoFn = 0; SdoCe = 0; SdoInteres = 0;
            RcdCi = 0; RcdCo = 0; RcdFn = 0; RcdCe = 0; SaldoMora = 0; SdoInteresTotal = 0;
            DtAdjudicacion = cnsViewAdjudicacion(EntOtrosi.IdAdjudicacion);
            DtExtracto = CnsDtConsultaStrId("Extracto", EntOtrosi.IdAdjudicacion);
            DtRecaudos = CnsDtConsultaStrId("Recaudo", EntOtrosi.IdAdjudicacion);
            DtRecaudosRsm = CnsDtConsultaStrId("RecaudoRsm", EntOtrosi.IdAdjudicacion);
            Entviewadjudicacion = viewadjudicacion.Find(EntOtrosi.IdAdjudicacion);
            DtFinanciacion = CnsDtConsultaStrId("Financiacion", EntOtrosi.IdAdjudicacion);
            for (int i = 0; i < DtExtracto.Rows.Count; i++)
            {
                if (Convert.ToInt32(DtExtracto.Rows[i]["Mora"]) > DiasMoras)
                {
                    DiasMoras = Convert.ToInt32(DtExtracto.Rows[i]["Mora"]);
                    SaldoMora += Convert.ToInt32(DtExtracto.Rows[i]["SdoCuota"]) * EntOficina.Mora * Convert.ToInt32(DtExtracto.Rows[i]["Mora"]) / 36500;
                }

                if (Convert.ToInt32(DtExtracto.Rows[i]["Mora"]) > 0)
                {
                    SdoInteres += Convert.ToDecimal(DtExtracto.Rows[i]["SdoInteres"]);
                }
                if (DtExtracto.Rows[i]["Concepto"].ToString() == "CI")
                {
                    SdoCi += Convert.ToDecimal(DtExtracto.Rows[i]["SdoCapital"]);
                }
                if (DtExtracto.Rows[i]["Concepto"].ToString() == "CE")
                {
                    SdoCe += Convert.ToDecimal(DtExtracto.Rows[i]["SdoCapital"]);
                }
                if (DtExtracto.Rows[i]["Concepto"].ToString() == "CO")
                {
                    SdoCo += Convert.ToDecimal(DtExtracto.Rows[i]["SdoCapital"]);
                }
                if (DtExtracto.Rows[i]["Concepto"].ToString() == "FN")
                {
                    SdoFn += Convert.ToDecimal(DtExtracto.Rows[i]["SdoCapital"]);
                }

            }

            for (int i = 0; i < DtRecaudos.Rows.Count; i++)
            {
                if (DtRecaudos.Rows[i]["Concepto"].ToString() == "CI")
                {
                    RcdCi += Convert.ToDecimal(DtRecaudos.Rows[i]["Capital"]);
                }
                if (DtRecaudos.Rows[i]["Concepto"].ToString() == "CE")
                {
                    RcdCe += Convert.ToDecimal(DtRecaudos.Rows[i]["Capital"]);
                }
                if (DtRecaudos.Rows[i]["Concepto"].ToString() == "CO")
                {
                    RcdCo += Convert.ToDecimal(DtRecaudos.Rows[i]["Capital"]);
                }
                if (DtRecaudos.Rows[i]["Concepto"].ToString() == "FN")
                {
                    RcdFn += Convert.ToDecimal(DtRecaudos.Rows[i]["Capital"]);
                }

            }

            SdoInteresTotal = SdoInteres + SaldoMora;
        }

        public void MtdOtrosiAprobado()
        {
            DiasMoras = 0;
            SdoCi = 0; SdoCo = 0; SdoFn = 0; SdoCe = 0; SdoInteres = 0;
            RcdCi = 0; RcdCo = 0; RcdFn = 0; RcdCe = 0; SaldoMora = 0; SdoInteresTotal = 0;
            DtAdjudicacion = cnsViewAdjudicacion(EntOtrosi.IdAdjudicacion);
            DtExtracto = CnsDtConsultaStrId("Extracto", EntOtrosi.IdAdjudicacion);

            
            DtRecaudos = CnsDtConsultaStrId("Recaudo", EntOtrosi.IdAdjudicacion);
            DtRecaudosRsm = CnsDtConsultaStrId("RecaudoRsm", EntOtrosi.IdAdjudicacion);
            Entviewadjudicacion = viewadjudicacion.Find(EntOtrosi.IdAdjudicacion);
            DtFinanciacion = CnsDtConsultaStrId("Financiacion", EntOtrosi.IdAdjudicacion);
            for (int i = 0; i < DtExtracto.Rows.Count; i++)
            {
                if (Convert.ToInt32(DtExtracto.Rows[i]["Mora"]) > DiasMoras)
                {
                    DiasMoras = Convert.ToInt32(DtExtracto.Rows[i]["Mora"]);
                    SaldoMora += Convert.ToInt32(DtExtracto.Rows[i]["SdoCuota"]) * EntOficina.Mora * Convert.ToInt32(DtExtracto.Rows[i]["Mora"]) / 36500;
                }

                if (Convert.ToInt32(DtExtracto.Rows[i]["Mora"]) > 0)
                {
                    SdoInteres += Convert.ToDecimal(DtExtracto.Rows[i]["SdoInteres"]);
                }

                DtExtracto = ConsultaDuoStrId("ExtractoOtrosi", EntOtrosi.IdAdjudicacion, EntOtrosi.IdTransaccion.ToString());

                if (DtExtracto.Rows[i]["Concepto"].ToString() == "CI")
                {
                    SdoCi += Convert.ToDecimal(DtExtracto.Rows[i]["SdoCapital"]);
                }
                if (DtExtracto.Rows[i]["Concepto"].ToString() == "CE")
                {
                    SdoCe += Convert.ToDecimal(DtExtracto.Rows[i]["SdoCapital"]);
                }
                if (DtExtracto.Rows[i]["Concepto"].ToString() == "CO")
                {
                    SdoCo += Convert.ToDecimal(DtExtracto.Rows[i]["SdoCapital"]);
                }
                if (DtExtracto.Rows[i]["Concepto"].ToString() == "FN")
                {
                    SdoFn += Convert.ToDecimal(DtExtracto.Rows[i]["SdoCapital"]);
                }

            }



            for (int i = 0; i < DtRecaudos.Rows.Count; i++)
            {
                if (DtRecaudos.Rows[i]["Concepto"].ToString() == "CI")
                {
                    RcdCi += Convert.ToDecimal(DtRecaudos.Rows[i]["Capital"]);
                }
                if (DtRecaudos.Rows[i]["Concepto"].ToString() == "CE")
                {
                    RcdCe += Convert.ToDecimal(DtRecaudos.Rows[i]["Capital"]);
                }
                if (DtRecaudos.Rows[i]["Concepto"].ToString() == "CO")
                {
                    RcdCo += Convert.ToDecimal(DtRecaudos.Rows[i]["Capital"]);
                }
                if (DtRecaudos.Rows[i]["Concepto"].ToString() == "FN")
                {
                    RcdFn += Convert.ToDecimal(DtRecaudos.Rows[i]["Capital"]);
                }

            }

            SdoInteresTotal = SdoInteres + SaldoMora;
            
        }

        public void MtdValidarDatos()
        {

            CuentaErrores = 0;
            Stb.Clear();
            if (EntOtrosi.AbonoCapital > 0)
            {
                if (EntOtrosi.FechaAbono == null || EntOtrosi.FechaAbono == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha Del Abono");
                }
            }

            if (string.IsNullOrEmpty(EntOtrosi.IdAdjudicacion))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Seleccionar Adjudicacion");
            }

            if (MtdDiferencia() != 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Documento Descuadrado");
            }

            if (string.IsNullOrEmpty(EntOtrosi.Observacion))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Observacion");
            }

            if (EntOtrosi.NuevaFormaPago == "Extraordinario")
            {
                if (CalculosExtraordinario.Capital == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Extraordinaria");
                }
                if (CalculosExtraordinario.Plazo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Numero de Cuotas ExtraOrdinaria");
                }
                if (CalculosExtraordinario.Periodo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Selecionar Periodo");
                }
                if (CalculosExtraordinario.Fecha == null || CalculosExtraordinario.Fecha == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha ExtraOrdinaria");
                }
                if (CalculosFinanciacion.Capital == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Financiacion");
                }
                if (CalculosFinanciacion.Plazo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Numero de Cuotas Financiacion");
                }
                if (CalculosFinanciacion.Periodo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Selecionar Periodo Financiacion");
                }
                if (CalculosFinanciacion.Fecha == null || CalculosFinanciacion.Fecha == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha Financiacion");
                }
            }

            if (EntOtrosi.NuevaFormaPago == "Credito")
            {
                if (CalculosFinanciacion.Capital == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Financiacion");
                }
                if (CalculosFinanciacion.Plazo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Numero de Cuotas Financiacion");
                }
                if (CalculosFinanciacion.Periodo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Selecionar Periodo Financiacion");
                }
                if (CalculosFinanciacion.Fecha == null || CalculosFinanciacion.Fecha == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha Inicio Financiacion");
                }
            }

            if (EntOtrosi.NuevaFormaPago == "Contado" & EntOtrosi.Contado == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Datos Cuotas Contado");
            }

            if (EntOtrosi.NuevaFormaPago == "CrediContado")
            {
                if (CalculosFinanciacion.Capital == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Valor Financiacion");
                }
                if (CalculosFinanciacion.Plazo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Numero de Cuotas Financiacion");
                }
                if (CalculosFinanciacion.Periodo == 0)
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Selecionar Periodo Financiacion");
                }
                if (CalculosFinanciacion.Fecha == null || CalculosFinanciacion.Fecha == Convert.ToDateTime("1/01/0001"))
                {
                    CuentaErrores += 1;
                    Stb.AppendLine("Falta Fecha Inicio Financiacion");
                }
            }

        }

        public decimal MtdDiferencia()
        {
            return (EntOtrosi.NuevoCapital - EntOtrosi.NuevoCuotaInicial - EntOtrosi.NuevoFinanciacion -
                   EntOtrosi.NuevoExtraordinaria - EntOtrosi.NuevoContado - EntOtrosi.AbonoCapital);
        }

        public void AdicionarOtrosi()
        {
            MtdValidarDatos();
            
            if (CuentaErrores > 0)
            {
                DataError_Event_ValidacionOtrosi(Stb.ToString(), DtFinanciacion);
            }
            else

            {
                try
                {
                    DtCuotas();
                  
                    int a = 0;
                    int IdAdjudicacion = cnsConcecutivo("adjudicacion");
                    string resultado = string.Empty;
                    string[] consulta = new string[(DtFinanciacion.Rows.Count + 3)];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };



                    #region Adicionar Transacciones
                    transacciones EntTransacciones = new transacciones();
                    EntTransacciones.Accion = "Adicionar";
                    EntTransacciones.Fecha = DateTime.Now;
                    EntTransacciones.Modulo = "Otrosi";
                    EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                    EntTransacciones.Id = cnsConcecutivo("Transacciones");
                    EntTransacciones.Registro = EntOtrosi.IdAdjudicacion;

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                    consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                    a += 1;

                    #endregion


                    #region Adicionar Otrosi

                    EntOtrosi.Fecha = DateTime.Now;
                    EntOtrosi.Estado = "Pendiente";
                    EntOtrosi.IdOtrosi = cnsConcecutivo("Otrosi");

                    EntOtrosi.TasaFnc = Entviewadjudicacion.TasaFnc;                    
                    EntOtrosi.NuevoTasaFnc = CalculosFinanciacion.Tasa;                    
                    EntOtrosi.NuevoPlazoFnc = CalculosFinanciacion.Plazo;
                    EntOtrosi.PlazoFnc = Entviewadjudicacion.PlazoFnc;
                    EntOtrosi.CuotaFnc = Entviewadjudicacion.CuotaFnc;
                    EntOtrosi.NuevoCuotaFnc = CalculosFinanciacion.Cuota;
                    EntOtrosi.InicioFnc = CalculosFinanciacion.Fecha;
                    EntOtrosi.PeriodoFnc = CalculosFinanciacion.Periodo;


                    EntOtrosi.TasaExtra = Entviewadjudicacion.TasaExtra;
                    EntOtrosi.NuevoTasaExtra = CalculosExtraordinario.Tasa;
                    EntOtrosi.CuotaExtra = Entviewadjudicacion.CuotaExtra;                    
                    EntOtrosi.NuevoCuotaExtra = CalculosExtraordinario.Cuota;                   
                    EntOtrosi.PlazoExtra = Entviewadjudicacion.PlazoExtra;                    
                    EntOtrosi.NuevoPlazoExtra = CalculosExtraordinario.Plazo;
                    EntOtrosi.InicioExtra = CalculosExtraordinario.Fecha;
                    EntOtrosi.PeriodoExtra = CalculosExtraordinario.Periodo;

                    EntOtrosi.IdTransaccion = EntTransacciones.Id;

                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntOtrosi));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntOtrosi));
                    consulta[a] = CadenaConexion.mtdCrearInsert("otrosi", CadenaConexion.MtdCrearParametro(EntOtrosi));
                    a += 1;
                    #endregion


                    #region Modificar Adjudicacion Estado Otrosi
                    string[] strpara = { "IdAdjudicacion" };
                    object[] objpara = { EntOtrosi.IdAdjudicacion };
                    nomparametros.Add(strpara);
                    valparametros.Add(objpara);
                    consulta[a] = "update adjudicacion set Estado='Otrosi' Where IdAdjudicacion=@IdAdjudicacion";
                    a += 1;
                    #endregion


                    #region  Adicionar financiacionotrosi
                    financiacionotrosi Entfinanciacionotrosi = new financiacionotrosi();
                    DtFinanciacion.DefaultView.Sort = "Fecha asc";
                    for (int i = 0; i < DtFinanciacion.Rows.Count; i++)
                    {
                        Entfinanciacionotrosi.Id = 0;
                        Entfinanciacionotrosi.Concepto = DtFinanciacion.Rows[i]["Concepto"].ToString();
                        Entfinanciacionotrosi.CuotaNumero = Convert.ToInt16(DtFinanciacion.Rows[i]["CuotaNumero"]);
                        Entfinanciacionotrosi.IdFinanciacion = Entfinanciacionotrosi.Concepto + Entfinanciacionotrosi.CuotaNumero + EntOtrosi.IdAdjudicacion;
                        Entfinanciacionotrosi.IdAdjudicacion = EntOtrosi.IdAdjudicacion;
                        Entfinanciacionotrosi.Fecha = Convert.ToDateTime(DtFinanciacion.Rows[i]["Fecha"]);
                        Entfinanciacionotrosi.Capital = Convert.ToDecimal(DtFinanciacion.Rows[i]["Capital"]);
                        Entfinanciacionotrosi.Interes = Convert.ToDecimal(DtFinanciacion.Rows[i]["Interes"]);
                        Entfinanciacionotrosi.Cuota = Convert.ToDecimal(DtFinanciacion.Rows[i]["Cuota"]);
                        Entfinanciacionotrosi.IdTransaccion = EntTransacciones.Id;
                        nomparametros.Add(CadenaConexion.MtdCrearParametro(Entfinanciacionotrosi));
                        valparametros.Add(CadenaConexion.MtdValParametros(Entfinanciacionotrosi));
                        consulta[a] = CadenaConexion.mtdCrearInsert("financiacionotrosi", CadenaConexion.MtdCrearParametro(Entfinanciacionotrosi));
                        a += 1;
                    }
                    #endregion

                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);

                }
                catch (Exception ex)
                {
                    ErrorString_Event_Otrosi(ex.Message);
                }


            }

        }        

        public void AprobarOtrosi()
        {

            try
            {
                adjudicacion EntAdjudicacion = adjudicacion.Find(EntOtrosi.IdAdjudicacion);
                DtFinanciacion = CnsDtConsultaStrId("FinanciacionOtrosi", EntOtrosi.IdTransaccion);
                string resultado = string.Empty;
                string[] consulta = new string[(DtFinanciacion.Rows.Count)+6];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };
                int a = 0;


                #region Adicionar Transacciones
                transacciones EntTransacciones = new transacciones();
                EntTransacciones.Accion = "Aprobar";
                EntTransacciones.Fecha = DateTime.Now;
                EntTransacciones.Modulo = "Otrosi";
                EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                EntTransacciones.Id = cnsConcecutivo("Transacciones");
                EntTransacciones.Registro = EntOtrosi.IdAdjudicacion;

                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                a += 1;

                #endregion

                #region Modificar Otrosi Estado Aprobado
                string[] strAprobarOtrosi = { "IdOtrosi" };
                object[] objAprobarOtrosi = { EntOtrosi.IdOtrosi };
                nomparametros.Add(strAprobarOtrosi);
                valparametros.Add(objAprobarOtrosi);
                consulta[a] = "update otrosi set Estado='Aprobado' Where IdOtrosi=@IdOtrosi";
                a += 1;
                #endregion

                #region Insertar ModTransacciones
                string[] strInserModFinancacion = { "IdAdjudicacion" };
                object[] objInserModFinancacion = { EntOtrosi.IdAdjudicacion };
                nomparametros.Add(strInserModFinancacion);
                valparametros.Add(objInserModFinancacion);
                consulta[a] = "INSERT INTO financiacionmod SELECT * FROM 	financiacion WHERE 	IdAdjudicacion = @IdAdjudicacion";
                a += 1;
                #endregion

                #region Insertar ModAdjudicacion
                string[] strInserModAdjudicacion = { "IdAdjudicacion" };
                object[] objInserModAdjudicacion = { EntOtrosi.IdAdjudicacion };
                nomparametros.Add(strInserModAdjudicacion);
                valparametros.Add(objInserModAdjudicacion);
                consulta[a] = "INSERT INTO adjudicacionmod SELECT * FROM 	adjudicacion WHERE 	IdAdjudicacion = @IdAdjudicacion";
                a += 1;
                #endregion

                #region Eliminar Financiacion
                string[] strDeleteTransaciones = { "IdAdjudicacion" };
                object[] objDeleteTransaciones = { EntOtrosi.IdAdjudicacion };
                nomparametros.Add(strInserModFinancacion);
                valparametros.Add(objInserModFinancacion);
                consulta[a] = "DELETE from financiacion WHERE IdAdjudicacion = @IdAdjudicacion";
                a += 1;
                #endregion

                #region  Adicionar financiacion
                financiacion Entfinanciacion = new financiacion();
              
                for (int i = 0; i < DtFinanciacion.Rows.Count; i++)
                {
                    Entfinanciacion.Id = 0;
                    Entfinanciacion.Concepto = DtFinanciacion.Rows[i]["Concepto"].ToString();
                    Entfinanciacion.CuotaNumero = Convert.ToInt16(DtFinanciacion.Rows[i]["CuotaNumero"]);
                    Entfinanciacion.IdFinanciacion = Entfinanciacion.Concepto + Entfinanciacion.CuotaNumero + EntOtrosi.IdAdjudicacion;
                    Entfinanciacion.IdAdjudicacion = EntOtrosi.IdAdjudicacion;
                    Entfinanciacion.Fecha = Convert.ToDateTime(DtFinanciacion.Rows[i]["Fecha"]);
                    Entfinanciacion.Capital = Convert.ToDecimal(DtFinanciacion.Rows[i]["Capital"]);
                    Entfinanciacion.Interes = Convert.ToDecimal(DtFinanciacion.Rows[i]["Interes"]);
                    Entfinanciacion.Cuota = Convert.ToDecimal(DtFinanciacion.Rows[i]["Cuota"]);
                    Entfinanciacion.IdTransaccion = EntTransacciones.Id;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(Entfinanciacion));
                    valparametros.Add(CadenaConexion.MtdValParametros(Entfinanciacion));
                    consulta[a] = CadenaConexion.mtdCrearInsert("financiacion", CadenaConexion.MtdCrearParametro(Entfinanciacion));
                    a += 1;
                }
                #endregion

                #region Mod Adjudicacion


                EntAdjudicacion.Valor = EntOtrosi.NuevoCapital;
                EntAdjudicacion.CuotaInicial = EntOtrosi.NuevoCuotaInicial;
                EntAdjudicacion.Financiacion = EntOtrosi.NuevoFinanciacion;
                EntAdjudicacion.Contado = EntOtrosi.NuevoContado;
                EntAdjudicacion.CuotaExtra = EntOtrosi.NuevoCuotaExtra;


                EntAdjudicacion.PeriodoFnc = CalculosFinanciacion.Periodo;
                EntAdjudicacion.PlazoFnc = CalculosFinanciacion.Plazo;
                EntAdjudicacion.TasaFnc = CalculosFinanciacion.Tasa;
                EntAdjudicacion.CuotaFnc = CalculosFinanciacion.Cuota;
                EntAdjudicacion.InicioFnc = CalculosFinanciacion.Fecha;


                EntAdjudicacion.PeriodoExtra = CalculosExtraordinario.Periodo;
                EntAdjudicacion.PlazoExtra = CalculosExtraordinario.Plazo;
                EntAdjudicacion.TasaExtra = CalculosExtraordinario.Tasa;
                EntAdjudicacion.CuotaExtra = CalculosExtraordinario.Cuota;
                EntAdjudicacion.InicioExtra = CalculosExtraordinario.Fecha;
                EntAdjudicacion.Estado = "Aprobado";
                EntAdjudicacion.IdTransaccion = EntTransacciones.Id;


                string[] para = { "IdAdjudicacion" };
                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntAdjudicacion));
                valparametros.Add(CadenaConexion.MtdValParametros(EntAdjudicacion));
                consulta[a] = CadenaConexion.mtdCrearUpdate("adjudicacion", CadenaConexion.MtdCrearParametro(EntAdjudicacion), para);
                a += 1;

                #endregion

                resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
            catch (Exception ex)
            {

                ErrorString_Event_Otrosi(ex.Message);
            }
        }

        public void EliminarOtrosi()
        {
            try
            {
                string[] consulta = new string[3];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };
                int a = 0;
                string resultado;

                #region Adicionar Transacciones
                transacciones EntTransacciones = new transacciones();
                EntTransacciones.Accion = "Eliminar";
                EntTransacciones.Fecha = DateTime.Now;
                EntTransacciones.Modulo = "Otrosi";
                EntTransacciones.Usuario = CadenaConexion.Logeo.Usuario;
                EntTransacciones.Id = cnsConcecutivo("Transacciones");
                EntTransacciones.Registro = EntOtrosi.IdAdjudicacion;
                nomparametros.Add(CadenaConexion.MtdCrearParametro(EntTransacciones));
                valparametros.Add(CadenaConexion.MtdValParametros(EntTransacciones));
                consulta[a] = CadenaConexion.mtdCrearInsert("transacciones", CadenaConexion.MtdCrearParametro(EntTransacciones));
                a += 1;
                #endregion

                #region Insertar ModAdjudicacion
                string[] strInserModAdjudicacion = { "IdAdjudicacion" };
                object[] objInserModAdjudicacion = { EntOtrosi.IdAdjudicacion };
                nomparametros.Add(strInserModAdjudicacion);
                valparametros.Add(objInserModAdjudicacion);
                consulta[a] = "UPDATE adjudicacion SET Estado='Aprobado' WHERE 	IdAdjudicacion = @IdAdjudicacion";
                a += 1;
                #endregion

                #region Insertar ModAdjudicacion
                string[] strInserModOtrosi = { "IdOtrosi" };
                object[] objInserModOtrosi = { EntOtrosi.IdOtrosi };
                nomparametros.Add(strInserModOtrosi);
                valparametros.Add(objInserModOtrosi);
                consulta[a] = "UPDATE otrosi SET Estado='Eliminado' WHERE 	IdOtrosi = @IdOtrosi";
                a += 1;
                #endregion

                resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
            catch (Exception ex)
            {
                ErrorString_Event_Otrosi(ex.Message);
            }
        }

        #endregion

    }
}
