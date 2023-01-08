namespace ControlTotal
{
    partial class XtraCnsPresupuestoPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraCnsPresupuestoPeriodo));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.CmbPeriodo = new DevExpress.XtraBars.BarEditItem();
            this.RpsPeriodo = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnConsultar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarPdf = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.GrdSeguimiento = new DevExpress.XtraGrid.GridControl();
            this.GrvSeguimiento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Adj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoCartera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Presupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Recaudo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RcdMora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rango = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSeguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSeguimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.CmbPeriodo,
            this.BtnConsultar,
            this.BtnExportarExcel,
            this.BtnExportarPdf,
            this.BtnImprimir});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RpsPeriodo});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.CmbPeriodo),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnConsultar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarPdf),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimir)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // CmbPeriodo
            // 
            this.CmbPeriodo.Caption = "Periodo";
            this.CmbPeriodo.Edit = this.RpsPeriodo;
            this.CmbPeriodo.EditWidth = 120;
            this.CmbPeriodo.Id = 0;
            this.CmbPeriodo.Name = "CmbPeriodo";
            this.CmbPeriodo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // RpsPeriodo
            // 
            this.RpsPeriodo.AutoHeight = false;
            this.RpsPeriodo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RpsPeriodo.Name = "RpsPeriodo";
            this.RpsPeriodo.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Caption = "Consultar";
            this.BtnConsultar.Id = 1;
            this.BtnConsultar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnConsultar.ImageOptions.SvgImage")));
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnConsultar_ItemClick);
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Caption = "Exportar Excel";
            this.BtnExportarExcel.Enabled = false;
            this.BtnExportarExcel.Id = 2;
            this.BtnExportarExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarExcel.ImageOptions.SvgImage")));
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarExcel_ItemClick);
            // 
            // BtnExportarPdf
            // 
            this.BtnExportarPdf.Caption = "Exportar Pdf";
            this.BtnExportarPdf.Enabled = false;
            this.BtnExportarPdf.Id = 3;
            this.BtnExportarPdf.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarPdf.ImageOptions.SvgImage")));
            this.BtnExportarPdf.Name = "BtnExportarPdf";
            this.BtnExportarPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarPdf_ItemClick);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Imprimir";
            this.BtnImprimir.Enabled = false;
            this.BtnImprimir.Id = 4;
            this.BtnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimir.ImageOptions.SvgImage")));
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1281, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 425);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1281, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 401);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1281, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 401);
            // 
            // GrdSeguimiento
            // 
            this.GrdSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdSeguimiento.Location = new System.Drawing.Point(0, 24);
            this.GrdSeguimiento.MainView = this.GrvSeguimiento;
            this.GrdSeguimiento.MenuManager = this.barManager1;
            this.GrdSeguimiento.Name = "GrdSeguimiento";
            this.GrdSeguimiento.Size = new System.Drawing.Size(1281, 401);
            this.GrdSeguimiento.TabIndex = 4;
            this.GrdSeguimiento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvSeguimiento});
            // 
            // GrvSeguimiento
            // 
            this.GrvSeguimiento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Adj,
            this.Cliente,
            this.TipoCartera,
            this.Cto,
            this.Cta,
            this.Mora,
            this.Presupuesto,
            this.Recaudo,
            this.RcdMora,
            this.Saldo,
            this.Rango});
            this.GrvSeguimiento.GridControl = this.GrdSeguimiento;
            this.GrvSeguimiento.GroupCount = 2;
            this.GrvSeguimiento.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", this.Saldo, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Recaudo", this.Recaudo, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RcdMora", this.RcdMora, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Presupuesto", this.Presupuesto, "{0:n2}")});
            this.GrvSeguimiento.Name = "GrvSeguimiento";
            this.GrvSeguimiento.OptionsBehavior.ReadOnly = true;
            this.GrvSeguimiento.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TipoCartera, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Rango, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Adj
            // 
            this.Adj.Caption = "Adj";
            this.Adj.FieldName = "IdAdjudicacion";
            this.Adj.Name = "Adj";
            this.Adj.Visible = true;
            this.Adj.VisibleIndex = 0;
            this.Adj.Width = 71;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 1;
            this.Cliente.Width = 248;
            // 
            // TipoCartera
            // 
            this.TipoCartera.Caption = "TipoCartera";
            this.TipoCartera.FieldName = "TipoCartera";
            this.TipoCartera.Name = "TipoCartera";
            this.TipoCartera.Visible = true;
            this.TipoCartera.VisibleIndex = 2;
            // 
            // Cto
            // 
            this.Cto.Caption = "Cto";
            this.Cto.FieldName = "Concepto";
            this.Cto.Name = "Cto";
            this.Cto.Visible = true;
            this.Cto.VisibleIndex = 2;
            this.Cto.Width = 46;
            // 
            // Cta
            // 
            this.Cta.Caption = "Cta";
            this.Cta.FieldName = "CuotaNumero";
            this.Cta.Name = "Cta";
            this.Cta.Visible = true;
            this.Cta.VisibleIndex = 3;
            this.Cta.Width = 45;
            // 
            // Mora
            // 
            this.Mora.Caption = "Mora";
            this.Mora.FieldName = "Mora";
            this.Mora.Name = "Mora";
            this.Mora.Visible = true;
            this.Mora.VisibleIndex = 4;
            this.Mora.Width = 50;
            // 
            // Presupuesto
            // 
            this.Presupuesto.Caption = "Presupuesto";
            this.Presupuesto.DisplayFormat.FormatString = "{0:n2}";
            this.Presupuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Presupuesto.FieldName = "Presupuesto";
            this.Presupuesto.Name = "Presupuesto";
            this.Presupuesto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Presupuesto", "{0:n2}")});
            this.Presupuesto.Visible = true;
            this.Presupuesto.VisibleIndex = 5;
            this.Presupuesto.Width = 133;
            // 
            // Recaudo
            // 
            this.Recaudo.Caption = "Recaudo";
            this.Recaudo.DisplayFormat.FormatString = "{0:n2}";
            this.Recaudo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Recaudo.FieldName = "Recaudo";
            this.Recaudo.Name = "Recaudo";
            this.Recaudo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Recaudo", "{0:n2}")});
            this.Recaudo.Visible = true;
            this.Recaudo.VisibleIndex = 6;
            this.Recaudo.Width = 145;
            // 
            // RcdMora
            // 
            this.RcdMora.Caption = "RcdMora";
            this.RcdMora.DisplayFormat.FormatString = "{0:n2}";
            this.RcdMora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RcdMora.FieldName = "RcdMora";
            this.RcdMora.Name = "RcdMora";
            this.RcdMora.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RcdMora", "{0:n2}")});
            this.RcdMora.Visible = true;
            this.RcdMora.VisibleIndex = 7;
            this.RcdMora.Width = 145;
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
            this.Saldo.Width = 178;
            // 
            // Rango
            // 
            this.Rango.Caption = "Rango";
            this.Rango.FieldName = "Rango";
            this.Rango.Name = "Rango";
            this.Rango.Visible = true;
            this.Rango.VisibleIndex = 9;
            // 
            // XtraCnsPresupuestoPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 445);
            this.Controls.Add(this.GrdSeguimiento);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraCnsPresupuestoPeriodo.IconOptions.SvgImage")));
            this.Name = "XtraCnsPresupuestoPeriodo";
            this.Text = "XtraCnsPresupuestoPeriodo";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSeguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSeguimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarEditItem CmbPeriodo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RpsPeriodo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraBars.BarButtonItem BtnConsultar;
        private DevExpress.XtraBars.BarButtonItem BtnExportarExcel;
        private DevExpress.XtraBars.BarButtonItem BtnExportarPdf;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl GrdSeguimiento;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvSeguimiento;
        private DevExpress.XtraGrid.Columns.GridColumn Adj;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn TipoCartera;
        private DevExpress.XtraGrid.Columns.GridColumn Cto;
        private DevExpress.XtraGrid.Columns.GridColumn Cta;
        private DevExpress.XtraGrid.Columns.GridColumn Mora;
        private DevExpress.XtraGrid.Columns.GridColumn Presupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn Recaudo;
        private DevExpress.XtraGrid.Columns.GridColumn RcdMora;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo;
        private DevExpress.XtraGrid.Columns.GridColumn Rango;
    }
}