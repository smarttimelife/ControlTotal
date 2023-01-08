namespace ControlTotal
{
    #region Librerias

    using Conexiones;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraGrid.Views.Card;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System.Data;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //Agosto 27 2020

    #endregion Librerias

    public partial class XtraRecaudoDetallado : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        private negRecaudos NegRecaudos;
        private CadenaConexionMysql CadenaConexion;
        private string IdAdjudicacion = string.Empty;
        private string strMensaje = string.Empty;

        #endregion Propiedades

        #region Constructor

        public XtraRecaudoDetallado(CadenaConexionMysql cadenaConexion, string idAdjudicacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            InitializeComponent();
            IdAdjudicacion = idAdjudicacion;
            CadenaConexion = cadenaConexion;
            NegRecaudos = new negRecaudos(cadenaConexion, IdAdjudicacion);
            NegRecaudos.Event_ErrorTableNgRecaudos += NegRecaudos_Event_ErrorTableNgRecaudos;
            userDatosClientes1.Inicio(NegRecaudos);
            strMensaje = string.Format("Recaudos detallados  Adjudicacion Num: {0} Cliente: {1} ", IdAdjudicacion, NegRecaudos.DtAdjudicacion.Rows[0]["TitularPrincipal"]);
            this.Text = "Recaudos Detallados";
            //GrdRecaudosDetallados.DataSource = NegRecaudos.CnsDtConsultaStrId("DatosRecaudos", idAdjudicacion);
            MtdDatos();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void NegRecaudos_Event_ErrorTableNgRecaudos(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Recaudos Detallados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos

        private void MtdDatos()
        {
            DataSet DataSetRecaudo = new DataSet();
            DataTable DtDatosRecaudos = NegRecaudos.CnsDtConsultaStrId("DatosRecaudos", IdAdjudicacion);
            DataTable DtRecaudos = NegRecaudos.CnsDtConsultaStrId("RecaudoDetallado", IdAdjudicacion);
            DataSetRecaudo.Tables.Add(DtRecaudos);
            DataSetRecaudo.Tables.Add(DtDatosRecaudos);

            //Set up a master-detail relationship between the DataTables
            DataColumn keyColumn = DataSetRecaudo.Tables[1].Columns["IdRecaudo" ];
            DataColumn foreignKeyColumn = DataSetRecaudo.Tables[0].Columns["IdRecaudo"];
            DataSetRecaudo.Relations.Add("Recibo", keyColumn, foreignKeyColumn);

            //Bind the grid control to the data source
            GrdRecaudosDetallados.DataSource = DataSetRecaudo.Tables[1];
            GrdRecaudosDetallados.ForceInitialize();

            //Assign a CardView to the relationship
            CardView cardView1 = new CardView(GrdRecaudosDetallados);
            GrdRecaudosDetallados.LevelTree.Nodes.Add("RecaudoDatosRecaudos", cardView1);
            //Specify text to be displayed within detail tabs.
            cardView1.ViewCaption = "Detalle Recaudos";

            //Hide the CategoryID column for the master View
            gridView1.Columns["IdRecaudo"].VisibleIndex = -1;

            //Create columns for the detail pattern View
            cardView1.PopulateColumns(DataSetRecaudo.Tables[0]);
            //Hide the CategoryID column for the detail View
            //cardView1.Columns["IdAdjudicacion"].VisibleIndex = -1;
            //Format UnitPrice column values as currency
            cardView1.Columns["Cuota"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            cardView1.Columns["Cuota"].DisplayFormat.FormatString = "{0:n2}";
            cardView1.Columns["Cuota"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Cuota", "{0:n2}");
        }

        private void BtnExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdRecaudosDetallados);
        }

        private void BtnPdf_ItemClick(object sender, ItemClickEventArgs e)
        {
            Operaciones.ExportarPdf(GrdRecaudosDetallados);
        }

        private void BtnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void BtnImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            Operaciones.impirmir(GrdRecaudosDetallados, strMensaje);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Metodos
    }
}