namespace ControlTotal
{
    partial class XtraSeguimientoPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraSeguimientoPresupuesto));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.GrvSeguimiento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Rango = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdAdjudicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdInmueble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CanCuotas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Presupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Recaudos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnEstadoCuenta = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRecaudoDetallado = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarPdf = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAddSeguimiento = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSeguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.GrvSeguimiento;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1294, 447);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvSeguimiento});
            // 
            // GrvSeguimiento
            // 
            this.GrvSeguimiento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Rango,
            this.IdAdjudicacion,
            this.IdInmueble,
            this.Cliente,
            this.CanCuotas,
            this.Mora,
            this.Presupuesto,
            this.Recaudos});
            this.GrvSeguimiento.GridControl = this.gridControl1;
            this.GrvSeguimiento.Name = "GrvSeguimiento";
            this.GrvSeguimiento.OptionsBehavior.ReadOnly = true;
            this.GrvSeguimiento.OptionsCustomization.AllowColumnMoving = false;
            this.GrvSeguimiento.OptionsCustomization.AllowGroup = false;
            this.GrvSeguimiento.OptionsFind.AlwaysVisible = true;
            this.GrvSeguimiento.OptionsView.ShowFooter = true;
            // 
            // Rango
            // 
            this.Rango.Caption = "Rango";
            this.Rango.FieldName = "Rango";
            this.Rango.Name = "Rango";
            this.Rango.Visible = true;
            this.Rango.VisibleIndex = 3;
            this.Rango.Width = 67;
            // 
            // IdAdjudicacion
            // 
            this.IdAdjudicacion.Caption = "IdAdjudicacion";
            this.IdAdjudicacion.FieldName = "IdAdjudicacion";
            this.IdAdjudicacion.Name = "IdAdjudicacion";
            this.IdAdjudicacion.Visible = true;
            this.IdAdjudicacion.VisibleIndex = 1;
            this.IdAdjudicacion.Width = 85;
            // 
            // IdInmueble
            // 
            this.IdInmueble.Caption = "IdInmueble";
            this.IdInmueble.FieldName = "IdInmueble";
            this.IdInmueble.Name = "IdInmueble";
            this.IdInmueble.Visible = true;
            this.IdInmueble.VisibleIndex = 2;
            this.IdInmueble.Width = 90;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 0;
            this.Cliente.Width = 281;
            // 
            // CanCuotas
            // 
            this.CanCuotas.Caption = "CantCuotas";
            this.CanCuotas.FieldName = "CantCuotas";
            this.CanCuotas.Name = "CanCuotas";
            this.CanCuotas.Visible = true;
            this.CanCuotas.VisibleIndex = 4;
            this.CanCuotas.Width = 69;
            // 
            // Mora
            // 
            this.Mora.Caption = "Mora";
            this.Mora.FieldName = "Mora";
            this.Mora.Name = "Mora";
            this.Mora.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Mora", "{0}")});
            this.Mora.Visible = true;
            this.Mora.VisibleIndex = 5;
            this.Mora.Width = 74;
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
            this.Presupuesto.VisibleIndex = 6;
            this.Presupuesto.Width = 178;
            // 
            // Recaudos
            // 
            this.Recaudos.Caption = "Recaudos";
            this.Recaudos.DisplayFormat.FormatString = "{0:n2}";
            this.Recaudos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Recaudos.FieldName = "Recaudos";
            this.Recaudos.Name = "Recaudos";
            this.Recaudos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Recaudos", "{0:n2}")});
            this.Recaudos.Visible = true;
            this.Recaudos.VisibleIndex = 7;
            this.Recaudos.Width = 217;
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
            this.BtnExportarExcel,
            this.BtnExportarPdf,
            this.BtnEstadoCuenta,
            this.BtnRecaudoDetallado,
            this.BtnAddSeguimiento});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnEstadoCuenta),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnRecaudoDetallado),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarPdf),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnAddSeguimiento)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // BtnEstadoCuenta
            // 
            this.BtnEstadoCuenta.Caption = "Estado Cuenta";
            this.BtnEstadoCuenta.Id = 2;
            this.BtnEstadoCuenta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnEstadoCuenta.ImageOptions.SvgImage")));
            this.BtnEstadoCuenta.Name = "BtnEstadoCuenta";
            this.BtnEstadoCuenta.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnEstadoCuenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEstadoCuenta_ItemClick);
            // 
            // BtnRecaudoDetallado
            // 
            this.BtnRecaudoDetallado.Caption = "Recaudos Detallados";
            this.BtnRecaudoDetallado.Id = 3;
            this.BtnRecaudoDetallado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRecaudoDetallado.ImageOptions.SvgImage")));
            this.BtnRecaudoDetallado.Name = "BtnRecaudoDetallado";
            this.BtnRecaudoDetallado.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnRecaudoDetallado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRecaudoDetallado_ItemClick);
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Caption = "Exportar Excel";
            this.BtnExportarExcel.Id = 0;
            this.BtnExportarExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarExcel.ImageOptions.SvgImage")));
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarExcel_ItemClick);
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
            // BtnAddSeguimiento
            // 
            this.BtnAddSeguimiento.Caption = "Add Seguimiento";
            this.BtnAddSeguimiento.Id = 4;
            this.BtnAddSeguimiento.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAddSeguimiento.ImageOptions.SvgImage")));
            this.BtnAddSeguimiento.Name = "BtnAddSeguimiento";
            this.BtnAddSeguimiento.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnAddSeguimiento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAddSeguimiento_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1294, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 471);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1294, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 447);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1294, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 447);
            // 
            // XtraSeguimientoPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 491);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraSeguimientoPresupuesto.IconOptions.SvgImage")));
            this.Name = "XtraSeguimientoPresupuesto";
            this.Text = "XtraSeguimientoPresupuesto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSeguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvSeguimiento;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn CanCuotas;
        private DevExpress.XtraGrid.Columns.GridColumn Mora;
        private DevExpress.XtraGrid.Columns.GridColumn Presupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn Recaudos;
        private DevExpress.XtraGrid.Columns.GridColumn IdAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdInmueble;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnExportarExcel;
        private DevExpress.XtraBars.BarButtonItem BtnExportarPdf;
        private DevExpress.XtraBars.BarButtonItem BtnEstadoCuenta;
        private DevExpress.XtraBars.BarButtonItem BtnRecaudoDetallado;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem BtnAddSeguimiento;
        private DevExpress.XtraGrid.Columns.GridColumn Rango;
    }
}