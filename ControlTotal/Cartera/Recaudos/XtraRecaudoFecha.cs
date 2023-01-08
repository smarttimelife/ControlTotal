namespace ControlTotal
{
    #region Librerias

    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //09 De Septiembre 2020

    #endregion Librerias

    public partial class XtraRecaudoFecha : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negReportes NegReportes;
        private BindingSource BsRecaudos = new BindingSource();
        private string StrOpcion = string.Empty;

        #endregion Propiedades

        #region Constructores

        public XtraRecaudoFecha(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegReportes = new negReportes(CadenaConexion);
            NegReportes.Event_ErrorTableNgConsultas += NegReportes_Event_ErrorTableNgConsultas;
            NegReportes.Event_ErrorTableReporte += NegReportes_Event_ErrorTableReporte;
            NegReportes.Event_OkTableReporte += NegReportes_Event_OkTableReporte;
            BsRecaudos.DataSource = NegReportes.EntConsultaFecha;
            DtpFechaInicial.DataBindings.Add("EditValue", BsRecaudos, "FechaInicial", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFechaFinal.DataBindings.Add("EditValue", BsRecaudos, "FechaFinal", true, DataSourceUpdateMode.OnPropertyChanged);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegReportes_Event_OkTableReporte(string mensaje, System.Data.DataTable dataTable)
        {
            GrdAdjudicacion.DataSource = dataTable;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            if (dataTable.Rows.Count > 0)
            {
                BtnImprimirListado.Enabled = true;
                BtnExportarExcel.Enabled = true;
                BtnImprimirRecibo.Enabled = true;
            }
        }

        private void NegReportes_Event_ErrorTableReporte(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Recaudos Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            BtnImprimirListado.Enabled = false;
            BtnExportarExcel.Enabled = false;
            BtnImprimirRecibo.Enabled = false;
        }

        private void NegReportes_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Recaudos Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            BtnImprimirListado.Enabled = false;
            BtnExportarExcel.Enabled = false;
            BtnImprimirRecibo.Enabled = false;
        }

        #endregion Disparadores

        #region Metodos y Eventos

        private void BtnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            NegReportes.CnsRecaudoFecha();
        }

        private void BtnImprimirRecibo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string IdRecaudo = GrvAdjudicacion.GetFocusedRowCellValue("IdRecaudo").ToString();
            decimal Valor = Convert.ToDecimal(GrvAdjudicacion.GetFocusedRowCellValue("Valor"));
            XtraRptReciboCaja Documento = new XtraRptReciboCaja(CadenaConexion, IdRecaudo, Valor);
            Documento.ShowDialog();
        }

        private void BtnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdAdjudicacion);
        }

        private void BtnImprimirListado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(GrdAdjudicacion, "RECAUDOS POR FECHA DESDE " + NegReportes.EntConsultaFecha.FechaInicial.ToShortDateString() +
                             " HASTA " + NegReportes.EntConsultaFecha.FechaFinal.ToShortDateString());
        }

        #endregion Metodos y Eventos
    }
}