namespace ControlTotal
{
    public partial class XtraDocx : DevExpress.XtraEditors.XtraForm
    {
        public XtraDocx(System.IO.MemoryStream stream1)
        {
            InitializeComponent();
            richEditControl1.LoadDocument(stream1);
        }
    }
}