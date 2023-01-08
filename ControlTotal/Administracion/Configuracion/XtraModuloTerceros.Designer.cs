
namespace ControlTotal
{
    partial class XtraModuloTerceros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraModuloTerceros));
            this.GrdTerceros = new DevExpress.XtraGrid.GridControl();
            this.GrvTerceros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdTercero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Apellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Barrio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Celular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CorreoElectronico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnAdicionar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTerceros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvTerceros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdTerceros
            // 
            this.GrdTerceros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdTerceros.Location = new System.Drawing.Point(0, 24);
            this.GrdTerceros.MainView = this.GrvTerceros;
            this.GrdTerceros.Name = "GrdTerceros";
            this.GrdTerceros.Size = new System.Drawing.Size(1317, 386);
            this.GrdTerceros.TabIndex = 7;
            this.GrdTerceros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvTerceros});
            // 
            // GrvTerceros
            // 
            this.GrvTerceros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdTercero,
            this.Nombres,
            this.Apellidos,
            this.Direccion,
            this.Barrio,
            this.Telefono,
            this.Celular,
            this.CorreoElectronico});
            this.GrvTerceros.GridControl = this.GrdTerceros;
            this.GrvTerceros.Name = "GrvTerceros";
            this.GrvTerceros.OptionsView.ShowFooter = true;
            this.GrvTerceros.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.GrvTerceros_CustomRowCellEdit);
            // 
            // IdTercero
            // 
            this.IdTercero.Caption = "IdTercero";
            this.IdTercero.FieldName = "IdTercero";
            this.IdTercero.Name = "IdTercero";
            this.IdTercero.Visible = true;
            this.IdTercero.VisibleIndex = 0;
            // 
            // Nombres
            // 
            this.Nombres.Caption = "Nombres";
            this.Nombres.FieldName = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.Visible = true;
            this.Nombres.VisibleIndex = 1;
            // 
            // Apellidos
            // 
            this.Apellidos.Caption = "Apellidos";
            this.Apellidos.FieldName = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Visible = true;
            this.Apellidos.VisibleIndex = 2;
            // 
            // Direccion
            // 
            this.Direccion.Caption = "Direccion";
            this.Direccion.FieldName = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Visible = true;
            this.Direccion.VisibleIndex = 3;
            // 
            // Barrio
            // 
            this.Barrio.Caption = "Barrio";
            this.Barrio.FieldName = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.Visible = true;
            this.Barrio.VisibleIndex = 4;
            // 
            // Telefono
            // 
            this.Telefono.Caption = "Telefono";
            this.Telefono.FieldName = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Visible = true;
            this.Telefono.VisibleIndex = 5;
            // 
            // Celular
            // 
            this.Celular.Caption = "Celular";
            this.Celular.FieldName = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.Visible = true;
            this.Celular.VisibleIndex = 6;
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.Caption = "CorreoElectronico";
            this.CorreoElectronico.FieldName = "CorreoElectronico";
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.Visible = true;
            this.CorreoElectronico.VisibleIndex = 7;
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
            this.BtnExportarExcel,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnExportarExcel),
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
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Caption = "Excel";
            this.BtnExportarExcel.Id = 4;
            this.BtnExportarExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarExcel.ImageOptions.SvgImage")));
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarExcel_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1317, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 410);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1317, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 386);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1317, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 386);
            // 
            // XtraModuloTerceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 430);
            this.Controls.Add(this.GrdTerceros);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraModuloTerceros.IconOptions.SvgImage")));
            this.Name = "XtraModuloTerceros";
            this.Load += new System.EventHandler(this.XtraModuloTerceros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdTerceros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvTerceros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdTerceros;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvTerceros;
        private DevExpress.XtraGrid.Columns.GridColumn IdTercero;
        private DevExpress.XtraGrid.Columns.GridColumn Nombres;
        private DevExpress.XtraGrid.Columns.GridColumn Apellidos;
        private DevExpress.XtraGrid.Columns.GridColumn Direccion;
        private DevExpress.XtraGrid.Columns.GridColumn Barrio;
        private DevExpress.XtraGrid.Columns.GridColumn Telefono;
        private DevExpress.XtraGrid.Columns.GridColumn Celular;
        private DevExpress.XtraGrid.Columns.GridColumn CorreoElectronico;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnAdicionar;
        private DevExpress.XtraBars.BarButtonItem BtnModificar;
        private DevExpress.XtraBars.BarButtonItem BtnEliminar;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.BarButtonItem BtnExportarExcel;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}