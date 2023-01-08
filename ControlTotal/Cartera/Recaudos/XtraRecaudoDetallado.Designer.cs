namespace ControlTotal
{
    partial class XtraRecaudoDetallado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraRecaudoDetallado));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPdf = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.userDatosClientes1 = new ControlTotal.UserDatosClientes();
            this.GrdRecaudosDetallados = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdRecaudo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Recibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Operacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRecaudosDetallados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.BtnExcel,
            this.BtnPdf,
            this.BtnSalir,
            this.BtnImprimir});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbon.Size = new System.Drawing.Size(986, 89);
            // 
            // BtnExcel
            // 
            this.BtnExcel.Caption = "Exportar Excel";
            this.BtnExcel.Id = 1;
            this.BtnExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExcel.ImageOptions.SvgImage")));
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExcel_ItemClick);
            // 
            // BtnPdf
            // 
            this.BtnPdf.Caption = "Exportar Pdf";
            this.BtnPdf.Id = 2;
            this.BtnPdf.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnPdf.ImageOptions.SvgImage")));
            this.BtnPdf.Name = "BtnPdf";
            this.BtnPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPdf_ItemClick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Caption = "Salir";
            this.BtnSalir.Id = 3;
            this.BtnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSalir.ImageOptions.SvgImage")));
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSalir_ItemClick);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Imprimir Listado";
            this.BtnImprimir.Id = 4;
            this.BtnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimir.ImageOptions.SvgImage")));
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Recaudos Detallados";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnExcel);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPdf);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnImprimir);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnSalir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // userDatosClientes1
            // 
            this.userDatosClientes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDatosClientes1.Location = new System.Drawing.Point(0, 0);
            this.userDatosClientes1.Name = "userDatosClientes1";
            this.userDatosClientes1.Size = new System.Drawing.Size(986, 143);
            this.userDatosClientes1.TabIndex = 2;
            // 
            // GrdRecaudosDetallados
            // 
            this.GrdRecaudosDetallados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdRecaudosDetallados.Location = new System.Drawing.Point(0, 0);
            this.GrdRecaudosDetallados.MainView = this.gridView1;
            this.GrdRecaudosDetallados.Name = "GrdRecaudosDetallados";
            this.GrdRecaudosDetallados.Size = new System.Drawing.Size(986, 246);
            this.GrdRecaudosDetallados.TabIndex = 4;
            this.GrdRecaudosDetallados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdRecaudo,
            this.Fecha,
            this.Recibo,
            this.FormaPago,
            this.Operacion,
            this.Valor});
            this.gridView1.GridControl = this.GrdRecaudosDetallados;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // IdRecaudo
            // 
            this.IdRecaudo.Caption = "IdRecaudo";
            this.IdRecaudo.FieldName = "IdRecaudo";
            this.IdRecaudo.Name = "IdRecaudo";
            this.IdRecaudo.Visible = true;
            this.IdRecaudo.VisibleIndex = 0;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Fecha", "{0}")});
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 2;
            // 
            // Recibo
            // 
            this.Recibo.Caption = "Recibo";
            this.Recibo.FieldName = "Recibo";
            this.Recibo.Name = "Recibo";
            this.Recibo.Visible = true;
            this.Recibo.VisibleIndex = 1;
            // 
            // FormaPago
            // 
            this.FormaPago.Caption = "FormaPago";
            this.FormaPago.FieldName = "FormaPago";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.Visible = true;
            this.FormaPago.VisibleIndex = 3;
            // 
            // Operacion
            // 
            this.Operacion.Caption = "Operacion";
            this.Operacion.FieldName = "Operacion";
            this.Operacion.Name = "Operacion";
            this.Operacion.Visible = true;
            this.Operacion.VisibleIndex = 4;
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
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 89);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.userDatosClientes1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.GrdRecaudosDetallados);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(986, 399);
            this.splitContainerControl1.SplitterPosition = 143;
            this.splitContainerControl1.TabIndex = 6;
            // 
            // XtraRecaudoDetallado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 488);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraRecaudoDetallado.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraRecaudoDetallado";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraRecaudoDetallado";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRecaudosDetallados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private UserDatosClientes userDatosClientes1;
        private DevExpress.XtraBars.BarButtonItem BtnExcel;
        private DevExpress.XtraBars.BarButtonItem BtnPdf;
        private DevExpress.XtraBars.BarButtonItem BtnSalir;
        private DevExpress.XtraGrid.GridControl GrdRecaudosDetallados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn Recibo;
        private DevExpress.XtraGrid.Columns.GridColumn FormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn Operacion;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn IdRecaudo;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}