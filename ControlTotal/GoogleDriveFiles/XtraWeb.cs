using System;

namespace ControlTotal
{
    public partial class XtraWeb : DevExpress.XtraEditors.XtraForm
    {
        public XtraWeb(string ruta)
        {
            InitializeComponent();
            webBrowser1.Navigate(new Uri(ruta));
        }
    }
}