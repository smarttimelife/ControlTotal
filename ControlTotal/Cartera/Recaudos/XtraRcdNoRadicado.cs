using Conexiones;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using NegociosCartera;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class XtraRcdNoRadicado : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        public string StrFuente = string.Empty;
        private BindingSource BsRecaudos = new BindingSource();
        private CadenaConexionMysql CadenaConexion;
        private negRecaudos NegRecaudos;
        private string StrIdReserva = string.Empty;
        private string StrOperacion = string.Empty;

        #endregion Propiedades

        #region Constructor

        public XtraRcdNoRadicado(CadenaConexionMysql cadenaConexion, string strFuente)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            StrFuente = strFuente;

            CadenaConexion = cadenaConexion;
            NegRecaudos = new negRecaudos(cadenaConexion);
            NegRecaudos.EventOkString += NegRecaudos_EventOkString;
            NegRecaudos.EventErrorString += NegRecaudos_EventErrorString;
            NegRecaudos.Event_ErrorTableNgRecaudos += NegRecaudos_Event_ErrorTableNgRecaudos;
            this.Text = "Adicionar Recaudos No Radicados";
            StrOperacion = "Adicionar";

            BsRecaudos.DataSource = NegRecaudos.EntNoRadicados;

            CmbOperacion.Properties.DataSource = NegRecaudos.DtOperacion;
            CmbOperacion.Properties.ValueMember = "Operacion";
            CmbOperacion.Properties.DisplayMember = "Operacion";

            CmbFormaPago.Properties.DataSource = NegRecaudos.CnsFormaPago(strFuente);
            CmbFormaPago.Properties.ValueMember = "FormaPago";
            CmbFormaPago.Properties.DisplayMember = "FormaPago";

            CmbReserva.Properties.DataSource = NegRecaudos.CnsDtCombox("Reservas");
            CmbReserva.Properties.ValueMember = "IdReserva";
            CmbReserva.Properties.DisplayMember = "Cliente";

            CmbReserva.DataBindings.Add("EditValue", BsRecaudos, "IdReserva", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtRecibo.DataBindings.Add("EditValue", BsRecaudos, "Recibo", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtBanco.DataBindings.Add("EditValue", BsRecaudos, "CodBanco", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtValor.DataBindings.Add("EditValue", BsRecaudos, "Valor", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFecha.DataBindings.Add("EditValue", BsRecaudos, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbOperacion.DataBindings.Add("EditValue", BsRecaudos, "Operacion", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbFormaPago.DataBindings.Add("EditValue", BsRecaudos, "FormaPago", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtDetalle.DataBindings.Add("EditValue", BsRecaudos, "Detalle", true, DataSourceUpdateMode.OnPropertyChanged);

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void NegRecaudos_Event_ErrorTableNgRecaudos(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Recaudos No Radicados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegRecaudos_EventErrorString(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Recaudos No Radicados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegRecaudos_EventOkString(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Recaudos No Radicados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Disparadores

        private void DtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, System.EventArgs e)
        {
            BtnGuardar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Este Recaudo?", StrOperacion + " Recaudos No Radicados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                NegRecaudos.MtdAdNoRadicados(StrFuente);
            }
        }
    }
}