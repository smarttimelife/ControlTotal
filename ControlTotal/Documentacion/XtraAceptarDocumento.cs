namespace ControlTotal
{
    #region Librerias

    using Cartera;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA

    #endregion Librerias

    public partial class XtraAceptarDocumento : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negDocumentacion NgDocumentacion;
        private BindingSource Bs = new BindingSource();
        private string StrOperacion = string.Empty;
        private string StrIdAdjudicacion = string.Empty;

        #endregion Propiedades

        #region Constructor

        public XtraAceptarDocumento(CadenaConexionMysql cadenaConexion, string strIdAdjudicacion, string strOperacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            this.Text = "Aceptar  " + strOperacion;
            CadenaConexion = cadenaConexion;
            StrOperacion = strOperacion;
            NgDocumentacion = new negDocumentacion(CadenaConexion, strIdAdjudicacion, strOperacion);
            NgDocumentacion.Event_ErrorTableNgConsultas += NgDocumentacion_Event_ErrorTableNgConsultas;
            NgDocumentacion.Error_Event_String_NegDocumentacion += NgDocumentacion_Error_Event_String_negConsultas;
            NgDocumentacion.Ok_Event_String_negDocumentacion += NgDocumentacion_Ok_Event_String_negConsultas;
            userAdjudicacion1.Inicio(cadenaConexion, strIdAdjudicacion);
            NgDocumentacion.MtdBuscarDocumento();
            Bs.DataSource = NgDocumentacion.EntDocumentacion;
            TxtOperacion.DataBindings.Add("EditValue", Bs, "Operacion", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtUsuario.DataBindings.Add("EditValue", Bs, "UsuarioEnvio", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFecha.DataBindings.Add("EditValue", Bs, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtComentarioEnvio.DataBindings.Add("EditValue", Bs, "ComentariosEnvio", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtComentarioRecibe.DataBindings.Add("EditValue", Bs, "ComentariosRecibe", true, DataSourceUpdateMode.OnPropertyChanged);
            if (TxtOperacion.EditValue == DBNull.Value)
            {
                Root.Enabled = false;
            }
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void NgDocumentacion_Ok_Event_String_negConsultas(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Aceptar " + StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NgDocumentacion_Error_Event_String_negConsultas(string mensaje)
        {
            BtnAceptar.Enabled = true;
            XtraMessageBox.Show(mensaje, "Aceptar " + StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NgDocumentacion_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Aceptar " + StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            BtnAceptar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de Aceptar " + StrOperacion + " ?", "Aceptar " + StrOperacion, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                NgDocumentacion.MtdAceptar();
                if (SplashScreenManager.Default != null)
                    SplashScreenManager.CloseForm();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Metodos
    }
}