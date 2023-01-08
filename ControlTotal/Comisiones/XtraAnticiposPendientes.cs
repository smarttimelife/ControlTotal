namespace ControlTotal
{
    #region Libreria

    using Cartera;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA

    #endregion Libreria

    public partial class XtraAnticiposPendientes : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negComisiones NegComisiones;

        #endregion Propiedades

        #region Constructores

        public XtraAnticiposPendientes(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegComisiones = new negComisiones(CadenaConexion);
            NegComisiones.Event_ErrorTableNgConsultas += NegComisiones_Event_ErrorTableNgConsultas;
            gridControl.DataSource = NegComisiones.CnsDtConsulta("AnticiposPdte");
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        private void NegComisiones_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Anticipos Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnExporarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(gridControl);
        }

        private void BtnExportarPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarPdf(gridControl);
        }

        private void BtnImprimi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(gridControl, "ANTICIPOS PENDIENTES DE PAGO");
        }
    }
}