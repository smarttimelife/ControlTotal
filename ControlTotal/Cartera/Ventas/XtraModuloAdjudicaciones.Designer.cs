namespace ControlTotal
{
    partial class XtraModuloAdjudicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraModuloAdjudicaciones));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnAdicionar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDesistir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAprobar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDesaprobar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRadicar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnModRadicacion = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarPdf = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimirAdjudicacion = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImpComisiones = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
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
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjudicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).BeginInit();
            this.SuspendLayout();
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
            this.BtnAdicionar,
            this.BtnModificar,
            this.BtnEliminar,
            this.BtnAprobar,
            this.BtnDesaprobar,
            this.BtnRadicar,
            this.BtnExportar,
            this.BtnExportarPdf,
            this.BtnImprimir,
            this.BtnImprimirAdjudicacion,
            this.BtnImpComisiones,
            this.BtnDesistir,
            this.BtnModRadicacion});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 14;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnAdicionar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnModificar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnEliminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnDesistir),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnAprobar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnDesaprobar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnRadicar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnModRadicacion),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarPdf),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimirAdjudicacion),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImpComisiones)});
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
            // BtnModificar
            // 
            this.BtnModificar.Caption = "Modificar";
            this.BtnModificar.Id = 1;
            this.BtnModificar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnModificar.ImageOptions.SvgImage")));
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnModificar_ItemClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Caption = "Eliminar";
            this.BtnEliminar.Id = 2;
            this.BtnEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnEliminar.ImageOptions.SvgImage")));
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEliminar_ItemClick);
            // 
            // BtnDesistir
            // 
            this.BtnDesistir.Caption = "Desistir";
            this.BtnDesistir.Id = 12;
            this.BtnDesistir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnDesistir.ImageOptions.SvgImage")));
            this.BtnDesistir.Name = "BtnDesistir";
            this.BtnDesistir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnDesistir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDesistir_ItemClick);
            // 
            // BtnAprobar
            // 
            this.BtnAprobar.Caption = "Aprobar";
            this.BtnAprobar.Id = 4;
            this.BtnAprobar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAprobar.ImageOptions.SvgImage")));
            this.BtnAprobar.Name = "BtnAprobar";
            this.BtnAprobar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnAprobar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAprobar_ItemClick);
            // 
            // BtnDesaprobar
            // 
            this.BtnDesaprobar.Caption = "Desaprobar";
            this.BtnDesaprobar.Id = 5;
            this.BtnDesaprobar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnDesaprobar.ImageOptions.SvgImage")));
            this.BtnDesaprobar.Name = "BtnDesaprobar";
            this.BtnDesaprobar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnDesaprobar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDesaprobar_ItemClick);
            // 
            // BtnRadicar
            // 
            this.BtnRadicar.Caption = "Add Radicacion";
            this.BtnRadicar.Id = 6;
            this.BtnRadicar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRadicar.ImageOptions.SvgImage")));
            this.BtnRadicar.Name = "BtnRadicar";
            this.BtnRadicar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnRadicar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRadicar_ItemClick);
            // 
            // BtnModRadicacion
            // 
            this.BtnModRadicacion.Caption = "Modifcar Radicacion";
            this.BtnModRadicacion.Id = 13;
            this.BtnModRadicacion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnModRadicacion.ImageOptions.SvgImage")));
            this.BtnModRadicacion.Name = "BtnModRadicacion";
            this.BtnModRadicacion.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnModRadicacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnModRadicacion_ItemClick);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Caption = "Exportar Excel";
            this.BtnExportar.Id = 7;
            this.BtnExportar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportar.ImageOptions.SvgImage")));
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportar_ItemClick);
            // 
            // BtnExportarPdf
            // 
            this.BtnExportarPdf.Caption = "Exportar Pdf";
            this.BtnExportarPdf.Id = 8;
            this.BtnExportarPdf.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarPdf.ImageOptions.SvgImage")));
            this.BtnExportarPdf.Name = "BtnExportarPdf";
            this.BtnExportarPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarPdf_ItemClick);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Imprimir Listado";
            this.BtnImprimir.Id = 9;
            this.BtnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimir.ImageOptions.SvgImage")));
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // BtnImprimirAdjudicacion
            // 
            this.BtnImprimirAdjudicacion.Caption = "Imprimir Adjudicacion";
            this.BtnImprimirAdjudicacion.Id = 10;
            this.BtnImprimirAdjudicacion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimirAdjudicacion.ImageOptions.SvgImage")));
            this.BtnImprimirAdjudicacion.Name = "BtnImprimirAdjudicacion";
            this.BtnImprimirAdjudicacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimirAdjudicacion_ItemClick);
            // 
            // BtnImpComisiones
            // 
            this.BtnImpComisiones.Caption = "Imprimir Comisiones";
            this.BtnImpComisiones.Id = 11;
            this.BtnImpComisiones.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImpComisiones.ImageOptions.SvgImage")));
            this.BtnImpComisiones.Name = "BtnImpComisiones";
            this.BtnImpComisiones.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImpComisiones_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1327, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 405);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 381);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1327, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 381);
            // 
            // GrdAdjudicacion
            // 
            this.GrdAdjudicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdAdjudicacion.Location = new System.Drawing.Point(0, 24);
            this.GrdAdjudicacion.MainView = this.GrvAdjudicacion;
            this.GrdAdjudicacion.Name = "GrdAdjudicacion";
            this.GrdAdjudicacion.Size = new System.Drawing.Size(1327, 381);
            this.GrdAdjudicacion.TabIndex = 6;
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
            this.Estado,
            this.FechaEntrega});
            this.GrvAdjudicacion.GridControl = this.GrdAdjudicacion;
            this.GrvAdjudicacion.Name = "GrvAdjudicacion";
            this.GrvAdjudicacion.OptionsBehavior.ReadOnly = true;
            this.GrvAdjudicacion.OptionsCustomization.AllowColumnMoving = false;
            this.GrvAdjudicacion.OptionsCustomization.AllowGroup = false;
            this.GrvAdjudicacion.OptionsView.ShowFooter = true;
            this.GrvAdjudicacion.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.GrvAdjudicacion_RowStyle);
            this.GrvAdjudicacion.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.GrvAdjudicacion_CustomRowCellEdit);
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
            this.IdAdjudicacion.Width = 46;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 0;
            this.Fecha.Width = 102;
            // 
            // IdInmueble
            // 
            this.IdInmueble.Caption = "Inmueble";
            this.IdInmueble.FieldName = "IdInmueble";
            this.IdInmueble.Name = "IdInmueble";
            this.IdInmueble.Visible = true;
            this.IdInmueble.VisibleIndex = 2;
            this.IdInmueble.Width = 69;
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
            this.TitularPrincipal.Width = 201;
            // 
            // SegundoTitular
            // 
            this.SegundoTitular.Caption = "Segundo Titular";
            this.SegundoTitular.FieldName = "SegundoTitular";
            this.SegundoTitular.Name = "SegundoTitular";
            this.SegundoTitular.Visible = true;
            this.SegundoTitular.VisibleIndex = 5;
            this.SegundoTitular.Width = 203;
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
            this.Valor.Width = 113;
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
            this.RcdCapital.Width = 100;
            // 
            // UltFechaRcd
            // 
            this.UltFechaRcd.Caption = "UltFechaRcd";
            this.UltFechaRcd.DisplayFormat.FormatString = "d";
            this.UltFechaRcd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.UltFechaRcd.FieldName = "UltFechaRcd";
            this.UltFechaRcd.Name = "UltFechaRcd";
            this.UltFechaRcd.Visible = true;
            this.UltFechaRcd.VisibleIndex = 8;
            this.UltFechaRcd.Width = 102;
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
            this.Saldo.VisibleIndex = 9;
            this.Saldo.Width = 95;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 10;
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.Caption = "FechaEntrega";
            this.FechaEntrega.FieldName = "FechaEntrega";
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.Visible = true;
            this.FechaEntrega.VisibleIndex = 11;
            // 
            // XtraModuloAdjudicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 405);
            this.Controls.Add(this.GrdAdjudicacion);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XtraModuloAdjudicaciones";
            this.Text = "XtraModuloAdjudicaciones";
            this.Activated += new System.EventHandler(this.XtraModuloAdjudicacion_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjudicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem BtnAdicionar;
        private DevExpress.XtraBars.BarButtonItem BtnModificar;
        private DevExpress.XtraBars.BarButtonItem BtnEliminar;
  
        private DevExpress.XtraBars.BarButtonItem BtnAprobar;
        private DevExpress.XtraBars.BarButtonItem BtnDesaprobar;
        private DevExpress.XtraBars.BarButtonItem BtnRadicar;
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
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn FechaEntrega;
        private DevExpress.XtraBars.BarButtonItem BtnExportar;
        private DevExpress.XtraBars.BarButtonItem BtnExportarPdf;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.BarButtonItem BtnImprimirAdjudicacion;
        private DevExpress.XtraBars.BarButtonItem BtnImpComisiones;
        private DevExpress.XtraBars.BarButtonItem BtnDesistir;
        private DevExpress.XtraBars.BarButtonItem BtnModRadicacion;
    }
}