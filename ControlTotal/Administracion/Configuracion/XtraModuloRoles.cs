namespace ControlTotal
{
    #region Librerias

    using Administracion.NegociosAdmin;
    using Conexiones;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Data;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    // 12 DE ABRIL 2020 20:14 PM

    #endregion Librerias

    public partial class XtraModuloRoles : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negRoles NegRoles;
        private string StrModulo = string.Empty;
        private int count = 0;

        #endregion Propiedades

        #region Constructores

        public XtraModuloRoles(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            StrModulo = strModulo;
            CadenaConexion = cadenaConexion;
            NegRoles = new negRoles(CadenaConexion, StrModulo);

            NegRoles.Event_ErrorTableNgConsultas += NegRoles_Event_ErrorTableNgConsultas;
            GrdRoles.DataSource = NegRoles.CnsRoles();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegRoles_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Modulo de Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos

        private void BtnAdicionar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAdicionar.Enabled = false;
            XtraRoles Documento = new XtraRoles(CadenaConexion, StrModulo);
            Documento.ShowDialog();
            BtnAdicionar.Enabled = true;
            GrdRoles.DataSource = NegRoles.CnsRoles();
        }

        private void BtnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnEliminar.Enabled = false;
            int Id = Convert.ToInt32(GrvRoles.GetFocusedRowCellValue("Id").ToString());
            XtraRoles Documento = new XtraRoles(CadenaConexion, StrModulo, "Eliminar", Id);
            Documento.ShowDialog();
            BtnEliminar.Enabled = true;
            GrdRoles.DataSource = NegRoles.CnsRoles();
        }

        private void BtnImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            Utilidades utilidades = new Utilidades();
            utilidades.impirmir(GrdRoles, "LISTADO GENERAL DE ROLES", CadenaConexion.Logeo.Logo);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnModificar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnModificar.Enabled = false;
            int Id = Convert.ToInt32(GrvRoles.GetFocusedRowCellValue("Id").ToString());
            XtraRoles Documento = new XtraRoles(CadenaConexion, StrModulo, "Modificar", Id);
            Documento.ShowDialog();
            BtnModificar.Enabled = true;
            GrdRoles.DataSource = NegRoles.CnsRoles();
        }

        private void XtraModuloRoles_Activated(object sender, EventArgs e)
        {
            if (count > 0)
            {
                GrdRoles.DataSource = NegRoles.CnsRoles();
            }
            count += 1;
        }

        #endregion Metodos

        private void BtnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void XtraModuloRoles_Load(object sender, EventArgs e)
        {
            BtnAdicionar.Links[0].Visible = NegRoles.MysPermisos.Adicionar;
            BtnModificar.Links[0].Visible = NegRoles.MysPermisos.Modificar;
            BtnEliminar.Links[0].Visible = NegRoles.MysPermisos.Eliminar;
            BtnImprimir.Links[0].Visible = NegRoles.MysPermisos.Imprimir;
        }
    }
}