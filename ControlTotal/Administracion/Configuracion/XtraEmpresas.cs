namespace ControlTotal
{
    #region Librerias

    using Administracion.NegociosAdmin;
    using Conexiones;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Data;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //FECHA CREACION ABRIL 8 2020 8:21AM

    #endregion Librerias

    public partial class XtraEmpresas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private string StrOperacion = string.Empty;
        private string StrModulo = string.Empty;
        private BindingSource BsEmpresas = new BindingSource();
        private negEmpresas NegEmpresas;

        #endregion Propiedades

        #region Constructores

        public XtraEmpresas(CadenaConexionMysql cadenaConexion, string strModulo, string strOperacion, int idEmpresa)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrModulo = strModulo;
            StrOperacion = strOperacion;
            NegEmpresas = new negEmpresas(CadenaConexion, StrModulo, StrOperacion, idEmpresa);
            Inicio();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraEmpresas(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrModulo = strModulo;
            StrOperacion = "Adicionar";
            NegEmpresas = new negEmpresas(CadenaConexion, StrModulo);
            Inicio();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegEmpresas_OkString_Event__Empresas(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Empresas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegEmpresas_ErrorString_Event_Empresas(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Empresas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnAceptar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegEmpresas_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show("Se Presento El Sgte Error " + mensaje + " Se Cerrara esta Ventana", StrOperacion + " Empresas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        #endregion Disparadores

        #region Metodos

        private void Inicio()
        {
            NegEmpresas.Event_ErrorTableNgConsultas += NegEmpresas_Event_ErrorTableNgConsultas;
            NegEmpresas.ErrorString_Event_Empresas += NegEmpresas_ErrorString_Event_Empresas;
            NegEmpresas.OkString_Event__Empresas += NegEmpresas_OkString_Event__Empresas;
            this.Text = StrOperacion + " Empresas";
            BsEmpresas.DataSource = NegEmpresas.EntEmpresas;
            byte[] numbers = { 0 };

            if (NegEmpresas.EntEmpresas.Imagen is null)
            {
                NegEmpresas.EntEmpresas.Imagen = numbers;
            }
            if (NegEmpresas.EntEmpresas.Logo is null)
            {
                NegEmpresas.EntEmpresas.Logo = numbers;
            }

            TxtNit.DataBindings.Add("EditValue", BsEmpresas, "Nit", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNombreEmpresa.DataBindings.Add("EditValue", BsEmpresas, "NombreEmpresa", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtDireccion.DataBindings.Add("EditValue", BsEmpresas, "Direccion", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTelefono.DataBindings.Add("EditValue", BsEmpresas, "Telefono", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCorreoElectronico.DataBindings.Add("EditValue", BsEmpresas, "Correo", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCelular.DataBindings.Add("EditValue", BsEmpresas, "Celular", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCuentaBancaria.DataBindings.Add("EditValue", BsEmpresas, "CuentaBancaria", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtHorarioAtencion.DataBindings.Add("EditValue", BsEmpresas, "HorarioAtencion", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtDecimales.DataBindings.Add("EditValue", BsEmpresas, "Decimales", true, DataSourceUpdateMode.OnPropertyChanged);
            PtbImagen.DataBindings.Add("EditValue", BsEmpresas, "Imagen", true, DataSourceUpdateMode.OnPropertyChanged);
            PtbLogo.DataBindings.Add("EditValue", BsEmpresas, "Logo", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNit.ReadOnly = true;
            if (StrOperacion == "Consultar")
            {
                BtnAceptar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                Root.Enabled = false;
            }
            if (StrOperacion == "Eliminar")
            {
                Root.Enabled = false;
            }
        }

        private void BtnAceptar_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAceptar.Enabled = false;

            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Esta Empresa?", StrOperacion + " Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegEmpresas.MtdAdicionar();
                        break;

                    case "Modificar":
                        NegEmpresas.MtdModificar();
                        break;

                    case "Eliminar":
                        NegEmpresas.MtdEliminar();
                        break;

                    case "Bloquear":

                        break;

                    case "Desbloquear":

                        break;
                }
            }
        }

        private void BtnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        #endregion Metodos
    }
}