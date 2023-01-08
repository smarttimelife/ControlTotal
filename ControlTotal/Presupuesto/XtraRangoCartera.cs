namespace ControlTotal
{
    #region Librerias

    using Cartera;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class XtraRangoCartera : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negPresupuesto NegPresupuesto;

        #endregion Propiedades

        #region Constructores

        public XtraRangoCartera(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegPresupuesto = new negPresupuesto(CadenaConexion);
            RpsTipo.DataSource = NegPresupuesto.DtTipoCartera();
            NegPresupuesto.ErrorString_Event_Presupuesto += NegPresupuesto_ErrorString_Event_Presupuesto;
            NegPresupuesto.Event_ErrorTableNgConsultas += NegPresupuesto_Event_ErrorTableNgConsultas;
            NegPresupuesto.OkString_Event_Presupuesto += NegPresupuesto_OkString_Event_Presupuesto;
            RpsTipo.ValueMember = "TipoCartera";
            RpsTipo.DisplayMember = "TipoCartera";
            gridControl1.DataSource = NegPresupuesto.CnsDtRangoCartera();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegPresupuesto_OkString_Event_Presupuesto(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Rango Cartera", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegPresupuesto_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Rango Cartera", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegPresupuesto_ErrorString_Event_Presupuesto(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Rango Cartera", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Disparadores

        #region Metodos

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BtnGuardar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de Actualizar?", "Rango Cartera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                NegPresupuesto.MtdActualizarRango();
            }
        }

        #endregion Metodos

        private void Adicionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GrvConfig.AddNewRow();
            GrvConfig.SetFocusedRowCellValue("Desde", 0);
            GrvConfig.SetFocusedRowCellValue("Hasta", 0);
        }

        private void Eliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = GrvConfig.FocusedRowHandle;
            GrvConfig.DeleteRow(row);
        }

        private void GrvConfig_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var rowH = GrvConfig.FocusedRowHandle;
            var focusRowVie = (DataRowView)GrvConfig.GetFocusedRow();
            if (focusRowVie == null || focusRowVie.IsNew) return;
            if (rowH >= 0)
                popupMenu1.ShowPopup(new Point(MousePosition.X, MousePosition.Y));
            else
                popupMenu1.HidePopup();
        }
    }
}