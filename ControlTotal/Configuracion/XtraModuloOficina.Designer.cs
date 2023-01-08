
namespace ControlTotal
{
    partial class XtraModuloOficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraModuloOficina));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnAdicionar = new DevExpress.XtraBars.BarButtonItem();
            this.Adicionar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.GrdOficina = new DevExpress.XtraGrid.GridControl();
            this.GrvFactor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreOficina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IntCorriente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Porcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Periodo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOficina)).BeginInit();
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
            this.BtnEliminar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(1310, 81);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Caption = "Adicionar";
            this.BtnAdicionar.Id = 1;
            this.BtnAdicionar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAdicionar.ImageOptions.SvgImage")));
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Oficina";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAdicionar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnModificar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Operaciones";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // GrdOficina
            // 
            this.GrdOficina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdOficina.Location = new System.Drawing.Point(0, 81);
            this.GrdOficina.MainView = this.GrvFactor;
            this.GrdOficina.MenuManager = this.ribbonControl1;
            this.GrdOficina.Name = "GrdOficina";
            this.GrdOficina.Size = new System.Drawing.Size(1310, 289);
            this.GrdOficina.TabIndex = 4;
            this.GrdOficina.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvFactor});
            // 
            // GrvFactor
            // 
            this.GrvFactor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.NombreOficina,
            this.IntCorriente,
            this.Mora,
            this.Porcentaje,
            this.Periodo});
            this.GrvFactor.GridControl = this.GrdOficina;
            this.GrvFactor.Name = "GrvFactor";
            this.GrvFactor.OptionsBehavior.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            // 
            // NombreOficina
            // 
            this.NombreOficina.Caption = "NombreOficina";
            this.NombreOficina.FieldName = "NombreOficina";
            this.NombreOficina.Name = "NombreOficina";
            this.NombreOficina.Visible = true;
            this.NombreOficina.VisibleIndex = 1;
            // 
            // IntCorriente
            // 
            this.IntCorriente.Caption = "IntCorriente";
            this.IntCorriente.FieldName = "IntCorriente";
            this.IntCorriente.Name = "IntCorriente";
            this.IntCorriente.Visible = true;
            this.IntCorriente.VisibleIndex = 2;
            // 
            // Mora
            // 
            this.Mora.Caption = "Mora";
            this.Mora.FieldName = "Mora";
            this.Mora.Name = "Mora";
            this.Mora.Visible = true;
            this.Mora.VisibleIndex = 3;
            // 
            // Porcentaje
            // 
            this.Porcentaje.Caption = "Porcentaje";
            this.Porcentaje.FieldName = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Visible = true;
            this.Porcentaje.VisibleIndex = 4;
            // 
            // Periodo
            // 
            this.Periodo.Caption = "Periodo";
            this.Periodo.FieldName = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.Visible = true;
            this.Periodo.VisibleIndex = 5;
            // 
            // XtraModuloOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 370);
            this.Controls.Add(this.GrdOficina);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "XtraModuloOficina";
            this.Text = "XtraModuloOficina";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOficina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem BtnAdicionar;
        private DevExpress.XtraBars.BarButtonItem Adicionar;
        private DevExpress.XtraBars.BarButtonItem BtnModificar;
        private DevExpress.XtraBars.BarButtonItem BtnEliminar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraGrid.GridControl GrdOficina;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvFactor;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn NombreOficina;
        private DevExpress.XtraGrid.Columns.GridColumn IntCorriente;
        private DevExpress.XtraGrid.Columns.GridColumn Mora;
        private DevExpress.XtraGrid.Columns.GridColumn Porcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn Periodo;
    }
}