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

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //28 de Marzo 2021

    #endregion Librerias

    public partial class XtraAdjudicacion : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        private BindingSource BsAdjudicacion = new BindingSource();
        private CadenaConexionMysql CadenaConexion;
        private negAdjudicacion NegAdjudicacion;
        private string StrModulo = string.Empty;
        private string StrOperacion = string.Empty;

        #endregion Propiedades

        #region Constructors

        public XtraAdjudicacion(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegAdjudicacion = new negAdjudicacion(CadenaConexion);
            StrModulo = strModulo;
            StrOperacion = "Adicionar";
            BsAdjudicacion.DataSource = NegAdjudicacion.EntAdjudicacion;
            GrdExtraordinaria.calculos.EntCalculos.Decimales = CadenaConexion.Logeo.Decimales;
            GrdExtraordinaria.calculos.EntCalculos.Tasa = NegAdjudicacion.EntOficina.IntCorriente;
            GrdFinanciacion.calculos.EntCalculos.Decimales = CadenaConexion.Logeo.Decimales;
            NegAdjudicacion.EntAdjudicacion.Financiacion = GrdFinanciacion.calculos.EntCalculos.Capital;
            TxtDiferencia.EditValue = NegAdjudicacion.Difencia;
            Inicio();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraAdjudicacion(CadenaConexionMysql cadenaConexion, string strModulo, string Id, string strOperacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegAdjudicacion = new negAdjudicacion(CadenaConexion, Id);
            StrModulo = strModulo;
            StrOperacion = strOperacion;
            BtnGuardar.Caption = StrOperacion;

            GrdFinanciacion.calculos.EntCalculos.Decimales = CadenaConexion.Logeo.Decimales;
            GrdExtraordinaria.calculos.EntCalculos.Decimales = CadenaConexion.Logeo.Decimales;
            BsAdjudicacion.DataSource = NegAdjudicacion.EntAdjudicacion;

            GrdFinanciacion.calculos.EntCalculos.Plazo = NegAdjudicacion.EntAdjudicacion.PlazoFnc;
            GrdFinanciacion.calculos.EntCalculos.Periodo = NegAdjudicacion.EntAdjudicacion.PeriodoFnc;
            GrdFinanciacion.calculos.EntCalculos.Capital = NegAdjudicacion.EntAdjudicacion.Financiacion;
            GrdFinanciacion.calculos.EntCalculos.Tasa = NegAdjudicacion.EntAdjudicacion.TasaFnc;
            GrdFinanciacion.calculos.EntCalculos.Fecha = NegAdjudicacion.EntAdjudicacion.InicioFnc;

            GrdExtraordinaria.calculos.EntCalculos.Plazo = NegAdjudicacion.EntAdjudicacion.PlazoExtra;
            GrdExtraordinaria.calculos.EntCalculos.Periodo = NegAdjudicacion.EntAdjudicacion.PeriodoExtra;
            GrdExtraordinaria.calculos.EntCalculos.Capital = NegAdjudicacion.EntAdjudicacion.Extraordinaria;
            GrdExtraordinaria.calculos.EntCalculos.Tasa = NegAdjudicacion.EntAdjudicacion.TasaFnc;
            GrdExtraordinaria.calculos.EntCalculos.Fecha = NegAdjudicacion.EntAdjudicacion.InicioExtra;

            GrdCuotasFinanciacion.DataSource = NegAdjudicacion.DtFinanciacion;
            GrdContado.dt.Clear();
            GrdInicial.dt.Clear();

            for (int i = 0; i < NegAdjudicacion.DtInicial.Rows.Count; i++)
            {
                GrdInicial.dt.Rows.Add(NegAdjudicacion.DtInicial.Rows[i]["Fecha"], NegAdjudicacion.DtInicial.Rows[i]["Valor"]);
            }

            for (int i = 0; i < NegAdjudicacion.DtContado.Rows.Count; i++)
            {
                GrdContado.dt.Rows.Add(NegAdjudicacion.DtContado.Rows[i]["Fecha"], NegAdjudicacion.DtContado.Rows[i]["Valor"]);
            }

            Inicio();

            if (StrOperacion == "Aprobar" || StrOperacion == "Eliminar" || StrOperacion == "Desaprobar")
            {
                MtdReadOnly();
            }

            if (StrOperacion == "Modificar")
            {
                CmbFormaPago.Visible = false;
            }
            CmbFormaPago.EditValue = NegAdjudicacion.EntAdjudicacion.FormaPago;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructors

        #region Disparadores

        private void NegAdjudicacion_DataError_Event_Adjud(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = false;
        }

        private void NegAdjudicacion_DataOK_Event_Adjud(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnGuardar.Enabled = true;
            GrdCuotasFinanciacion.DataSource = NegAdjudicacion.DtFinanciacion;
        }

        private void NegAdjudicacion_ErrorString_Event_adjudicacion(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegAdjudicacion_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegAdjudicacion_OkString_Event_adjudicacion(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            switch (StrOperacion)
            {
                case "Adicionar":
                    BtnValidar.Enabled = false;
                    BtnNuevo.Enabled = true;
                    PnlDatos.Enabled = false;
                    PnlFormaPago.Enabled = false;
                    BtnImprimir.Enabled = true;
                    break;

                case "Modificar":
                    BtnValidar.Enabled = false;
                    BtnNuevo.Enabled = true;
                    PnlDatos.Enabled = false;
                    PnlFormaPago.Enabled = false;
                    BtnImprimir.Enabled = true;
                    break;

                case "Eliminar":

                    break;

                case "Aprobar":

                    break;

                case "Desaprobar":

                    break;
            }

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Disparadores

        #region Metodos

        private void BtnGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Esta Adjudicacion ?", StrOperacion + " Adjudicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BtnGuardar.Enabled = false;
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegAdjudicacion.MtdAdicionar();
                        break;

                    case "Modificar":
                        NegAdjudicacion.MtdModificar();
                        break;

                    case "Eliminar":
                        NegAdjudicacion.MtdEliminar();
                        break;

                    case "Aprobar":
                        NegAdjudicacion.MtdAprobar();
                        break;

                    case "Desaprobar":
                        NegAdjudicacion.MtdDesaprobar();
                        break;
                }
            }
        }

        private void BtnImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraRptAdjudicacion Documento = new XtraRptAdjudicacion(CadenaConexion, NegAdjudicacion.EntAdjudicacion.IdAdjudicacion);
            Documento.Show();
        }

        private void BtnNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            //BtnNuevo.Enabled = false;
            //BtnValidar.Enabled = true;
            BsAdjudicacion.Clear();
            CmbReserva.EditValue = 0;
            TxtDiferencia.EditValue = NegAdjudicacion.Difencia;
            GrdFinanciacion.MtdLimpiar();
            GrdInicial.MtdLimpiar();
            GrdContado.MtdLimpiar();
            GrdExtraordinaria.MtdLimpiar();

            PnlDatos.Enabled = true;
            PnlFormaPago.Enabled = true;
            BtnImprimir.Enabled = false;

            NegAdjudicacion = new negAdjudicacion(CadenaConexion);
            NegAdjudicacion.Event_ErrorTableNgConsultas += NegAdjudicacion_Event_ErrorTableNgConsultas;
            NegAdjudicacion.DataError_Event_Adjud += NegAdjudicacion_DataError_Event_Adjud;
            NegAdjudicacion.DataOK_Event_Adjud += NegAdjudicacion_DataOK_Event_Adjud;
            BsAdjudicacion.DataSource = NegAdjudicacion.EntAdjudicacion;
            GrdCuotasFinanciacion.DataSource = null;
            BsAdjudicacion.DataSource = NegAdjudicacion.EntAdjudicacion;

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void BtnValidar_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            GrdInicial.GrvInicial.CloseEditor();
            GrdInicial.GrvInicial.UpdateCurrentRow();
            if (NegAdjudicacion.EntAdjudicacion.FormaPago == "Contado")
            {
                GrdContado.GrvInicial.CloseEditor();
                GrdContado.GrvInicial.UpdateCurrentRow();
            }
            MtdCalculo();
            NegAdjudicacion.CalculosFinanciacion = GrdFinanciacion.calculos.EntCalculos;
            NegAdjudicacion.CalculosExtraordinario = GrdExtraordinaria.calculos.EntCalculos;
            NegAdjudicacion.DtContado = GrdContado.dt;
            NegAdjudicacion.DtInicial = GrdInicial.dt;

            if (StrOperacion == "Adicionar")
            {
                NegAdjudicacion.DtCuotas(0);
            }
            else
            if (StrOperacion == "Modificar")
            {
                NegAdjudicacion.DtCuotasMod(NegAdjudicacion.EntAdjudicacion.IdAdjudicacion);
            }

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void CmbFormaPago_EditValueChanged(object sender, System.EventArgs e)
        {
            if (StrOperacion == "Adicionar" || StrOperacion == "Modificar")
            {
                GrdExtraordinaria.TxtTasa.ReadOnly = NegAdjudicacion.EntOficina.Automatico;
                GrdFinanciacion.TxtTasa.ReadOnly = NegAdjudicacion.EntOficina.Automatico;
                switch (CmbFormaPago.EditValue)
                {
                    case "Credito":

                        GrdContado.Visible = false;
                        GrdExtraordinaria.Visible = false;
                        GrdFinanciacion.Visible = true;
                        GrdExtraordinaria.MtdLimpiar();
                        GrdContado.MtdLimpiar();
                        GrdFinanciacion.calculos.EntCalculos.Tasa = NegAdjudicacion.EntOficina.IntCorriente;

                        break;

                    case "Contado":
                        GrdExtraordinaria.Visible = false;
                        GrdFinanciacion.Visible = false;
                        GrdContado.Visible = true;
                        GrdFinanciacion.MtdLimpiar();
                        GrdExtraordinaria.MtdLimpiar();
                        break;

                    case "CrediContado":
                        GrdExtraordinaria.Visible = false;
                        GrdContado.Visible = false;
                        GrdFinanciacion.Visible = true;
                        GrdFinanciacion.calculos.EntCalculos.Tasa = 0;
                        GrdExtraordinaria.MtdLimpiar();
                        GrdContado.MtdLimpiar();
                        break;

                    case "Extraordinario":
                        GrdContado.Visible = false;
                        GrdExtraordinaria.Visible = true;
                        GrdFinanciacion.Visible = true;
                        GrdContado.MtdLimpiar();
                        GrdFinanciacion.calculos.EntCalculos.Tasa = NegAdjudicacion.EntOficina.IntCorriente;
                        break;

                    default:

                        break;
                }
            }

            if (StrOperacion == "Aprobar" || StrOperacion == "Eliminar")
            {
                switch (CmbFormaPago.EditValue)
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
                        GrdFinanciacion.calculos.EntCalculos.Tasa = 0;
                        GrdContado.Visible = false;
                        break;

                    case "Extraordinario":

                        GrdExtraordinaria.Visible = true;
                        GrdFinanciacion.Visible = true;
                        GrdContado.Visible = false;
                        break;

                    default:
                        GrdExtraordinaria.Visible = false;
                        GrdFinanciacion.Visible = false;
                        GrdContado.Visible = false;

                        break;
                }
            }
        }

        private void CmbReserva_EditValueChanged(object sender, EventArgs e)
        {
            CmbIdTercero1.EditValue = GrvReserva.GetFocusedRowCellValue("IdTercero");
            TxtIdInmueble.EditValue = GrvReserva.GetFocusedRowCellValue("IdInmueble");
            TxtContrato.EditValue = GrvReserva.GetFocusedRowCellValue("Contrato");
            DtpFechaContrato.EditValue = GrvReserva.GetFocusedRowCellValue("Fecha");
            NegAdjudicacion.IdReserva = CmbReserva.EditValue.ToString();
        }

        private void GrdContado_After_CustomSummaryExists(object sender, EventArgs e)
        {
            GrdContado.GrvInicial.CloseEditor();
            GrdContado.GrvInicial.UpdateCurrentRow();
            MtdCalculo();
        }

        private void GrdFinanciacion_After_KeyPress(object sender, EventArgs e)
        {
            MtdCalculo();
        }

        private void GrdInicial_After_CustomSummaryExists(object sender, EventArgs e)
        {
            GrdInicial.GrvInicial.CloseEditor();
            GrdInicial.GrvInicial.UpdateCurrentRow();
            MtdCalculo();
        }

        private void GrdInicial_After_ValidatingEditor(object sender, EventArgs e)
        {
            MtdCalculo();
        }

        private void GrdInicial_Leave(object sender, EventArgs e)
        {
            MtdCalculo();
        }

        private void Inicio()
        {
            NegAdjudicacion.Event_ErrorTableNgConsultas += NegAdjudicacion_Event_ErrorTableNgConsultas;
            NegAdjudicacion.DataError_Event_Adjud += NegAdjudicacion_DataError_Event_Adjud;
            NegAdjudicacion.DataOK_Event_Adjud += NegAdjudicacion_DataOK_Event_Adjud;
            NegAdjudicacion.OkString_Event_adjudicacion += NegAdjudicacion_OkString_Event_adjudicacion;
            NegAdjudicacion.ErrorString_Event_adjudicacion += NegAdjudicacion_ErrorString_Event_adjudicacion;

            this.Text = StrOperacion + " Adjudicacion";
            DtpFecha.DataBindings.Add("EditValue", BsAdjudicacion, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaEntrega.DataBindings.Add("EditValue", BsAdjudicacion, "FechaEntrega", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaContrato.DataBindings.Add("EditValue", BsAdjudicacion, "FechaContrato", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtIdInmueble.DataBindings.Add("EditValue", BsAdjudicacion, "IdInmueble", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbIdTercero1.DataBindings.Add("EditValue", BsAdjudicacion, "IdTercero1", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbIdTercero2.DataBindings.Add("EditValue", BsAdjudicacion, "IdTercero2", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbIdTercero3.DataBindings.Add("EditValue", BsAdjudicacion, "IdTercero3", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbFormaPago.DataBindings.Add("EditValue", BsAdjudicacion, "FormaPago", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtValor.DataBindings.Add("EditValue", BsAdjudicacion, "Valor", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtContrato.DataBindings.Add("EditValue", BsAdjudicacion, "Contrato", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbOrigenVenta.DataBindings.Add("EditValue", BsAdjudicacion, "OrigenVenta", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtFinanciacion.DataBindings.Add("EditValue", BsAdjudicacion, "Financiacion", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtContado.DataBindings.Add("EditValue", BsAdjudicacion, "Contado", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtExtraOrdinaria.DataBindings.Add("EditValue", BsAdjudicacion, "Extraordinaria", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtInicial.DataBindings.Add("EditValue", BsAdjudicacion, "CuotaInicial", true, DataSourceUpdateMode.OnPropertyChanged);

            CmbFormaPago.Properties.DataSource = NegAdjudicacion.DtFormaPago();
            CmbFormaPago.Properties.DisplayMember = "FormaPago";
            CmbFormaPago.Properties.ValueMember = "FormaPago";

            CmbOrigenVenta.Properties.DataSource = NegAdjudicacion.DtOrigenVenta();
            CmbOrigenVenta.Properties.DisplayMember = "OrigenVenta";
            CmbOrigenVenta.Properties.ValueMember = "OrigenVenta";

            CmbIdTercero1.Properties.DataSource = NegAdjudicacion.CnsDtCombox("Clientes");
            CmbIdTercero1.Properties.ValueMember = "IdTercero";
            CmbIdTercero1.Properties.DisplayMember = "Cliente";

            CmbIdTercero2.Properties.DataSource = NegAdjudicacion.CnsDtCombox("Clientes");
            CmbIdTercero2.Properties.ValueMember = "IdTercero";
            CmbIdTercero2.Properties.DisplayMember = "Cliente";

            CmbIdTercero3.Properties.DataSource = NegAdjudicacion.CnsDtCombox("Clientes");
            CmbIdTercero3.Properties.ValueMember = "IdTercero";
            CmbIdTercero3.Properties.DisplayMember = "Cliente";

            CmbReserva.Properties.DataSource = NegAdjudicacion.CnsDtCombox("Reservas");
            CmbReserva.Properties.DisplayMember = "IdReserva";
            CmbReserva.Properties.ValueMember = "IdReserva";
        }

        private void MtdCalculo()
        {
            TxtInicial.EditValue = GrdInicial.GrvInicial.Columns["Valor"].SummaryItem.SummaryValue;
            TxtContado.EditValue = GrdContado.GrvInicial.Columns["Valor"].SummaryItem.SummaryValue;
            TxtFinanciacion.EditValue = GrdFinanciacion.TxtValor.EditValue;
            TxtExtraOrdinaria.EditValue = GrdExtraordinaria.TxtValor.EditValue;
            TxtDiferencia.EditValue = NegAdjudicacion.MtdDiferencia();
        }

        private void MtdReadOnly()
        {
            BtnValidar.Visibility = BarItemVisibility.Never;
            BtnGuardar.Enabled = true;
            BtnImprimir.Enabled = true;
            CmbIdTercero2.ReadOnly = true;
            CmbIdTercero3.ReadOnly = true;
            DtpFechaEntrega.ReadOnly = true;
            CmbFormaPago.ReadOnly = true;
            CmbOrigenVenta.ReadOnly = true;
            TxtValor.ReadOnly = true;
            GrdInicial.GrvInicial.OptionsBehavior.ReadOnly = true;
            GrdContado.GrvInicial.OptionsBehavior.ReadOnly = true;
            GrdExtraordinaria.MtdReadOnly();
            GrdFinanciacion.MtdReadOnly();
            DtpFecha.ReadOnly = true;
            CmbReserva.ReadOnly = true;
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                MtdCalculo();
                SendKeys.Send("{TAB}");
            }
        }

        #endregion Metodos
    }
}