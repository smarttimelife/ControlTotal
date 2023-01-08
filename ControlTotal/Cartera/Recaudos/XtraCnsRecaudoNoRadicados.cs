using Cartera;
using Conexiones;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class XtraCnsRecaudoNoRadicados : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negConsultas NegConsultas;
        private string StrEstado = string.Empty;

        #endregion Propiedades

        #region Constructor

        public XtraCnsRecaudoNoRadicados(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            this.Text = "Recaudos No Radicados Pendientes Aplicar";
            CadenaConexion = cadenaConexion;
            NegConsultas = new negConsultas(CadenaConexion);
            NegConsultas.Event_ErrorTableNgConsultas += NegReportes_Event_ErrorTableNgConsultas;
            GrdAdjudicacion.DataSource = NegConsultas.CnsDtConsulta("RecaudosNoRadicados");
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
            XtraMessageBox.Show(mensaje, "Recaudos No Radicados Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnImprimirListado.Enabled = false;
            BtnExportarExcel.Enabled = false;
        }

        private void NegReportes_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Recaudos No Radicados Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Operaciones.impirmir(GrdAdjudicacion, "RECAUDOS NO RADICADOS PENDIENTES POR APLICAR");
        }

        private void GrvAdjudicacion_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            StrEstado = GrvAdjudicacion.GetFocusedRowCellValue("EstadoReserva").ToString();
            if (StrEstado == "Pendiente")
            {
                BtnAddRecaudo.Enabled = false;
            }
            else
            {
                BtnAddRecaudo.Enabled = true;
            }
        }

        private void GrvAdjudicacion_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            StrEstado = GrvAdjudicacion.GetFocusedRowCellValue("EstadoReserva").ToString();
            if (StrEstado == "Pendiente")
            {
                BtnAddRecaudo.Enabled = false;
            }
            else
            {
                BtnAddRecaudo.Enabled = true;
            }
        }

        #endregion Metodos
    }
}