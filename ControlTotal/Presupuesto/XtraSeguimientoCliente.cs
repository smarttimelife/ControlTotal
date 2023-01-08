namespace ControlTotal
{
    #region Librerias

    using Cartera;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System;
    using System.Windows.Forms;

    //JAVIER VILLALBA ESPINOSA

    #endregion Librerias

    public partial class XtraSeguimientoCliente : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negRecaudos NegRecaudos;
        private negPresupuesto NegPresupuesto;
        private string StrIdAdjudicacion = string.Empty;
        private string StrTipoCartera = string.Empty;
        private BindingSource BsSeguimiento = new BindingSource();

        #endregion Propiedades

        #region Contructor

        public XtraSeguimientoCliente(CadenaConexionMysql cadenaConexion, string strIdAdjudicacion, string strTipoCartera)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrIdAdjudicacion = strIdAdjudicacion;
            NegRecaudos = new negRecaudos(CadenaConexion, StrIdAdjudicacion);
            NegPresupuesto = new negPresupuesto(CadenaConexion);
            StrTipoCartera = strTipoCartera;
            NegPresupuesto.ErrorString_Event_Presupuesto += NegPresupuesto_ErrorString_Event_Presupuesto;
            NegPresupuesto.Event_ErrorTableNgConsultas += NegPresupuesto_Event_ErrorTableNgConsultas;
            NegPresupuesto.OkString_Event_Presupuesto += NegPresupuesto_OkString_Event_Presupuesto;
            userDatosClientes1.Inicio(NegRecaudos);
            gridControl1.DataSource = NegRecaudos.CnsDtConsultaStrId("Seguimiento", StrIdAdjudicacion);
            CmbAccion.Properties.DataSource = NegRecaudos.CnsDtCombox("Acciones");
            CmbAccion.Properties.ValueMember = "Acciones";
            CmbAccion.Properties.DisplayMember = "Acciones";
            CmbObjeccion.Properties.DataSource = NegRecaudos.CnsDtCombox("Objeciones");
            CmbObjeccion.Properties.ValueMember = "Objecion";
            CmbObjeccion.Properties.DisplayMember = "Objecion";

            NegPresupuesto.EntSeguimiento.Fecha = DateTime.Now;
            NegPresupuesto.EntSeguimiento.IdAdjudicacion = StrIdAdjudicacion;
            NegPresupuesto.EntSeguimiento.IdUsuario = CadenaConexion.Logeo.Usuario;
            NegPresupuesto.EntSeguimiento.Inmueble = NegRecaudos.DtAdjudicacion.Rows[0]["IdInmueble"].ToString();
            NegPresupuesto.EntSeguimiento.TipoCartera = StrTipoCartera;

            BsSeguimiento.DataSource = NegPresupuesto.EntSeguimiento;
            CmbAccion.DataBindings.Add("EditValue", BsSeguimiento, "Accion", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbObjeccion.DataBindings.Add("EditValue", BsSeguimiento, "Objecion", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCompromiso.DataBindings.Add("EditValue", BsSeguimiento, "Compromiso", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaCompromiso.DataBindings.Add("EditValue", BsSeguimiento, "FechaCompromiso", true, DataSourceUpdateMode.OnPropertyChanged);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Contructor

        #region Disparadores

        private void NegPresupuesto_OkString_Event_Presupuesto(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Seguimiento Clientes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegPresupuesto_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Seguimiento Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegPresupuesto_ErrorString_Event_Presupuesto(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Seguimiento Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Disparadores

        #region Metodos

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BtnGuardar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro Adicionar Seguimiento?", "Seguimiento Cartera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                NegPresupuesto.AddSeguimiento();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Metodos
    }
}