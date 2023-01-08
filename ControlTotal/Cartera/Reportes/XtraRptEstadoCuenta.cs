using Conexiones;
using DevExpress.XtraSplashScreen;
using NegociosCartera;
using System.Data;

namespace ControlTotal
{
    public partial class XtraRptEstadoCuenta : DevExpress.XtraEditors.XtraForm
    {
        public XtraRptEstadoCuenta(CadenaConexionMysql cadenaConexion, string IdAdjudicacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            negReportes Rpt = new negReportes(cadenaConexion, IdAdjudicacion);

            RptEstadoCuenta xtraReport1 = new RptEstadoCuenta(cadenaConexion.Logeo.Logo);
            xtraReport1.DataSource = Rpt.CnsDtConsultaStrId("Extracto", IdAdjudicacion);

            DataTable DtAdjudicacion = Rpt.CnsDtConsultaStrId("ViewAdjudicacion", IdAdjudicacion);

            xtraReport1.Parameters["Cliente"].Value = DtAdjudicacion.Rows[0]["TitularPrincipal"];
            xtraReport1.Parameters["IdAdjudicacion"].Value = DtAdjudicacion.Rows[0]["IdAdjudicacion"];
            xtraReport1.Parameters["VrLote"].Value = DtAdjudicacion.Rows[0]["Valor"];
            xtraReport1.Parameters["Direccion"].Value = DtAdjudicacion.Rows[0]["Direccion"];
            xtraReport1.Parameters["Ciudad"].Value = DtAdjudicacion.Rows[0]["Ciudad"];
            xtraReport1.Parameters["Saldo"].Value = DtAdjudicacion.Rows[0]["Saldo"];
            xtraReport1.Parameters["IdInmueble"].Value = DtAdjudicacion.Rows[0]["IdInmueble"];
            xtraReport1.Parameters["VrCanje"].Value = DtAdjudicacion.Rows[0]["Canje"];
            documentViewer1.DocumentSource = xtraReport1;
            xtraReport1.CreateDocument();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }
    }
}