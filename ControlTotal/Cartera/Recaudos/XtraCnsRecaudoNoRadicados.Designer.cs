namespace ControlTotal
{
    partial class XtraCnsRecaudoNoRadicados
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
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraCnsRecaudoNoRadicados));
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnAddRecaudo = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimirListado = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Operacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrvAdjudicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdReserva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstadoReserva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdInmueble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TitularPrincipal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Recibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrdAdjudicacion = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjudicacion)).BeginInit();
            this.SuspendLayout();
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
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1292, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 373);
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
            this.BtnImprimirListado,
            this.BtnAddRecaudo});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnAddRecaudo),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimirListado)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // BtnAddRecaudo
            // 
            this.BtnAddRecaudo.Caption = "AdiconarRecaudo";
            this.BtnAddRecaudo.Id = 6;
            this.BtnAddRecaudo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAddRecaudo.ImageOptions.SvgImage")));
            this.BtnAddRecaudo.Name = "BtnAddRecaudo";
            this.BtnAddRecaudo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem2.Text = "Adicionar Recaudo";
            toolTipItem2.Text = "Adiciona el Recaudo al cliente, si ya la adjudicacion ha sido creada.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.BtnAddRecaudo.SuperTip = superToolTip2;
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Caption = "Exportar Excel";
            this.BtnExportarExcel.Id = 4;
            this.BtnExportarExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarExcel.ImageOptions.SvgImage")));
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarExcel_ItemClick);
            // 
            // BtnImprimirListado
            // 
            this.BtnImprimirListado.Caption = "Imprimir Listado";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1292, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 397);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1292, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 373);
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
            // Operacion
            // 
            this.Operacion.Caption = "Operacion";
            this.Operacion.FieldName = "Operacion";
            this.Operacion.Name = "Operacion";
            this.Operacion.Visible = true;
            this.Operacion.VisibleIndex = 7;
            this.Operacion.Width = 100;
            // 
            // GrvAdjudicacion
            // 
            this.GrvAdjudicacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Fecha,
            this.IdReserva,
            this.EstadoReserva,
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
            this.GrvAdjudicacion.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.GrvAdjudicacion_CustomRowCellEdit);
            this.GrvAdjudicacion.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.GrvAdjudicacion_CustomRowCellEditForEditing);
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 0;
            this.Fecha.Width = 89;
            // 
            // IdReserva
            // 
            this.IdReserva.Caption = "IdReserva";
            this.IdReserva.FieldName = "IdReserva";
            this.IdReserva.Name = "IdReserva";
            this.IdReserva.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdAdjudicacion", "{0}")});
            this.IdReserva.Visible = true;
            this.IdReserva.VisibleIndex = 1;
            this.IdReserva.Width = 84;
            // 
            // EstadoReserva
            // 
            this.EstadoReserva.Caption = "Estado Reserva";
            this.EstadoReserva.FieldName = "EstadoReserva";
            this.EstadoReserva.Name = "EstadoReserva";
            this.EstadoReserva.Visible = true;
            this.EstadoReserva.VisibleIndex = 2;
            this.EstadoReserva.Width = 93;
            // 
            // IdInmueble
            // 
            this.IdInmueble.Caption = "Inmueble";
            this.IdInmueble.FieldName = "IdInmueble";
            this.IdInmueble.Name = "IdInmueble";
            this.IdInmueble.Visible = true;
            this.IdInmueble.VisibleIndex = 3;
            this.IdInmueble.Width = 77;
            // 
            // TitularPrincipal
            // 
            this.TitularPrincipal.Caption = "Titular Principal";
            this.TitularPrincipal.FieldName = "TitularPrincipal";
            this.TitularPrincipal.Name = "TitularPrincipal";
            this.TitularPrincipal.Visible = true;
            this.TitularPrincipal.VisibleIndex = 4;
            this.TitularPrincipal.Width = 193;
            // 
            // FormaPago
            // 
            this.FormaPago.Caption = "FormaPago";
            this.FormaPago.FieldName = "FormaPago";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.Visible = true;
            this.FormaPago.VisibleIndex = 9;
            this.FormaPago.Width = 119;
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
            this.Valor.VisibleIndex = 5;
            this.Valor.Width = 106;
            // 
            // Recibo
            // 
            this.Recibo.Caption = "Recibo";
            this.Recibo.FieldName = "Recibo";
            this.Recibo.Name = "Recibo";
            this.Recibo.Visible = true;
            this.Recibo.VisibleIndex = 6;
            this.Recibo.Width = 100;
            // 
            // CodBanco
            // 
            this.CodBanco.Caption = "CodBanco";
            this.CodBanco.FieldName = "CodBanco";
            this.CodBanco.Name = "CodBanco";
            this.CodBanco.Visible = true;
            this.CodBanco.VisibleIndex = 8;
            this.CodBanco.Width = 100;
            // 
            // GrdAdjudicacion
            // 
            this.GrdAdjudicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdAdjudicacion.Location = new System.Drawing.Point(0, 24);
            this.GrdAdjudicacion.MainView = this.GrvAdjudicacion;
            this.GrdAdjudicacion.Name = "GrdAdjudicacion";
            this.GrdAdjudicacion.Size = new System.Drawing.Size(1292, 373);
            this.GrdAdjudicacion.TabIndex = 6;
            this.GrdAdjudicacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvAdjudicacion});
            // 
            // XtraCnsRecaudoNoRadicados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 417);
            this.Controls.Add(this.GrdAdjudicacion);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraCnsRecaudoNoRadicados.IconOptions.SvgImage")));
            this.Name = "XtraCnsRecaudoNoRadicados";
            this.Text = "XtraCnsRecaudoNoRadicados";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjudicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnExportarExcel;
        private DevExpress.XtraBars.BarButtonItem BtnImprimirListado;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraGrid.GridControl GrdAdjudicacion;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn IdReserva;
        private DevExpress.XtraGrid.Columns.GridColumn IdInmueble;
        private DevExpress.XtraGrid.Columns.GridColumn TitularPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn FormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn Recibo;
        private DevExpress.XtraGrid.Columns.GridColumn Operacion;
        private DevExpress.XtraGrid.Columns.GridColumn CodBanco;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarButtonItem BtnAddRecaudo;
        private DevExpress.XtraGrid.Columns.GridColumn EstadoReserva;
    }
}