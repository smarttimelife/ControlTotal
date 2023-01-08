namespace ControlTotal
{
    using Cartera;

    #region Librerias

    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Data;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class XtraOficina : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private BindingSource BsOficina = new BindingSource();
        private CadenaConexionMysql CadenaConexion;
        private negOficina NegOficina;
        private string StrOperacion;

        #endregion Propiedades

        #region Constructor

        public XtraOficina(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrOperacion = "Adicionar";
            this.Text = StrOperacion + " Oficina";
            NegOficina = new negOficina(CadenaConexion);
            NegOficina.ErrorString_Event_factor += NegFactores_Event_ErrorStringFactor;
            NegOficina.Event_ErrorTableNgConsultas += NegFactores_Event_ErrorTableNgConsultas;
            NegOficina.OkString_Event_factor += NegFactores_Event_OkStringFactor;
            BsOficina.DataSource = NegOficina.entOficina;
            TxtId.DataBindings.Add("EditValue", BsOficina, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtIntCorriente.DataBindings.Add("EditValue", BsOficina, "IntCorriente", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtMora.DataBindings.Add("EditValue", BsOficina, "Mora", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNombreOficina.DataBindings.Add("EditValue", BsOficina, "NombreOficina", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPeriodo.DataBindings.Add("EditValue", BsOficina, "Periodo", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPorcentaje.DataBindings.Add("EditValue", BsOficina, "Porcentaje", true, DataSourceUpdateMode.OnPropertyChanged);
            CheAutomatico.DataBindings.Add("EditValue", BsOficina, "Automatico", true, DataSourceUpdateMode.OnPropertyChanged);

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraOficina(CadenaConexionMysql cadenaConexion, int Id, string strOperacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrOperacion = strOperacion;
            NegOficina = new negOficina(CadenaConexion, Id);
            NegOficina.ErrorString_Event_factor += NegFactores_Event_ErrorStringFactor;
            NegOficina.Event_ErrorTableNgConsultas += NegFactores_Event_ErrorTableNgConsultas;
            NegOficina.OkString_Event_factor += NegFactores_Event_OkStringFactor;
            BsOficina.DataSource = NegOficina.entOficina;
            TxtId.DataBindings.Add("EditValue", BsOficina, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtIntCorriente.DataBindings.Add("EditValue", BsOficina, "IntCorriente", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtMora.DataBindings.Add("EditValue", BsOficina, "Mora", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtNombreOficina.DataBindings.Add("EditValue", BsOficina, "NombreOficina", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPeriodo.DataBindings.Add("EditValue", BsOficina, "Periodo", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPorcentaje.DataBindings.Add("EditValue", BsOficina, "Porcentaje", true, DataSourceUpdateMode.OnPropertyChanged);
            CheAutomatico.DataBindings.Add("EditValue", BsOficina, "Automatico", true, DataSourceUpdateMode.OnPropertyChanged);
            this.Text = strOperacion + " Oficina";
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void NegFactores_Event_OkStringFactor(string mensaje)
        {
            XtraMessageBox.Show(mensaje, " Factores", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegFactores_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, " Factores", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegFactores_Event_ErrorStringFactor(string mensaje)
        {
            XtraMessageBox.Show(mensaje, " Factores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            BtnGuardar.Enabled = true;
        }

        #endregion Disparadores

        private void BnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BtnGuardar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Esta Oficina?", StrOperacion + " Oficina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegOficina.Adicionar();
                        break;

                    case "Modificar":
                        NegOficina.Modificar();
                        break;

                    case "Eliminar":

                        break;

                    case "Bloquear":

                        break;

                    case "Desbloquear":

                        break;
                }
            }
        }
    }
}