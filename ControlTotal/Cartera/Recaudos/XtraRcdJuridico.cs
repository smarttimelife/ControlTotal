using Conexiones;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using NegociosCartera;
using System;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class XtraRcdJuridico : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        public string StrFuente = string.Empty;
        private BindingSource BsRecaudos = new BindingSource();
        private CadenaConexionMysql CadenaConexion;
        private negRecaudos NegRecaudos;
        private string StrIdReserva = string.Empty;
        private string StrIdAdjudicacion = string.Empty;
        private string StrOperacion = string.Empty;

        #endregion Propiedades

        #region Constructor

        public XtraRcdJuridico(CadenaConexionMysql cadenaConexion, string strFuente, string strIdAdjudicacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();

            CadenaConexion = cadenaConexion;
            NegRecaudos = new negRecaudos(cadenaConexion, strIdAdjudicacion);
            NegRecaudos.EventOkString += NegRecaudos_EventOkString;
            NegRecaudos.EventErrorString += NegRecaudos_EventErrorString;
            NegRecaudos.Event_ErrorTableNgRecaudos += NegRecaudos_Event_ErrorTableNgRecaudos;
            this.Text = "Adicionar Recaudos Juridicos";
            StrOperacion = "Adicionar";
            StrIdAdjudicacion = strIdAdjudicacion;
            BsRecaudos.DataSource = NegRecaudos.EntRecaudosJuridico;
            userDatosClientes1.Inicio(NegRecaudos);

            CmbOperacion.Properties.DataSource = NegRecaudos.DtOperacion;
            CmbOperacion.Properties.ValueMember = "Operacion";
            CmbOperacion.Properties.DisplayMember = "Operacion";

            CmbFormaPago.Properties.DataSource = NegRecaudos.CnsFormaPago(strFuente);
            CmbFormaPago.Properties.ValueMember = "FormaPago";
            CmbFormaPago.Properties.DisplayMember = "FormaPago";

            this.Text = "Adicionar Recaudo Juridico " + strIdAdjudicacion.ToUpper() + " " + NegRecaudos.DtAdjudicacion.Rows[0]["TitularPrincipal"];

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
            XtraMessageBox.Show(mensaje, "Recaudos Juidicos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegRecaudos_EventErrorString(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Recaudos Juridicos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegRecaudos_EventOkString(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Recaudos Juridicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Disparadores

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BtnGuardar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Este Recaudo?", StrOperacion + " Recaudos Juridicos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                NegRecaudos.MtdAddJuridicos(StrFuente);
            }
        }
    }
}