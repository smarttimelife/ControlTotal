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
    // MAYO 15 DEL 2020

    #endregion Librerias

    public partial class XtraModuloOtrosi : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negOtrosi NegOtrosi;
        private string StrModulo = string.Empty;

        #endregion Propiedades

        #region Constructores

        public XtraModuloOtrosi(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrModulo = strModulo;
            NegOtrosi = new negOtrosi(CadenaConexion);
            Inicio();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Metodos

        private void BtnAdicionar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraOtrosi Documento = new XtraOtrosi(CadenaConexion);
            Documento.ShowDialog();
            GrdOtrosi.DataSource = NegOtrosi.CnsDtConsulta("Otrosi");
        }

        private void BtnAprobar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount > 0)
            {
                int Id = Convert.ToInt32(GrvAdjudicacion.GetFocusedRowCellValue("IdOtrosi"));
                BtnAprobar.Enabled = false;
                XtraOtrosi Documento = new XtraOtrosi(CadenaConexion, Id, "Aprobar");
                Documento.ShowDialog();
                BtnAprobar.Enabled = true;
                GrdOtrosi.DataSource = NegOtrosi.CnsDtConsulta("Otrosi");
            }
            else
            {
                XtraMessageBox.Show("No ahy Otrosi Para Aprobar", "Modulo Otrosi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount > 0)
            {
                int Id = Convert.ToInt32(GrvAdjudicacion.GetFocusedRowCellValue("IdOtrosi"));
                BtnAprobar.Enabled = false;
                XtraOtrosi Documento = new XtraOtrosi(CadenaConexion, Id, "Eliminar");
                Documento.ShowDialog();
                BtnAprobar.Enabled = true;
                GrdOtrosi.DataSource = NegOtrosi.CnsDtConsulta("Otrosi");
            }
            else
            {
                XtraMessageBox.Show("No ahy Otrosi Para Eliminar", "Modulo Otrosi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImprimiOtrosi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount > 0)
            {
                string IdTransaccion = GrvAdjudicacion.GetFocusedRowCellValue("IdTransaccion").ToString();
                string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                BtnImprimiOtrosi.Enabled = false;
                XtraRptOtrosi Documento = new XtraRptOtrosi(CadenaConexion, IdTransaccion, IdAdj);
                Documento.ShowDialog();
                BtnImprimiOtrosi.Enabled = true;
                GrdOtrosi.DataSource = NegOtrosi.CnsDtConsulta("Otrosi");
            }
            else
            {
                XtraMessageBox.Show("No ahy Otrosi Para Imprimir", "Modulo Otrosi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            Utilidades utilidades = new Utilidades();
            utilidades.impirmir(GrdOtrosi, "LISTADO GENERAL DE OTROSI");
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            GrdOtrosi.DataSource = NegOtrosi.CnsDtConsulta("Otrosi");
        }

        private void BtnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void Inicio()
        {
           
           
            GrdOtrosi.DataSource = NegOtrosi.CnsDtConsulta("Otrosi");
        }

        #endregion Metodos

        private void BtnExportarExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdOtrosi);
        }

        private void XtraModuloOtrosi_Load(object sender, EventArgs e)
        {
            BtnImprimiOtrosi.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
            BtnCorrerFechas.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == "C308").Adicionar;
            BtnAdicionar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Adicionar;
            BtnAprobar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Eliminar;
            BtnAprobar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Aprobar;
            BtnImprimir.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
            BtnEliminar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Eliminar;
        }

        private void BtnCorrerFechas_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}