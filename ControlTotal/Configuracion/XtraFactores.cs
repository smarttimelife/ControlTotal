namespace ControlTotal
{
    #region Librerias

    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System;
    using System.Data;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class XtraFactores : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private BindingSource BsFactores = new BindingSource();
        private CadenaConexionMysql CadenaConexion;
        private negFactores NegFactores;
        private string StrOperacion;
        #endregion Propiedades



        public XtraFactores(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrOperacion = "Adicionar";
            this.Text = StrOperacion + " Factores";
            NegFactores = new negFactores(CadenaConexion);
            NegFactores.ErrorString_Event_factor += NegFactores_Event_ErrorStringFactor;
            NegFactores.Event_ErrorTableNgConsultas += NegFactores_Event_ErrorTableNgConsultas;
            NegFactores.OkString_Event_factor += NegFactores_Event_OkStringFactor;
            BsFactores.DataSource = NegFactores.entFactores;
            TxtPlazo.DataBindings.Add("EditValue", BsFactores, "Plazo", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTasa.DataBindings.Add("EditValue", BsFactores, "Tasa", true, DataSourceUpdateMode.OnPropertyChanged);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraFactores(CadenaConexionMysql cadenaConexion, int Id, string strOperacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrOperacion = strOperacion;
            NegFactores = new negFactores(CadenaConexion, Id);
            NegFactores.ErrorString_Event_factor += NegFactores_Event_ErrorStringFactor;
            NegFactores.Event_ErrorTableNgConsultas += NegFactores_Event_ErrorTableNgConsultas;
            NegFactores.OkString_Event_factor += NegFactores_Event_OkStringFactor;
            BsFactores.DataSource = NegFactores.entFactores;
            TxtPlazo.DataBindings.Add("EditValue", BsFactores, "Plazo", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTasa.DataBindings.Add("EditValue", BsFactores, "Tasa", true, DataSourceUpdateMode.OnPropertyChanged);
            this.Text = strOperacion + " Factores";
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

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
            BtnAceptar.Enabled = true;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            BtnAceptar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Este Factor?", StrOperacion + " Factores", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegFactores.Adicionar();
                        break;

                    case "Modificar":
                        NegFactores.Modificar();
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