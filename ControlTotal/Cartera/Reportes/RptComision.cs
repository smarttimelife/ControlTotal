using DevExpress.XtraPrinting.Drawing;
using System.Drawing;
using System.IO;

namespace ControlTotal
{
    public partial class RptComision : DevExpress.XtraReports.UI.XtraReport
    {
        public RptComision(byte[] image)
        {
            InitializeComponent();
            if (image != null)
            {
                PtbLogo.ImageSource = new ImageSource(byteArrayToImage(image));
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }
    }
}