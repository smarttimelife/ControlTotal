using Conexiones;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using NegociosCartera;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class XtraCnsRecaudoJuridico : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negReportes NegReportes;
        private BindingSource BsRecaudos = new BindingSource();

        #endregion Propiedades

        #region Constructor

        public XtraCnsRecaudoJuridico(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            this.Text = "Recaudos Juridicos Pendientes Aplicar";
            CadenaConexion = cadenaConexion;
            NegReportes = new negReportes(CadenaConexion);
            NegReportes.Event_ErrorTableNgConsultas += NegReportes_Event_ErrorTableNgConsultas;
            NegReportes.Event_ErrorTableReporte += NegReportes_Event_ErrorTableReporte;
            BsRecaudos.DataSource = NegReportes.EntConsultaFecha;
            GrdAdjudicacion.DataSource = NegReportes.CnsDtConsulta("RecaudosJuridicos");
            if (GrvAdjudicacion.DataRowCount == 0)
            {
                BtnExportarExcel.Enabled = false;
                BtnImprimirListado.Enabled = false;
            }
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void NegReportes_Event_ErrorTableReporte(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Recaudos Juridicos Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnImprimirListado.Enabled = false;
            BtnExportarExcel.Enabled = false;
        }

        private void NegReportes_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Recaudos Juridicos Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnImprimirListado.Enabled = false;
            BtnExportarExcel.Enabled = false;
        }

        #endregion Disparadores

        #region Metodos

        private void BtnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdAdjudicacion);
        }

        private void BtnImprimirListado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(GrdAdjudicacion, "RECAUDOS JURIDICOS PENDIENTES POR APLICAR");
        }

        #endregion Metodos
    }
}