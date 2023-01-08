namespace ControlTotal
{
    #region Librerias

    using Administracion.NegociosAdmin;
    using Conexiones;
    using DevExpress.LookAndFeel;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Data;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    // ABRIL 10 2020

    #endregion Librerias

    public partial class XtraLogin : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private BindingSource BsLogin = new BindingSource();
        private CadenaConexionMysql CadenaConexion;
        private negLogin NegLogin;

        #endregion Propiedades

        #region Constructores

        public XtraLogin(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegLogin = new negLogin(CadenaConexion);
            NegLogin.Event_ErrorTableNgConsultas += NegLogin_Event_ErrorTableNgConsultas;
            NegLogin.Event_ErrorStringLogin += NegLogin_Event_ErrorStringLogin;
            NegLogin.Event_OkStringLogin += NegLogin_Event_OkStringLogin;
            UserLookAndFeel.Default.SkinName = Operaciones.GetSetting("ControlTotal", "Skin", "Tema", UserLookAndFeel.Default.SkinName.ToString());
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegLogin_Event_ErrorStringLogin(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnAceptar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegLogin_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegLogin_Event_OkStringLogin(string mensaje)
        {
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            CadenaConexion.Logeo = NegLogin.EntLogeo;
            XtraMenuGeneral xtraMenuGeneral = new XtraMenuGeneral(CadenaConexion);
            Hide();
            xtraMenuGeneral.Owner = this;
            xtraMenuGeneral.ShowDialog();
            xtraMenuGeneral = null;

            Close();
        }

        #endregion Disparadores

        #region Metodos y Eventos

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnAceptar.Enabled = false;
            NegLogin.MtdLogin();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void XtraLogin_Load(object sender, EventArgs e)
        {
            NegLogin.MtdInicio();
            CmbProyecto.Properties.DataSource = NegLogin.dtProyectos;
            CmbProyecto.Properties.ValueMember = "Id";
            CmbProyecto.Properties.DisplayMember = "NombreProyecto";
            BsLogin.DataSource = NegLogin.EntLogeo;
            TxtClave.DataBindings.Add("EditValue", BsLogin, "Clave", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtUsuario.DataBindings.Add("EditValue", BsLogin, "Usuario", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbProyecto.DataBindings.Add("EditValue", BsLogin, "IdProyecto", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFecha.DataBindings.Add("EditValue", BsLogin, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        #endregion Metodos y Eventos
    }
}