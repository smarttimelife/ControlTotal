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
    //FECHA CREACION ABRIL 8 2020 8:21AM

    #endregion Librerias

    public partial class XtraModuloEmpresas : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negEmpresas NegEmpresas;
        private string StrModulo = string.Empty;
        private int count = 0;

        #endregion Propiedades

        #region Constructores

        public XtraModuloEmpresas(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            StrModulo = strModulo;
            CadenaConexion = cadenaConexion;
            NegEmpresas = new negEmpresas(CadenaConexion, StrModulo);
            NegEmpresas.Event_ErrorTableNgConsultas += NegEmpresas_Event_ErrorTableNgConsultas;
            GrdEmpresas.DataSource = NegEmpresas.CnsEmpresas();

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegEmpresas_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show("Se Presento El Sgte Error: " + mensaje, "Modulo de Empresas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        #endregion Disparadores

        #region Metodos

        private void BtnImprimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            Utilidades utilidades = new Utilidades();
            utilidades.impirmir(GrdEmpresas, "LISTADO GENERAL DE EMPRESAS", CadenaConexion.Logeo.Logo);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnAdicionar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAdicionar.Enabled = false;
            XtraEmpresas Documento = new XtraEmpresas(CadenaConexion, StrModulo);
            Documento.ShowDialog();
            BtnAdicionar.Enabled = true;
        }

        private void BtnModificar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnModificar.Enabled = false;
            int Id = Convert.ToInt32(GrvEmpresa.GetFocusedRowCellValue("Id").ToString());
            XtraEmpresas Documento = new XtraEmpresas(CadenaConexion, StrModulo, "Modificar", Id);
            Documento.ShowDialog();
            BtnModificar.Enabled = true;
        }

        private void BtnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnModificar.Enabled = false;
            int Id = Convert.ToInt32(GrvEmpresa.GetFocusedRowCellValue("Id").ToString());
            XtraEmpresas Documento = new XtraEmpresas(CadenaConexion, StrModulo, "Eliminar", Id);
            Documento.ShowDialog();
            BtnModificar.Enabled = true;
        }

        private void XtraModuloEmpresas_Activated(object sender, EventArgs e)
        {
            if (count > 0)
            {
                GrdEmpresas.DataSource = NegEmpresas.CnsEmpresas();
            }
            count += 1;
        }

        private void BtnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion Metodos

        private void XtraModuloEmpresas_Load(object sender, EventArgs e)
        {
            BtnAdicionar.Links[0].Visible = NegEmpresas.MysPermisos.Adicionar;
            BtnModificar.Links[0].Visible = NegEmpresas.MysPermisos.Modificar;
            BtnEliminar.Links[0].Visible = NegEmpresas.MysPermisos.Eliminar;
            BtnImprimir.Links[0].Visible = NegEmpresas.MysPermisos.Imprimir;
        }
    }
}