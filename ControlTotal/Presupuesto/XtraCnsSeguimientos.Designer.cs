namespace ControlTotal
{
    partial class XtraCnsSeguimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraCnsSeguimientos));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.DtpFechaInicial = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.DtpFechaFinal = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.BtnConsultar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarPdf = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.GrdSeguimiento = new DevExpress.XtraGrid.GridControl();
            this.GrvSeguimiento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adjudicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Inmueble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Accion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Objecion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaCompromiso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Compromiso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSeguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSeguimiento)).BeginInit();
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
            this.BtnExportarExcel,
            this.BtnExportarPdf,
            this.BtnImprimir});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarPdf),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimir)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1304, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 445);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1304, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 421);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1304, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 421);
            // 
            // GrdSeguimiento
            // 
            this.GrdSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdSeguimiento.Location = new System.Drawing.Point(0, 24);
            this.GrdSeguimiento.MainView = this.GrvSeguimiento;
            this.GrdSeguimiento.MenuManager = this.barManager1;
            this.GrdSeguimiento.Name = "GrdSeguimiento";
            this.GrdSeguimiento.Size = new System.Drawing.Size(1304, 421);
            this.GrdSeguimiento.TabIndex = 4;
            this.GrdSeguimiento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvSeguimiento});
            // 
            // GrvSeguimiento
            // 
            this.GrvSeguimiento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Fecha,
            this.Adjudicacion,
            this.Inmueble,
            this.Cliente,
            this.Accion,
            this.Objecion,
            this.FechaCompromiso,
            this.Compromiso,
            this.Usuario});
            this.GrvSeguimiento.GridControl = this.GrdSeguimiento;
            this.GrvSeguimiento.Name = "GrvSeguimiento";
            this.GrvSeguimiento.OptionsBehavior.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 0;
            this.Fecha.Width = 63;
            // 
            // Adjudicacion
            // 
            this.Adjudicacion.Caption = "Adj";
            this.Adjudicacion.FieldName = "IdAdjudicacion";
            this.Adjudicacion.Name = "Adjudicacion";
            this.Adjudicacion.Visible = true;
            this.Adjudicacion.VisibleIndex = 1;
            this.Adjudicacion.Width = 77;
            // 
            // Inmueble
            // 
            this.Inmueble.Caption = "Inmueble";
            this.Inmueble.FieldName = "Inmueble";
            this.Inmueble.Name = "Inmueble";
            this.Inmueble.Visible = true;
            this.Inmueble.VisibleIndex = 2;
            this.Inmueble.Width = 64;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 3;
            this.Cliente.Width = 193;
            // 
            // Accion
            // 
            this.Accion.Caption = "Accion";
            this.Accion.FieldName = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.Visible = true;
            this.Accion.VisibleIndex = 4;
            this.Accion.Width = 128;
            // 
            // Objecion
            // 
            this.Objecion.Caption = "Objecion";
            this.Objecion.FieldName = "Objecion";
            this.Objecion.Name = "Objecion";
            this.Objecion.Visible = true;
            this.Objecion.VisibleIndex = 5;
            this.Objecion.Width = 128;
            // 
            // FechaCompromiso
            // 
            this.FechaCompromiso.Caption = "FechaCompromiso";
            this.FechaCompromiso.FieldName = "FechaCompromiso";
            this.FechaCompromiso.Name = "FechaCompromiso";
            this.FechaCompromiso.Visible = true;
            this.FechaCompromiso.VisibleIndex = 6;
            this.FechaCompromiso.Width = 76;
            // 
            // Compromiso
            // 
            this.Compromiso.Caption = "Compromiso";
            this.Compromiso.FieldName = "Compromiso";
            this.Compromiso.Name = "Compromiso";
            this.Compromiso.Visible = true;
            this.Compromiso.VisibleIndex = 7;
            this.Compromiso.Width = 253;
            // 
            // Usuario
            // 
            this.Usuario.Caption = "Usuario";
            this.Usuario.FieldName = "IdUsuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.Visible = true;
            this.Usuario.VisibleIndex = 8;
            this.Usuario.Width = 79;
            // 
            // XtraCnsSeguimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 465);
            this.Controls.Add(this.GrdSeguimiento);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraCnsSeguimientos.IconOptions.SvgImage")));
            this.Name = "XtraCnsSeguimientos";
            this.Text = "Seguimiento Cartera por Fecha";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSeguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSeguimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem DtpFechaInicial;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem DtpFechaFinal;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem BtnConsultar;
        private DevExpress.XtraBars.BarButtonItem BtnExportarExcel;
        private DevExpress.XtraBars.BarButtonItem BtnExportarPdf;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraGrid.GridControl GrdSeguimiento;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvSeguimiento;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn Adjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Inmueble;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Accion;
        private DevExpress.XtraGrid.Columns.GridColumn Objecion;
        private DevExpress.XtraGrid.Columns.GridColumn FechaCompromiso;
        private DevExpress.XtraGrid.Columns.GridColumn Compromiso;
        private DevExpress.XtraGrid.Columns.GridColumn Usuario;
    }
}