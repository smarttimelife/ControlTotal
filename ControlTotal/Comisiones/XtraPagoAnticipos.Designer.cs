namespace ControlTotal
{
    partial class XtraPagoAnticipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraPagoAnticipos));
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.DtpFechaPago = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.TxtTotalPagar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.BtnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.RpsNegocios = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.GrvAnticipos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdAdjudicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gestor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RcdInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LqdAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PagoAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAnticipos)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 400);
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
            // 
            // BtnSalir
            // 
            this.BtnSalir.Caption = "Salir";
            this.BtnSalir.Id = 5;
            this.BtnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSalir.ImageOptions.SvgImage")));
            this.BtnSalir.Name = "BtnSalir";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1302, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 424);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1302, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1302, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 400);
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
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 24);
            this.gridControl.MainView = this.GrvAnticipos;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1302, 400);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvAnticipos});
            // 
            // GrvAnticipos
            // 
            this.GrvAnticipos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GrvAnticipos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdAdjudicacion,
            this.Cliente,
            this.NombreCargo,
            this.Gestor,
            this.RcdInicial,
            this.LqdAnticipo,
            this.PagoAnticipo,
            this.Saldo,
            this.TotalPagar});
            this.GrvAnticipos.GridControl = this.gridControl;
            this.GrvAnticipos.Name = "GrvAnticipos";
            this.GrvAnticipos.OptionsBehavior.Editable = false;
            this.GrvAnticipos.OptionsBehavior.ReadOnly = true;
            this.GrvAnticipos.OptionsSelection.MultiSelect = true;
            this.GrvAnticipos.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.GrvAnticipos.OptionsView.ShowFooter = true;
            this.GrvAnticipos.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.GrvAnticipos_SelectionChanged);
            // 
            // IdAdjudicacion
            // 
            this.IdAdjudicacion.Caption = "IdAdjudicacion";
            this.IdAdjudicacion.FieldName = "IdAdjudicacion";
            this.IdAdjudicacion.Name = "IdAdjudicacion";
            this.IdAdjudicacion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdAdjudicacion", "{0}")});
            this.IdAdjudicacion.Visible = true;
            this.IdAdjudicacion.VisibleIndex = 1;
            this.IdAdjudicacion.Width = 67;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 2;
            this.Cliente.Width = 151;
            // 
            // NombreCargo
            // 
            this.NombreCargo.Caption = "NombreCargo";
            this.NombreCargo.FieldName = "NombreCargo";
            this.NombreCargo.Name = "NombreCargo";
            this.NombreCargo.Visible = true;
            this.NombreCargo.VisibleIndex = 3;
            this.NombreCargo.Width = 100;
            // 
            // Gestor
            // 
            this.Gestor.Caption = "Gestor";
            this.Gestor.FieldName = "Gestor";
            this.Gestor.Name = "Gestor";
            this.Gestor.Visible = true;
            this.Gestor.VisibleIndex = 4;
            this.Gestor.Width = 138;
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
            this.RcdInicial.Width = 91;
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
            this.LqdAnticipo.Width = 102;
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
            this.PagoAnticipo.Width = 85;
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
            this.Saldo.Width = 92;
            // 
            // TotalPagar
            // 
            this.TotalPagar.Caption = "TotalPagar";
            this.TotalPagar.DisplayFormat.FormatString = "{0:n2}";
            this.TotalPagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalPagar.FieldName = "TotalPagar";
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPagar", "{0:n2}")});
            this.TotalPagar.Visible = true;
            this.TotalPagar.VisibleIndex = 9;
            this.TotalPagar.Width = 89;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "TotalPagar";
            this.gridColumn1.DisplayFormat.FormatString = "{0:n2}";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:n2}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            this.gridColumn1.Width = 89;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "TotalPagar";
            this.gridColumn2.DisplayFormat.FormatString = "{0:n2}";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:n2}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            this.gridColumn2.Width = 89;
            // 
            // XtraPagoAnticipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 424);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraPagoAnticipos.IconOptions.SvgImage")));
            this.Name = "XtraPagoAnticipos";
            this.Text = "XtraPagoAnticipos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAnticipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarEditItem DtpFechaPago;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit RpsNegocios;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraBars.BarEditItem TxtTotalPagar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem BtnGuardar;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.BarButtonItem BtnSalir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvAnticipos;
        private DevExpress.XtraGrid.Columns.GridColumn IdAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCargo;
        private DevExpress.XtraGrid.Columns.GridColumn Gestor;
        private DevExpress.XtraGrid.Columns.GridColumn RcdInicial;
        private DevExpress.XtraGrid.Columns.GridColumn LqdAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn PagoAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPagar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}