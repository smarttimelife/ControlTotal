using Conexiones;
using DevExpress.XtraSplashScreen;
using NegociosCartera;

namespace ControlTotal
{
    public partial class XtraRptAdjudicacion : DevExpress.XtraEditors.XtraForm
    {
        public XtraRptAdjudicacion(CadenaConexionMysql cadenaConexion, string IdAdjudicacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            RptAdjudicacion xtraReport1 = new RptAdjudicacion(cadenaConexion.Logeo.Logo);

            negReportes Rpt = new negReportes(cadenaConexion, IdAdjudicacion);

            xtraReport1.DataSource = Rpt.DtFinanciacion;
            xtraReport1.Parameters["Titulo"].Value = "REPORTE DE ADJUDICACION";
            xtraReport1.Parameters["Fecha"].Value = Rpt.DtAdjudicacion.Rows[0]["Fecha"];
            xtraReport1.Parameters["Cliente"].Value = Rpt.DtAdjudicacion.Rows[0]["TitularPrincipal"];
            xtraReport1.Parameters["Adjudicacion"].Value = Rpt.DtAdjudicacion.Rows[0]["IdAdjudicacion"];
            xtraReport1.Parameters["Venta"].Value = Rpt.DtAdjudicacion.Rows[0]["Valor"];
            xtraReport1.Parameters["Contado"].Value = Rpt.DtAdjudicacion.Rows[0]["Contado"];
            xtraReport1.Parameters["Inicial"].Value = Rpt.DtAdjudicacion.Rows[0]["CuotaInicial"];
            xtraReport1.Parameters["Financiacion"].Value = Rpt.DtAdjudicacion.Rows[0]["Financiacion"];
            xtraReport1.Parameters["CuotaFnc"].Value = Rpt.DtAdjudicacion.Rows[0]["CuotaFnc"];
            xtraReport1.Parameters["PlazoFnc"].Value = Rpt.DtAdjudicacion.Rows[0]["PlazoFnc"];
            xtraReport1.Parameters["Extraordinaria"].Value = Rpt.DtAdjudicacion.Rows[0]["Extraordinaria"];
            xtraReport1.Parameters["CuotaExtra"].Value = Rpt.DtAdjudicacion.Rows[0]["CuotaExtra"];
            xtraReport1.Parameters["PlazoExtra"].Value = Rpt.DtAdjudicacion.Rows[0]["PlazoExtra"];
            xtraReport1.Parameters["Contrato"].Value = Rpt.DtAdjudicacion.Rows[0]["Contrato"];
            xtraReport1.Parameters["FechaEntrega"].Value = Rpt.DtAdjudicacion.Rows[0]["FechaEntrega"];
            xtraReport1.Parameters["IdInmueble"].Value = Rpt.DtAdjudicacion.Rows[0]["IdInmueble"];
            documentViewer1.DocumentSource = xtraReport1;
            xtraReport1.CreateDocument();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }
    }
}