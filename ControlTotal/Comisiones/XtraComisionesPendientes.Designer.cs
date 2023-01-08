namespace ControlTotal
{
    partial class XtraComisionesPendientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraComisionesPendientes));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnExporarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarPdf = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimi = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DatosCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdGestor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Recaudo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BaseComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comision1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comision2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PagoComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaldoAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PagoNeto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(1277, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 388);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1277, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 364);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1277, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 364);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 24);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1277, 364);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DatosCliente,
            this.IdGestor,
            this.Nombres,
            this.NombreCargo,
            this.Recaudo,
            this.BaseComision,
            this.Comision1,
            this.Comision2,
            this.PagoComision,
            this.TotalComision,
            this.SaldoAnticipo,
            this.PagoNeto});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupCount = 1;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.DatosCliente, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // DatosCliente
            // 
            this.DatosCliente.Caption = "DatosCliente";
            this.DatosCliente.FieldName = "DatosCliente";
            this.DatosCliente.MinWidth = 21;
            this.DatosCliente.Name = "DatosCliente";
            this.DatosCliente.Visible = true;
            this.DatosCliente.VisibleIndex = 1;
            this.DatosCliente.Width = 93;
            // 
            // IdGestor
            // 
            this.IdGestor.Caption = "IdGestor";
            this.IdGestor.FieldName = "IdGestor";
            this.IdGestor.MinWidth = 21;
            this.IdGestor.Name = "IdGestor";
            this.IdGestor.Visible = true;
            this.IdGestor.VisibleIndex = 0;
            this.IdGestor.Width = 93;
            // 
            // Nombres
            // 
            this.Nombres.Caption = "Nombres";
            this.Nombres.FieldName = "Nombres";
            this.Nombres.MinWidth = 21;
            this.Nombres.Name = "Nombres";
            this.Nombres.Visible = true;
            this.Nombres.VisibleIndex = 1;
            this.Nombres.Width = 93;
            // 
            // NombreCargo
            // 
            this.NombreCargo.Caption = "NombreCargo";
            this.NombreCargo.FieldName = "NombreCargo";
            this.NombreCargo.MinWidth = 21;
            this.NombreCargo.Name = "NombreCargo";
            this.NombreCargo.Visible = true;
            this.NombreCargo.VisibleIndex = 2;
            this.NombreCargo.Width = 93;
            // 
            // Recaudo
            // 
            this.Recaudo.Caption = "Recaudo";
            this.Recaudo.DisplayFormat.FormatString = "{0:n2}";
            this.Recaudo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Recaudo.FieldName = "Recaudo";
            this.Recaudo.MinWidth = 21;
            this.Recaudo.Name = "Recaudo";
            this.Recaudo.Visible = true;
            this.Recaudo.VisibleIndex = 3;
            this.Recaudo.Width = 93;
            // 
            // BaseComision
            // 
            this.BaseComision.Caption = "BaseComision";
            this.BaseComision.DisplayFormat.FormatString = "{0:n2}";
            this.BaseComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BaseComision.FieldName = "BaseComision";
            this.BaseComision.MinWidth = 21;
            this.BaseComision.Name = "BaseComision";
            this.BaseComision.Visible = true;
            this.BaseComision.VisibleIndex = 4;
            this.BaseComision.Width = 93;
            // 
            // Comision1
            // 
            this.Comision1.Caption = "Com1";
            this.Comision1.FieldName = "Comision1";
            this.Comision1.MinWidth = 21;
            this.Comision1.Name = "Comision1";
            this.Comision1.Visible = true;
            this.Comision1.VisibleIndex = 5;
            this.Comision1.Width = 93;
            // 
            // Comision2
            // 
            this.Comision2.Caption = "Com2";
            this.Comision2.FieldName = "Comision2";
            this.Comision2.MinWidth = 21;
            this.Comision2.Name = "Comision2";
            this.Comision2.Visible = true;
            this.Comision2.VisibleIndex = 6;
            this.Comision2.Width = 93;
            // 
            // PagoComision
            // 
            this.PagoComision.Caption = "Com Pagada";
            this.PagoComision.DisplayFormat.FormatString = "{0:n2}";
            this.PagoComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PagoComision.FieldName = "PagoComision";
            this.PagoComision.MinWidth = 21;
            this.PagoComision.Name = "PagoComision";
            this.PagoComision.Visible = true;
            this.PagoComision.VisibleIndex = 7;
            this.PagoComision.Width = 93;
            // 
            // TotalComision
            // 
            this.TotalComision.Caption = "TotalComision";
            this.TotalComision.DisplayFormat.FormatString = "{0:n2}";
            this.TotalComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalComision.FieldName = "TotalComision";
            this.TotalComision.MinWidth = 21;
            this.TotalComision.Name = "TotalComision";
            this.TotalComision.Visible = true;
            this.TotalComision.VisibleIndex = 8;
            this.TotalComision.Width = 93;
            // 
            // SaldoAnticipo
            // 
            this.SaldoAnticipo.Caption = "Anticipo";
            this.SaldoAnticipo.DisplayFormat.FormatString = "{0:n2}";
            this.SaldoAnticipo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SaldoAnticipo.FieldName = "SaldoAnticipo";
            this.SaldoAnticipo.MinWidth = 21;
            this.SaldoAnticipo.Name = "SaldoAnticipo";
            this.SaldoAnticipo.Visible = true;
            this.SaldoAnticipo.VisibleIndex = 9;
            this.SaldoAnticipo.Width = 93;
            // 
            // PagoNeto
            // 
            this.PagoNeto.Caption = "PagoNeto";
            this.PagoNeto.DisplayFormat.FormatString = "{0:n2}";
            this.PagoNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PagoNeto.FieldName = "PagoNeto";
            this.PagoNeto.MinWidth = 21;
            this.PagoNeto.Name = "PagoNeto";
            this.PagoNeto.Visible = true;
            this.PagoNeto.VisibleIndex = 10;
            this.PagoNeto.Width = 93;
            // 
            // XtraComisionesPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 388);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XtraComisionesPendientes";
            this.Text = "XtraComisionesPendientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn DatosCliente;
        private DevExpress.XtraGrid.Columns.GridColumn IdGestor;
        private DevExpress.XtraGrid.Columns.GridColumn Nombres;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCargo;
        private DevExpress.XtraGrid.Columns.GridColumn Recaudo;
        private DevExpress.XtraGrid.Columns.GridColumn BaseComision;
        private DevExpress.XtraGrid.Columns.GridColumn Comision1;
        private DevExpress.XtraGrid.Columns.GridColumn Comision2;
        private DevExpress.XtraGrid.Columns.GridColumn PagoComision;
        private DevExpress.XtraGrid.Columns.GridColumn TotalComision;
        private DevExpress.XtraGrid.Columns.GridColumn SaldoAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn PagoNeto;
        private DevExpress.XtraBars.BarButtonItem BtnExporarExcel;
        private DevExpress.XtraBars.BarButtonItem BtnExportarPdf;
        private DevExpress.XtraBars.BarButtonItem BtnImprimi;
    }
}