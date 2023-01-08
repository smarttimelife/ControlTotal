namespace ControlTotal
{
    partial class XtraRecaudoFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraRecaudoFecha));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.DtpFechaInicial = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.DtpFechaFinal = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.BtnConsultar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimirRecibo = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimirListado = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.GrdAdjudicacion = new DevExpress.XtraGrid.GridControl();
            this.GrvAdjudicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdAdjudicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdInmueble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TitularPrincipal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Recibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Operacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjudicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).BeginInit();
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
            this.DtpFechaInicial,
            this.DtpFechaFinal,
            this.BtnConsultar,
            this.BtnImprimirRecibo,
            this.BtnExportarExcel,
            this.BtnImprimirListado});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.barManager1.StatusBar = this.bar3;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnConsultar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimirRecibo),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimirListado)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // DtpFechaInicial
            // 
            this.DtpFechaInicial.Caption = "Fecha Inicial";
            this.DtpFechaInicial.Edit = this.repositoryItemDateEdit1;
            this.DtpFechaInicial.EditWidth = 100;
            this.DtpFechaInicial.Id = 0;
            this.DtpFechaInicial.Name = "DtpFechaInicial";
            this.DtpFechaInicial.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
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
            this.DtpFechaFinal.EditWidth = 100;
            this.DtpFechaFinal.Id = 1;
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            this.DtpFechaFinal.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
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
            // BtnImprimirRecibo
            // 
            this.BtnImprimirRecibo.Caption = "ImprimiRecibo";
            this.BtnImprimirRecibo.Enabled = false;
            this.BtnImprimirRecibo.Id = 3;
            this.BtnImprimirRecibo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimirRecibo.ImageOptions.SvgImage")));
            this.BtnImprimirRecibo.Name = "BtnImprimirRecibo";
            this.BtnImprimirRecibo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimirRecibo_ItemClick);
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Caption = "Exportar Excel";
            this.BtnExportarExcel.Enabled = false;
            this.BtnExportarExcel.Id = 4;
            this.BtnExportarExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarExcel.ImageOptions.SvgImage")));
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarExcel_ItemClick);
            // 
            // BtnImprimirListado
            // 
            this.BtnImprimirListado.Caption = "Imprimir Listado";
            this.BtnImprimirListado.Enabled = false;
            this.BtnImprimirListado.Id = 5;
            this.BtnImprimirListado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimirListado.ImageOptions.SvgImage")));
            this.BtnImprimirListado.Name = "BtnImprimirListado";
            this.BtnImprimirListado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimirListado_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1278, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1278, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 406);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1278, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 406);
            // 
            // GrdAdjudicacion
            // 
            this.GrdAdjudicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdAdjudicacion.Location = new System.Drawing.Point(0, 24);
            this.GrdAdjudicacion.MainView = this.GrvAdjudicacion;
            this.GrdAdjudicacion.Name = "GrdAdjudicacion";
            this.GrdAdjudicacion.Size = new System.Drawing.Size(1278, 406);
            this.GrdAdjudicacion.TabIndex = 4;
            this.GrdAdjudicacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvAdjudicacion});
            // 
            // GrvAdjudicacion
            // 
            this.GrvAdjudicacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Fecha,
            this.IdAdjudicacion,
            this.IdInmueble,
            this.TitularPrincipal,
            this.FormaPago,
            this.Valor,
            this.Recibo,
            this.Operacion,
            this.CodBanco});
            this.GrvAdjudicacion.GridControl = this.GrdAdjudicacion;
            this.GrvAdjudicacion.Name = "GrvAdjudicacion";
            this.GrvAdjudicacion.OptionsBehavior.ReadOnly = true;
            this.GrvAdjudicacion.OptionsView.ShowFooter = true;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 0;
            this.Fecha.Width = 96;
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
            this.IdAdjudicacion.Width = 90;
            // 
            // IdInmueble
            // 
            this.IdInmueble.Caption = "Inmueble";
            this.IdInmueble.FieldName = "IdInmueble";
            this.IdInmueble.Name = "IdInmueble";
            this.IdInmueble.Visible = true;
            this.IdInmueble.VisibleIndex = 2;
            this.IdInmueble.Width = 86;
            // 
            // TitularPrincipal
            // 
            this.TitularPrincipal.Caption = "Titular Principal";
            this.TitularPrincipal.FieldName = "TitularPrincipal";
            this.TitularPrincipal.Name = "TitularPrincipal";
            this.TitularPrincipal.Visible = true;
            this.TitularPrincipal.VisibleIndex = 3;
            this.TitularPrincipal.Width = 214;
            // 
            // FormaPago
            // 
            this.FormaPago.Caption = "FormaPago";
            this.FormaPago.FieldName = "FormaPago";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.Visible = true;
            this.FormaPago.VisibleIndex = 8;
            this.FormaPago.Width = 124;
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
            this.Valor.VisibleIndex = 4;
            this.Valor.Width = 118;
            // 
            // Recibo
            // 
            this.Recibo.Caption = "Recibo";
            this.Recibo.FieldName = "Recibo";
            this.Recibo.Name = "Recibo";
            this.Recibo.Visible = true;
            this.Recibo.VisibleIndex = 5;
            this.Recibo.Width = 111;
            // 
            // Operacion
            // 
            this.Operacion.Caption = "Operacion";
            this.Operacion.FieldName = "Operacion";
            this.Operacion.Name = "Operacion";
            this.Operacion.Visible = true;
            this.Operacion.VisibleIndex = 6;
            this.Operacion.Width = 111;
            // 
            // CodBanco
            // 
            this.CodBanco.Caption = "CodBanco";
            this.CodBanco.FieldName = "CodBanco";
            this.CodBanco.Name = "CodBanco";
            this.CodBanco.Visible = true;
            this.CodBanco.VisibleIndex = 7;
            this.CodBanco.Width = 111;
            // 
            // XtraRecaudoFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 450);
            this.Controls.Add(this.GrdAdjudicacion);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraRecaudoFecha.IconOptions.SvgImage")));
            this.Name = "XtraRecaudoFecha";
            this.Text = "XtraRecaudoFecha";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjudicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarEditItem DtpFechaInicial;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem DtpFechaFinal;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem BtnConsultar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem BtnImprimirRecibo;
        private DevExpress.XtraBars.BarButtonItem BtnExportarExcel;
        private DevExpress.XtraBars.BarButtonItem BtnImprimirListado;
        private DevExpress.XtraGrid.GridControl GrdAdjudicacion;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn IdAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdInmueble;
        private DevExpress.XtraGrid.Columns.GridColumn TitularPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn FormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn Recibo;
        private DevExpress.XtraGrid.Columns.GridColumn Operacion;
        private DevExpress.XtraGrid.Columns.GridColumn CodBanco;
    }
}