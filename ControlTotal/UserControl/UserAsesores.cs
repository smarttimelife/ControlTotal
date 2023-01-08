using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class UserAsesores : DevExpress.XtraEditors.XtraUserControl
    {
        public DataTable dt = new DataTable();

        public event EventHandler After_CustomSummaryExists;

        public UserAsesores()
        {
            InitializeComponent();

            dt.Columns.Add("IdCargo", typeof(string));
            dt.Columns.Add("IdTercero", typeof(string));
            dt.Columns.Add("Com1", typeof(decimal));
            dt.Columns.Add("Com2", typeof(decimal));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["IdCargo"] };
            dt.Columns["IdCargo"].AllowDBNull = true;

            GrdAsesores.DataSource = dt;

            GrvAsesores.AddNewRow();
            GrvAsesores.SetFocusedRowCellValue("Com1", 0);
            GrvAsesores.SetFocusedRowCellValue("Com2", 0);
            RpsAsesor.ValueMember = "IdTercero";
            RpsAsesor.DisplayMember = "Asesor";

            RpsCargo.ValueMember = "IdCargo";
            RpsCargo.DisplayMember = "NombreCargo";
        }

        private void GrdAsesores_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    GrvAsesores.DeleteRow(GrvAsesores.FocusedRowHandle);
                    if (GrvAsesores.DataRowCount == 0)
                    {
                        GrvAsesores.AddNewRow();
                        GrvAsesores.SetFocusedRowCellValue("Com1", 0);
                        GrvAsesores.SetFocusedRowCellValue("Com2", 0);
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    string strDato0, strDato1;
                    decimal decCom1 = 0, decCom2 = 0;

                    if (GrvAsesores.FocusedRowHandle == GrvAsesores.RowCount - 1)
                    {
                        GrvAsesores.CloseEditor();
                        strDato0 = GrvAsesores.GetRowCellValue(GrvAsesores.FocusedRowHandle, GrvAsesores.Columns[0]).ToString();
                        strDato1 = GrvAsesores.GetRowCellValue(GrvAsesores.FocusedRowHandle, GrvAsesores.Columns[1]).ToString();
                        decCom1 = Convert.ToDecimal(GrvAsesores.GetRowCellValue(GrvAsesores.FocusedRowHandle, GrvAsesores.Columns[2]).ToString());
                        decCom2 = Convert.ToDecimal(GrvAsesores.GetRowCellValue(GrvAsesores.FocusedRowHandle, GrvAsesores.Columns[3]).ToString());

                        if (strDato0 != string.Empty && strDato1 != string.Empty && decCom1 > 0 && decCom2 > 0)
                        {
                            GrvAsesores.AddNewRow();
                            GrvAsesores.SetFocusedRowCellValue("Com1", 0);
                            GrvAsesores.SetFocusedRowCellValue("Com2", 0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, " Logeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrvAsesores_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (After_CustomSummaryExists != null)
                After_CustomSummaryExists(this, e);
        }
    }
}