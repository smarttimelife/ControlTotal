using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using ModelCartera;
using System.IO;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class Ppruebas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private GoogleDoc GoogleDoc = new GoogleDoc();
        private string strRuta = string.Empty;

        public Ppruebas()
        {
            InitializeComponent();
            GoogleDoc.Error_Event_GoogleDoc += GoogleDoc_Error_Event_GoogleDoc;
            GoogleDoc.Ok_Event_GoogleDoc += GoogleDoc_Ok_Event_GoogleDoc;
            GoogleDoc.Error_Event_String += GoogleDoc_Error_Event_String;
            GoogleDoc.Ok_Event_String += GoogleDoc_Ok_Event_String;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Buscar Archivo";
            dlg.Filter = "Todos Los Archivos PDF | *.pdf";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.TxtPath.EditValue = dlg.FileName;
                this.TxtName.EditValue = dlg.SafeFileName;
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            GoogleDoc.FileUpload(TxtPath.EditValue.ToString(), TxtName.EditValue.ToString());
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            string idc = "1S3Gt9WGAlpKmKVO4ybwkKElWZM0tK3s_";
            GoogleDoc.FileUploadInFolder(idc, TxtPath.EditValue.ToString(), TxtName.EditValue.ToString());
        }

        private void BtnAbrirDocumento_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView2.DataRowCount > 0)
            {
                string Id = (gridView2.GetFocusedRowCellValue("Id").ToString());
                string IdWeb = (gridView2.GetFocusedRowCellValue("WebViewLink").ToString());
                //string a= GoogleDoc.DownloadGoogleFile(Id);
                //WebBrowser web = new WebBrowser();
                //web.Navigate(a, true);
                //web.Show();
                XtraWeb miweb = new XtraWeb(IdWeb);
                miweb.Show();
            }
            else
            {
                XtraMessageBox.Show("No Ahy Resgistros ", "¨Pruebas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDescargar_ItemClick(object sender, ItemClickEventArgs e)
        {
            string IdWeb = (gridView2.GetFocusedRowCellValue("Id").ToString());
            string Name = (gridView2.GetFocusedRowCellValue("Name").ToString());
            System.IO.MemoryStream myFileStream = new System.IO.MemoryStream();
            string extension = (gridView2.GetFocusedRowCellValue("MimeType").ToString());
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            if (extension == "application/pdf")
            {
                XtraPdf Documento = new XtraPdf(GoogleDoc.DownloaaFile(IdWeb), Name);
                Documento.Show();
            }
            else
            if (extension == "image/jpeg" || extension == "image/svg+xml" || extension == "image/png" || extension == "image/x-icon")
            {
                XtraImagen xtr = new XtraImagen(GoogleDoc.DownloaaFile(IdWeb), Name);
                xtr.Show();
            }
            else

             if (extension == "application/vnd.openxmlformats-officedocument.wordprocessingml.document" || extension == "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                XtraDocx doc = new XtraDocx(GoogleDoc.DownloaaFile(IdWeb));
                doc.Show();
            }
            else
            {
                XtraMessageBox.Show("Formato No Admitido", "Modulo Pruebas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void FileUploadInFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Buscar Archivo";
            dlg.Filter = "Todos Los Archivos PDF | *.pdf";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.TxtPath.EditValue = dlg.FileName;
                this.TxtName.EditValue = dlg.SafeFileName;
            }
        }

        private void GetContainsInFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            string idc = "1S3Gt9WGAlpKmKVO4ybwkKElWZM0tK3s_";
            gridControl2.DataSource = GoogleDoc.GetContainsInFolder(idc);
        }

        private void GetDriveFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl2.DataSource = GoogleDoc.GetDriveFiles();
        }

        private void GoogleDoc_Error_Event_GoogleDoc(string mensaje, googledrivefile googledoc)
        {
            XtraMessageBox.Show(mensaje, "Modulo Pruebas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TxtName.EditValue = googledoc.IdGoogle;
            FileUploadInFolder.Enabled = true;
        }

        private void GoogleDoc_Error_Event_String(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Modulo Pruebas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GoogleDoc_Ok_Event_GoogleDoc(string mensaje, googledrivefile googledoc)
        {
            XtraMessageBox.Show(mensaje, "Modulo Pruebas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtId.EditValue = googledoc.IdGoogle;
            FileUploadInFolder.Enabled = true;
        }

        private void GoogleDoc_Ok_Event_String(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Modulo Pruebas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView2_DoubleClick(object sender, System.EventArgs e)
        {
            if (gridView2.DataRowCount > 0)
            {
                string IdWeb = (gridView2.GetFocusedRowCellValue("Id").ToString());
                string Name = (gridView2.GetFocusedRowCellValue("Name").ToString());
                System.IO.MemoryStream myFileStream = new System.IO.MemoryStream();
                string extension = Path.GetExtension(Name);
            }
            if (gridView2.DataRowCount > 0)
            {
                string IdWeb = (gridView2.GetFocusedRowCellValue("WebViewLink").ToString());
                XtraWeb documento = new XtraWeb(IdWeb);
                documento.Show();
            }
            else
            {
                XtraMessageBox.Show("No Ahy Resgistros ", "¨Pruebas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}