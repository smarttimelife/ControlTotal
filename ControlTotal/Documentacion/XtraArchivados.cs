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

    public partial class XtraArchivados : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negDocumentacion NegDocumentacion;

        #endregion Propiedades

        #region Constructor

        public XtraArchivados(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegDocumentacion = new negDocumentacion(CadenaConexion);
            NegDocumentacion.Error_Event_String_NegDocumentacion += NegDocumentacion_Error_Event_String_negConsultas;
            NegDocumentacion.Event_ErrorTableNgConsultas += NegDocumentacion_Event_ErrorTableNgConsultas;
            GrdAdjudicacion.DataSource = NegDocumentacion.CnsDtConsultaStrId("EstadosAdj", "Archivados");
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void NegDocumentacion_Error_Event_String_negConsultas(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Tramite Escrituracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegDocumentacion_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "PagTramite Escrituraciondos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos

        private void BtnAceptar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount == 0)
            {
                NegDocumentacion_Error_Event_String_negConsultas("No Ahy Negocios Archivados");
            }
            else
            {
                string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                XtraAceptarDocumento Documento = new XtraAceptarDocumento(CadenaConexion, IdAdj, "Archivados");
                Documento.ShowDialog();
                GrdAdjudicacion.DataSource = NegDocumentacion.CnsDtConsultaStrId("EstadosAdj", "Archivados");
            }
        }

        private void BtnEnviarCerrado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount == 0)
            {
                NegDocumentacion_Error_Event_String_negConsultas("No Ahy Negocios Para Cerrar");
            }
            else
            {
                string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                XtraDocumentacion Documento = new XtraDocumentacion(CadenaConexion, IdAdj, "Cerrado");
                Documento.ShowDialog();
                GrdAdjudicacion.DataSource = NegDocumentacion.CnsDtConsultaStrId("EstadosAdj", "Archivados");
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
            Operaciones.impirmir(GrdAdjudicacion, "NEGOCIOS ARCHIVADOS");
        }

        private void GrdAdjudicacion_DoubleClick(object sender, System.EventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount == 0)
            {
                NegDocumentacion_Error_Event_String_negConsultas("No Ahy Negocios Para Cerrar");
            }
            else
            {
                string Docu = GrvAdjudicacion.GetFocusedRowCellValue("Documentacion").ToString();
                if (Docu == "Recibido")
                {
                    string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                    XtraDocumentacion Documento = new XtraDocumentacion(CadenaConexion, IdAdj, "Cerrado");
                    Documento.ShowDialog();
                    GrdAdjudicacion.DataSource = NegDocumentacion.CnsDtConsultaStrId("EstadosAdj", "Archivados");
                }
                else
                {
                    NegDocumentacion_Error_Event_String_negConsultas("Documento Archivado No Sido Aceptado");
                }
            }
        }

        private void GrvAdjudicacion_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            string Documen = (GrvAdjudicacion.GetFocusedRowCellValue("Documentacion").ToString());
            if (Documen != "Recibido")
            {
                BtnEnviarCerrado.Enabled = false;
                BtnAceptar.Enabled = true;
            }
            else
            {
                BtnEnviarCerrado.Enabled = true;
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