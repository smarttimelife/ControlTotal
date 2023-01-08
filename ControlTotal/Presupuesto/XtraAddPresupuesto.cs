namespace ControlTotal
{
    #region Librerias

    using Cartera;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Data;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class XtraAddPresupuesto : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private BindingSource BsCausar = new BindingSource();
        private negPresupuesto NegPresupuesto;

        #endregion Propiedades

        #region Constructor

        public XtraAddPresupuesto(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegPresupuesto = new negPresupuesto(cadenaConexion);
            NegPresupuesto.ErrorString_Event_Presupuesto += NegPresupuesto_ErrorString_Event_Presupuesto;
            NegPresupuesto.Event_ErrorTableNgConsultas += NegPresupuesto_Event_ErrorTableNgConsultas;
            NegPresupuesto.OkString_Event_Presupuesto += NegPresupuesto_OkString_Event_Presupuesto;
            NegPresupuesto.ErrorTable_EventPresupuesto += NegPresupuesto_ErrorTable_EventPresupuesto;
            BsCausar.DataSource = NegPresupuesto.EntDatosPresupuesto;
            DtpFechaInicial.DataBindings.Add("EditValue", BsCausar, "FechaInicial", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaFinal.DataBindings.Add("EditValue", BsCausar, "FechaFinal", true, DataSourceUpdateMode.OnPropertyChanged);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void NegPresupuesto_ErrorTable_EventPresupuesto(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegPresupuesto_OkString_Event_Presupuesto(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            BtnCalcular.Enabled = false;
        }

        private void NegPresupuesto_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegPresupuesto_ErrorString_Event_Presupuesto(string mensaje)
        {
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            XtraMessageBox.Show(mensaje, "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos

        private void BtnCalcular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            DataTable dt = NegPresupuesto.BorradorPresupuesto();
            gridControl1.DataSource = dt;
            pivotGridControl1.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                BtnMontarPresupuesto.Enabled = false;
                BtnExportarExcel.Enabled = false;
            }
            else
            {
                BtnMontarPresupuesto.Enabled = true;
                BtnExportarExcel.Enabled = true;
            }
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnMontarPresupuesto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnMontarPresupuesto.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de Montar Presupuesto?", "Montar Presupuesto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                NegPresupuesto.MontarPresupuesto();
            }
        }

        #endregion Metodos

        private void BtnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(gridControl1);
        }

        private void BtnResumen_EditValueChanged(object sender, System.EventArgs e)
        {
            if (BtnResumen.EditValue.ToString() == "True")
            {
                gridControl1.Visible = true;
                pivotGridControl1.Visible = false;
                BtnResumen.Caption = "Resumen";
            }
            else
            {
                gridControl1.Visible = false;
                pivotGridControl1.Visible = true;
                BtnResumen.Caption = "Detalle";
            }
        }
    }
}