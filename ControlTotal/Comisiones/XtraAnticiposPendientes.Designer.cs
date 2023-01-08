namespace ControlTotal
{
    partial class XtraAnticiposPendientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraAnticiposPendientes));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdAdjudicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdGestor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gestor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RcdInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LqdAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PagoAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnExporarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarPdf = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 24);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1283, 408);
            this.gridControl.TabIndex = 5;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdAdjudicacion,
            this.Cliente,
            this.NombreCargo,
            this.IdGestor,
            this.Gestor,
            this.RcdInicial,
            this.LqdAnticipo,
            this.PagoAnticipo,
            this.Saldo});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ShowFooter = true;
            // 
            // IdAdjudicacion
            // 
            this.IdAdjudicacion.Caption = "IdAdjudicacion";
            this.IdAdjudicacion.FieldName = "IdAdjudicacion";
            this.IdAdjudicacion.Name = "IdAdjudicacion";
            this.IdAdjudicacion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdAdjudicacion", "{0}")});
            this.IdAdjudicacion.Visible = true;
            this.IdAdjudicacion.VisibleIndex = 0;
            this.IdAdjudicacion.Width = 78;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 1;
            this.Cliente.Width = 175;
            // 
            // NombreCargo
            // 
            this.NombreCargo.Caption = "NombreCargo";
            this.NombreCargo.FieldName = "NombreCargo";
            this.NombreCargo.Name = "NombreCargo";
            this.NombreCargo.Visible = true;
            this.NombreCargo.VisibleIndex = 2;
            this.NombreCargo.Width = 116;
            // 
            // IdGestor
            // 
            this.IdGestor.Caption = "IdGestor";
            this.IdGestor.FieldName = "IdGestor";
            this.IdGestor.Name = "IdGestor";
            this.IdGestor.Visible = true;
            this.IdGestor.VisibleIndex = 3;
            this.IdGestor.Width = 85;
            // 
            // Gestor
            // 
            this.Gestor.Caption = "Gestor";
            this.Gestor.FieldName = "Gestor";
            this.Gestor.Name = "Gestor";
            this.Gestor.Visible = true;
            this.Gestor.VisibleIndex = 4;
            this.Gestor.Width = 160;
            // 
            // RcdInicial
            // 
            this.RcdInicial.Caption = "RcdInicial";
            this.RcdInicial.DisplayFormat.FormatString = "{0:n2}";
            this.RcdInicial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RcdInicial.FieldName = "RcdInicial";
            this.RcdInicial.Name = "RcdInicial";
            this.RcdInicial.Visible = true;
            this.RcdInicial.VisibleIndex = 5;
            this.RcdInicial.Width = 105;
            // 
            // LqdAnticipo
            // 
            this.LqdAnticipo.Caption = "LqdAnticipo";
            this.LqdAnticipo.DisplayFormat.FormatString = "{0:n2}";
            this.LqdAnticipo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LqdAnticipo.FieldName = "LqdAnticipo";
            this.LqdAnticipo.Name = "LqdAnticipo";
            this.LqdAnticipo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LqdAnticipo", "{0:n2}")});
            this.LqdAnticipo.Visible = true;
            this.LqdAnticipo.VisibleIndex = 6;
            this.LqdAnticipo.Width = 118;
            // 
            // PagoAnticipo
            // 
            this.PagoAnticipo.Caption = "PagoAnticipo";
            this.PagoAnticipo.DisplayFormat.FormatString = "{0:n2}";
            this.PagoAnticipo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PagoAnticipo.FieldName = "PagoAnticipo";
            this.PagoAnticipo.Name = "PagoAnticipo";
            this.PagoAnticipo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PagoAnticipo", "{0:n2}")});
            this.PagoAnticipo.Visible = true;
            this.PagoAnticipo.VisibleIndex = 7;
            this.PagoAnticipo.Width = 99;
            // 
            // Saldo
            // 
            this.Saldo.Caption = "Saldo";
            this.Saldo.DisplayFormat.FormatString = "{0:n2}";
            this.Saldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Saldo.FieldName = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", "{0:n2}")});
            this.Saldo.Visible = true;
            this.Saldo.VisibleIndex = 8;
            this.Saldo.Width = 127;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 408);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnExporarExcel,
            this.BtnExportarPdf,
            this.BtnImprimi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExporarExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarPdf),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimi)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // BtnExporarExcel
            // 
            this.BtnExporarExcel.Caption = "Exportar Excel";
            this.BtnExporarExcel.Id = 0;
            this.BtnExporarExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExporarExcel.ImageOptions.SvgImage")));
            this.BtnExporarExcel.Name = "BtnExporarExcel";
            this.BtnExporarExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnExporarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExporarExcel_ItemClick);
            // 
            // BtnExportarPdf
            // 
            this.BtnExportarPdf.Caption = "Exportar Pdf";
            this.BtnExportarPdf.Id = 1;
            this.BtnExportarPdf.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarPdf.ImageOptions.SvgImage")));
            this.BtnExportarPdf.Name = "BtnExportarPdf";
            this.BtnExportarPdf.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnExportarPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarPdf_ItemClick);
            // 
            // BtnImprimi
            // 
            this.BtnImprimi.Caption = "Imprimir Listado";
            this.BtnImprimi.Id = 2;
            this.BtnImprimi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimi.ImageOptions.SvgImage")));
            this.BtnImprimi.Name = "BtnImprimi";
            this.BtnImprimi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnImprimi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimi_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1283, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 432);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1283, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1283, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 408);
            // 
            // XtraAnticiposPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 432);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraAnticiposPendientes.IconOptions.SvgImage")));
            this.Name = "XtraAnticiposPendientes";
            this.Text = "XtraAnticiposPendientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn IdAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCargo;
        private DevExpress.XtraGrid.Columns.GridColumn IdGestor;
        private DevExpress.XtraGrid.Columns.GridColumn Gestor;
        private DevExpress.XtraGrid.Columns.GridColumn RcdInicial;
        private DevExpress.XtraGrid.Columns.GridColumn LqdAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn PagoAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnExporarExcel;
        private DevExpress.XtraBars.BarButtonItem BtnExportarPdf;
        private DevExpress.XtraBars.BarButtonItem BtnImprimi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}