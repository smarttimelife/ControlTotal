using Cartera;
using Conexiones;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class XtraCnsComisionGestor : DevExpress.XtraEditors.XtraForm
    {
        private CadenaConexionMysql CadenaConexion;
        private negConsultas NegConsultas;
        private BindingSource Bs = new BindingSource();

        public XtraCnsComisionGestor(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegConsultas = new negConsultas(cadenaConexion);
            NegConsultas.Event_ErrorTableNgConsultas += NegConsultas_Event_ErrorTableNgConsultas;
            NegConsultas.Error_Event_String_negConsultas += NegConsultas_Error_Event_String_negConsultas;
            RpsGestor.DataSource = NegConsultas.CnsDtCombox("GestorComision");
            RpsGestor.ValueMember = "IdGestor";
            RpsGestor.DisplayMember = "Gestor";
            Bs.DataSource = NegConsultas.EntDatosConsultas;
            CmbGestor.DataBindings.Add("EditValue", Bs, "IdTercero", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaInicial.DataBindings.Add("EditValue", Bs, "FechaInicial", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaFinal.DataBindings.Add("EditValue", Bs, "FechaFinal", true, DataSourceUpdateMode.OnPropertyChanged);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegConsultas_Error_Event_String_negConsultas(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Consulta Comisiones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnExportarExcel.Enabled = false;
            BtnExportarPdf.Enabled = false;
            BtnImprimir.Enabled = false;
        }

        private void NegConsultas_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Consulta Comisiones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnExportarExcel.Enabled = false;
            BtnExportarPdf.Enabled = false;
            BtnImprimir.Enabled = false;
        }

        private void BtnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            GrdSeguimiento.DataSource = NegConsultas.CnsComisionAsesor();
            if (GrvSeguimiento.DataRowCount > 0)
            {
                BtnExportarExcel.Enabled = true;
                BtnExportarPdf.Enabled = true;
                BtnImprimir.Enabled = true;
            }
            else
            {
                BtnExportarExcel.Enabled = false;
                BtnExportarPdf.Enabled = false;
                BtnImprimir.Enabled = false;
            }
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdSeguimiento);
        }

        private void BtnExportarPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarPdf(GrdSeguimiento);
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(GrdSeguimiento, "CONSULTA COMISIONES DEL" + NegConsultas.EntDatosConsultas.FechaInicial.ToShortDateString()
                                + " AL" + NegConsultas.EntDatosConsultas.FechaFinal.ToShortDateString());
        }
    }
}