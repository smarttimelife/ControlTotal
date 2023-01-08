namespace ControlTotal
{
    #region Librerias

    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System;
    using System.Data;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    // ABRIL 18 2020 12:49 PM

    #endregion Librerias

    public partial class XtraSimulador : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        private BindingSource BsSimulador = new BindingSource();
        private CadenaConexionMysql CadenasConexion;
        private DataTable DtDatos = new DataTable();
        private negSimulador NegSimulador;

        #endregion Propiedades

        #region Constructores

        public XtraSimulador(CadenaConexionMysql cadenaConexion, string StrModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenasConexion = cadenaConexion;
            NegSimulador = new negSimulador(cadenaConexion);
            BtnImprimir.Links[0].Visible = CadenasConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
            BtnCalcular.Links[0].Visible = CadenasConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Adicionar;
            BsSimulador.DataSource = NegSimulador.EntSimulador;
            NegSimulador.DataError_Event_simulador += NegSimulador_DataError_Event_simulador;
            DtpFecha.DataBindings.Add("EditValue", BsSimulador, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaExtra.DataBindings.Add("EditValue", BsSimulador, "FechaExtra", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaFnc.DataBindings.Add("EditValue", BsSimulador, "FechaFnc", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCliente.DataBindings.Add("EditValue", BsSimulador, "Cliente", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPrestamo.DataBindings.Add("EditValue", BsSimulador, "Prestamo", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCuotaInicial.DataBindings.Add("EditValue", BsSimulador, "CuotaInicial", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCapitalExtra.DataBindings.Add("EditValue", BsSimulador, "Extraordinaria", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtSaldoFinanciar.DataBindings.Add("EditValue", BsSimulador, "SaldoFinanciar", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPlazoFnc.DataBindings.Add("EditValue", BsSimulador, "PlazoFnc", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPlazoExtra.DataBindings.Add("EditValue", BsSimulador, "PlazoExtra", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCuotaExtra.DataBindings.Add("EditValue", BsSimulador, "CuotaExtra", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCuotaFnc.DataBindings.Add("EditValue", BsSimulador, "CuotaFnc", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbFormaPago.DataBindings.Add("EditValue", BsSimulador, "FormaPago", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbPeriodoExtra.DataBindings.Add("EditValue", BsSimulador, "PeriodoExtra", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbPeriodoFnc.DataBindings.Add("EditValue", BsSimulador, "PeriodoFnc", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCapitalFnc.DataBindings.Add("EditValue", BsSimulador, "Financiacion", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTasa.DataBindings.Add("EditValue", BsSimulador, "Tasa", true, DataSourceUpdateMode.OnPropertyChanged);

            CmbFormaPago.Properties.DataSource = NegSimulador.DtFormaPago();
            CmbFormaPago.Properties.ValueMember = "Id";
            CmbFormaPago.Properties.DisplayMember = "FormaPago";

            CmbPeriodoExtra.Properties.DataSource = NegSimulador.DtPeriodo();
            CmbPeriodoExtra.Properties.DisplayMember = "Nombre";
            CmbPeriodoExtra.Properties.ValueMember = "Periodo";

            CmbPeriodoFnc.Properties.DataSource = NegSimulador.DtPeriodo();
            CmbPeriodoFnc.Properties.DisplayMember = "Nombre";
            CmbPeriodoFnc.Properties.ValueMember = "Periodo";

            //BarStatus.Caption = cadenaConexion.Logeo.StrUsuarioConextado;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegSimulador_DataError_Event_simulador(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show("Se Presento El Sgte Error " + mensaje, "Simulador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnImprimir.Enabled = false;
        }

        #endregion Disparadores

        #region Metodos

        private void BtnCalcular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            NegSimulador.Extraordinaria();
            NegSimulador.CuotaFija();
            BtnImprimir.Enabled = true;
            DtDatos = NegSimulador.DtCuotas();
            GrdSimulador.DataSource = DtDatos;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            XtraRptSimulador Documento = new XtraRptSimulador(CadenasConexion, NegSimulador.EntSimulador, DtDatos);
            Documento.Show();
            BtnImprimir.Enabled = true;
            SplashScreenManager.CloseForm(); if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            GrdSimulador.DataSource = null;
            BsSimulador.Clear();
            NegSimulador = new negSimulador(CadenasConexion);
            NegSimulador.DataError_Event_simulador += NegSimulador_DataError_Event_simulador;
            BsSimulador.DataSource = NegSimulador.EntSimulador;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void CmbFormaPago_EditValueChanged(object sender, EventArgs e)
        {
            if (CmbFormaPago.Text == "Credito")
            {
                GrupFinanciacion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                GrupCuotaExtra.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                GrupFinanciacion.Text = "Financiacion";
            }
            else
            if (CmbFormaPago.Text == "Extraordinario")
            {
                GrupFinanciacion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                GrupCuotaExtra.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                GrupCuotaExtra.Text = "Financiacion";
                GrupFinanciacion.Text = "Extraordinaria";
            }
            else

            {
                GrupFinanciacion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                GrupCuotaExtra.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void CmbFormaPago_TextChanged(object sender, EventArgs e)
        {
            if (CmbFormaPago.Text == "Credito")
            {
                TxtCuotaExtra.EditValue = 0;
                TxtPlazoExtra.EditValue = 0;
                TxtCapitalExtra.EditValue = 0;
                CmbPeriodoExtra.EditValue = 180;
                CmbPeriodoFnc.EditValue = 30;
                NegSimulador.CuotaFija();
            }
            else
           if (CmbFormaPago.Text == "Extraordinario")
            {
                CmbPeriodoExtra.EditValue = 30;
                CmbPeriodoFnc.EditValue = 180;
            }
        }

        private void CmbPeriodoExtra_EditValueChanged(object sender, EventArgs e)
        {
            NegSimulador.Extraordinaria();
            NegSimulador.CuotaFija();
        }

        private void TxtPlazoFnc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                NegSimulador.Extraordinaria();
                NegSimulador.CuotaFija();
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtPlazoFnc_Leave(object sender, EventArgs e)
        {
            NegSimulador.Extraordinaria();
            NegSimulador.CuotaFija();
        }

        #endregion Metodos
    }
}