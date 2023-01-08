using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class GrillaCuota : DevExpress.XtraEditors.XtraUserControl
    {
        public OperCalculos calculos = new OperCalculos();

        public event EventHandler After_KeyPress;

        public event EventHandler After_EditValueChanged;

        private BindingSource BsCalculos = new BindingSource();
        private string _texto;

        [Browsable(true)]
        [Category("Custom")]
        public string Texto
        {
            get { return _texto; }
            set
            {
                _texto = value;
                GrupoCuota.Text = _texto;
            }
        }

        public GrillaCuota()
        {
            InitializeComponent();
            BsCalculos.DataSource = calculos.EntCalculos;
            TxtValor.DataBindings.Add("EditValue", BsCalculos, "Capital", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCuota.DataBindings.Add("EditValue", BsCalculos, "Cuota", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtPlazo.DataBindings.Add("EditValue", BsCalculos, "Plazo", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbPeriodo.DataBindings.Add("EditValue", BsCalculos, "Periodo", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTasa.DataBindings.Add("EditValue", BsCalculos, "Tasa", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpInicio.DataBindings.Add("EditValue", BsCalculos, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbPeriodo.Properties.DataSource = calculos.DtPeriodo();
            CmbPeriodo.Properties.ValueMember = "Periodo";
            CmbPeriodo.Properties.DisplayMember = "Periodo";
        }

        private void TxtValor_Validated(object sender, EventArgs e)
        {
            TxtCuota.EditValue = calculos.Cuota();
        }

        private void CmbPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (After_KeyPress != null)
                After_KeyPress(this, e);
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtValor_EditValueChanged(object sender, EventArgs e)
        {
            TxtCuota.EditValue = calculos.Cuota();
            if (After_EditValueChanged != null)
                After_EditValueChanged(this, e);
        }

        public void MtdLimpiar()
        {
            TxtValor.EditValue = 0;
            TxtPlazo.EditValue = 0;
            CmbPeriodo.EditValue = 30;
            TxtCuota.EditValue = 0;
            DtpInicio.EditValue = null;
        }

        public void MtdReadOnly()
        {
            TxtValor.ReadOnly = true;
            TxtTasa.ReadOnly = true;
            TxtCuota.ReadOnly = true;
            DtpInicio.ReadOnly = true;
            CmbPeriodo.ReadOnly = true;
            TxtValor.ReadOnly = true;
        }
    }
}