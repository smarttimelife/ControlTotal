namespace ControlTotal
{
    #region Librerias

    using Cartera;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraSplashScreen;
    using System.Drawing;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA

    #endregion Librerias

    public partial class XtraPagados : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negDocumentacion NegDocumentacion;

        #endregion Propiedades

        #region Constructor

        public XtraPagados(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegDocumentacion = new negDocumentacion(CadenaConexion);
            NegDocumentacion.Error_Event_String_NegDocumentacion += NegDocumentacion_Error_Event_String_negConsultas;
            NegDocumentacion.Event_ErrorTableNgConsultas += NegDocumentacion_Event_ErrorTableNgConsultas;
            GrdAdjudicacion.DataSource = NegDocumentacion.CnsDtConsultaStrId("EstadosAdj", "Pagado");
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void NegDocumentacion_Error_Event_String_negConsultas(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Pagados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegDocumentacion_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Pagados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos

        private void BtnAceptar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount == 0)
            {
                NegDocumentacion_Error_Event_String_negConsultas("No Ahy Negocios Pagados");
            }
            else
            {
                string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                XtraAceptarDocumento Documento = new XtraAceptarDocumento(CadenaConexion, IdAdj, "Pagado");
                Documento.ShowDialog();
                GrdAdjudicacion.DataSource = NegDocumentacion.CnsDtConsultaStrId("EstadosAdj", "Pagado");
            }
        }

        private void BtnEnviarTramite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount == 0)
            {
                NegDocumentacion_Error_Event_String_negConsultas("No Ahy Negocios Pagados");
            }
            else
            {
                string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                XtraDocumentacion Documento = new XtraDocumentacion(CadenaConexion, IdAdj, "Tramite Escrituracion");
                Documento.ShowDialog();
                GrdAdjudicacion.DataSource = NegDocumentacion.CnsDtConsultaStrId("EstadosAdj", "Pagado");
            }
        }

        private void BtnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdAdjudicacion);
        }

        private void BtnExportarPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarPdf(GrdAdjudicacion);
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(GrdAdjudicacion, "NEGOCIOS PAGADOS");
        }

        private void GrdAdjudicacion_DoubleClick(object sender, System.EventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount == 0)
            {
                NegDocumentacion_Error_Event_String_negConsultas("No Ahy Negocios Pagados");
            }
            else
            {
                string Docu = GrvAdjudicacion.GetFocusedRowCellValue("Documentacion").ToString();
                if (Docu == "Recibido")
                {
                    string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                    XtraDocumentacion Documento = new XtraDocumentacion(CadenaConexion, IdAdj, "Tramite Escrituracion");
                    Documento.ShowDialog();
                    GrdAdjudicacion.DataSource = NegDocumentacion.CnsDtConsultaStrId("EstadosAdj", "Pagado");
                }
                else
                {
                    NegDocumentacion_Error_Event_String_negConsultas("Documento Pagado No ha Sido Aceptado");
                }
            }
        }

        private void GrvAdjudicacion_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            string Documen = (GrvAdjudicacion.GetFocusedRowCellValue("Documentacion").ToString());
            if (Documen != "Recibido")
            {
                BtnEnviarTramite.Enabled = false;
                BtnAceptar.Enabled = true;
            }
            else
            {
                BtnEnviarTramite.Enabled = true;
                BtnAceptar.Enabled = false;
            }
        }

        private void GrvAdjudicacion_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string Documen = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Documentacion"]);
                if (Documen != "Recibido")
                {
                    e.Appearance.BackColor = Color.Red;
                    //e.Appearance.ForeColor = Color.White;
                }
            }
        }

        #endregion Metodos
    }
}