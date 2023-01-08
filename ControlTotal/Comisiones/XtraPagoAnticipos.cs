namespace ControlTotal
{
    #region Librerias

    using Cartera;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Data;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA

    #endregion Librerias

    public partial class XtraPagoAnticipos : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negComisiones NegComisiones;
        private BindingSource BsCausar = new BindingSource();

        #endregion Propiedades

        #region Constructores

        public XtraPagoAnticipos(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegComisiones = new negComisiones(CadenaConexion);
            NegComisiones.Event_ErrorTableNgConsultas += NegComisiones_Event_ErrorTableNgConsultas;
            NegComisiones.ErrorString_Event_Comision += NegComisiones_ErrorString_Event_Comision;
            NegComisiones.OkString_Event_Comision += NegComisiones_OkString_Event_Comision;
            gridControl.DataSource = NegComisiones.CnsAnticiposPdte();
            BsCausar.DataSource = NegComisiones.EntDatosComision;
            DtpFechaPago.DataBindings.Add("EditValue", BsCausar, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtTotalPagar.DataBindings.Add("EditValue", BsCausar, "TotalComision", true, DataSourceUpdateMode.OnPropertyChanged);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegComisiones_OkString_Event_Comision(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Pagos de Anticipos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegComisiones_ErrorString_Event_Comision(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Pagos de Anticipos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegComisiones_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Pagos de Anticipos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos y Eventos

        private void GrvAnticipos_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                for (int i = 0; i < GrvAnticipos.DataRowCount; i++)
                {
                    if (GrvAnticipos.IsRowSelected(i))
                    {
                        GrvAnticipos.SetRowCellValue(i, GrvAnticipos.Columns["TotalPagar"], GrvAnticipos.GetRowCellValue(i, "Saldo"));
                    }
                    else
                    {
                        GrvAnticipos.SetRowCellValue(i, GrvAnticipos.Columns["TotalPagar"], 0.00);
                    }
                }
                TxtTotalPagar.EditValue = GrvAnticipos.Columns["TotalPagar"].SummaryItem.SummaryValue;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Pago de Anticipos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        #endregion Metodos y Eventos

        private void BtnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnGuardar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de Pagar Estos Anticipos?", "Pagos de Anticipos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                NegComisiones.PagarAnticipo();
            }
        }
    }
}