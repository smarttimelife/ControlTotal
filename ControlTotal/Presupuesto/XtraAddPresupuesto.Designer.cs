namespace ControlTotal
{
    partial class XtraAddPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraAddPresupuesto));
            this.TipoCarteras = new DevExpress.XtraPivotGrid.PivotGridField();
            this.RangoC = new DevExpress.XtraPivotGrid.PivotGridField();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.DtpFechaInicial = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.DtpFechaFinal = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.BtnResumen = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.BtnCalcular = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMontarPresupuesto = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.Cuota = new DevExpress.XtraPivotGrid.PivotGridField();
            this.VrMora = new DevExpress.XtraPivotGrid.PivotGridField();
            this.SdoCuotas = new DevExpress.XtraPivotGrid.PivotGridField();
            this.IdAdjudicaciones = new DevExpress.XtraPivotGrid.PivotGridField();
            this.TitularPrincipales = new DevExpress.XtraPivotGrid.PivotGridField();
            this.UltimoPag = new DevExpress.XtraPivotGrid.PivotGridField();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TipoCartera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rango = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TitularPrincipal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdAdjudicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Concepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CuotaNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SdoCuota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltimoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoCarteras
            // 
            this.TipoCarteras.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.TipoCarteras.AreaIndex = 0;
            this.TipoCarteras.Caption = "TipoCartera";
            this.TipoCarteras.FieldName = "TipoCartera";
            this.TipoCarteras.Name = "TipoCarteras";
            this.TipoCarteras.Width = 150;
            // 
            // RangoC
            // 
            this.RangoC.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.RangoC.AreaIndex = 1;
            this.RangoC.Caption = "Rango";
            this.RangoC.FieldName = "Rango";
            this.RangoC.Name = "RangoC";
            this.RangoC.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
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
            this.DtpFechaInicial,
            this.DtpFechaFinal,
            this.BtnCalcular,
            this.BtnMontarPresupuesto,
            this.BtnExportarExcel,
            this.barCheckItem1,
            this.BtnResumen});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemCheckEdit1,
            this.repositoryItemToggleSwitch1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.DtpFechaInicial),
            new DevExpress.XtraBars.LinkPersistInfo(this.DtpFechaFinal),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnResumen),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnCalcular),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnMontarPresupuesto),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarExcel)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // DtpFechaInicial
            // 
            this.DtpFechaInicial.Caption = "Fecha Inicial";
            this.DtpFechaInicial.Edit = this.repositoryItemDateEdit1;
            this.DtpFechaInicial.EditWidth = 120;
            this.DtpFechaInicial.Id = 0;
            this.DtpFechaInicial.Name = "DtpFechaInicial";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // DtpFechaFinal
            // 
            this.DtpFechaFinal.Caption = "Fecha Final";
            this.DtpFechaFinal.Edit = this.repositoryItemDateEdit2;
            this.DtpFechaFinal.EditWidth = 120;
            this.DtpFechaFinal.Id = 1;
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // BtnResumen
            // 
            this.BtnResumen.Caption = "Detalle";
            this.BtnResumen.Edit = this.repositoryItemToggleSwitch1;
            this.BtnResumen.Id = 8;
            this.BtnResumen.Name = "BtnResumen";
            this.BtnResumen.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnResumen.EditValueChanged += new System.EventHandler(this.BtnResumen_EditValueChanged);
            // 
            // repositoryItemToggleSwitch1
            // 
            this.repositoryItemToggleSwitch1.AutoHeight = false;
            this.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
            this.repositoryItemToggleSwitch1.OffText = "Off";
            this.repositoryItemToggleSwitch1.OnText = "On";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Caption = "Calcular";
            this.BtnCalcular.Id = 2;
            this.BtnCalcular.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnCalcular.ImageOptions.SvgImage")));
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnCalcular.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCalcular_ItemClick);
            // 
            // BtnMontarPresupuesto
            // 
            this.BtnMontarPresupuesto.Caption = "Montar Presupuesto";
            this.BtnMontarPresupuesto.Enabled = false;
            this.BtnMontarPresupuesto.Id = 3;
            this.BtnMontarPresupuesto.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnMontarPresupuesto.ImageOptions.SvgImage")));
            this.BtnMontarPresupuesto.Name = "BtnMontarPresupuesto";
            this.BtnMontarPresupuesto.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnMontarPresupuesto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMontarPresupuesto_ItemClick);
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Caption = "Exportar Excel";
            this.BtnExportarExcel.Enabled = false;
            this.BtnExportarExcel.Id = 5;
            this.BtnExportarExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarExcel.ImageOptions.SvgImage")));
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarExcel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1299, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 371);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1299, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 347);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1299, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 347);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "Detalle";
            this.barCheckItem1.Id = 6;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.Cuota,
            this.VrMora,
            this.SdoCuotas,
            this.RangoC,
            this.TipoCarteras,
            this.IdAdjudicaciones,
            this.TitularPrincipales,
            this.UltimoPag});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 24);
            this.pivotGridControl1.MenuManager = this.barManager1;
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsCustomization.AllowCustomizationForm = false;
            this.pivotGridControl1.OptionsCustomization.AllowEdit = false;
            this.pivotGridControl1.OptionsCustomization.AllowSort = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(1299, 347);
            this.pivotGridControl1.TabIndex = 9;
            // 
            // Cuota
            // 
            this.Cuota.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.Cuota.AreaIndex = 0;
            this.Cuota.Caption = "Cuotas Vencidas";
            this.Cuota.FieldName = "CuotaNumero";
            this.Cuota.Name = "Cuota";
            this.Cuota.RunningTotal = true;
            this.Cuota.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // VrMora
            // 
            this.VrMora.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.VrMora.AreaIndex = 1;
            this.VrMora.Caption = "Dias de Mora";
            this.VrMora.FieldName = "Mora";
            this.VrMora.Name = "VrMora";
            this.VrMora.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.VrMora.Width = 120;
            // 
            // SdoCuotas
            // 
            this.SdoCuotas.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.SdoCuotas.AreaIndex = 2;
            this.SdoCuotas.Caption = "SdoCuota";
            this.SdoCuotas.CellFormat.FormatString = "{0:n2}";
            this.SdoCuotas.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SdoCuotas.FieldName = "SdoCuota";
            this.SdoCuotas.Name = "SdoCuotas";
            this.SdoCuotas.Width = 150;
            // 
            // IdAdjudicaciones
            // 
            this.IdAdjudicaciones.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.IdAdjudicaciones.AreaIndex = 3;
            this.IdAdjudicaciones.Caption = "IdAdjudicacion";
            this.IdAdjudicaciones.FieldName = "IdAdjudicacion";
            this.IdAdjudicaciones.Name = "IdAdjudicaciones";
            // 
            // TitularPrincipales
            // 
            this.TitularPrincipales.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.TitularPrincipales.AreaIndex = 2;
            this.TitularPrincipales.Caption = "TitularPrinicipal";
            this.TitularPrincipales.FieldName = "TitularPrincipal";
            this.TitularPrincipales.Name = "TitularPrincipales";
            this.TitularPrincipales.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals;
            this.TitularPrincipales.Width = 400;
            // 
            // UltimoPag
            // 
            this.UltimoPag.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.UltimoPag.AreaIndex = 4;
            this.UltimoPag.Caption = "Ultimo Pago";
            this.UltimoPag.FieldName = "UltimoPago";
            this.UltimoPag.Name = "UltimoPag";
            this.UltimoPag.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            this.UltimoPag.Width = 120;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1299, 371);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TipoCartera,
            this.Rango,
            this.TitularPrincipal,
            this.IdAdjudicacion,
            this.Fecha,
            this.Concepto,
            this.CuotaNumero,
            this.SdoCuota,
            this.UltimoPago});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SdoCuota", this.SdoCuota, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Concepto", this.Concepto, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TipoCartera, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Rango, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // TipoCartera
            // 
            this.TipoCartera.Caption = "TipoCartera";
            this.TipoCartera.FieldName = "TipoCartera";
            this.TipoCartera.Name = "TipoCartera";
            this.TipoCartera.Visible = true;
            this.TipoCartera.VisibleIndex = 0;
            // 
            // Rango
            // 
            this.Rango.Caption = "Rango";
            this.Rango.FieldName = "Rango";
            this.Rango.Name = "Rango";
            this.Rango.Visible = true;
            this.Rango.VisibleIndex = 0;
            // 
            // TitularPrincipal
            // 
            this.TitularPrincipal.Caption = "TitularPrincipal";
            this.TitularPrincipal.FieldName = "TitularPrincipal";
            this.TitularPrincipal.Name = "TitularPrincipal";
            this.TitularPrincipal.Visible = true;
            this.TitularPrincipal.VisibleIndex = 0;
            // 
            // IdAdjudicacion
            // 
            this.IdAdjudicacion.Caption = "IdAdjudicacion";
            this.IdAdjudicacion.FieldName = "IdAdjudicacion";
            this.IdAdjudicacion.Name = "IdAdjudicacion";
            this.IdAdjudicacion.Visible = true;
            this.IdAdjudicacion.VisibleIndex = 1;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 2;
            // 
            // Concepto
            // 
            this.Concepto.Caption = "Concepto";
            this.Concepto.FieldName = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Concepto", "{0}")});
            this.Concepto.Visible = true;
            this.Concepto.VisibleIndex = 3;
            // 
            // CuotaNumero
            // 
            this.CuotaNumero.Caption = "CuotaNumero";
            this.CuotaNumero.FieldName = "CuotaNumero";
            this.CuotaNumero.Name = "CuotaNumero";
            this.CuotaNumero.Visible = true;
            this.CuotaNumero.VisibleIndex = 4;
            // 
            // SdoCuota
            // 
            this.SdoCuota.Caption = "SdoCuota";
            this.SdoCuota.DisplayFormat.FormatString = "{0:n2}";
            this.SdoCuota.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SdoCuota.FieldName = "SdoCuota";
            this.SdoCuota.Name = "SdoCuota";
            this.SdoCuota.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SdoCuota", "{0:n2}")});
            this.SdoCuota.Visible = true;
            this.SdoCuota.VisibleIndex = 5;
            // 
            // UltimoPago
            // 
            this.UltimoPago.Caption = "UltimoPago";
            this.UltimoPago.FieldName = "UltimoPago";
            this.UltimoPago.Name = "UltimoPago";
            this.UltimoPago.Visible = true;
            this.UltimoPago.VisibleIndex = 6;
            // 
            // XtraAddPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 371);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XtraAddPresupuesto";
            this.Text = "XtraAddPresupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem DtpFechaInicial;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem DtpFechaFinal;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem BtnCalcular;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField Cuota;
        private DevExpress.XtraPivotGrid.PivotGridField VrMora;
        private DevExpress.XtraPivotGrid.PivotGridField SdoCuotas;
        private DevExpress.XtraPivotGrid.PivotGridField RangoC;
        private DevExpress.XtraPivotGrid.PivotGridField TipoCarteras;
        private DevExpress.XtraPivotGrid.PivotGridField IdAdjudicaciones;
        private DevExpress.XtraPivotGrid.PivotGridField TitularPrincipales;
        private DevExpress.XtraPivotGrid.PivotGridField UltimoPag;
        private DevExpress.XtraBars.BarButtonItem BtnMontarPresupuesto;
        
        private DevExpress.XtraBars.BarButtonItem BtnExportarExcel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TipoCartera;
        private DevExpress.XtraGrid.Columns.GridColumn Rango;
        private DevExpress.XtraGrid.Columns.GridColumn TitularPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn IdAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn Concepto;
        private DevExpress.XtraGrid.Columns.GridColumn SdoCuota;
        private DevExpress.XtraGrid.Columns.GridColumn CuotaNumero;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoPago;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarEditItem BtnResumen;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch1;
    }
}