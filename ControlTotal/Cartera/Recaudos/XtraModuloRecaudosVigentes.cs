namespace ControlTotal
{
    #region Librerias

    using Conexiones;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA

    #endregion Librerias

    public partial class XtraModuloRecaudosVigentes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negRecaudos NegRecaudos;
        private string StrModulo;

        #endregion Propiedades

        #region Constructores

        public XtraModuloRecaudosVigentes(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegRecaudos = new negRecaudos(CadenaConexion);
            StrModulo = strModulo;
            GrdAdjudicacion.DataSource = NegRecaudos.CnsDtConsulta("Cartera");
            BtnAdicionar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Adicionar;
            BtnModificar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Modificar;
            BtnEliminar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Eliminar;
            BtnImprimir.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
            BtnExportar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
            BtnEstadoCuenta.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == "C009").Imprimir;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Metodos

        private void BtnAdicionar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAdicionar.Enabled = false;
            string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            decimal NoRadicado = Convert.ToDecimal(GrvAdjudicacion.GetFocusedRowCellValue("RcdNoRadicado"));

            if (NoRadicado > 0)
            {
                XtraMessageBox.Show("Cliente Tienes Recaudos No Radicados Pendientes", "Recaudos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraFuentePago Documento1 = new XtraFuentePago(CadenaConexion);
                Documento1.ShowDialog();

                if (XtraFuentePago.botonpresionado == "ACEPTAR")
                {
                    XtraRecaudos Documento = new XtraRecaudos(CadenaConexion, XtraFuentePago.StrFuenteRecibo, IdAdj);
                    XtraFuentePago.botonpresionado = string.Empty;
                    XtraFuentePago.strfuente = string.Empty;
                    Documento.ShowDialog();
                }
                else
                {
                    XtraFuentePago.botonpresionado = string.Empty;
                    XtraFuentePago.strfuente = string.Empty;
                }
            }
            BtnAdicionar.Enabled = true;
        }

        private void GrvAdjudicacion_DoubleClick(object sender, EventArgs e)
        {
            BtnAdicionar.Enabled = false;
            string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            XtraFuentePago Documento1 = new XtraFuentePago(CadenaConexion);
            Documento1.ShowDialog();

            if (XtraFuentePago.botonpresionado == "ACEPTAR")
            {
                XtraRecaudos Documento = new XtraRecaudos(CadenaConexion, XtraFuentePago.StrFuenteRecibo, IdAdj);
                XtraFuentePago.botonpresionado = string.Empty;
                XtraFuentePago.strfuente = string.Empty;
                Documento.Show();
            }
            else
            {
                XtraFuentePago.botonpresionado = string.Empty;
                XtraFuentePago.strfuente = string.Empty;
            }
            BtnAdicionar.Enabled = true;
        }

        private void BtnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void BtnImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            Utilidades utilidades = new Utilidades();
            utilidades.impirmir(GrdAdjudicacion, "LISTADO GENERAL DE CARTERA", CadenaConexion.Logeo.Logo);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnExportar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdAdjudicacion);
        }

        private void BtnRecaudosDetallados_ItemClick(object sender, ItemClickEventArgs e)
        {
            string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            XtraRecaudoDetallado Documento = new XtraRecaudoDetallado(CadenaConexion, IdAdj);
            Documento.ShowDialog();
        }

        private void BtnEstadoCuenta_ItemClick(object sender, ItemClickEventArgs e)
        {
            string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            XtraRptEstadoCuenta Documento = new XtraRptEstadoCuenta(CadenaConexion, IdAdj);
            Documento.ShowDialog();
        }

        #endregion Metodos

        private void BtnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            XtraModificarRecaudos Documento = new XtraModificarRecaudos(CadenaConexion, IdAdj);
            Documento.Show();
        }

        private void BtnModificar_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}