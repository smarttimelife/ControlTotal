namespace ControlTotal
{
    #region Librerias

    using Conexiones;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //15 DE ABRIL 2020 10:29 AM

    #endregion Librerias

    public partial class XtraInmuebles : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region propiedades

        private CadenaConexionMysql CadenaConexion;
        private BindingSource addressBindingSource = new BindingSource();
        private neginmuebles NegInmuebles;
        private string StrOperacion = string.Empty;

        #endregion propiedades

        #region Constructores

        public XtraInmuebles(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegInmuebles = new neginmuebles(CadenaConexion);
            StrOperacion = "Adicionar";
            Inicio();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraInmuebles(CadenaConexionMysql cadenaConexion, string strModulo, string IdInmueble, string strOperacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegInmuebles = new neginmuebles(CadenaConexion, IdInmueble);
            StrOperacion = strOperacion;
            if (StrOperacion != "Modificar")
            {
                dataLayoutControl1.Enabled = false;
            }
            Inicio();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegInmuebles_OkString_Event_inmuebles(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Modulo Inmuebles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SplashScreenManager.CloseForm();
        }

        private void NegInmuebles_ErrorString_Event_inmuebles(string mensaje)
        {
            BtnGuardar.Enabled = true;
            XtraMessageBox.Show(mensaje, "Modulo Inmuebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Disparadores

        #region Metodos

        private void dataLayoutControl1_FieldRetrieved(object sender, DevExpress.XtraDataLayout.FieldRetrievedEventArgs e)
        {
            if (e.FieldName == "Id" || e.FieldName == "IdTransaccion" || e.FieldName == "Estado")
            {
                e.Item.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void Inicio()
        {
            this.Text = StrOperacion + " Inmueble";
            BtnGuardar.Caption = StrOperacion;
            barStaticItem1.Caption = CadenaConexion.Logeo.StrUsuarioConextado;
            NegInmuebles.ErrorString_Event_inmuebles += NegInmuebles_ErrorString_Event_inmuebles;
            NegInmuebles.OkString_Event_inmuebles += NegInmuebles_OkString_Event_inmuebles;
            addressBindingSource.DataSource = NegInmuebles.Entinmuebles;
            dataLayoutControl1.DataSource = addressBindingSource;
            dataLayoutControl1.FieldRetrieved += dataLayoutControl1_FieldRetrieved;
            dataLayoutControl1.RetrieveFields();
        }

        private void BtnGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            addressBindingSource.EndEdit();
            BtnGuardar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Este Inmueble?", StrOperacion + " Inmueble", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegInmuebles.MtdAdicionar();
                        break;

                    case "Modificar":
                        NegInmuebles.MtdModificar();
                        break;

                    case "Eliminar":
                        NegInmuebles.MtdEliminar();
                        break;

                    case "Bloquear":
                        NegInmuebles.MtdBloquear();
                        break;

                    case "Desbloquear":
                        NegInmuebles.MtdDesbloquear();
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