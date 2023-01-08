namespace ControlTotal
{
    #region Librerias

    using Administracion.NegociosAdmin;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    // ABRIL 12 2020 15:07 PM

    #endregion Librerias

    public partial class XtraRoles : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        private BindingSource BsRoles = new BindingSource();
        private CadenaConexionMysql CadenaConexion;
        private negRoles NegRoles;
        private string StrModulo = string.Empty;
        private string StrOperacion = string.Empty;

        #endregion Propiedades

        #region Constructores

        public XtraRoles(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrModulo = strModulo;
            StrOperacion = "Adicionar";
            NegRoles = new negRoles(cadenaConexion);
            NegRoles.ErrorString_Event_Roles += NegRoles_ErrorString_Event_Roles;
            NegRoles.OkString_Event__Roles += NegRoles_OkString_Event__Roles;
            NegRoles.Event_ErrorTableNgConsultas += NegRoles_Event_ErrorTableNgConsultas;
            Inicio();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraRoles(CadenaConexionMysql cadenaConexion, string strModulo, string strOperacion, int IdRol)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrModulo = strModulo;
            StrOperacion = strOperacion;
            NegRoles = new negRoles(cadenaConexion, IdRol);
            TxtNombreRol.EditValue = NegRoles.EntRoles.NombreRol;
            NegRoles.ErrorString_Event_Roles += NegRoles_ErrorString_Event_Roles;
            NegRoles.OkString_Event__Roles += NegRoles_OkString_Event__Roles;
            NegRoles.Event_ErrorTableNgConsultas += NegRoles_Event_ErrorTableNgConsultas;
            Inicio();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegRoles_ErrorString_Event_Roles(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegRoles_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show("Se Presento El Sgte Error " + mensaje + " Se Cerrara esta Ventana", StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        private void NegRoles_OkString_Event__Roles(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Disparadores

        #region Metodos

        private void BtnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Este Rol?", StrOperacion + " Rol de Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                BtnGuardar.Enabled = false;
                NegRoles.EntRoles.NombreRol = TxtNombreRol.Text;
                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegRoles.MtdAdicionar();
                        break;

                    case "Modificar":
                        NegRoles.MtdModificar();
                        break;

                    case "Eliminar":
                        NegRoles.MtdEliminar();
                        break;

                    case "Bloquear":

                        break;

                    case "Desbloquear":

                        break;
                }
            }
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void ChkMarcar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkMarcar.Text == "Marcar Todos")
            {
                NegRoles.MtdMarcar(true);
                ChkMarcar.Text = "Desmarcar Todos";
            }
            else
            {
                NegRoles.MtdMarcar(false);
                ChkMarcar.Text = "Marcar Todos";
            }
        }

        private void Inicio()
        {
            BtnGuardar.Caption = StrOperacion;
            this.Text = StrOperacion + " Rol de Usuarios";
            BsRoles.DataSource = NegRoles.EntRoles;

            RpsSotware.DataSource = NegRoles.CnsSoftware();
            RpsSotware.DisplayMember = "NombreSoftware";
            RpsSotware.ValueMember = "Id";
            GrdRoles.DataSource = NegRoles.DtRolDetalle;
        }

        #endregion Metodos

        private void BtnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}