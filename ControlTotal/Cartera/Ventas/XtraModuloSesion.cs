namespace ControlTotal
{
    #region Librerias

    using Cartera;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class XtraModuloSesion : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades
        private CadenaConexionMysql CadenaConexion;
        private negConsultas Consultas;
        private string StrModulo = string.Empty;
        private string StrIdAdjudicacion = string.Empty, StrIdCesion = string.Empty, StrEstado = string.Empty;
        #endregion

        #region Constructor
        public XtraModuloSesion(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            StrModulo = strModulo;
            CadenaConexion = cadenaConexion;
            Consultas = new negConsultas(CadenaConexion);
            Consultas.Event_ErrorTableNgConsultas += Consultas_Event_ErrorTableNgConsultas;
            GrdSesion.DataSource = Consultas.CnsDtConsulta("Sesion");
           
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }
        #endregion  

        #region Metodos

        private void BtnAdicionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraSesion Documento = new XtraSesion(CadenaConexion);
            Documento.ShowDialog();
            GrdSesion.DataSource = Consultas.CnsDtConsulta("Sesion");
        }

        private void BtnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvSesion.DataRowCount > 0)
            {
                XtraSesion Documento = new XtraSesion(CadenaConexion, "Modificar", StrIdCesion);
                Documento.ShowDialog();
                GrdSesion.DataSource = Consultas.CnsDtConsulta("Sesion");
            }
            else
            {
                XtraMessageBox.Show("No ahy Sessiones Para Modificar", "Modulo Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvSesion.DataRowCount > 0)
            {
                XtraSesion Documento = new XtraSesion(CadenaConexion, "Eliminar", StrIdCesion);
                Documento.ShowDialog();
                GrdSesion.DataSource = Consultas.CnsDtConsulta("Sesion");
            }
            else
            {
                XtraMessageBox.Show("No ahy Sessiones Para Eliminar", "Modulo Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAprobar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraSesion Documento = new XtraSesion(CadenaConexion, "Aprobar", StrIdCesion);
            Documento.ShowDialog();
            GrdSesion.DataSource = Consultas.CnsDtConsulta("Sesion");
        }

        private void BtnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void XtraModuloSesion_Load(object sender, System.EventArgs e)
        {
            BtnAdicionar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Adicionar;
            BtnModificar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Modificar;
            BtnEliminar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Eliminar;
            BtnAprobar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Aprobar;
        }

        private void GrvSesion_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            StrIdAdjudicacion = GrvSesion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            StrIdCesion = GrvSesion.GetFocusedRowCellValue("IdSesion").ToString();
            StrEstado = GrvSesion.GetFocusedRowCellValue("Estado").ToString();
            switch (StrEstado)
            {
                case "Pendiente":
                    BtnEliminar.Enabled = true;
                    BtnModificar.Enabled = true;
                    BtnAprobar.Enabled = true;
                    break;

                case "Aprobado":
                    BtnEliminar.Enabled = false;
                    BtnModificar.Enabled = false;
                    BtnAprobar.Enabled = false;
                    break;

                default:
                    BtnEliminar.Enabled = false;
                    BtnModificar.Enabled = false;
                    BtnAprobar.Enabled = false;
                    break;
            }
        }

        private void Consultas_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, " Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion 
    }
}