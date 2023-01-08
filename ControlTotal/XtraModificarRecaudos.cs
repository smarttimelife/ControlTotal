namespace ControlTotal
{
    #region Librerias
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraGrid.Views.Card;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System;
    using System.Data;
    using System.Windows.Forms; 
    #endregion
    public partial class XtraModificarRecaudos : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades


        private CadenaConexionMysql CadenaConexion;
        private negRecaudos NegRecaudos;
        private string StrIdAdjudicacion = string.Empty;
        private string StrOperacion = string.Empty;

        #endregion Propiedades
        public XtraModificarRecaudos(CadenaConexionMysql cadenaConexion, string strIdAdjudicacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            StrOperacion = "Eliminar Recaudos";
            this.Text = StrOperacion;
            InitializeComponent();
            StrIdAdjudicacion = strIdAdjudicacion;
            CadenaConexion = cadenaConexion;
            NegRecaudos = new negRecaudos(cadenaConexion, strIdAdjudicacion);
            NegRecaudos.EventOkString += NegRecaudos_EventOkString;
            NegRecaudos.EventErrorString += NegRecaudos_EventErrorString;
            NegRecaudos.Event_ErrorTableNgRecaudos += NegRecaudos_Event_ErrorTableNgRecaudos;
            userAdjudicacion1.Inicio(CadenaConexion, StrIdAdjudicacion);
            MtdDatos();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #region Disparadores
        private void NegRecaudos_Event_ErrorTableNgRecaudos(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegRecaudos_EventErrorString(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegRecaudos_EventOkString(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MtdDatos();
        }
        #endregion

        private void MtdDatos()
        {
            DataSet DataSetRecaudo = new DataSet();
            DataTable DtDatosRecaudos = NegRecaudos.CnsDtConsultaStrId("DatosRecaudos", StrIdAdjudicacion);
            DataTable DtRecaudos = NegRecaudos.CnsDtConsultaStrId("RecaudoDetallado", StrIdAdjudicacion);
            DataSetRecaudo.Tables.Add(DtRecaudos);
            DataSetRecaudo.Tables.Add(DtDatosRecaudos);

            //Set up a master-detail relationship between the DataTables
            DataColumn keyColumn = DataSetRecaudo.Tables[1].Columns["IdRecaudo"];
            DataColumn foreignKeyColumn = DataSetRecaudo.Tables[0].Columns["IdRecaudo"];
            DataSetRecaudo.Relations.Add("IdRecaudo", keyColumn, foreignKeyColumn);

            //Bind the grid control to the data source
            GrdRecaudosDetallados.DataSource = DataSetRecaudo.Tables[1];
            GrdRecaudosDetallados.ForceInitialize();

            //Assign a CardView to the relationship
            CardView cardView1 = new CardView(GrdRecaudosDetallados);
            GrdRecaudosDetallados.LevelTree.Nodes.Add("RecaudoDatosRecaudos", cardView1);
            //Specify text to be displayed within detail tabs.
            cardView1.ViewCaption = "Detalle Recaudos";

            //Hide the CategoryID column for the master View
            GrvAdjudicacion.Columns["IdRecaudo"].VisibleIndex = -1;

            //Create columns for the detail pattern View
            cardView1.PopulateColumns(DataSetRecaudo.Tables[0]);
            //Hide the CategoryID column for the detail View
            //cardView1.Columns["IdAdjudicacion"].VisibleIndex = -1;
            //Format UnitPrice column values as currency
            cardView1.Columns["Cuota"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            cardView1.Columns["Cuota"].DisplayFormat.FormatString = "{0:n2}";
            cardView1.Columns["Cuota"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Cuota", "{0:n2}");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string IdRecaudo = GrvAdjudicacion.GetFocusedRowCellValue("IdRecaudo").ToString();
            string Recibo = GrvAdjudicacion.GetFocusedRowCellValue("Recibo").ToString();
            string TransaCont = GrvAdjudicacion.GetFocusedRowCellValue("TransaccionContab").ToString();
            string StrValor = GrvAdjudicacion.GetFocusedRowCellValue("Valor").ToString();

            if (XtraMessageBox.Show("¿Esta Seguro de Eliminar El Recibo N. " + Recibo + " Por Valor de $" + StrValor, StrOperacion, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                NegRecaudos.MtdEliminar(StrIdAdjudicacion, IdRecaudo, TransaCont);
                if (SplashScreenManager.Default != null)
                    SplashScreenManager.CloseForm();
            }
        }
    }
}