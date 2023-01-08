using Conexiones;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using NegociosCartera;
using System.Data;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class XtraRptOtrosi : DevExpress.XtraEditors.XtraForm
    {
        public XtraRptOtrosi(CadenaConexionMysql cadenaConexion, string Transaccion, string IdAdjudicacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();

            RptOtrosi xtraReport1 = new RptOtrosi();

            negReportes Reporte = new negReportes(cadenaConexion);
            Reporte.Event_ErrorTableNgConsultas += Rpt_Event_ErrorTableNgConsultas;

            DataTable DtAdjudicacion = Reporte.cnsAdjudicacion(IdAdjudicacion);
            DataTable DtOtrosi = Reporte.CnsDtConsultaStrId("OtrosiPdte", Transaccion);
            DataTable DtFinanciacion = Reporte.CnsDtConsultaStrId("FinanciacionOtrosi", Transaccion);

            xtraReport1.DataSource = DtFinanciacion;
            xtraReport1.Parameters["Titulo"].Value = "REPORTE DE OTROSI";
            xtraReport1.Parameters["Fecha"].Value = DtAdjudicacion.Rows[0]["Fecha"];
            xtraReport1.Parameters["Cliente"].Value = DtAdjudicacion.Rows[0]["TitularPrincipal"];
            xtraReport1.Parameters["IdAdjudicacion"].Value = DtAdjudicacion.Rows[0]["IdAdjudicacion"];
            xtraReport1.Parameters["IdOtrosi"].Value = DtOtrosi.Rows[0]["IdOtrosi"];
            xtraReport1.Parameters["Venta"].Value = DtAdjudicacion.Rows[0]["Valor"];
            xtraReport1.Parameters["Contado"].Value = DtAdjudicacion.Rows[0]["Contado"];
            xtraReport1.Parameters["Inicial"].Value = DtAdjudicacion.Rows[0]["CuotaInicial"];
            xtraReport1.Parameters["Financiacion"].Value = DtAdjudicacion.Rows[0]["Financiacion"];
            xtraReport1.Parameters["CuotaFnc"].Value = DtAdjudicacion.Rows[0]["CuotaFnc"];
            xtraReport1.Parameters["PlazoFnc"].Value = DtAdjudicacion.Rows[0]["PlazoFnc"];
            xtraReport1.Parameters["Extraordinaria"].Value = DtAdjudicacion.Rows[0]["Extraordinaria"];
            xtraReport1.Parameters["CuotaExtra"].Value = DtAdjudicacion.Rows[0]["CuotaExtra"];
            xtraReport1.Parameters["PlazoExtra"].Value = DtAdjudicacion.Rows[0]["PlazoExtra"];
            xtraReport1.Parameters["Contrato"].Value = DtAdjudicacion.Rows[0]["Contrato"];
            xtraReport1.Parameters["IdInmueble"].Value = DtAdjudicacion.Rows[0]["IdInmueble"];
            xtraReport1.Parameters["FechaOtrosi"].Value = DtOtrosi.Rows[0]["Fecha"];
            xtraReport1.Parameters["FechaAbono"].Value = DtOtrosi.Rows[0]["FechaAbono"];
            xtraReport1.Parameters["NuevoCapital"].Value = DtOtrosi.Rows[0]["NuevoCapital"];
            xtraReport1.Parameters["NuevaInicial"].Value = DtOtrosi.Rows[0]["NuevoCuotaInicial"];
            xtraReport1.Parameters["NuevoContado"].Value = DtOtrosi.Rows[0]["NuevoContado"];
            xtraReport1.Parameters["NuevaExtraordinaria"].Value = DtOtrosi.Rows[0]["NuevoExtraordinaria"];
            xtraReport1.Parameters["NuevaFinanciacion"].Value = DtOtrosi.Rows[0]["NuevoFinanciacion"];
            xtraReport1.Parameters["NuevoPlazoFnc"].Value = DtOtrosi.Rows[0]["NuevoPlazoFnc"];
            xtraReport1.Parameters["NuevoPlazoExtra"].Value = DtOtrosi.Rows[0]["NuevoPlazoExtra"];
            xtraReport1.Parameters["NuevaCuotaFnc"].Value = DtOtrosi.Rows[0]["NuevoCuotaFnc"];
            xtraReport1.Parameters["NuevaCuotaExtra"].Value = DtOtrosi.Rows[0]["NuevoCuotaExtra"];
            xtraReport1.Parameters["AbonoCapital"].Value = DtOtrosi.Rows[0]["AbonoCapital"];

            documentViewer1.DocumentSource = xtraReport1;
            xtraReport1.CreateDocument();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void Rpt_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Reporte Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void XtraRptOtrosi_Load(object sender, System.EventArgs e)
        {
        }
    }
}