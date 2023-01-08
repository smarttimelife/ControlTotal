using Conexiones;
using DevExpress.XtraSplashScreen;
using NegociosCartera;
using System.Data;

namespace ControlTotal
{
    public partial class XtraRptReciboCaja : DevExpress.XtraEditors.XtraForm
    {
        public XtraRptReciboCaja(CadenaConexionMysql cadenaConexion, string IdRecaudo, decimal Valor)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            RptReciboCaja xtraReport1 = new RptReciboCaja(cadenaConexion.Logeo.Logo);
            negReportes Rpt = new negReportes(cadenaConexion);

            DataTable DtRecaudos = Rpt.CnsDtConsultaStrId("ReciboCaja", IdRecaudo);
            if (DtRecaudos.Rows.Count > 0)
            {
                xtraReport1.DataSource = DtRecaudos;
                DataTable DtAdjudicacion = Rpt.CnsDtConsultaStrId("Adjudicacion", DtRecaudos.Rows[0]["IdAdjudicacion"].ToString());
                xtraReport1.Parameters["Titulo"].Value = "RECIBO DE CAJA";
                xtraReport1.Parameters["Cliente"].Value = DtAdjudicacion.Rows[0]["TitularPrincipal"];
                xtraReport1.Parameters["IdAdjudicacion"].Value = DtAdjudicacion.Rows[0]["IdAdjudicacion"];
                xtraReport1.Parameters["Contrato"].Value = DtAdjudicacion.Rows[0]["Contrato"];
                xtraReport1.Parameters["IdInmueble"].Value = DtAdjudicacion.Rows[0]["IdInmueble"];
                xtraReport1.Parameters["Valor"].Value = Valor;

                documentViewer1.DocumentSource = xtraReport1;
                xtraReport1.CreateDocument();
            }
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }
    }
}