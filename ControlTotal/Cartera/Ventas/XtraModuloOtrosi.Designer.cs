namespace ControlTotal
{
    partial class XtraModuloOtrosi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraModuloOtrosi));
            this.GrdOtrosi = new DevExpress.XtraGrid.GridControl();
            this.GrvAdjudicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdOtrosi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdAdjudicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdInmueble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Contrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TitularPrincipal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SegundoTitular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RcdCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RcdInteres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnAdicionar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAprobar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCorrerFechas = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimiOtrosi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BtnEliminar = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOtrosi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdOtrosi
            // 
            this.GrdOtrosi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdOtrosi.Location = new System.Drawing.Point(0, 24);
            this.GrdOtrosi.MainView = this.GrvAdjudicacion;
            this.GrdOtrosi.Name = "GrdOtrosi";
            this.GrdOtrosi.Size = new System.Drawing.Size(1233, 465);
            this.GrdOtrosi.TabIndex = 3;
            this.GrdOtrosi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvAdjudicacion});
            // 
            // GrvAdjudicacion
            // 
            this.GrvAdjudicacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdOtrosi,
            this.IdAdjudicacion,
            this.IdInmueble,
            this.Contrato,
            this.TitularPrincipal,
            this.SegundoTitular,
            this.Valor,
            this.RcdCapital,
            this.RcdInteres,
            this.Saldo,
            this.Estado});
            this.GrvAdjudicacion.GridControl = this.GrdOtrosi;
            this.GrvAdjudicacion.Name = "GrvAdjudicacion";
            this.GrvAdjudicacion.OptionsView.ShowFooter = true;
            // 
            // IdOtrosi
            // 
            this.IdOtrosi.Caption = "IdOtrosi";
            this.IdOtrosi.FieldName = "IdOtrosi";
            this.IdOtrosi.Name = "IdOtrosi";
            this.IdOtrosi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdOtrosi", "{0}")});
            this.IdOtrosi.Visible = true;
            this.IdOtrosi.VisibleIndex = 0;
            this.IdOtrosi.Width = 57;
            // 
            // IdAdjudicacion
            // 
            this.IdAdjudicacion.Caption = "Adj";
            this.IdAdjudicacion.FieldName = "IdAdjudicacion";
            this.IdAdjudicacion.Name = "IdAdjudicacion";
            this.IdAdjudicacion.Visible = true;
            this.IdAdjudicacion.VisibleIndex = 1;
            this.IdAdjudicacion.Width = 42;
            // 
            // IdInmueble
            // 
            this.IdInmueble.Caption = "Inmueble";
            this.IdInmueble.FieldName = "IdInmueble";
            this.IdInmueble.Name = "IdInmueble";
            this.IdInmueble.Visible = true;
            this.IdInmueble.VisibleIndex = 2;
            this.IdInmueble.Width = 56;
            // 
            // Contrato
            // 
            this.Contrato.Caption = "Contrato";
            this.Contrato.FieldName = "Contrato";
            this.Contrato.Name = "Contrato";
            this.Contrato.Visible = true;
            this.Contrato.VisibleIndex = 3;
            this.Contrato.Width = 51;
            // 
            // TitularPrincipal
            // 
            this.TitularPrincipal.Caption = "Titular Principal";
            this.TitularPrincipal.FieldName = "TitularPrincipal";
            this.TitularPrincipal.Name = "TitularPrincipal";
            this.TitularPrincipal.Visible = true;
            this.TitularPrincipal.VisibleIndex = 4;
            this.TitularPrincipal.Width = 184;
            // 
            // SegundoTitular
            // 
            this.SegundoTitular.Caption = "Segundo Titular";
            this.SegundoTitular.FieldName = "SegundoTitular";
            this.SegundoTitular.Name = "SegundoTitular";
            this.SegundoTitular.Visible = true;
            this.SegundoTitular.VisibleIndex = 5;
            this.SegundoTitular.Width = 186;
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
            this.Valor.Width = 103;
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
            this.RcdCapital.VisibleIndex = 7;
            this.RcdCapital.Width = 91;
            // 
            // RcdInteres
            // 
            this.RcdInteres.Caption = "RcdInteres";
            this.RcdInteres.DisplayFormat.FormatString = "{0:n2}";
            this.RcdInteres.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RcdInteres.FieldName = "RcdInteresCte";
            this.RcdInteres.Name = "RcdInteres";
            this.RcdInteres.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RcdInteresCte", "{0:n2}")});
            this.RcdInteres.Visible = true;
            this.RcdInteres.VisibleIndex = 8;
            this.RcdInteres.Width = 94;
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
            this.Saldo.VisibleIndex = 9;
            this.Saldo.Width = 87;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 10;
            this.Estado.Width = 110;
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
            this.BtnAdicionar,
            this.BtnAprobar,
            this.BtnImprimiOtrosi,
            this.BtnExportarExcel,
            this.BtnSalir,
            this.BtnImprimir,
            this.BtnCorrerFechas,
            this.BtnEliminar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnAdicionar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnAprobar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnEliminar, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnCorrerFechas),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimiOtrosi),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnSalir)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Caption = "Adicionar";
            this.BtnAdicionar.Id = 0;
            this.BtnAdicionar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAdicionar.ImageOptions.SvgImage")));
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnAdicionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAdicionar_ItemClick);
            // 
            // BtnAprobar
            // 
            this.BtnAprobar.Caption = "Aprobar";
            this.BtnAprobar.Id = 2;
            this.BtnAprobar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAprobar.ImageOptions.SvgImage")));
            this.BtnAprobar.Name = "BtnAprobar";
            this.BtnAprobar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnAprobar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAprobar_ItemClick);
            // 
            // BtnCorrerFechas
            // 
            this.BtnCorrerFechas.Caption = "Correr Fechas";
            this.BtnCorrerFechas.Id = 7;
            this.BtnCorrerFechas.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnCorrerFechas.ImageOptions.SvgImage")));
            this.BtnCorrerFechas.Name = "BtnCorrerFechas";
            this.BtnCorrerFechas.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnCorrerFechas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.BtnCorrerFechas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCorrerFechas_ItemClick);
            // 
            // BtnImprimiOtrosi
            // 
            this.BtnImprimiOtrosi.Caption = "Imprimir Otrosi";
            this.BtnImprimiOtrosi.Id = 3;
            this.BtnImprimiOtrosi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimiOtrosi.ImageOptions.SvgImage")));
            this.BtnImprimiOtrosi.Name = "BtnImprimiOtrosi";
            this.BtnImprimiOtrosi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnImprimiOtrosi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimiOtrosi_ItemClick);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Imprimir Listado";
            this.BtnImprimir.Id = 6;
            this.BtnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimir.ImageOptions.SvgImage")));
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Caption = "Excel";
            this.BtnExportarExcel.Id = 4;
            this.BtnExportarExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarExcel.ImageOptions.SvgImage")));
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarExcel_ItemClick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Caption = "Salir";
            this.BtnSalir.Id = 5;
            this.BtnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSalir.ImageOptions.SvgImage")));
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSalir_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1233, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 489);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1233, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 465);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1233, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 465);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Caption = "Eliminar";
            this.BtnEliminar.Id = 8;
            this.BtnEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnEliminar.ImageOptions.SvgImage")));
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEliminar_ItemClick);
            // 
            // XtraModuloOtrosi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 509);
            this.Controls.Add(this.GrdOtrosi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraModuloOtrosi.IconOptions.SvgImage")));
            this.Name = "XtraModuloOtrosi";
            this.Text = "XtraModuloOtrosi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XtraModuloOtrosi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdOtrosi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GrdOtrosi;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdInmueble;
        private DevExpress.XtraGrid.Columns.GridColumn Contrato;
        private DevExpress.XtraGrid.Columns.GridColumn TitularPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn SegundoTitular;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn RcdCapital;
        private DevExpress.XtraGrid.Columns.GridColumn RcdInteres;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn IdOtrosi;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnAdicionar;
        private DevExpress.XtraBars.BarButtonItem BtnAprobar;
        private DevExpress.XtraBars.BarButtonItem BtnImprimiOtrosi;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.BarButtonItem BtnExportarExcel;
        private DevExpress.XtraBars.BarButtonItem BtnSalir;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem BtnCorrerFechas;
        private DevExpress.XtraBars.BarButtonItem BtnEliminar;
    }
}