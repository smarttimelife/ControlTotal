using DevExpress.XtraPrinting.Drawing;
using System.Drawing;

namespace ControlTotal
{
    public partial class RptEstadoCuenta : DevExpress.XtraReports.UI.XtraReport
    {
        public RptEstadoCuenta()
        {
            InitializeComponent();
        }

        public RptEstadoCuenta(byte[] image)
        {
            InitializeComponent();
            if (image != null)
            {
                PtbLogo.ImageSource = new ImageSource(byteArrayToImage(image));
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (System.IO.MemoryStream mStream = new System.IO.MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }
    }
}