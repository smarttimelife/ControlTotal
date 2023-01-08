namespace ControlTotal
{
    partial class XtraModuloRecaudoJuridico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraModuloRecaudoJuridico));
            this.GrdAdjudicacion = new DevExpress.XtraGrid.GridControl();
            this.GrvAdjudicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdAdjudicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdInmueble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Contrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TitularPrincipal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SegundoTitular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RcdCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltFechaRcd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiasMora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnAdicionar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEstadoCuenta = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRecaudosDetallados = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RcdJuridico = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjudicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdAdjudicacion
            // 
            this.GrdAdjudicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdAdjudicacion.Location = new System.Drawing.Point(0, 89);
            this.GrdAdjudicacion.MainView = this.GrvAdjudicacion;
            this.GrdAdjudicacion.Name = "GrdAdjudicacion";
            this.GrdAdjudicacion.Size = new System.Drawing.Size(1305, 355);
            this.GrdAdjudicacion.TabIndex = 4;
            this.GrdAdjudicacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvAdjudicacion});
            // 
            // GrvAdjudicacion
            // 
            this.GrvAdjudicacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdAdjudicacion,
            this.Fecha,
            this.IdInmueble,
            this.Contrato,
            this.TitularPrincipal,
            this.SegundoTitular,
            this.Valor,
            this.RcdCapital,
            this.UltFechaRcd,
            this.Saldo,
            this.DiasMora,
            this.Mora,
            this.FechaEntrega,
            this.RcdJuridico});
            this.GrvAdjudicacion.GridControl = this.GrdAdjudicacion;
            this.GrvAdjudicacion.Name = "GrvAdjudicacion";
            this.GrvAdjudicacion.OptionsView.ShowFooter = true;
            // 
            // IdAdjudicacion
            // 
            this.IdAdjudicacion.Caption = "Adj";
            this.IdAdjudicacion.FieldName = "IdAdjudicacion";
            this.IdAdjudicacion.Name = "IdAdjudicacion";
            this.IdAdjudicacion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdAdjudicacion", "{0}")});
            this.IdAdjudicacion.Visible = true;
            this.IdAdjudicacion.VisibleIndex = 1;
            this.IdAdjudicacion.Width = 54;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 0;
            this.Fecha.Width = 78;
            // 
            // IdInmueble
            // 
            this.IdInmueble.Caption = "Inmueble";
            this.IdInmueble.FieldName = "IdInmueble";
            this.IdInmueble.Name = "IdInmueble";
            this.IdInmueble.Visible = true;
            this.IdInmueble.VisibleIndex = 2;
            this.IdInmueble.Width = 58;
            // 
            // Contrato
            // 
            this.Contrato.Caption = "Contrato";
            this.Contrato.FieldName = "Contrato";
            this.Contrato.Name = "Contrato";
            this.Contrato.Visible = true;
            this.Contrato.VisibleIndex = 3;
            this.Contrato.Width = 56;
            // 
            // TitularPrincipal
            // 
            this.TitularPrincipal.Caption = "Titular Principal";
            this.TitularPrincipal.FieldName = "TitularPrincipal";
            this.TitularPrincipal.Name = "TitularPrincipal";
            this.TitularPrincipal.Visible = true;
            this.TitularPrincipal.VisibleIndex = 4;
            this.TitularPrincipal.Width = 144;
            // 
            // SegundoTitular
            // 
            this.SegundoTitular.Caption = "Segundo Titular";
            this.SegundoTitular.FieldName = "SegundoTitular";
            this.SegundoTitular.Name = "SegundoTitular";
            this.SegundoTitular.Visible = true;
            this.SegundoTitular.VisibleIndex = 5;
            this.SegundoTitular.Width = 146;
            // 
            // Valor
            // 
            this.Valor.Caption = "Valor";
            this.Valor.DisplayFormat.FormatString = "{0:n2}";
            this.Valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Valor.FieldName = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor", "{0:n2}")});
            this.Valor.Visible = true;
            this.Valor.VisibleIndex = 6;
            this.Valor.Width = 80;
            // 
            // RcdCapital
            // 
            this.RcdCapital.Caption = "Rcd Capital";
            this.RcdCapital.DisplayFormat.FormatString = "{0:n2}";
            this.RcdCapital.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RcdCapital.FieldName = "RcdCapital";
            this.RcdCapital.Name = "RcdCapital";
            this.RcdCapital.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RcdCapital", "{0:n2}")});
            this.RcdCapital.Visible = true;
            this.RcdCapital.VisibleIndex = 8;
            this.RcdCapital.Width = 70;
            // 
            // UltFechaRcd
            // 
            this.UltFechaRcd.Caption = "UltFechaRcd";
            this.UltFechaRcd.DisplayFormat.FormatString = "d";
            this.UltFechaRcd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.UltFechaRcd.FieldName = "UltFechaRcd";
            this.UltFechaRcd.Name = "UltFechaRcd";
            this.UltFechaRcd.Visible = true;
            this.UltFechaRcd.VisibleIndex = 9;
            this.UltFechaRcd.Width = 72;
            // 
            // Saldo
            // 
            this.Saldo.Caption = "Saldo";
            this.Saldo.DisplayFormat.FormatString = "{0:n2}";
            this.Saldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Saldo.FieldName = "SdoCapital";
            this.Saldo.Name = "Saldo";
            this.Saldo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SdoCapital", "{0:n2}")});
            this.Saldo.Visible = true;
            this.Saldo.VisibleIndex = 10;
            this.Saldo.Width = 66;
            // 
            // DiasMora
            // 
            this.DiasMora.Caption = "DiasMora";
            this.DiasMora.FieldName = "DiasMora";
            this.DiasMora.Name = "DiasMora";
            this.DiasMora.Visible = true;
            this.DiasMora.VisibleIndex = 11;
            this.DiasMora.Width = 50;
            // 
            // Mora
            // 
            this.Mora.Caption = "Mora";
            this.Mora.DisplayFormat.FormatString = "{0:n2}";
            this.Mora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Mora.FieldName = "Mora";
            this.Mora.Name = "Mora";
            this.Mora.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mora", "{0:n2}")});
            this.Mora.Visible = true;
            this.Mora.VisibleIndex = 12;
            this.Mora.Width = 98;
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.Caption = "FechaEntrega";
            this.FechaEntrega.FieldName = "FechaEntrega";
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.Visible = true;
            this.FechaEntrega.VisibleIndex = 13;
            this.FechaEntrega.Width = 83;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnAdicionar,
            this.BtnExportar,
            this.BtnImprimir,
            this.BtnEstadoCuenta,
            this.BtnRecaudosDetallados});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(1305, 89);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Caption = "Adicionar";
            this.BtnAdicionar.Id = 1;
            this.BtnAdicionar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAdicionar.ImageOptions.SvgImage")));
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAdicionar_ItemClick);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Caption = "Exportar Excel";
            this.BtnExportar.Id = 2;
            this.BtnExportar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportar.ImageOptions.SvgImage")));
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportar_ItemClick);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Imprimir Listado";
            this.BtnImprimir.Id = 3;
            this.BtnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimir.ImageOptions.SvgImage")));
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // BtnEstadoCuenta
            // 
            this.BtnEstadoCuenta.Caption = "Estado Cuenta";
            this.BtnEstadoCuenta.Id = 4;
            this.BtnEstadoCuenta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnEstadoCuenta.ImageOptions.SvgImage")));
            this.BtnEstadoCuenta.Name = "BtnEstadoCuenta";
            this.BtnEstadoCuenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEstadoCuenta_ItemClick);
            // 
            // BtnRecaudosDetallados
            // 
            this.BtnRecaudosDetallados.Caption = "Recaudos Detallados";
            this.BtnRecaudosDetallados.Id = 5;
            this.BtnRecaudosDetallados.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRecaudosDetallados.ImageOptions.SvgImage")));
            this.BtnRecaudosDetallados.Name = "BtnRecaudosDetallados";
            this.BtnRecaudosDetallados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRecaudosDetallados_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Operaciones";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAdicionar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnExportar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnImprimir);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnEstadoCuenta);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnRecaudosDetallados);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Recaudos Juridicos";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // RcdJuridico
            // 
            this.RcdJuridico.Caption = "RcdJuridico";
            this.RcdJuridico.DisplayFormat.FormatString = "{0:n2}";
            this.RcdJuridico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RcdJuridico.FieldName = "RcdJuridico";
            this.RcdJuridico.Name = "RcdJuridico";
            this.RcdJuridico.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RcdJuridico", "{0:n2}")});
            this.RcdJuridico.Visible = true;
            this.RcdJuridico.VisibleIndex = 7;
            // 
            // XtraModuloRecaudoJuridico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 444);
            this.Controls.Add(this.GrdAdjudicacion);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraModuloRecaudoJuridico.IconOptions.SvgImage")));
            this.Name = "XtraModuloRecaudoJuridico";
            this.Ribbon = this.ribbonControl1;
            this.Text = "XtraModuloRecaudoJuridico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjudicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GrdAdjudicacion;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn IdInmueble;
        private DevExpress.XtraGrid.Columns.GridColumn Contrato;
        private DevExpress.XtraGrid.Columns.GridColumn TitularPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn SegundoTitular;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn RcdCapital;
        private DevExpress.XtraGrid.Columns.GridColumn UltFechaRcd;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo;
        private DevExpress.XtraGrid.Columns.GridColumn DiasMora;
        private DevExpress.XtraGrid.Columns.GridColumn Mora;
        private DevExpress.XtraGrid.Columns.GridColumn FechaEntrega;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem BtnAdicionar;
        private DevExpress.XtraBars.BarButtonItem BtnExportar;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.BarButtonItem BtnEstadoCuenta;
        private DevExpress.XtraBars.BarButtonItem BtnRecaudosDetallados;
        private DevExpress.XtraGrid.Columns.GridColumn RcdJuridico;
    }
}