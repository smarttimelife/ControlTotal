namespace ControlTotal
{
    #region Libreria

    using Cartera;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Data;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA

    #endregion Libreria

    public partial class XtraPagoComision : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negComisiones NegComisiones;
        private BindingSource BsCausar = new BindingSource();

        #endregion Propiedades

        #region Constructores

        public XtraPagoComision(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegComisiones = new negComisiones(CadenaConexion);
            BsCausar.DataSource = NegComisiones.EntDatosComision;
            NegComisiones.ErrorString_Event_Comision += NegComisiones_ErrorString_Event_Comision;
            NegComisiones.Event_ErrorTableNgConsultas += NegComisiones_Event_ErrorTableNgConsultas;

            NegComisiones.OkString_Event_Comision += NegComisiones_OkString_Event_Comision;

            RpsNegocios.DataSource = NegComisiones.CnsDtConsulta("RsmComisionesPdte");
            RpsNegocios.DisplayMember = "Cliente";
            RpsNegocios.ValueMember = "IdAdjudicacion";

            CmbNegocio.DataBindings.Add("EditValue", BsCausar, "IdAdjudicacion", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaPago.DataBindings.Add("EditValue", BsCausar, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTotalPagar.DataBindings.Add("EditValue", BsCausar, "TotalComision", true, DataSourceUpdateMode.OnPropertyChanged);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegComisiones_OkString_Event_Comision(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Pago de Comisiones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegComisiones_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Pago de Comisiones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegComisiones_ErrorString_Event_Comision(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Pago de Comisiones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            BtnGuardar.Enabled = true;
        }

        #endregion Disparadores

        #region Metodos y Eventos

        private void CmbNegocio_EditValueChanged(object sender, EventArgs e)
        {
            NegComisiones.DtComision = NegComisiones.CnsDtConsultaStrId("ComisionesIdAdj", CmbNegocio.EditValue);
            GrdComisiones.DataSource = NegComisiones.DtComision;
        }

        private void GrvComisiones_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                for (int i = 0; i < GrvComisiones.DataRowCount; i++)
                {
                    if (GrvComisiones.IsRowSelected(i))
                    {
                        GrvComisiones.SetRowCellValue(i, GrvComisiones.Columns["TotalPagar"], GrvComisiones.GetRowCellValue(i, "PagoNeto"));
                    }
                    else
                    {
                        GrvComisiones.SetRowCellValue(i, GrvComisiones.Columns["TotalPagar"], 0.00);
                    }
                }
                TxtTotalPagar.EditValue = GrvComisiones.Columns["TotalPagar"].SummaryItem.SummaryValue;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Pago de Comisiones", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BtnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnGuardar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de Pagar Esta Comision?", "Pagos de Comisiones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                NegComisiones.PagarComision();
            }
        }

        private void BtnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        #endregion Metodos y Eventos
    }
}