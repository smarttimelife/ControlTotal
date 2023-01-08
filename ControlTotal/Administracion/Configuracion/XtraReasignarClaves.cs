namespace ControlTotal
{
    #region Librerias

    using Administracion;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Windows.Forms;

    // JAVIER ENRIQUE VILLALBA ESPINOSA
    // 13 DE ABRIL 2020

    #endregion Librerias

    public partial class XtraReasignarClaves : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private string StrOperacion = string.Empty;
        private negClaves NegClaves;
        private BindingSource BsUsuarios = new BindingSource();

        #endregion Propiedades

        #region Constructor

        public XtraReasignarClaves(CadenaConexionMysql cadenaConexion, string StrModulo, int IdUsuario, string strOperacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrOperacion = strOperacion;
            NegClaves = new negClaves(cadenaConexion, StrModulo, IdUsuario);
            NegClaves.ErrorString_Event_Claves += NegClaves_ErrorString_Event_Claves;
            NegClaves.OkString_Event_Claves += NegClaves_OkString_Event_Claves;
            NegClaves.Event_ErrorTableNgConsultas += NegClaves_Event_ErrorTableNgConsultas;
            BsUsuarios.DataSource = NegClaves.EntClaves;
            TxtIdUsuario.DataBindings.Add("EditValue", BsUsuarios, "Idusuario", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNombreUsuario.DataBindings.Add("EditValue", BsUsuarios, "NombreUsuario", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtClave.DataBindings.Add("EditValue", BsUsuarios, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtConfirmarClave.DataBindings.Add("EditValue", BsUsuarios, "ConfirmarClave", true, DataSourceUpdateMode.OnPropertyChanged);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraReasignarClaves(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrOperacion = "Cambiar";
            NegClaves = new negClaves(cadenaConexion);
            NegClaves.ErrorString_Event_Claves += NegClaves_ErrorString_Event_Claves;
            NegClaves.OkString_Event_Claves += NegClaves_OkString_Event_Claves;
            NegClaves.Event_ErrorTableNgConsultas += NegClaves_Event_ErrorTableNgConsultas;
            BsUsuarios.DataSource = NegClaves.EntClaves;
            LblClaveActual.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            TxtIdUsuario.DataBindings.Add("EditValue", BsUsuarios, "Idusuario", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNombreUsuario.DataBindings.Add("EditValue", BsUsuarios, "NombreUsuario", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtClave.DataBindings.Add("EditValue", BsUsuarios, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtConfirmarClave.DataBindings.Add("EditValue", BsUsuarios, "ConfirmarClave", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtClaveActual.DataBindings.Add("EditValue", BsUsuarios, "ClaveActual", true, DataSourceUpdateMode.OnPropertyChanged);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void NegClaves_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegClaves_OkString_Event_Claves(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Clave", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegClaves_ErrorString_Event_Claves(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnAceptar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Disparadores

        #region Metodos

        private void BtnAceptar_Click(object sender, System.EventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Clave", StrOperacion + " Clave", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BtnAceptar.Enabled = false;
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                switch (StrOperacion)
                {
                    case "Reasignar":
                        NegClaves.MtdReasignarClave();
                        break;

                    case "Cambiar":
                        NegClaves.MtdCambiarClave();
                        break;
                }
            }
        }

        private void BtnSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion Metodos
    }
}