using Cartera;
using Conexiones;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraSplashScreen;
using System.Data;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class XtraSeguimientoPresupuesto : DevExpress.XtraEditors.XtraForm
    {
        private CadenaConexionMysql CadenaConexion;
        private negPresupuesto NegPresupuesto;

        public XtraSeguimientoPresupuesto(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegPresupuesto = new negPresupuesto(CadenaConexion);
            NegPresupuesto.Event_ErrorTableNgConsultas += NegPresupuesto_Event_ErrorTableNgConsultas;

            // gridControl1.DataSource = NegPresupuesto.CnsDtSeguimiento();
            MtdDatos();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegPresupuesto_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Seguimiento Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnEstadoCuenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string IdAdj = GrvSeguimiento.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            XtraRptEstadoCuenta Documento = new XtraRptEstadoCuenta(CadenaConexion, IdAdj);
            Documento.ShowDialog();
        }

        private void BtnRecaudoDetallado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string IdAdj = GrvSeguimiento.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            XtraRecaudoDetallado Documento = new XtraRecaudoDetallado(CadenaConexion, IdAdj);
            Documento.ShowDialog();
        }

        private void BtnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(gridControl1);
        }

        private void BtnExportarPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarPdf(gridControl1);
        }

        private void MtdDatos()
        {
            DataSet DatasetPresupuesto = new DataSet();
            DataTable DtSeguimiento = NegPresupuesto.CnsDtSeguimiento();
            DataTable DtPresupuesto = NegPresupuesto.CnsDtPresupuesto();
            DatasetPresupuesto.Tables.Add(DtPresupuesto);
            DatasetPresupuesto.Tables.Add(DtSeguimiento);

            //Set up a master-detail relationship between the DataTables
            DataColumn keyColumn = DatasetPresupuesto.Tables[1].Columns["IdAdjudicacion"];
            DataColumn foreignKeyColumn = DatasetPresupuesto.Tables[0].Columns["IdAdjudicacion"];
            DatasetPresupuesto.Relations.Add("IdAdjudicacion", keyColumn, foreignKeyColumn);

            //Bind the grid control to the data source
            gridControl1.DataSource = DatasetPresupuesto.Tables[1];
            gridControl1.ForceInitialize();

            //Assign a CardView to the relationship
            CardView cardView1 = new CardView(gridControl1);
            gridControl1.LevelTree.Nodes.Add("Presupuesto", cardView1);
            //Specify text to be displayed within detail tabs.
            cardView1.ViewCaption = "Detalle Presupuesto";

            //Hide the CategoryID column for the master View
            GrvSeguimiento.Columns["IdAdjudicacion"].VisibleIndex = -1;

            //Create columns for the detail pattern View
            cardView1.PopulateColumns(DatasetPresupuesto.Tables[0]);
            //Hide the CategoryID column for the detail View
            //cardView1.Columns["IdAdjudicacion"].VisibleIndex = -1;
            //Format UnitPrice column values as currency
            cardView1.Columns["Recaudo"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            cardView1.Columns["Recaudo"].DisplayFormat.FormatString = "c2";
            cardView1.Columns["Recaudo"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Recaudo", "{0:n2}");
        }

        private void BtnAddSeguimiento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string IdAdj = GrvSeguimiento.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            string Tipo = GrvSeguimiento.GetFocusedRowCellValue("TipoCartera").ToString();
            XtraSeguimientoCliente Documento = new XtraSeguimientoCliente(CadenaConexion, IdAdj, Tipo);
            Documento.ShowDialog();
        }
    }
}