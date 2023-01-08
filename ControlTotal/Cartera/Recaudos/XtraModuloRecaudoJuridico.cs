using Conexiones;
using DevExpress.XtraSplashScreen;
using NegociosCartera;

namespace ControlTotal
{
    public partial class XtraModuloRecaudoJuridico : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CadenaConexionMysql CadenaConexion;
        private negRecaudos NegRecaudos;
        private string StrModulo;

        public XtraModuloRecaudoJuridico(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegRecaudos = new negRecaudos(CadenaConexion);
            StrModulo = strModulo;
            GrdAdjudicacion.DataSource = NegRecaudos.CnsDtConsulta("Juridico");

            BtnAdicionar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Adicionar;
            //BtnModificar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Modificar;
            //BtnEliminar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Eliminar;
            BtnImprimir.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
            BtnExportar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
            BtnEstadoCuenta.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == "C009").Imprimir;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            Utilidades utilidades = new Utilidades();
            utilidades.impirmir(GrdAdjudicacion, "LISTADO GENERAL DE CARTERA JURIDICA", CadenaConexion.Logeo.Logo);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdAdjudicacion);
        }

        private void BtnEstadoCuenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            XtraRptEstadoCuenta Documento = new XtraRptEstadoCuenta(CadenaConexion, IdAdj);
            Documento.ShowDialog();
        }

        private void BtnRecaudosDetallados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            XtraRecaudoDetallado Documento = new XtraRecaudoDetallado(CadenaConexion, IdAdj);
            Documento.ShowDialog();
        }

        private void BtnAdicionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnAdicionar.Enabled = false;
            string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            XtraFuentePago Documento1 = new XtraFuentePago(CadenaConexion);
            Documento1.ShowDialog();

            if (XtraFuentePago.botonpresionado == "ACEPTAR")
            {
                XtraRcdJuridico Documento = new XtraRcdJuridico(CadenaConexion, XtraFuentePago.StrFuenteRecibo, IdAdj);
                XtraFuentePago.botonpresionado = string.Empty;
                XtraFuentePago.strfuente = string.Empty;
                Documento.ShowDialog();
            }
            else
            {
                XtraFuentePago.botonpresionado = string.Empty;
                XtraFuentePago.strfuente = string.Empty;
            }
            BtnAdicionar.Enabled = true;
        }
    }
}