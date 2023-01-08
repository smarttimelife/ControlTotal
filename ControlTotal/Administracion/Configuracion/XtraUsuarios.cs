namespace ControlTotal
{
    #region Librerias

    using Administracion;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Data;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class XtraUsuarios : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private string StrOperacion = string.Empty;
        private negUsurios NegUsurios;
        private BindingSource BsUsuarios = new BindingSource();

        #endregion Propiedades

        #region Constructores

        public XtraUsuarios(CadenaConexionMysql cadenaConexion, string StrModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegUsurios = new negUsurios(cadenaConexion, StrModulo);
            StrOperacion = "Adicionar";
            Inicio();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraUsuarios(CadenaConexionMysql cadenaConexion, string StrModulo, string strOperacion, int IdUsuario)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            StrOperacion = strOperacion;
            CadenaConexion = cadenaConexion;
            NegUsurios = new negUsurios(cadenaConexion, StrModulo, StrOperacion, IdUsuario);
            Inicio();
            TxtIdUsuario.ReadOnly = true;
            if (strOperacion != "Modificar")
            {
                TxtNombreUsuario.ReadOnly = true;
                TxtCorreoElectronico.ReadOnly = true;
                CmbIdRol.ReadOnly = true;
            }
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegUsurios_OkString_Event_Usuarios(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegUsurios_ErrorString_Event_Usuarios(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnAceptar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegUsurios_Error_Event_TableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show("Se Presento El Sgte Error " + mensaje + " Se Cerrara esta Ventana", StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        #endregion Disparadores

        #region Metodos

        private void Inicio()
        {
            NegUsurios.ErrorString_Event_Usuarios += NegUsurios_ErrorString_Event_Usuarios;
            NegUsurios.OkString_Event__Usuarios += NegUsurios_OkString_Event_Usuarios;
            NegUsurios.Event_ErrorTableNgConsultas += NegUsurios_Error_Event_TableNgConsultas;
            BsUsuarios.DataSource = NegUsurios.EntUsuarios;
            CmbIdRol.Properties.DataSource = NegUsurios.DtRoles;
            CmbIdRol.Properties.DisplayMember = "NombreRol";
            CmbIdRol.Properties.ValueMember = "Id";
            TxtIdUsuario.DataBindings.Add("EditValue", BsUsuarios, "IdUsuario", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbIdRol.DataBindings.Add("EditValue", BsUsuarios, "IdRol", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNombreUsuario.DataBindings.Add("EditValue", BsUsuarios, "NombreUsuario", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCorreoElectronico.DataBindings.Add("EditValue", BsUsuarios, "CorreoElectronico", true, DataSourceUpdateMode.OnPropertyChanged);
            this.Text = StrOperacion + " Usuarios";
        }

        private void BtnAcpetar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Este Usuario?", StrOperacion + " Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                BtnAceptar.Enabled = false;
                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegUsurios.MtdAdicionar();
                        break;

                    case "Modificar":
                        NegUsurios.MtdModificar();
                        break;

                    case "Eliminar":
                        NegUsurios.MtdEliminar();
                        break;

                    case "Bloquear":
                        NegUsurios.MtdBloquear();
                        break;

                    case "Desbloquear":
                        NegUsurios.MtdDesbloquear();
                        break;
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Metodos
    }
}