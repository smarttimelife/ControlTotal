namespace ControlTotal
{
    partial class XtraCnsComisionGestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraCnsComisionGestor));
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.CmbGestor = new DevExpress.XtraBars.BarEditItem();
            this.RpsGestor = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DtpFechaInicial = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.DtpFechaFinal = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.BtnConsultar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarPdf = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.Comision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TasaComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gestor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Negocio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrvSeguimiento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdSeguimiento = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsGestor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSeguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSeguimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1266, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 413);
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
            this.BtnConsultar,
            this.BtnExportarExcel,
            this.BtnExportarPdf,
            this.BtnImprimir,
            this.CmbGestor});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.RpsGestor});
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.CmbGestor),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.DtpFechaInicial, "", false, true, true, 118),
            new DevExpress.XtraBars.LinkPersistInfo(this.DtpFechaFinal),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnConsultar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarPdf),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimir)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // CmbGestor
            // 
            this.CmbGestor.Caption = "Gestor";
            this.CmbGestor.Edit = this.RpsGestor;
            this.CmbGestor.EditWidth = 200;
            this.CmbGestor.Id = 6;
            this.CmbGestor.Name = "CmbGestor";
            this.CmbGestor.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // RpsGestor
            // 
            this.RpsGestor.AutoHeight = false;
            this.RpsGestor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RpsGestor.Name = "RpsGestor";
            this.RpsGestor.PopupView = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // DtpFechaInicial
            // 
            this.DtpFechaInicial.Caption = "Fecha Inicial";
            this.DtpFechaInicial.Edit = this.repositoryItemDateEdit1;
            this.DtpFechaInicial.EditWidth = 120;
            this.DtpFechaInicial.Id = 0;
            this.DtpFechaInicial.Name = "DtpFechaInicial";
            this.DtpFechaInicial.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.DtpFechaFinal.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // BtnConsultar
            // 
            this.BtnConsultar.Caption = "Consultar";
            this.BtnConsultar.Id = 2;
            this.BtnConsultar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnConsultar.ImageOptions.SvgImage")));
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnConsultar_ItemClick);
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Caption = "Exportar Excel";
            this.BtnExportarExcel.Enabled = false;
            this.BtnExportarExcel.Id = 3;
            this.BtnExportarExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarExcel.ImageOptions.SvgImage")));
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarExcel_ItemClick);
            // 
            // BtnExportarPdf
            // 
            this.BtnExportarPdf.Caption = "Exportar Pdf";
            this.BtnExportarPdf.Enabled = false;
            this.BtnExportarPdf.Id = 4;
            this.BtnExportarPdf.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarPdf.ImageOptions.SvgImage")));
            this.BtnExportarPdf.Name = "BtnExportarPdf";
            this.BtnExportarPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarPdf_ItemClick);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Imprimir";
            this.BtnImprimir.Enabled = false;
            this.BtnImprimir.Id = 5;
            this.BtnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimir.ImageOptions.SvgImage")));
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1266, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 437);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1266, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 413);
            // 
            // Comision
            // 
            this.Comision.Caption = "Comision";
            this.Comision.DisplayFormat.FormatString = "{0:n2}";
            this.Comision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Comision.FieldName = "Comision";
            this.Comision.Name = "Comision";
            this.Comision.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Comision", "{0:n2}")});
            this.Comision.Visible = true;
            this.Comision.VisibleIndex = 6;
            this.Comision.Width = 153;
            // 
            // TasaComision
            // 
            this.TasaComision.Caption = "Tasa";
            this.TasaComision.DisplayFormat.FormatString = "{0:n2}";
            this.TasaComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TasaComision.FieldName = "TasaComision";
            this.TasaComision.Name = "TasaComision";
            this.TasaComision.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TasaComision", "{0:n2}")});
            this.TasaComision.Visible = true;
            this.TasaComision.VisibleIndex = 5;
            this.TasaComision.Width = 117;
            // 
            // NombreCargo
            // 
            this.NombreCargo.Caption = "NombreCargo";
            this.NombreCargo.FieldName = "NombreCargo";
            this.NombreCargo.Name = "NombreCargo";
            this.NombreCargo.Visible = true;
            this.NombreCargo.VisibleIndex = 4;
            this.NombreCargo.Width = 171;
            // 
            // IdCargo
            // 
            this.IdCargo.Caption = "IdCargo";
            this.IdCargo.FieldName = "IdCargo";
            this.IdCargo.Name = "IdCargo";
            this.IdCargo.Visible = true;
            this.IdCargo.VisibleIndex = 3;
            this.IdCargo.Width = 81;
            // 
            // Gestor
            // 
            this.Gestor.Caption = "Gestor";
            this.Gestor.FieldName = "Gestor";
            this.Gestor.Name = "Gestor";
            this.Gestor.Visible = true;
            this.Gestor.VisibleIndex = 2;
            this.Gestor.Width = 249;
            // 
            // Negocio
            // 
            this.Negocio.Caption = "Negocio";
            this.Negocio.FieldName = "Negocio";
            this.Negocio.Name = "Negocio";
            this.Negocio.Visible = true;
            this.Negocio.VisibleIndex = 0;
            this.Negocio.Width = 322;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 1;
            this.Fecha.Width = 148;
            // 
            // GrvSeguimiento
            // 
            this.GrvSeguimiento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Fecha,
            this.Negocio,
            this.Gestor,
            this.IdCargo,
            this.NombreCargo,
            this.TasaComision,
            this.Comision});
            this.GrvSeguimiento.GridControl = this.GrdSeguimiento;
            this.GrvSeguimiento.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Comision", this.Comision, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TasaComision", this.TasaComision, "{0:n2}")});
            this.GrvSeguimiento.Name = "GrvSeguimiento";
            this.GrvSeguimiento.OptionsBehavior.AutoExpandAllGroups = true;
            this.GrvSeguimiento.OptionsBehavior.ReadOnly = true;
            this.GrvSeguimiento.OptionsView.ShowFooter = true;
            // 
            // GrdSeguimiento
            // 
            this.GrdSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdSeguimiento.Location = new System.Drawing.Point(0, 24);
            this.GrdSeguimiento.MainView = this.GrvSeguimiento;
            this.GrdSeguimiento.MenuManager = this.barManager1;
            this.GrdSeguimiento.Name = "GrdSeguimiento";
            this.GrdSeguimiento.Size = new System.Drawing.Size(1266, 413);
            this.GrdSeguimiento.TabIndex = 6;
            this.GrdSeguimiento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvSeguimiento});
            // 
            // XtraCnsComisionGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 437);
            this.Controls.Add(this.GrdSeguimiento);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XtraCnsComisionGestor";
            this.Text = "XtraCnsComisionGestor";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsGestor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSeguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSeguimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarEditItem DtpFechaInicial;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem DtpFechaFinal;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem BtnConsultar;
        private DevExpress.XtraBars.BarButtonItem BtnExportarExcel;
        private DevExpress.XtraBars.BarButtonItem BtnExportarPdf;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraGrid.GridControl GrdSeguimiento;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvSeguimiento;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn Negocio;
        private DevExpress.XtraGrid.Columns.GridColumn Gestor;
        private DevExpress.XtraGrid.Columns.GridColumn IdCargo;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCargo;
        private DevExpress.XtraGrid.Columns.GridColumn TasaComision;
        private DevExpress.XtraGrid.Columns.GridColumn Comision;
        private DevExpress.XtraBars.BarEditItem CmbGestor;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit RpsGestor;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
    }
}