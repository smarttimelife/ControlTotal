namespace ControlTotal
{
    #region Libreria

    using Cartera;
    using Conexiones;
    using DevExpress.Utils;
    using DevExpress.XtraEditors;
    using DevExpress.XtraGrid;
    using DevExpress.XtraSplashScreen;
    using System.Windows.Forms;

    #endregion Libreria

    public partial class XtraComisionesPendientes : DevExpress.XtraEditors.XtraForm

    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negComisiones NegComisiones;

        #endregion Propiedades

        #region Constructores

        public XtraComisionesPendientes(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegComisiones = new negComisiones(CadenaConexion);
            NegComisiones.Event_ErrorTableNgConsultas += NegComisiones_Event_ErrorTableNgConsultas;
            gridControl.DataSource = NegComisiones.CnsDtConsulta("ComisionesPdte");
            gridView.OptionsBehavior.AutoExpandAllGroups = true;
            MtdColumna();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegComisiones_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Comisiones Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos y Eventos

        private void BtnExporarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(gridControl);
        }

        private void BtnExportarPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarPdf(gridControl);
        }

        private void BtnImprimi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.impirmir(gridControl, "COMISIONES PENDIENTES DE PAGO");
        }

        private void MtdColumna()
        {
            gridView.OptionsBehavior.AutoExpandAllGroups = true;

            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = "Comision1";
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView.GroupSummary.Add(item);
            item.DisplayFormat = "{0:n2}";
            item.ShowInGroupColumnFooter = gridView.Columns["Comision1"];

            gridView.OptionsBehavior.AutoExpandAllGroups = true;

            GridGroupSummaryItem item2 = new GridGroupSummaryItem();
            item2.FieldName = "Comision2";
            item2.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView.GroupSummary.Add(item2);
            item2.DisplayFormat = "{0:n2}";
            item2.ShowInGroupColumnFooter = gridView.Columns["Comision2"];

            GridGroupSummaryItem item5 = new GridGroupSummaryItem();
            item5.FieldName = "TotalComision";
            item5.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView.GroupSummary.Add(item5);
            item5.DisplayFormat = "{0:n2}";
            item5.ShowInGroupColumnFooter = gridView.Columns["TotalComision"];

            GridGroupSummaryItem item6 = new GridGroupSummaryItem();
            item6.FieldName = "Retencion";
            item6.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView.GroupSummary.Add(item6);
            item6.DisplayFormat = "{0:n2}";
            item6.ShowInGroupColumnFooter = gridView.Columns["Retencion"];

            GridGroupSummaryItem item7 = new GridGroupSummaryItem();
            item7.FieldName = "SaldoAnticipo";
            item7.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView.GroupSummary.Add(item7);
            item7.DisplayFormat = "{0:n2}";
            item7.ShowInGroupColumnFooter = gridView.Columns["SaldoAnticipo"];

            GridGroupSummaryItem item8 = new GridGroupSummaryItem();
            item8.FieldName = "PagoNeto";
            item8.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView.GroupSummary.Add(item8);
            item8.DisplayFormat = "{0:n2}";
            item8.ShowInGroupColumnFooter = gridView.Columns["PagoNeto"];

            GridGroupSummaryItem item9 = new GridGroupSummaryItem();
            item9.FieldName = "PagoComision";
            item9.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView.GroupSummary.Add(item9);
            item9.DisplayFormat = "{0:n2}";
            item9.ShowInGroupColumnFooter = gridView.Columns["PagoComision"];

            gridView.Columns["PagoNeto"].DisplayFormat.FormatType = FormatType.Numeric;
            gridView.Columns["PagoNeto"].DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns["PagoNeto"].Summary.Clear();

            gridView.Columns["TotalComision"].DisplayFormat.FormatType = FormatType.Numeric;
            gridView.Columns["TotalComision"].DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns["TotalComision"].Summary.Clear();

            gridView.Columns["SaldoAnticipo"].DisplayFormat.FormatType = FormatType.Numeric;
            gridView.Columns["SaldoAnticipo"].DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns["SaldoAnticipo"].Summary.Clear();

            gridView.Columns["PagoComision"].DisplayFormat.FormatType = FormatType.Numeric;
            gridView.Columns["PagoComision"].DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns["PagoComision"].Summary.Clear();

            gridView.Columns["PagoNeto"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "PagoNeto", "{0:n2}");
            gridView.Columns["TotalComision"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "TotalComision", "{0:n2}");
            gridView.Columns["SaldoAnticipo"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "SaldoAnticipo", "{0:n2}");
            gridView.Columns["PagoComision"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "PagoComision", "{0:n2}");
        }

        #endregion Metodos y Eventos
    }
}