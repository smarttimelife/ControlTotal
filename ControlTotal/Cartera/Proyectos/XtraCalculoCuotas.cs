using Conexiones;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using NegociosCartera;
using System.Data;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class XtraCalculoCuotas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negSimulador NegSimulador;
        private BindingSource BsSimulador = new BindingSource();

        #endregion Propiedades

        #region Constructores

        public XtraCalculoCuotas(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegSimulador = new negSimulador(cadenaConexion);

            Txtperodo.Properties.DataSource = NegSimulador.DtPeriodo();
            Txtperodo.Properties.DisplayMember = "Nombre";
            Txtperodo.Properties.ValueMember = "Periodo";

            BsSimulador.DataSource = NegSimulador.EntSimulador;
            NegSimulador.Event_ErrorTableNgConsultas += NegReportes_Event_ErrorTableNgConsultas;
            NegSimulador.DataError_Event_simulador += NegReportes_DataError_Event_simulador;
            Dtp_Fecha.DataBindings.Add("EditValue", BsSimulador, "FechaFnc", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCapital.DataBindings.Add("EditValue", BsSimulador, "Capital", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTasa.DataBindings.Add("EditValue", BsSimulador, "Tasa", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPlazo.DataBindings.Add("EditValue", BsSimulador, "PlazoFnc", true, DataSourceUpdateMode.OnPropertyChanged);

            Txtperodo.DataBindings.Add("EditValue", BsSimulador, "PeriodoFnc", true, DataSourceUpdateMode.OnPropertyChanged);
            barStaticItem1.Caption = CadenaConexion.Logeo.StrUsuarioConextado;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegReportes_DataError_Event_simulador(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Modulo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NegReportes_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Modulo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion Disparadores

        #region Metodos

        private void BtnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            gridControl1.DataSource = NegSimulador.MtdCuotaFija();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Operaciones.impirmir(gridControl1, "CALCULOS DE CUOTAS");
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Operaciones.ExportarExel(gridControl1);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        #endregion Metodos
    }
}