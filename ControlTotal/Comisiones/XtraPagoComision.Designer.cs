namespace ControlTotal
{
    partial class XtraPagoComision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraPagoComision));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.DtpFechaPago = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.CmbNegocio = new DevExpress.XtraBars.BarEditItem();
            this.RpsNegocios = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TxtTotalPagar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.BtnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.GrdComisiones = new DevExpress.XtraGrid.GridControl();
            this.GrvComisiones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Gestor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comision1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comision2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LqdCom1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LqdCom2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PagoComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaldoAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PagoNeto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdComisiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvComisiones)).BeginInit();
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
            this.DtpFechaPago,
            this.CmbNegocio,
            this.TxtTotalPagar,
            this.BtnGuardar,
            this.BtnImprimir,
            this.BtnSalir});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.RpsNegocios,
            this.repositoryItemTextEdit1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.DtpFechaPago),
            new DevExpress.XtraBars.LinkPersistInfo(this.CmbNegocio),
            new DevExpress.XtraBars.LinkPersistInfo(this.TxtTotalPagar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnGuardar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnSalir)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // DtpFechaPago
            // 
            this.DtpFechaPago.Caption = "Fecha Pago";
            this.DtpFechaPago.Edit = this.repositoryItemDateEdit1;
            this.DtpFechaPago.EditWidth = 100;
            this.DtpFechaPago.Id = 0;
            this.DtpFechaPago.Name = "DtpFechaPago";
            this.DtpFechaPago.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
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
            // CmbNegocio
            // 
            this.CmbNegocio.Caption = "Negocio";
            this.CmbNegocio.Edit = this.RpsNegocios;
            this.CmbNegocio.EditWidth = 250;
            this.CmbNegocio.Id = 1;
            this.CmbNegocio.Name = "CmbNegocio";
            this.CmbNegocio.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.CmbNegocio.EditValueChanged += new System.EventHandler(this.CmbNegocio_EditValueChanged);
            // 
            // RpsNegocios
            // 
            this.RpsNegocios.AutoHeight = false;
            this.RpsNegocios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RpsNegocios.Name = "RpsNegocios";
            this.RpsNegocios.PopupView = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.Caption = "Total a Pagar";
            this.TxtTotalPagar.Edit = this.repositoryItemTextEdit1;
            this.TxtTotalPagar.EditWidth = 120;
            this.TxtTotalPagar.Id = 2;
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "{0:n2}";
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.ReadOnly = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Caption = "Pagar";
            this.BtnGuardar.Id = 3;
            this.BtnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGuardar_ItemClick);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Imprimir";
            this.BtnImprimir.Id = 4;
            this.BtnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimir.ImageOptions.SvgImage")));
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Caption = "Salir";
            this.BtnSalir.Id = 5;
            this.BtnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSalir.ImageOptions.SvgImage")));
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSalir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1269, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 388);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1269, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1269, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 364);
            // 
            // GrdComisiones
            // 
            this.GrdComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdComisiones.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrdComisiones.Location = new System.Drawing.Point(0, 24);
            this.GrdComisiones.MainView = this.GrvComisiones;
            this.GrdComisiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrdComisiones.Name = "GrdComisiones";
            this.GrdComisiones.Size = new System.Drawing.Size(1269, 364);
            this.GrdComisiones.TabIndex = 4;
            this.GrdComisiones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvComisiones});
            // 
            // GrvComisiones
            // 
            this.GrvComisiones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Gestor,
            this.NombreCargo,
            this.Comision1,
            this.Comision2,
            this.LqdCom1,
            this.LqdCom2,
            this.PagoComision,
            this.SaldoAnticipo,
            this.PagoNeto,
            this.TotalPagar});
            this.GrvComisiones.DetailHeight = 284;
            this.GrvComisiones.GridControl = this.GrdComisiones;
            this.GrvComisiones.Name = "GrvComisiones";
            this.GrvComisiones.OptionsBehavior.ReadOnly = true;
            this.GrvComisiones.OptionsSelection.MultiSelect = true;
            this.GrvComisiones.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.GrvComisiones.OptionsView.ShowFooter = true;
            this.GrvComisiones.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.GrvComisiones_SelectionChanged);
            // 
            // Gestor
            // 
            this.Gestor.Caption = "Gestor";
            this.Gestor.FieldName = "Gestor";
            this.Gestor.MinWidth = 21;
            this.Gestor.Name = "Gestor";
            this.Gestor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Nombres", "{0}")});
            this.Gestor.Visible = true;
            this.Gestor.VisibleIndex = 1;
            this.Gestor.Width = 149;
            // 
            // NombreCargo
            // 
            this.NombreCargo.Caption = "NombreCargo";
            this.NombreCargo.FieldName = "NombreCargo";
            this.NombreCargo.MinWidth = 21;
            this.NombreCargo.Name = "NombreCargo";
            this.NombreCargo.Visible = true;
            this.NombreCargo.VisibleIndex = 2;
            this.NombreCargo.Width = 168;
            // 
            // Comision1
            // 
            this.Comision1.Caption = "Com1";
            this.Comision1.FieldName = "Comision1";
            this.Comision1.MinWidth = 21;
            this.Comision1.Name = "Comision1";
            this.Comision1.Visible = true;
            this.Comision1.VisibleIndex = 3;
            this.Comision1.Width = 67;
            // 
            // Comision2
            // 
            this.Comision2.Caption = "Com2";
            this.Comision2.FieldName = "Comision2";
            this.Comision2.MinWidth = 21;
            this.Comision2.Name = "Comision2";
            this.Comision2.Visible = true;
            this.Comision2.VisibleIndex = 4;
            this.Comision2.Width = 56;
            // 
            // LqdCom1
            // 
            this.LqdCom1.Caption = "LqdCom1";
            this.LqdCom1.DisplayFormat.FormatString = "{0:n2}";
            this.LqdCom1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LqdCom1.FieldName = "LqdCom1";
            this.LqdCom1.MinWidth = 21;
            this.LqdCom1.Name = "LqdCom1";
            this.LqdCom1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LqdCom1", "{0:N2}")});
            this.LqdCom1.Visible = true;
            this.LqdCom1.VisibleIndex = 5;
            this.LqdCom1.Width = 81;
            // 
            // LqdCom2
            // 
            this.LqdCom2.Caption = "LqdCom2";
            this.LqdCom2.DisplayFormat.FormatString = "{0:n2}";
            this.LqdCom2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LqdCom2.FieldName = "LqdCom2";
            this.LqdCom2.MinWidth = 21;
            this.LqdCom2.Name = "LqdCom2";
            this.LqdCom2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LqdCom2", "{0:N2}")});
            this.LqdCom2.Visible = true;
            this.LqdCom2.VisibleIndex = 6;
            this.LqdCom2.Width = 81;
            // 
            // PagoComision
            // 
            this.PagoComision.Caption = "PagoComision";
            this.PagoComision.DisplayFormat.FormatString = "{0:n2}";
            this.PagoComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PagoComision.FieldName = "PagoComision";
            this.PagoComision.MinWidth = 21;
            this.PagoComision.Name = "PagoComision";
            this.PagoComision.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PagoComision", "{0:N2}")});
            this.PagoComision.Visible = true;
            this.PagoComision.VisibleIndex = 7;
            this.PagoComision.Width = 81;
            // 
            // SaldoAnticipo
            // 
            this.SaldoAnticipo.Caption = "SaldoAnticipo";
            this.SaldoAnticipo.DisplayFormat.FormatString = "{0:n2}";
            this.SaldoAnticipo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SaldoAnticipo.FieldName = "SaldoAnticipo";
            this.SaldoAnticipo.MinWidth = 21;
            this.SaldoAnticipo.Name = "SaldoAnticipo";
            this.SaldoAnticipo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaldoAnticipo", "{0:N2}")});
            this.SaldoAnticipo.Visible = true;
            this.SaldoAnticipo.VisibleIndex = 8;
            this.SaldoAnticipo.Width = 81;
            // 
            // PagoNeto
            // 
            this.PagoNeto.Caption = "PagoNeto";
            this.PagoNeto.DisplayFormat.FormatString = "{0:n2}";
            this.PagoNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PagoNeto.FieldName = "PagoNeto";
            this.PagoNeto.MinWidth = 21;
            this.PagoNeto.Name = "PagoNeto";
            this.PagoNeto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PagoNeto", "{0:N2}")});
            this.PagoNeto.Visible = true;
            this.PagoNeto.VisibleIndex = 9;
            this.PagoNeto.Width = 120;
            // 
            // TotalPagar
            // 
            this.TotalPagar.Caption = "TotalPagar";
            this.TotalPagar.CustomizationCaption = "{0:n2}";
            this.TotalPagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalPagar.FieldName = "TotalPagar";
            this.TotalPagar.MinWidth = 21;
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPagar", "{0:N2}")});
            this.TotalPagar.Visible = true;
            this.TotalPagar.VisibleIndex = 10;
            this.TotalPagar.Width = 81;
            // 
            // XtraPagoComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 388);
            this.Controls.Add(this.GrdComisiones);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraPagoComision.IconOptions.SvgImage")));
            this.Name = "XtraPagoComision";
            this.Text = "XtraPagoComision";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdComisiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvComisiones)).EndInit();
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
        private DevExpress.XtraBars.BarEditItem DtpFechaPago;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem CmbNegocio;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit RpsNegocios;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraBars.BarEditItem TxtTotalPagar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem BtnGuardar;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.BarButtonItem BtnSalir;
        private DevExpress.XtraGrid.GridControl GrdComisiones;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvComisiones;
        private DevExpress.XtraGrid.Columns.GridColumn Gestor;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCargo;
        private DevExpress.XtraGrid.Columns.GridColumn Comision1;
        private DevExpress.XtraGrid.Columns.GridColumn Comision2;
        private DevExpress.XtraGrid.Columns.GridColumn LqdCom1;
        private DevExpress.XtraGrid.Columns.GridColumn LqdCom2;
        private DevExpress.XtraGrid.Columns.GridColumn PagoComision;
        private DevExpress.XtraGrid.Columns.GridColumn SaldoAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn PagoNeto;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPagar;
    }
}