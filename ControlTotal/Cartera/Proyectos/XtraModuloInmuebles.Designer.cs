namespace ControlTotal
{
    partial class XtraModuloInmuebles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraModuloInmuebles));
            this.GrdInmuebles = new DevExpress.XtraGrid.GridControl();
            this.GrvInmuebles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnAdicionar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BtnBloquear = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDesbloquear = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.GrdInmuebles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvInmuebles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdInmuebles
            // 
            this.GrdInmuebles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdInmuebles.Location = new System.Drawing.Point(0, 24);
            this.GrdInmuebles.MainView = this.GrvInmuebles;
            this.GrdInmuebles.Name = "GrdInmuebles";
            this.GrdInmuebles.Size = new System.Drawing.Size(1277, 495);
            this.GrdInmuebles.TabIndex = 2;
            this.GrdInmuebles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvInmuebles});
            // 
            // GrvInmuebles
            // 
            this.GrvInmuebles.GridControl = this.GrdInmuebles;
            this.GrvInmuebles.Name = "GrvInmuebles";
            this.GrvInmuebles.OptionsBehavior.ReadOnly = true;
            this.GrvInmuebles.OptionsView.ShowFooter = true;
            this.GrvInmuebles.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.GrvInmuebles_CustomRowCellEdit);
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
            this.BtnModificar,
            this.BtnEliminar,
            this.BtnImprimir,
            this.BtnExportar,
            this.barButtonItem1,
            this.BtnBloquear,
            this.BtnDesbloquear});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnModificar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnEliminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportar),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnBloquear),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnDesbloquear),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
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
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Imprimir";
            this.BtnImprimir.Id = 3;
            this.BtnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimir.ImageOptions.SvgImage")));
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Caption = "Excel";
            this.BtnExportar.Id = 4;
            this.BtnExportar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarExcel.ImageOptions.SvgImage")));
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportar_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Salir";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSalir_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1277, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 519);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1277, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 495);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1277, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 495);
            // 
            // BtnBloquear
            // 
            this.BtnBloquear.Caption = "Bloquear";
            this.BtnBloquear.Id = 6;
            this.BtnBloquear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnBloquear.ImageOptions.SvgImage")));
            this.BtnBloquear.Name = "BtnBloquear";
            this.BtnBloquear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBloquear_ItemClick);
            // 
            // BtnDesbloquear
            // 
            this.BtnDesbloquear.Caption = "Desbloquear";
            this.BtnDesbloquear.Id = 7;
            this.BtnDesbloquear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnDesbloquear.ImageOptions.SvgImage")));
            this.BtnDesbloquear.Name = "BtnDesbloquear";
            this.BtnDesbloquear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDesbloquear_ItemClick);
            // 
            // XtraModuloInmuebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 539);
            this.Controls.Add(this.GrdInmuebles);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraModuloInmuebles.IconOptions.Icon")));
            this.Name = "XtraModuloInmuebles";
            this.Text = "Modulo de Inmuebles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XtraModuloInmuebles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdInmuebles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvInmuebles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GrdInmuebles;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvInmuebles;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnAdicionar;
        private DevExpress.XtraBars.BarButtonItem BtnModificar;
        private DevExpress.XtraBars.BarButtonItem BtnEliminar;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.BarButtonItem BtnExportar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem BtnBloquear;
        private DevExpress.XtraBars.BarButtonItem BtnDesbloquear;
    }
}