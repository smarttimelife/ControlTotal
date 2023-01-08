namespace ControlTotal
{
    #region Librerias

    using Administracion;
    using Conexiones;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Data;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    // ABRIL 05 2020 8:08 AM

    #endregion Librerias

    public partial class XtraModuloUsuarios : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negUsurios NegUsurios;
        private string StrModulo = string.Empty;

        #endregion Propiedades

        #region Constructores

        public XtraModuloUsuarios(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrModulo = strModulo;
            NegUsurios = new negUsurios(CadenaConexion, StrModulo);
            NegUsurios.Event_ErrorTableNgConsultas += NegUsurios_Event_ErrorTableNgConsultas;

            GrdUsuarios.DataSource = NegUsurios.CnsUsuarios_Vigentes();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegUsurios_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Modulo de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Disparadores

        #region Metodos

        private void BtnAdicionar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAdicionar.Enabled = false;
            XtraUsuarios Documento = new XtraUsuarios(CadenaConexion, StrModulo);
            Documento.ShowDialog();
            BtnAdicionar.Enabled = true;
            GrdUsuarios.DataSource = NegUsurios.CnsUsuarios_Vigentes();
        }

        private void BtnBloquear_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnBloquear.Enabled = false;
            int Id = Convert.ToInt32(GrvUsuarios.GetFocusedRowCellValue("Id").ToString());
            XtraUsuarios Documento = new XtraUsuarios(CadenaConexion, StrModulo, "Bloquear", Id);
            Documento.ShowDialog();
            BtnBloquear.Enabled = true;
            GrdUsuarios.DataSource = NegUsurios.CnsUsuarios_Vigentes();
        }

        private void BtnDesbloquear_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnDesbloquear.Enabled = false;
            int Id = Convert.ToInt32(GrvUsuarios.GetFocusedRowCellValue("Id").ToString());
            XtraUsuarios Documento = new XtraUsuarios(CadenaConexion, StrModulo, "Desbloquear", Id);
            Documento.ShowDialog();
            BtnDesbloquear.Enabled = true;
            GrdUsuarios.DataSource = NegUsurios.CnsUsuarios_Vigentes();
        }

        private void BtnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnEliminar.Enabled = false;
            int Id = Convert.ToInt32(GrvUsuarios.GetFocusedRowCellValue("Id").ToString());
            XtraUsuarios Documento = new XtraUsuarios(CadenaConexion, StrModulo, "Eliminar", Id);
            Documento.ShowDialog();
            BtnEliminar.Enabled = true;
            GrdUsuarios.DataSource = NegUsurios.CnsUsuarios_Vigentes();
        }

        private void BtnImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            Utilidades utilidades = new Utilidades();
            utilidades.impirmir(GrdUsuarios, "LISTADO GENERAL DE USUARIOS", CadenaConexion.Logeo.Logo);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnModificar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnModificar.Enabled = false;
            int Id = Convert.ToInt32(GrvUsuarios.GetFocusedRowCellValue("Id").ToString());
            XtraUsuarios Documento = new XtraUsuarios(CadenaConexion, StrModulo, "Modificar", Id);
            Documento.ShowDialog();
            BtnModificar.Enabled = true;

            GrdUsuarios.DataSource = NegUsurios.CnsUsuarios_Vigentes();
        }

        private void BtnReasignar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnReasignar.Enabled = false;
            int Id = Convert.ToInt32(GrvUsuarios.GetFocusedRowCellValue("Id").ToString());
            XtraReasignarClaves Documento = new XtraReasignarClaves(CadenaConexion, StrModulo, Id, "Reasignar");
            Documento.ShowDialog();
            BtnReasignar.Enabled = true;
            GrdUsuarios.DataSource = NegUsurios.CnsUsuarios_Vigentes();
        }

        private void BtnUsuarioProyectos_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnUsuarioProyectos.Enabled = false;
            int Id = Convert.ToInt32(GrvUsuarios.GetFocusedRowCellValue("Id").ToString());
            XtraUsuarioProyectos Documento = new XtraUsuarioProyectos(CadenaConexion, Id);
            Documento.ShowDialog();
            BtnUsuarioProyectos.Enabled = true;
            GrdUsuarios.DataSource = NegUsurios.CnsUsuarios_Vigentes();
        }

        private void GrvUsuarios_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            string Nomina = (GrvUsuarios.GetFocusedRowCellValue("Estado").ToString());
            switch (Nomina)
            {
                case "Vigente":
                    BtnModificar.Enabled = true;
                    BtnBloquear.Enabled = true;
                    BtnDesbloquear.Enabled = false;
                    BtnEliminar.Enabled = true;
                    break;

                case "Bloqueado":
                    BtnModificar.Enabled = false;
                    BtnBloquear.Enabled = false;
                    BtnDesbloquear.Enabled = true;
                    BtnEliminar.Enabled = false;
                    break;

                default:

                    break;
            }
        }

        private void XtraModuloUsuarios_Load(object sender, EventArgs e)
        {
            BtnAdicionar.Links[0].Visible = NegUsurios.MysPermisos.Adicionar;
            BtnModificar.Links[0].Visible = NegUsurios.MysPermisos.Modificar;
            BtnEliminar.Links[0].Visible = NegUsurios.MysPermisos.Eliminar;
            BtnImprimir.Links[0].Visible = NegUsurios.MysPermisos.Imprimir;
            BtnBloquear.Links[0].Visible = NegUsurios.MysPermisos.Eliminar;
            BtnDesbloquear.Links[0].Visible = NegUsurios.MysPermisos.Eliminar;
            BtnReasignar.Links[0].Visible = NegUsurios.MysPermisos.Adicionar;
        }

        #endregion Metodos

    }
}