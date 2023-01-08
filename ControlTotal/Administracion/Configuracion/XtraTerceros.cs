namespace ControlTotal
{
    #region Librerias

    using Administracion.NegociosAdmin;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Windows.Forms;

    //Finalizado Marzo 28 2020 8:34am
    //Creado por Javier Villalba Espinosa

    #endregion Librerias

    public partial class XtraTerceros : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negTerceros NegTerceros;
        private string StrOperacion;
        private int TipoCliente;
        private string StTercero;
        private BindingSource BsTerceros = new BindingSource();

        #endregion Propiedades

        #region Constructores

        public XtraTerceros(CadenaConexionMysql cadenaConexion, int tipocliente)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrOperacion = "Adicionar";
            BtnAceptar.Caption = StrOperacion;

            TipoCliente = tipocliente;

            switch (tipocliente)
            {
                case 1:
                    StTercero = "Clientes";

                    break;

                case 2:
                    StTercero = "Provedores";

                    break;

                case 3:
                    StTercero = "Empleados";

                    break;

                case 4:
                    StTercero = "Asesores";

                    break;
            }
            this.Text = StTercero + " Asesores";
            RpTerceros.Text = StTercero;
            NegTerceros = new negTerceros(CadenaConexion, tipocliente);
            NegTerceros.Event_ErrorTableNgConsultas += NegTerceros_Event_ErrorTableNgConsultas;
            NegTerceros.Event_ErrorStringTerceros += NegTerceros_Event_ErrorStringTerceros;
            NegTerceros.Event_OkStringTerceros += NegTerceros_Event_OkStringTerceros;
            NegTerceros.Event_ValidateStringTerceros += NegTerceros_Event_ValidateStringTerceros;
            BsTerceros.DataSource = NegTerceros.EntTerceros;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraTerceros(CadenaConexionMysql cadenaConexion, int tipocliente, string strOperacion, string StrId)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            StrOperacion = strOperacion;
            BtnAceptar.Caption = StrOperacion;
            RpTerceros.Text = StrOperacion;
            TipoCliente = tipocliente;
            CadenaConexion = cadenaConexion;

            TipoCliente = tipocliente;

            switch (tipocliente)
            {
                case 1:
                    StTercero = "Clientes";

                    break;

                case 2:
                    StTercero = "Provedores";

                    break;

                case 3:
                    StTercero = "Empleados";

                    break;

                case 4:
                    StTercero = "Asesores";
                    break;
            }

            this.Text = StTercero + " Asesores";

            RpTerceros.Text = StTercero;
            TxtIdTercero.ReadOnly = true;
            NegTerceros = new negTerceros(CadenaConexion, tipocliente, StrId);
            NegTerceros.Event_ErrorTableNgConsultas += NegTerceros_Event_ErrorTableNgConsultas;
            NegTerceros.Event_ErrorStringTerceros += NegTerceros_Event_ErrorStringTerceros;
            NegTerceros.Event_OkStringTerceros += NegTerceros_Event_OkStringTerceros;
            NegTerceros.Event_ValidateStringTerceros += NegTerceros_Event_ValidateStringTerceros;
            BsTerceros.DataSource = NegTerceros.EntTerceros;
            if (StrOperacion == "Eliminar")
            {
                TabDireccion.Enabled = false;
                TabDatosPersonales.Enabled = false;
                BtnAceptar.Enabled = true;
            }
            else
            {
                TabDireccion.Enabled = NegTerceros.BoolEstado;
                TabDatosPersonales.Enabled = NegTerceros.BoolEstado;
                BtnAceptar.Enabled = NegTerceros.BoolEstado;
            }
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegTerceros_Event_OkStringTerceros(string mensaje)
        {
            BtnAceptar.Enabled = NegTerceros.BoolEstado;
            XtraMessageBox.Show(mensaje, StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnAceptar.Enabled = NegTerceros.BoolEstado;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegTerceros_Event_ErrorStringTerceros(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnAceptar.Enabled = NegTerceros.BoolEstado;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegTerceros_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show("Se Presento el siguiente Error:\n" + mensaje + "\nEste Formulario se Cerrara", StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Close();
        }

        private void NegTerceros_Event_ValidateStringTerceros(string mensaje)
        {
            BtnAceptar.Enabled = NegTerceros.BoolEstado;
            if (XtraMessageBox.Show(mensaje, StrOperacion, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NegTerceros.MtdAddTipoTerceros();
            }
        }

        #endregion Disparadores

        #region Metodos

        private void Inicio()
        {
            try
            {
                CmbTipoPersona.Properties.DataSource = NegTerceros.CnsTipoPersonas();
                CmbTipoPersona.Properties.DisplayMember = "Detalle";
                CmbTipoPersona.Properties.ValueMember = "Id";

                CmbTipoDocumento.Properties.DataSource = NegTerceros.CnsTipoDocumento();
                CmbTipoDocumento.Properties.DisplayMember = "TipoDocumento";
                CmbTipoDocumento.Properties.ValueMember = "Id";

                TxtIdTercero.DataBindings.Add("EditValue", BsTerceros, "IdTercero", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtNombres.DataBindings.Add("EditValue", BsTerceros, "Nombres", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtTelefono1.DataBindings.Add("EditValue", BsTerceros, "Telefono1", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtTelefono2.DataBindings.Add("EditValue", BsTerceros, "Telefono2", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtDireccion.DataBindings.Add("EditValue", BsTerceros, "Direccion", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtCelular.DataBindings.Add("EditValue", BsTerceros, "Celular", true, DataSourceUpdateMode.OnPropertyChanged);
                CmbTipoPersona.DataBindings.Add("EditValue", BsTerceros, "TipoPersona", true, DataSourceUpdateMode.OnPropertyChanged);
                CmbTipoDocumento.DataBindings.Add("EditValue", BsTerceros, "IdTipoDocumento", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtCiudad.DataBindings.Add("EditValue", BsTerceros, "Ciudad", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtDepartamento.DataBindings.Add("EditValue", BsTerceros, "Departamento", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtCorreoElectronico.DataBindings.Add("EditValue", BsTerceros, "CorreoElectronico", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtContactos.DataBindings.Add("EditValue", BsTerceros, "Contacto", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtPaginaWeb.DataBindings.Add("EditValue", BsTerceros, "PaginaWeb", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtApellidos.DataBindings.Add("EditValue", BsTerceros, "Apellidos", true, DataSourceUpdateMode.OnPropertyChanged);
                DtpFechaNacimiento.DataBindings.Add("EditValue", BsTerceros, "FechaNacimiento", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Se Presento el siguiente Error:\n" + ex.Message + "\nEste Formulario se Cerrara", "Modulo Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Close();
            }
        }

        private void Limpiar()
        {
            try
            {
                CmbTipoPersona.EditValue = 0;
                CmbTipoDocumento.EditValue = 0;
                TxtNombres.EditValue = null;
                TxtTelefono1.EditValue = null;
                TxtTelefono2.EditValue = null;
                TxtDireccion.EditValue = null;
                TxtCelular.EditValue = null;
                CmbTipoPersona.EditValue = null;
                CmbTipoDocumento.EditValue = null;
                TxtCiudad.EditValue = null;
                TxtDepartamento.EditValue = null;
                TxtCorreoElectronico.EditValue = null;
                TxtContactos.EditValue = null;
                TxtPaginaWeb.EditValue = null;
                TxtApellidos.EditValue = null;
                DtpFechaNacimiento.EditValue = null;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Se Presento el siguiente Error:\n" + ex.Message + "\nEste Formulario se Cerrara", "Modulo Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void XtraTerceros_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        private void TxtIdTercero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void CmbTipoPersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtIdTercero_Leave(object sender, EventArgs e)
        {
            if (StrOperacion == "Adicionar")
            {
                Limpiar();
                NegTerceros.MtdLlenarTercero();
                TabDireccion.Enabled = NegTerceros.BoolEstado;
                TabDatosPersonales.Enabled = NegTerceros.BoolEstado;
                BtnAceptar.Enabled = NegTerceros.BoolEstado;
            }
        }

        private void BtnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void BtnAceptar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Este Tercero?", StrOperacion + " Terceros", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                BtnAceptar.Enabled = false;
                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegTerceros.MtdAdicionarTerceros();
                        break;

                    case "Modificar":
                        NegTerceros.MtdModTerceros();
                        break;

                    case "Eliminar":
                        NegTerceros.MtdDelTerceros();
                        break;
                }
            }
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Metodos
    }
}