using DevExpress.XtraEditors;
using System.Drawing;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class XtraImagen : DevExpress.XtraEditors.XtraForm
    {
        private System.IO.MemoryStream stream1;

        public XtraImagen(System.IO.MemoryStream stream, string strTitulo)
        {
            InitializeComponent();
            stream1 = stream;
            this.Text = strTitulo;
        }

        private void XtraImagen_Load(object sender, System.EventArgs e)
        {
            try
            {
                pictureEdit1.EditValue = Image.FromStream(stream1);
            }
            catch (System.Exception)
            {
                XtraMessageBox.Show("Formato No Admitido", "Vista de Imagenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}