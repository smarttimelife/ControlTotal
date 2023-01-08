namespace ControlTotal
{
    partial class ModuloXtraFactores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloXtraFactores));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnAdicionar = new DevExpress.XtraBars.BarButtonItem();
            this.Adicionar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.GrdFactor = new DevExpress.XtraGrid.GridControl();
            this.GrvFactor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Plazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Factor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnAdicionar,
            this.Adicionar,
            this.BtnModificar,
            this.BtnEliminar,
            this.BtnImprimir,
            this.BtnExportarExcel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(1218, 89);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Caption = "Adicionar";
            this.BtnAdicionar.Id = 1;
            this.BtnAdicionar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAdicionar.ImageOptions.SvgImage")));
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAdicionar_ItemClick);
            // 
            // Adicionar
            // 
            this.Adicionar.Caption = "Adicionar";
            this.Adicionar.Id = 4;
            this.Adicionar.Name = "Adicionar";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Caption = "Modificar";
            this.BtnModificar.Id = 5;
            this.BtnModificar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnModificar.ImageOptions.SvgImage")));
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnModificar_ItemClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Caption = "Eliminar";
            this.BtnEliminar.Id = 6;
            this.BtnEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnEliminar.ImageOptions.SvgImage")));
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEliminar_ItemClick);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Imprimir";
            this.BtnImprimir.Id = 7;
            this.BtnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimir.ImageOptions.SvgImage")));
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Caption = "Exportar Excel";
            this.BtnExportarExcel.Id = 8;
            this.BtnExportarExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportarExcel.ImageOptions.SvgImage")));
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportarExcel_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Factores";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAdicionar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnModificar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnEliminar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnImprimir);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnExportarExcel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Operaciones";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // GrdFactor
            // 
            this.GrdFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdFactor.Location = new System.Drawing.Point(0, 89);
            this.GrdFactor.MainView = this.GrvFactor;
            this.GrdFactor.MenuManager = this.ribbonControl1;
            this.GrdFactor.Name = "GrdFactor";
            this.GrdFactor.Size = new System.Drawing.Size(1218, 358);
            this.GrdFactor.TabIndex = 2;
            this.GrdFactor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvFactor});
            // 
            // GrvFactor
            // 
            this.GrvFactor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Plazo,
            this.Tasa,
            this.Factor});
            this.GrvFactor.GridControl = this.GrdFactor;
            this.GrvFactor.Name = "GrvFactor";
            this.GrvFactor.OptionsBehavior.ReadOnly = true;
            // 
            // Plazo
            // 
            this.Plazo.Caption = "Plazo";
            this.Plazo.FieldName = "Plazo";
            this.Plazo.Name = "Plazo";
            this.Plazo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Plazo.Visible = true;
            this.Plazo.VisibleIndex = 0;
            // 
            // Tasa
            // 
            this.Tasa.Caption = "Tasa";
            this.Tasa.DisplayFormat.FormatString = "{0:n2}";
            this.Tasa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Tasa.FieldName = "Tasa";
            this.Tasa.Name = "Tasa";
            this.Tasa.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Tasa.Visible = true;
            this.Tasa.VisibleIndex = 1;
            // 
            // Factor
            // 
            this.Factor.Caption = "Factor";
            this.Factor.DisplayFormat.FormatString = "{0:n8}";
            this.Factor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Factor.FieldName = "Factor";
            this.Factor.Name = "Factor";
            this.Factor.OptionsColumn.ReadOnly = true;
            this.Factor.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Factor.Visible = true;
            this.Factor.VisibleIndex = 2;
            // 
            // ModuloXtraFactores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 447);
            this.Controls.Add(this.GrdFactor);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ModuloXtraFactores.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModuloXtraFactores";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ModuloXtraFactores_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem BtnAdicionar;
        private DevExpress.XtraGrid.GridControl GrdFactor;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvFactor;
        private DevExpress.XtraBars.BarButtonItem Adicionar;
        private DevExpress.XtraGrid.Columns.GridColumn Plazo;
        private DevExpress.XtraGrid.Columns.GridColumn Tasa;
        private DevExpress.XtraGrid.Columns.GridColumn Factor;
        private DevExpress.XtraBars.BarButtonItem BtnModificar;
        private DevExpress.XtraBars.BarButtonItem BtnEliminar;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.BarButtonItem BtnExportarExcel;
    }
}