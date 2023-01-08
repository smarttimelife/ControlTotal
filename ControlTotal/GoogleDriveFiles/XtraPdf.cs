namespace ControlTotal
{
    public partial class XtraPdf : DevExpress.XtraEditors.XtraForm
    {
        public XtraPdf(System.IO.MemoryStream stream1, string titulo)
        {
            InitializeComponent();
            pdfViewer1.LoadDocument(stream1);
            this.Text = titulo;
        }
    }
}