using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControlTotal
{
    public delegate void meserror(string mensaje);

    public partial class GrillaCapital : DevExpress.XtraEditors.XtraUserControl
    {
        public OperCalculos calculos = new OperCalculos();
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

        public GrillaCapital()
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

        private void CmbPeriodo_Validated(object sender, EventArgs e)
        {
            TxtValor.EditValue = calculos.Capital();
        }

        private void DtpInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}