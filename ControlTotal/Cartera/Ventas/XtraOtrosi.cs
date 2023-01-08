namespace ControlTotal
{
    #region Librerias

    using Conexiones;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class XtraOtrosi : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negOtrosi NegOtrosi;
        private string StrOperacion = string.Empty;
        private BindingSource BsOtrosi = new BindingSource();
        private int VecesFormaPago = 0;

        #endregion Propiedades

        #region Constructores

        public XtraOtrosi(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegOtrosi = new negOtrosi(CadenaConexion);
            NegOtrosi.Event_ErrorTableNgConsultas += NegOtrosi_Event_ErrorTableNgConsultas;
            NegOtrosi.DataError_Event_ValidacionOtrosi += NegOtrosi_DataError_Event_ValidacionOtrosi;
            NegOtrosi.DataOK_Event_ValidacionOtrosi += NegOtrosi_DataOK_Event_ValidacionOtrosi;
            NegOtrosi.OkString_Event_Otrosi += NegOtrosi_OkString_Event_Otrosi;
            NegOtrosi.ErrorString_Event_Otrosi += NegOtrosi_ErrorString_Event_Otrosi;
            StrOperacion = "Adicionar";
            BsOtrosi.DataSource = NegOtrosi.EntOtrosi;
            GrdExtraordinaria.calculos.EntCalculos.Decimales = CadenaConexion.Logeo.Decimales;
            GrdExtraordinaria.calculos.EntCalculos.Tasa = NegOtrosi.EntOficina.IntCorriente;
            GrdFinanciacion.calculos.EntCalculos.Decimales = CadenaConexion.Logeo.Decimales;
            CmbAdjudicacion.Properties.DataSource = NegOtrosi.CnsDtCombox("Otrosi");
            CmbAdjudicacion.Properties.ValueMember = "IdAdjudicacion";
            CmbAdjudicacion.Properties.DisplayMember = "IdAdjudicacion";
            Inicio();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraOtrosi(CadenaConexionMysql cadenaConexion, int idOtrosi, string strOperacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegOtrosi = new negOtrosi(CadenaConexion, idOtrosi);
            NegOtrosi.Event_ErrorTableNgConsultas += NegOtrosi_Event_ErrorTableNgConsultas;
            NegOtrosi.DataError_Event_ValidacionOtrosi += NegOtrosi_DataError_Event_ValidacionOtrosi;
            NegOtrosi.DataOK_Event_ValidacionOtrosi += NegOtrosi_DataOK_Event_ValidacionOtrosi;
            NegOtrosi.OkString_Event_Otrosi += NegOtrosi_OkString_Event_Otrosi;
            NegOtrosi.ErrorString_Event_Otrosi += NegOtrosi_ErrorString_Event_Otrosi;
            StrOperacion = strOperacion;
            BsOtrosi.DataSource = NegOtrosi.EntOtrosi;
            CmbAdjudicacion.Properties.DataSource = NegOtrosi.CnsDtCombox("OtrosiPdte");
            CmbAdjudicacion.Properties.ValueMember = "IdAdjudicacion";
            CmbAdjudicacion.Properties.DisplayMember = "IdAdjudicacion";
            CmbAdjudicacion.Properties.ReadOnly = true;
            GrdExtraordinaria.calculos.EntCalculos.Decimales = CadenaConexion.Logeo.Decimales;
            GrdFinanciacion.calculos.EntCalculos.Decimales = CadenaConexion.Logeo.Decimales;
            Inicio();
            CmbAdjudicacion.EditValue = NegOtrosi.Entviewadjudicacion.IdAdjudicacion;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegOtrosi_DataOK_Event_ValidacionOtrosi(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Otrosi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnGuardar.Enabled = true;
            GrdCuotas.DataSource = NegOtrosi.DtFinanciacion;
        }

        private void NegOtrosi_DataError_Event_ValidacionOtrosi(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Otrosi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = false;
        }

        private void NegOtrosi_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Otrosi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NegOtrosi_ErrorString_Event_Otrosi(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Otrosi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = true;
            xtraTabControl1.Enabled = false;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegOtrosi_OkString_Event_Otrosi(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Otrosi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnImprimir.Enabled = true;
            BtnValidar.Enabled = false;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Disparadores

        #region Metodos

        private void Inicio()
        {
            this.Text = StrOperacion + "Otrosi";

            GrdCuotaInicial.Enabled = checkInicial.Checked;
            BtnGuardar.Caption = StrOperacion;
            TxtIdAdjudicacion.DataBindings.Add("EditValue", BsOtrosi, "IdAdjudicacion", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtValor.DataBindings.Add("EditValue", BsOtrosi, "Capital", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNuevoValorContrato.DataBindings.Add("EditValue", BsOtrosi, "NuevoCapital", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCuotaInicial.DataBindings.Add("EditValue", BsOtrosi, "CuotaInicial", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNuevaInicial.DataBindings.Add("EditValue", BsOtrosi, "NuevoCuotaInicial", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtContado.DataBindings.Add("EditValue", BsOtrosi, "Contado", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNuevoContado.DataBindings.Add("EditValue", BsOtrosi, "NuevoContado", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtFinanciacion.DataBindings.Add("EditValue", BsOtrosi, "Financiacion", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNuevaFinanciacion.DataBindings.Add("EditValue", BsOtrosi, "NuevoFinanciacion", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtExtraordinaria.DataBindings.Add("EditValue", BsOtrosi, "Extraordinaria", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNuevaExtraOrdinaria.DataBindings.Add("EditValue", BsOtrosi, "NuevoExtraordinaria", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtRecaudoTotal.DataBindings.Add("EditValue", BsOtrosi, "RecaudoTotal", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtAbonoCapital.DataBindings.Add("EditValue", BsOtrosi, "AbonoCapital", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaAbono.DataBindings.Add("EditValue", BsOtrosi, "FechaAbono", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNuevaFormaPago.DataBindings.Add("EditValue", BsOtrosi, "NuevaFormaPago", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtFormaPago.DataBindings.Add("EditValue", BsOtrosi, "FormaPago", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtObservacion.DataBindings.Add("EditValue", BsOtrosi, "Observacion", true, DataSourceUpdateMode.OnPropertyChanged);

            CmbNuevaFormaPago.Properties.DataSource = NegOtrosi.DtFormaPago();
            CmbNuevaFormaPago.Properties.DisplayMember = "FormaPago";
            CmbNuevaFormaPago.Properties.ValueMember = "FormaPago";
        }

        private void MtdCalculo()
        {
            TxtNuevaInicial.EditValue = Convert.ToDecimal(GrdCuotaInicial.GrvInicial.Columns["Valor"].SummaryItem.SummaryValue) + NegOtrosi.RcdCi;
            TxtNuevoContado.EditValue = Convert.ToDecimal(GrdContado.GrvInicial.Columns["Valor"].SummaryItem.SummaryValue) + NegOtrosi.RcdCo;
            TxtNuevaFinanciacion.EditValue = (GrdFinanciacion.calculos.EntCalculos.Capital) + NegOtrosi.RcdFn;
            TxtNuevaExtraOrdinaria.EditValue = (GrdExtraordinaria.calculos.EntCalculos.Capital) + NegOtrosi.RcdCe;
            TxtSaldoReFinanciar.EditValue = Convert.ToDecimal(TxtNuevoValorContrato.EditValue) - Convert.ToDecimal(TxtRecaudoTotal.EditValue);
            TxtDiferencia.EditValue = NegOtrosi.MtdDiferencia();
        }

        private void BtnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void CmbAdjudicacion_EditValueChanged(object sender, EventArgs e)
        {
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            //VecesFormaPago = 0;
            if (StrOperacion == "Adicionar")
            {
                if (CmbAdjudicacion.EditValue == null)
                {
                    xtraTabControl1.Enabled = false;
                }
                else
                {
                    xtraTabControl1.Enabled = true;
                    TxtIdAdjudicacion.EditValue = CmbAdjudicacion.EditValue;

                    NegOtrosi.MtdOtrosi();

                    GrdCuotasFinanciacion.DataSource = NegOtrosi.DtFinanciacion;
                    GrdRecaudo.DataSource = NegOtrosi.DtRecaudos;
                    GrdCuotas.DataSource = NegOtrosi.DtExtracto;

                    TxtIdInmueble.EditValue = NegOtrosi.Entviewadjudicacion.IdInmueble;
                    TxtValor.EditValue = NegOtrosi.Entviewadjudicacion.Valor;
                    TxtNuevoValorContrato.EditValue = NegOtrosi.Entviewadjudicacion.Valor;
                    TxtFormaPago.EditValue = NegOtrosi.Entviewadjudicacion.FormaPago;
                    CmbNuevaFormaPago.EditValue = NegOtrosi.Entviewadjudicacion.FormaPago;
                    TxtTitularPrincipal.EditValue = NegOtrosi.Entviewadjudicacion.TitularPrincipal;
                    TxtContrato.EditValue = NegOtrosi.Entviewadjudicacion.Contrato;
                    TxtRecaudoTotal.EditValue = NegOtrosi.Entviewadjudicacion.RcdCapital;
                    TxtSaldoTotal.EditValue = NegOtrosi.Entviewadjudicacion.Saldo;
                    TxtCuotaInicial.EditValue = NegOtrosi.Entviewadjudicacion.CuotaInicial;
                    TxtFinanciacion.EditValue = NegOtrosi.Entviewadjudicacion.Financiacion;
                    TxtExtraordinaria.EditValue = NegOtrosi.Entviewadjudicacion.Extraordinaria;
                    TxtContado.EditValue = NegOtrosi.Entviewadjudicacion.Contado;

                    GrdFinanciacion.calculos.EntCalculos.Plazo = Convert.ToInt32(NegOtrosi.Entviewadjudicacion.PlazoFnc);
                    GrdFinanciacion.calculos.EntCalculos.Periodo = Convert.ToInt32(NegOtrosi.Entviewadjudicacion.PeriodoFnc);
                    GrdFinanciacion.calculos.EntCalculos.Capital = NegOtrosi.SdoFn;
                    GrdFinanciacion.calculos.EntCalculos.Tasa = Convert.ToDecimal(NegOtrosi.Entviewadjudicacion.TasaFnc);
                    GrdFinanciacion.calculos.EntCalculos.Fecha = Convert.ToDateTime(NegOtrosi.Entviewadjudicacion.InicioFnc);

                    GrdExtraordinaria.calculos.EntCalculos.Plazo = Convert.ToInt32(NegOtrosi.Entviewadjudicacion.PlazoExtra);
                    GrdExtraordinaria.calculos.EntCalculos.Periodo = Convert.ToInt32(NegOtrosi.Entviewadjudicacion.PeriodoExtra);
                    GrdExtraordinaria.calculos.EntCalculos.Capital = NegOtrosi.SdoCe;
                    GrdExtraordinaria.calculos.EntCalculos.Tasa = Convert.ToDecimal(NegOtrosi.Entviewadjudicacion.TasaExtra);
                    GrdExtraordinaria.calculos.EntCalculos.Fecha = Convert.ToDateTime(NegOtrosi.Entviewadjudicacion.InicioExtra);

                    GrdCuotaInicial.MtdLimpiar2();
                    for (int i = 0; i < NegOtrosi.DtExtracto.Rows.Count; i++)
                    {
                        if (NegOtrosi.DtExtracto.Rows[i]["Concepto"].ToString() == "CI" & (Convert.ToDecimal(NegOtrosi.DtExtracto.Rows[i]["SdoCapital"]) > 0))
                        {
                            GrdCuotaInicial.dt.Rows.Add(NegOtrosi.DtExtracto.Rows[i]["Fecha"], NegOtrosi.DtExtracto.Rows[i]["SdoCapital"]);
                        }
                    }
                    if (GrdCuotaInicial.dt.Rows.Count == 0)
                    {
                        GrdCuotaInicial.GrvInicial.AddNewRow();
                    }
                    GrdContado.MtdLimpiar2();
                    for (int i = 0; i < NegOtrosi.DtExtracto.Rows.Count; i++)
                    {
                        if (NegOtrosi.DtExtracto.Rows[i]["Concepto"].ToString() == "CO" & (Convert.ToDecimal(NegOtrosi.DtExtracto.Rows[i]["SdoCapital"]) > 0))
                        {
                            GrdContado.dt.Rows.Add(NegOtrosi.DtExtracto.Rows[i]["Fecha"], NegOtrosi.DtExtracto.Rows[i]["SdoCapital"]);
                        }
                    }
                    if (GrdContado.dt.Rows.Count == 0)
                    {
                        GrdContado.GrvInicial.AddNewRow();
                    }

                    TxtSaldoContado.EditValue = NegOtrosi.SdoCo;
                    TxtSaldoExtra.EditValue = NegOtrosi.SdoCe;
                    TxtSaldoFinanciacion.EditValue = NegOtrosi.SdoFn;
                    TxtSaldoInicial.EditValue = NegOtrosi.SdoCi;
                    TxtRcdExtra.EditValue = NegOtrosi.RcdCe;
                    TxtRcdContado.EditValue = NegOtrosi.RcdCo;
                    TxtRcdInicial.EditValue = NegOtrosi.RcdCi;
                    TxtRcdFinanciacion.EditValue = NegOtrosi.RcdFn;
                    TxtMora.EditValue = NegOtrosi.DiasMoras;
                    TxtSdoInteres.EditValue = NegOtrosi.SdoInteres;
                    TxtValorMora.EditValue = NegOtrosi.SaldoMora;
                    TxtInteresTotal.EditValue = NegOtrosi.SdoInteresTotal;
                    MtdCalculo();
                    TxtDiferencia.EditValue = NegOtrosi.MtdDiferencia();
                }
            }
            else

                if (StrOperacion == "Aprobar" || StrOperacion == "Eliminar")
            {
                BtnImprimir.Enabled = true;
                BtnValidar.Links[0].Visible = false;
                BtnGuardar.Enabled = true;
                xtraTabControl1.Enabled = true;
                layoutControlGroup1.Enabled = false;
                GrdContado.Enabled = false;
                GrdFinanciacion.Enabled = false;
                GrdExtraordinaria.Enabled = false;
                TxtIdAdjudicacion.EditValue = CmbAdjudicacion.EditValue;
                GrdCuotasFinanciacion.DataSource = NegOtrosi.DtFinanciacion;
                GrdRecaudo.DataSource = NegOtrosi.DtRecaudos;
                GrdCuotas.DataSource = NegOtrosi.DtExtracto;
                TxtIdInmueble.EditValue = NegOtrosi.Entviewadjudicacion.IdInmueble;
                TxtValor.EditValue = NegOtrosi.Entviewadjudicacion.Valor;
                TxtNuevoValorContrato.EditValue = NegOtrosi.Entviewadjudicacion.Valor;
                TxtFormaPago.EditValue = NegOtrosi.Entviewadjudicacion.FormaPago;
                CmbNuevaFormaPago.EditValue = NegOtrosi.Entviewadjudicacion.FormaPago;
                TxtTitularPrincipal.EditValue = NegOtrosi.Entviewadjudicacion.TitularPrincipal;
                TxtContrato.EditValue = NegOtrosi.Entviewadjudicacion.Contrato;
                TxtRecaudoTotal.EditValue = NegOtrosi.Entviewadjudicacion.RcdCapital;
                TxtSaldoTotal.EditValue = NegOtrosi.Entviewadjudicacion.Saldo;
                TxtCuotaInicial.EditValue = NegOtrosi.Entviewadjudicacion.CuotaInicial;
                TxtFinanciacion.EditValue = NegOtrosi.Entviewadjudicacion.Financiacion;
                TxtExtraordinaria.EditValue = NegOtrosi.Entviewadjudicacion.Extraordinaria;
                TxtContado.EditValue = NegOtrosi.Entviewadjudicacion.Contado;

                GrdFinanciacion.calculos.EntCalculos.Plazo = Convert.ToInt32(NegOtrosi.EntOtrosi.NuevoPlazoFnc);
                GrdFinanciacion.calculos.EntCalculos.Periodo = Convert.ToInt32(NegOtrosi.EntOtrosi.PeriodoFnc);
                GrdFinanciacion.calculos.EntCalculos.Capital = NegOtrosi.SdoFn;
                GrdFinanciacion.calculos.EntCalculos.Tasa = Convert.ToDecimal(NegOtrosi.EntOtrosi.NuevoTasaFnc);
                GrdFinanciacion.calculos.EntCalculos.Fecha = Convert.ToDateTime(NegOtrosi.EntOtrosi.InicioFnc);

                GrdExtraordinaria.calculos.EntCalculos.Plazo = Convert.ToInt32(NegOtrosi.EntOtrosi.NuevoPlazoExtra);
                GrdExtraordinaria.calculos.EntCalculos.Periodo = Convert.ToInt32(NegOtrosi.EntOtrosi.PeriodoExtra);
                GrdExtraordinaria.calculos.EntCalculos.Capital = NegOtrosi.SdoCe;
                GrdExtraordinaria.calculos.EntCalculos.Tasa = Convert.ToDecimal(NegOtrosi.EntOtrosi.NuevoTasaExtra);
                GrdExtraordinaria.calculos.EntCalculos.Fecha = Convert.ToDateTime(NegOtrosi.EntOtrosi.InicioExtra);

                GrdCuotaInicial.MtdLimpiar2();
                for (int i = 0; i < NegOtrosi.DtExtracto.Rows.Count; i++)
                {
                    if (NegOtrosi.DtExtracto.Rows[i]["Concepto"].ToString() == "CI" & (Convert.ToDecimal(NegOtrosi.DtExtracto.Rows[i]["SdoCapital"]) > 0))
                    {
                        GrdCuotaInicial.dt.Rows.Add(NegOtrosi.DtExtracto.Rows[i]["Fecha"], NegOtrosi.DtExtracto.Rows[i]["SdoCapital"]);
                    }
                }
                if (GrdCuotaInicial.dt.Rows.Count == 0)
                {
                    GrdCuotaInicial.GrvInicial.AddNewRow();
                }
                GrdContado.MtdLimpiar2();
                for (int i = 0; i < NegOtrosi.DtExtracto.Rows.Count; i++)
                {
                    if (NegOtrosi.DtExtracto.Rows[i]["Concepto"].ToString() == "CO" & (Convert.ToDecimal(NegOtrosi.DtExtracto.Rows[i]["SdoCapital"]) > 0))
                    {
                        GrdContado.dt.Rows.Add(NegOtrosi.DtExtracto.Rows[i]["Fecha"], NegOtrosi.DtExtracto.Rows[i]["SdoCapital"]);
                    }
                }
                if (GrdContado.dt.Rows.Count == 0)
                {
                    GrdContado.GrvInicial.AddNewRow();
                }

                TxtSaldoContado.EditValue = NegOtrosi.SdoCo;
                TxtSaldoExtra.EditValue = NegOtrosi.SdoCe;
                TxtSaldoFinanciacion.EditValue = NegOtrosi.SdoFn;
                TxtSaldoInicial.EditValue = NegOtrosi.SdoCi;
                TxtRcdExtra.EditValue = NegOtrosi.RcdCe;
                TxtRcdContado.EditValue = NegOtrosi.RcdCo;
                TxtRcdInicial.EditValue = NegOtrosi.RcdCi;
                TxtRcdFinanciacion.EditValue = NegOtrosi.RcdFn;
                TxtMora.EditValue = NegOtrosi.DiasMoras;
                TxtSdoInteres.EditValue = NegOtrosi.SdoInteres;
                TxtValorMora.EditValue = NegOtrosi.SaldoMora;
                TxtInteresTotal.EditValue = NegOtrosi.SdoInteresTotal;
                MtdCalculo();
                TxtDiferencia.EditValue = NegOtrosi.MtdDiferencia();
            }

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void CmbNuevaFormaPago_EditValueChanged(object sender, EventArgs e)
        {
            TxtNuevaFormaPago.EditValue = CmbNuevaFormaPago.EditValue;
            GrdExtraordinaria.TxtTasa.ReadOnly = NegOtrosi.EntOficina.Automatico;
            GrdFinanciacion.TxtTasa.ReadOnly = NegOtrosi.EntOficina.Automatico;
            if (VecesFormaPago > 0)
            {
                switch (CmbNuevaFormaPago.EditValue)
                {
                    case "Credito":
                        GrdExtraordinaria.Visible = false;
                        GrdFinanciacion.Visible = true;
                        GrdContado.Visible = false;
                        GrdExtraordinaria.MtdLimpiar();
                        GrdContado.MtdLimpiar();
                        GrdFinanciacion.calculos.EntCalculos.Tasa = NegOtrosi.EntOficina.IntCorriente;
                        break;

                    case "Contado":
                        GrdFinanciacion.MtdLimpiar();
                        GrdExtraordinaria.MtdLimpiar();
                        GrdExtraordinaria.Visible = false;
                        GrdFinanciacion.Visible = false;
                        GrdContado.Visible = true;
                        break;

                    case "CrediContado":
                        GrdExtraordinaria.Visible = false;
                        GrdFinanciacion.Visible = true;
                        GrdFinanciacion.calculos.EntCalculos.Tasa = 0;
                        GrdContado.Visible = false;
                        GrdExtraordinaria.MtdLimpiar();
                        GrdContado.MtdLimpiar();
                        break;

                    case "Extraordinario":

                        GrdExtraordinaria.Visible = true;
                        GrdFinanciacion.Visible = true;
                        GrdContado.Visible = false;
                        GrdContado.MtdLimpiar();
                        GrdFinanciacion.calculos.EntCalculos.Tasa = NegOtrosi.EntOficina.IntCorriente;
                        break;

                    default:

                        break;
                }
                VecesFormaPago += 1;
            }
            else
            {
                switch (CmbNuevaFormaPago.EditValue)
                {
                    case "Credito":
                        GrdExtraordinaria.Visible = false;
                        GrdFinanciacion.Visible = true;
                        GrdContado.Visible = false;

                        break;

                    case "Contado":
                        GrdExtraordinaria.Visible = false;
                        GrdFinanciacion.Visible = false;
                        GrdContado.Visible = true;

                        break;

                    case "CrediContado":
                        GrdExtraordinaria.Visible = false;
                        GrdFinanciacion.Visible = true;
                        GrdContado.Visible = false;

                        break;

                    case "Extraordinario":

                        GrdExtraordinaria.Visible = true;
                        GrdFinanciacion.Visible = true;
                        GrdContado.Visible = false;

                        break;

                    default:

                        break;
                }
                VecesFormaPago += 1;
            }
        }

        private void GrdCuotaInicial_After_CustomSummaryExists(object sender, EventArgs e)
        {
            MtdCalculo();
        }

        private void GrdContado_After_CustomSummaryExists(object sender, EventArgs e)
        {
            MtdCalculo();
        }

        private void GrdFinanciacion_After_KeyPress(object sender, EventArgs e)
        {
            MtdCalculo();
        }

        private void GrdExtraordinaria_After_KeyPress(object sender, EventArgs e)
        {
            MtdCalculo();
        }

        private void TxtNuevoValorContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                MtdCalculo();
                SendKeys.Send("{TAB}");
            }
        }

        private void GrdCuotaInicial_After_ValidatingEditor(object sender, EventArgs e)
        {
            MtdCalculo();
        }

        private void GrdCuotaInicial_Leave(object sender, EventArgs e)
        {
            MtdCalculo();
        }

        private void GrdContado_Leave(object sender, EventArgs e)
        {
            MtdCalculo();
        }

        private void BtnValidar_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            NegOtrosi.BolInicial = checkInicial.Checked;
            BtnGuardar.Enabled = false;
            GrdCuotaInicial.GrvInicial.CloseEditor();
            GrdCuotaInicial.GrvInicial.UpdateCurrentRow();
            if (NegOtrosi.EntOtrosi.NuevaFormaPago == "Contado")
            {
                GrdContado.GrvInicial.CloseEditor();
                GrdContado.GrvInicial.UpdateCurrentRow();
            }
            MtdCalculo();
            NegOtrosi.CalculosFinanciacion = GrdFinanciacion.calculos.EntCalculos;
            NegOtrosi.CalculosExtraordinario = GrdExtraordinaria.calculos.EntCalculos;
            NegOtrosi.DtContado = GrdContado.dt;
            NegOtrosi.DtInicial = GrdCuotaInicial.dt;

            if (StrOperacion == "Adicionar")
            {
                NegOtrosi.DtCuotas(TxtIdAdjudicacion.EditValue.ToString());
            }
            else
            if (StrOperacion == "Modificar")
            {
                // NegOtrosi.DtCuotas(TxtIdAdjudicacion.EditValue.ToString());
            }

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void TxtAbonoCapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                MtdCalculo();
                SendKeys.Send("{TAB}");
            }
        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Utilidades utilidades = new Utilidades();
            utilidades.impirmir(GrdCuotas, "SALDO CARTERA " + TxtIdAdjudicacion.EditValue, CadenaConexion.Logeo.Logo);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void checkInicial_CheckedChanged(object sender, EventArgs e)
        {
            GrdCuotaInicial.Enabled = checkInicial.Checked;
        }

        private void BtnGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Este Otrosi ?", StrOperacion + " Otrosi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BtnGuardar.Enabled = false;
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegOtrosi.AdicionarOtrosi();
                        break;

                    case "Modificar":

                        break;

                    case "Eliminar":
                        NegOtrosi.EliminarOtrosi();
                        break;

                    case "Aprobar":
                        NegOtrosi.AprobarOtrosi();
                        break;

                    case "Desaprobar":

                        break;
                }
                if (SplashScreenManager.Default != null)
                    SplashScreenManager.CloseForm();
            }
        }

        private void BtnImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraRptOtrosi Documento = new XtraRptOtrosi(CadenaConexion, NegOtrosi.EntOtrosi.IdTransaccion.ToString(), NegOtrosi.EntOtrosi.IdAdjudicacion);
            Documento.Show();
        }

        #endregion Metodos
    }
}