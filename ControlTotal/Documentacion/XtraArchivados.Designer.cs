namespace ControlTotal
{
    partial class XtraArchivados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraArchivados));
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.BtnAceptar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEnviarCerrado = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarPdf = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrvAdjudicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Adj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdInmueble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Contrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TitularPrincipal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SegundoTitular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RcdCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RcdInteres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Documentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdAdjudicacion = new DevExpress.XtraGrid.GridControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjudicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1280, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 372);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnExportarExcel,
            this.BtnExportarPdf,
            this.BtnImprimir,
            this.BtnEnviarCerrado,
            this.BtnAceptar});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar3
            // 
            this.bar3.BarName = "Menú principal";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnAceptar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnEnviarCerrado),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarPdf),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimir)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Menú principal";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Caption = "Aceptar";
            this.BtnAceptar.Id = 4;
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAceptar_ItemClick);
            // 
            // BtnEnviarCerrado
            // 
            this.BtnEnviarCerrado.Caption = "Cerrar";
            this.BtnEnviarCerrado.Id = 3;
            this.BtnEnviarCerrado.Name = "BtnEnviarCerrado";
            this.BtnEnviarCerrado.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnEnviarCerrado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEnviarCerrado_ItemClick);
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Caption = "ExportarExcel";
            this.BtnExportarExcel.Id = 0;
            this.BtnExportarExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarExcel.ImageOptions.SvgImage")));
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarExcel_ItemClick);
            // 
            // BtnExportarPdf
            // 
            this.BtnExportarPdf.Caption = "Exportar Pdf";
            this.BtnExportarPdf.Id = 1;
            this.BtnExportarPdf.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarPdf.ImageOptions.SvgImage")));
            this.BtnExportarPdf.Name = "BtnExportarPdf";
            this.BtnExportarPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarPdf_ItemClick);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Imprimir";
            this.BtnImprimir.Id = 2;
            this.BtnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimir.ImageOptions.SvgImage")));
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Barra de estado";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1280, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 396);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1280, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 372);
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
            this.Saldo.Width = 107;
            // 
            // GrvAdjudicacion
            // 
            this.GrvAdjudicacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Adj,
            this.Fecha,
            this.IdInmueble,
            this.Contrato,
            this.TitularPrincipal,
            this.SegundoTitular,
            this.Valor,
            this.RcdCapital,
            this.RcdInteres,
            this.Saldo,
            this.Documentacion});
            this.GrvAdjudicacion.GridControl = this.GrdAdjudicacion;
            this.GrvAdjudicacion.Name = "GrvAdjudicacion";
            this.GrvAdjudicacion.OptionsBehavior.ReadOnly = true;
            this.GrvAdjudicacion.OptionsView.ShowFooter = true;
            this.GrvAdjudicacion.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.GrvAdjudicacion_RowStyle);
            this.GrvAdjudicacion.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.GrvAdjudicacion_CustomRowCellEdit);
            // 
            // Adj
            // 
            this.Adj.Caption = "Adj";
            this.Adj.FieldName = "IdAdjudicacion";
            this.Adj.Name = "Adj";
            this.Adj.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdAdjudicacion", "{0}")});
            this.Adj.Visible = true;
            this.Adj.VisibleIndex = 1;
            this.Adj.Width = 61;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 0;
            this.Fecha.Width = 66;
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
            this.Contrato.Width = 57;
            // 
            // TitularPrincipal
            // 
            this.TitularPrincipal.Caption = "TitularPrincipal";
            this.TitularPrincipal.FieldName = "TitularPrincipal";
            this.TitularPrincipal.Name = "TitularPrincipal";
            this.TitularPrincipal.Visible = true;
            this.TitularPrincipal.VisibleIndex = 4;
            this.TitularPrincipal.Width = 126;
            // 
            // SegundoTitular
            // 
            this.SegundoTitular.Caption = "SegundoTitular";
            this.SegundoTitular.FieldName = "SegundoTitular";
            this.SegundoTitular.Name = "SegundoTitular";
            this.SegundoTitular.Visible = true;
            this.SegundoTitular.VisibleIndex = 5;
            this.SegundoTitular.Width = 141;
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
            this.Valor.Width = 104;
            // 
            // RcdCapital
            // 
            this.RcdCapital.Caption = "RcdCapital";
            this.RcdCapital.DisplayFormat.FormatString = "{0:n2}";
            this.RcdCapital.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RcdCapital.FieldName = "RcdCapital";
            this.RcdCapital.Name = "RcdCapital";
            this.RcdCapital.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RcdCapital", "{0:n2}")});
            this.RcdCapital.Visible = true;
            this.RcdCapital.VisibleIndex = 7;
            this.RcdCapital.Width = 103;
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
            this.RcdInteres.Width = 81;
            // 
            // Documentacion
            // 
            this.Documentacion.Caption = "Documentacion";
            this.Documentacion.FieldName = "Documentacion";
            this.Documentacion.Name = "Documentacion";
            this.Documentacion.Visible = true;
            this.Documentacion.VisibleIndex = 10;
            this.Documentacion.Width = 86;
            // 
            // GrdAdjudicacion
            // 
            this.GrdAdjudicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdAdjudicacion.Location = new System.Drawing.Point(0, 24);
            this.GrdAdjudicacion.MainView = this.GrvAdjudicacion;
            this.GrdAdjudicacion.Name = "GrdAdjudicacion";
            this.GrdAdjudicacion.Size = new System.Drawing.Size(1280, 372);
            this.GrdAdjudicacion.TabIndex = 6;
            this.GrdAdjudicacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvAdjudicacion});
            this.GrdAdjudicacion.DoubleClick += new System.EventHandler(this.GrdAdjudicacion_DoubleClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Menú principal";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Menú principal";
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // XtraArchivados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 416);
            this.Controls.Add(this.GrdAdjudicacion);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XtraArchivados";
            this.Text = "XtraArchivados";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjudicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem BtnEnviarCerrado;
        private DevExpress.XtraBars.BarButtonItem BtnExportarExcel;
        private DevExpress.XtraBars.BarButtonItem BtnExportarPdf;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraGrid.GridControl GrdAdjudicacion;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Adj;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn IdInmueble;
        private DevExpress.XtraGrid.Columns.GridColumn Contrato;
        private DevExpress.XtraGrid.Columns.GridColumn TitularPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn SegundoTitular;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn RcdCapital;
        private DevExpress.XtraGrid.Columns.GridColumn RcdInteres;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo;
        private DevExpress.XtraGrid.Columns.GridColumn Documentacion;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnAceptar;
    }
}