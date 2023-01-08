namespace ControlTotal
{
    #region Librerias

    using Cartera;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Data;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA

    #endregion Librerias

    public partial class XtraCnsSeguimientos : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negPresupuesto NegPresupuesto;
        private BindingSource BsSeguimiento = new BindingSource();

        #endregion Propiedades

        #region Constructor

        public XtraCnsSeguimientos(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegPresupuesto = new negPresupuesto(cadenaConexion);
            NegPresupuesto.ErrorTable_EventPresupuesto += NegPresupuesto_ErrorTable_EventPresupuesto;
            NegPresupuesto.Event_ErrorTableNgConsultas += NegPresupuesto_ErrorTable_EventPresupuesto;
            BsSeguimiento.DataSource = NegPresupuesto.EntDatosPresupuesto;
            DtpFechaInicial.DataBindings.Add("EditValue", BsSeguimiento, "FechaInicial", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaFinal.DataBindings.Add("EditValue", BsSeguimiento, "FechaFinal", true, DataSourceUpdateMode.OnPropertyChanged);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void NegPresupuesto_ErrorTable_EventPresupuesto(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Seguimiento Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnExportarExcel.Enabled = false;
            BtnExportarPdf.Enabled = false;
            BtnImprimir.Enabled = false;
        }

        #endregion Disparadores

        #region Metodos

        private void BtnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            GrdSeguimiento.DataSource = NegPresupuesto.DtCnsSeguimientoFecha();
            if (GrvSeguimiento.DataRowCount > 0)
            {
                BtnExportarExcel.Enabled = true;
                BtnExportarPdf.Enabled = true;
                BtnImprimir.Enabled = true;
            }
            else
            {
                BtnExportarExcel.Enabled = false;
                BtnExportarPdf.Enabled = false;
                BtnImprimir.Enabled = false;
            }
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdSeguimiento);
        }

        private void BtnExportarPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarPdf(GrdSeguimiento);
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(GrdSeguimiento, "SEGUIMIENTO CARTERA DEL" + NegPresupuesto.EntDatosPresupuesto.FechaInicial.ToShortDateString()
                                + " AL" + NegPresupuesto.EntDatosPresupuesto.FechaFinal.ToShortDateString());
        }

        #endregion Metodos
    }
}