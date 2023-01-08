namespace ControlTotal
{
    #region Libreria

    using Cartera;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //12 de Septiembre 2020

    #endregion Libreria

    public partial class XtraConfigAnticipos : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negComisiones NegComisiones;

        #endregion Propiedades

        #region Constructor

        public XtraConfigAnticipos(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegComisiones = new negComisiones(CadenaConexion);
            NegComisiones.Event_ErrorTableNgConsultas += NegComisiones_Event_ErrorTableNgConsultas;
            NegComisiones.OkString_Event_Comision += NegComisiones_OkString_Event_Comision;
            NegComisiones.ErrorString_Event_Comision += NegComisiones_ErrorString_Event_Comision;
            gridControl1.DataSource = NegComisiones.CnsBaseAnticipo();
            RpsCargos.DataSource = NegComisiones.CnsDtConsulta("Cargos");
            RpsCargos.ValueMember = "IdCargo";
            RpsCargos.DisplayMember = "NombreCargo";

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void NegComisiones_ErrorString_Event_Comision(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Configuracion Anticipos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegComisiones_OkString_Event_Comision(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Configuracion Anticipos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegComisiones_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Configuracion Anticipos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos y Eventos

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BtnGuardar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de Actualizar?", "Configuracion Anticipos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                NegComisiones.MtdActulizarTablaAnticipo();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Metodos y Eventos

        private void Adicionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GrvConfig.AddNewRow();
            GrvConfig.SetFocusedRowCellValue("Recaudo1", 0);
            GrvConfig.SetFocusedRowCellValue("Recaudo2", 0);
            GrvConfig.SetFocusedRowCellValue("Anticipo1", 0);
            GrvConfig.SetFocusedRowCellValue("Anticipo2", 0);
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