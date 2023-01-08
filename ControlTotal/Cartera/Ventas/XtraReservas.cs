namespace ControlTotal
{
    #region Librerias

    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //19 de Abril 2020 13:30 pm

    #endregion Librerias

    public partial class XtraReservas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        private BindingSource BsReservas = new BindingSource();
        private CadenaConexionMysql CadenaConexion;
        private int count = 0;
        private negReservas NegReservas;
        private string StrModulo = string.Empty;
        private string StrOperacion = string.Empty;
        private int IntIdReservas = 0;

        #endregion Propiedades

        #region Constructores

        public XtraReservas(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            StrModulo = strModulo;
            StrOperacion = "Adicionar";
            CadenaConexion = cadenaConexion;
            NegReservas = new negReservas(CadenaConexion);
            NegReservas.Event_ErrorTableNgConsultas += NegReservas_Event_ErrorTableNgConsultas;
            NegReservas.ErrorString_Event_reservas += NegReservas_ErrorString_Event_reservas;
            NegReservas.OkString_Event_reservas += NegReservas_OkString_Event_reservas;
            Inicio();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraReservas(CadenaConexionMysql cadenaConexion, string strModulo, int IdReservas, string strOperacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            IntIdReservas = IdReservas;
            StrModulo = strModulo;
            StrOperacion = strOperacion;
            CadenaConexion = cadenaConexion;
            NegReservas = new negReservas(CadenaConexion, IdReservas);
            NegReservas.Event_ErrorTableNgConsultas += NegReservas_Event_ErrorTableNgConsultas;
            NegReservas.ErrorString_Event_reservas += NegReservas_ErrorString_Event_reservas;
            NegReservas.OkString_Event_reservas += NegReservas_OkString_Event_reservas;
            Inicio();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegReservas_OkString_Event_reservas(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnNuevo.Enabled = true;
            Root.Enabled = false;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegReservas_ErrorString_Event_reservas(string mensaje)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegReservas_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, StrOperacion + " Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos

        private void Inicio()
        {
            try
            {
                this.Text = StrOperacion + " Reservas";
                BtnGuardar.Caption = StrOperacion;

                if (StrOperacion == "Adicionar")
                {
                    CmbInmueble.Properties.DataSource = NegReservas.CnsDtConsulta("InmueblesLibre");
                    CmbInmueble.Properties.ValueMember = "IdInmueble";
                    CmbInmueble.Properties.DisplayMember = "IdInmueble";
                }
                else

                {
                    BtnNuevo.Links[0].Visible = false;
                    CmbInmueble.Properties.DataSource = NegReservas.CnsDtConsultaStrId("InmueblesLibre", IntIdReservas);
                    CmbInmueble.Properties.ValueMember = "IdInmueble";
                    CmbInmueble.Properties.DisplayMember = "IdInmueble";
                }
                CmbGestor.Properties.DataSource = NegReservas.CnsDtConsulta("Asesor");
                CmbGestor.Properties.ValueMember = "IdTercero";
                CmbGestor.Properties.DisplayMember = "Asesor";

                CmbTerceros.Properties.DataSource = NegReservas.CnsDtConsulta("Clientes");
                CmbTerceros.Properties.ValueMember = "IdTercero";
                CmbTerceros.Properties.DisplayMember = "Cliente";

                BsReservas.DataSource = NegReservas.EntReservas;
                DtpFecha.DataBindings.Add("EditValue", BsReservas, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
                CmbGestor.DataBindings.Add("EditValue", BsReservas, "IdGestor", true, DataSourceUpdateMode.OnPropertyChanged);
                CmbInmueble.DataBindings.Add("EditValue", BsReservas, "IdInmueble", true, DataSourceUpdateMode.OnPropertyChanged);
                CmbTerceros.DataBindings.Add("EditValue", BsReservas, "IdTercero", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtContrato.DataBindings.Add("EditValue", BsReservas, "Contrato", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtLetra.DataBindings.Add("EditValue", BsReservas, "Letra", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtValorContrato.DataBindings.Add("EditValue", BsReservas, "ValorContrato", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtValorPago1.DataBindings.Add("EditValue", BsReservas, "ValorPago1", true, DataSourceUpdateMode.OnPropertyChanged);
                DtpFechaInicio.DataBindings.Add("EditValue", BsReservas, "FechaInicio", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message, StrOperacion + " Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void BtnCliente_Click(object sender, System.EventArgs e)
        {
            CadenaConexionMysql Cadena = new CadenaConexionMysql(CadenaConexion.StrServidor, "admin", CadenaConexion.StrPuerto);
            Cadena.Logeo = CadenaConexion.Logeo;
            this.Cursor = Cursors.AppStarting;
            BtnCliente.Enabled = false;
            XtraTerceros Documento = new XtraTerceros(Cadena, 1);
            Documento.Show();
            BtnCliente.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void BtnAsesor_Click(object sender, System.EventArgs e)
        {
            CadenaConexionMysql Cadena = new CadenaConexionMysql(CadenaConexion.StrServidor, "admin", CadenaConexion.StrPuerto);
            Cadena.Logeo = CadenaConexion.Logeo;
            this.Cursor = Cursors.AppStarting;
            BtnAsesor.Enabled = false;
            XtraTerceros Documento = new XtraTerceros(Cadena, 4);
            Documento.Show();
            BtnAsesor.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void BtnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Esta Reserva?", StrOperacion + " Reservas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BtnGuardar.Enabled = false;
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegReservas.MtdAdicionar();
                        break;

                    case "Modificar":
                        NegReservas.MtdModificar();
                        break;

                    case "Eliminar":
                        NegReservas.MtdEliminar();
                        break;

                    case "Bloquear":

                        break;

                    case "Desbloquear":

                        break;
                }
                if (SplashScreenManager.Default != null)
                    SplashScreenManager.CloseForm();
            }
        }

        private void BtnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void BtnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnGuardar.Enabled = true;
            NegReservas = new negReservas(CadenaConexion);
            NegReservas.Event_ErrorTableNgConsultas += NegReservas_Event_ErrorTableNgConsultas;
            NegReservas.ErrorString_Event_reservas += NegReservas_ErrorString_Event_reservas;
            NegReservas.OkString_Event_reservas += NegReservas_OkString_Event_reservas;
            BsReservas.Clear();
            BsReservas.DataSource = NegReservas.EntReservas;
            Root.Enabled = true;
            BtnNuevo.Enabled = false;
            CmbInmueble.Properties.DataSource = NegReservas.CnsDtConsulta("InmueblesLibre");
            CmbGestor.Properties.DataSource = NegReservas.CnsDtConsulta("Asesor");
            CmbTerceros.Properties.DataSource = NegReservas.CnsDtConsulta("Clientes");
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void XtraReservas_Activated(object sender, System.EventArgs e)
        {
            if (count > 0)
            {
                CmbTerceros.Properties.DataSource = NegReservas.CnsDtConsulta("Clientes");
                CmbGestor.Properties.DataSource = NegReservas.CnsDtConsulta("Asesor");
            }
            count += 1;
        }

        #endregion Metodos
    }
}