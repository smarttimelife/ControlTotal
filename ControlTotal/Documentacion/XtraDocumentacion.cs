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

    public partial class XtraDocumentacion : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negDocumentacion NgDocumentacion;
        private BindingSource Bs = new BindingSource();
        private string StrOperacion = string.Empty;
        private string StrIdAdjudicacion = string.Empty;

        #endregion Propiedades

        #region Constructor

        public XtraDocumentacion(CadenaConexionMysql cadenaConexion, string strIdAdjudicacion, string strOperacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrOperacion = strOperacion;
            NgDocumentacion = new negDocumentacion(CadenaConexion, strIdAdjudicacion, strOperacion);
            NgDocumentacion.Event_ErrorTableNgConsultas += NgDocumentacion_Event_ErrorTableNgConsultas;
            NgDocumentacion.Error_Event_String_NegDocumentacion += NgDocumentacion_Error_Event_String_negConsultas;
            NgDocumentacion.Ok_Event_String_negDocumentacion += NgDocumentacion_Ok_Event_String_negConsultas;
            userAdjudicacion1.Inicio(cadenaConexion, strIdAdjudicacion);
            Bs.DataSource = NgDocumentacion.EntDocumentacion;
            this.Text = "Envio A: " + strOperacion;
            TxtComentarios.DataBindings.Add("EditValue", Bs, "ComentariosEnvio", true, DataSourceUpdateMode.OnPropertyChanged);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void NgDocumentacion_Ok_Event_String_negConsultas(string mensaje)
        {
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            XtraMessageBox.Show(mensaje, "Envio A " + StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NgDocumentacion_Error_Event_String_negConsultas(string mensaje)
        {
            BtnEnviar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            XtraMessageBox.Show(mensaje, "Envio A " + StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NgDocumentacion_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Envio A " + StrOperacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            BtnEnviar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de Enviar a " + StrOperacion + " ?", "Envio A " + StrOperacion, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                NgDocumentacion.MtdEnviar();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Metodos
    }
}