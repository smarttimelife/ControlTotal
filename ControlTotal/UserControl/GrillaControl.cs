namespace ControlTotal
{
    #region Librerias

    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //21 DE ABRIL 2020 5;46 AM

    #endregion Librerias

    public partial class GrillaControl : DevExpress.XtraEditors.XtraUserControl
    {
        #region Propiedades

        public event EventHandler After_KeyUp;

        public event EventHandler After_ValidatingEditor;

        public event EventHandler After_CustomSummaryExists;

        public event EventHandler After_KeyPress;

        public event EventHandler After_CellValueChanged;

        public DataTable dt = new DataTable();
        private string _texto;

        [Browsable(true)]
        [Category("Custom")]
        public string Texto
        {
            get { return _texto; }
            set
            {
                _texto = value;
                GroupGrilla.Text = _texto;
            }
        }

        #endregion Propiedades

        #region Constructor

        public GrillaControl()
        {
            InitializeComponent();
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Valor", typeof(decimal));
            dt.Columns["Valor"].DefaultValue = 0;
            GrdControl.DataSource = dt;
            GrvInicial.AddNewRow();
            GrvInicial.SetFocusedRowCellValue("Valor", 0);
        }

        #endregion Constructor

        #region Metodos

        private void GrvControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GrvInicial.DeleteRow(GrvInicial.FocusedRowHandle);
                if (GrvInicial.DataRowCount == 0)
                {
                    GrvInicial.AddNewRow();
                    GrvInicial.SetFocusedRowCellValue("Valor", 0);
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                string strDato0, strDato1;

                if (GrvInicial.FocusedRowHandle == GrvInicial.RowCount - 1)
                {
                    GrvInicial.CloseEditor();
                    strDato0 = GrvInicial.GetRowCellValue(GrvInicial.FocusedRowHandle, GrvInicial.Columns[0]).ToString();
                    strDato1 = GrvInicial.GetRowCellValue(GrvInicial.FocusedRowHandle, GrvInicial.Columns[1]).ToString();

                    if (strDato0 != string.Empty && strDato1 != string.Empty)
                    {
                        GrvInicial.AddNewRow();
                        GrvInicial.SetFocusedRowCellValue("Valor", 0);
                    }
                }
            }
            if (After_KeyUp != null)
                After_KeyUp(this, e);
        }

        private void GrvControl_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (After_ValidatingEditor != null)
                After_ValidatingEditor(this, e);
        }

        private void GrvControl_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (After_CustomSummaryExists != null)
                After_CustomSummaryExists(this, e);
        }

        #endregion Metodos

        public void MtdLimpiar()
        {
            dt.Clear();
            GrvInicial.AddNewRow();
        }

        public void MtdLimpiar2()
        {
            dt.Clear();
        }

        private void GrvInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (After_KeyPress != null)
                After_KeyPress(this, e);
        }

        private void GrvInicial_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (After_CellValueChanged != null)
                After_CellValueChanged(this, e);
        }
    }
}