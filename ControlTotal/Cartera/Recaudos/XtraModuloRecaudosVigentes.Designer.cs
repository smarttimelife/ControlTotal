namespace ControlTotal
{
    partial class XtraModuloRecaudosVigentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraModuloRecaudosVigentes));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnAdicionar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEstadoCuenta = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRecaudosDetallados = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExportar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GrdAdjudicacion = new DevExpress.XtraGrid.GridControl();
            this.GrvAdjudicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdAdjudicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdInmueble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Contrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TitularPrincipal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RcdNoRadicado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RcdCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltFechaRcd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiasMora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjudicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.BtnAdicionar,
            this.BtnModificar,
            this.BtnEliminar,
            this.BtnSalir,
            this.BtnEstadoCuenta,
            this.BtnRecaudosDetallados,
            this.BtnImprimir,
            this.BtnExportar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbon.Size = new System.Drawing.Size(1298, 89);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Caption = "Adicionar";
            this.BtnAdicionar.Id = 1;
            this.BtnAdicionar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAdicionar.ImageOptions.SvgImage")));
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAdicionar_ItemClick);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Caption = "Modificar";
            this.BtnModificar.Id = 2;
            this.BtnModificar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnModificar.ImageOptions.SvgImage")));
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnModificar_ItemClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Caption = "Eliminar";
            this.BtnEliminar.Id = 3;
            this.BtnEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnEliminar.ImageOptions.SvgImage")));
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEliminar_ItemClick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Caption = "Salir";
            this.BtnSalir.Id = 4;
            this.BtnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSalir.ImageOptions.SvgImage")));
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.BtnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSalir_ItemClick);
            // 
            // BtnEstadoCuenta
            // 
            this.BtnEstadoCuenta.Caption = "Estado Cuenta";
            this.BtnEstadoCuenta.Id = 5;
            this.BtnEstadoCuenta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnEstadoCuenta.ImageOptions.SvgImage")));
            this.BtnEstadoCuenta.Name = "BtnEstadoCuenta";
            this.BtnEstadoCuenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEstadoCuenta_ItemClick);
            // 
            // BtnRecaudosDetallados
            // 
            this.BtnRecaudosDetallados.Caption = "Recaudos Detallados";
            this.BtnRecaudosDetallados.Id = 6;
            this.BtnRecaudosDetallados.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRecaudosDetallados.ImageOptions.SvgImage")));
            this.BtnRecaudosDetallados.Name = "BtnRecaudosDetallados";
            this.BtnRecaudosDetallados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRecaudosDetallados_ItemClick);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Imprimir Listado";
            this.BtnImprimir.Id = 7;
            this.BtnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimir.ImageOptions.SvgImage")));
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Caption = "Exportar Excel";
            this.BtnExportar.Id = 8;
            this.BtnExportar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnExportar.ImageOptions.SvgImage")));
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExportar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Recaduos";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAdicionar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnModificar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnEliminar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Operaciones";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnImprimir);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnExportar);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnEstadoCuenta);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnRecaudosDetallados);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnSalir);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Consultas Generales";
            // 
            // GrdAdjudicacion
            // 
            this.GrdAdjudicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdAdjudicacion.Location = new System.Drawing.Point(0, 89);
            this.GrdAdjudicacion.MainView = this.GrvAdjudicacion;
            this.GrdAdjudicacion.MenuManager = this.ribbon;
            this.GrdAdjudicacion.Name = "GrdAdjudicacion";
            this.GrdAdjudicacion.Size = new System.Drawing.Size(1298, 456);
            this.GrdAdjudicacion.TabIndex = 3;
            this.GrdAdjudicacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvAdjudicacion});
            // 
            // GrvAdjudicacion
            // 
            this.GrvAdjudicacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdAdjudicacion,
            this.Fecha,
            this.IdInmueble,
            this.Contrato,
            this.TitularPrincipal,
            this.Valor,
            this.RcdNoRadicado,
            this.RcdCapital,
            this.UltFechaRcd,
            this.Saldo,
            this.DiasMora,
            this.Mora,
            this.FechaEntrega});
            this.GrvAdjudicacion.GridControl = this.GrdAdjudicacion;
            this.GrvAdjudicacion.Name = "GrvAdjudicacion";
            this.GrvAdjudicacion.OptionsBehavior.ReadOnly = true;
            this.GrvAdjudicacion.OptionsView.ShowFooter = true;
            this.GrvAdjudicacion.DoubleClick += new System.EventHandler(this.GrvAdjudicacion_DoubleClick);
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
            this.IdAdjudicacion.Width = 67;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 0;
            this.Fecha.Width = 98;
            // 
            // IdInmueble
            // 
            this.IdInmueble.Caption = "Inmueble";
            this.IdInmueble.FieldName = "IdInmueble";
            this.IdInmueble.Name = "IdInmueble";
            this.IdInmueble.Visible = true;
            this.IdInmueble.VisibleIndex = 2;
            this.IdInmueble.Width = 73;
            // 
            // Contrato
            // 
            this.Contrato.Caption = "Contrato";
            this.Contrato.FieldName = "Contrato";
            this.Contrato.Name = "Contrato";
            this.Contrato.Visible = true;
            this.Contrato.VisibleIndex = 3;
            this.Contrato.Width = 69;
            // 
            // TitularPrincipal
            // 
            this.TitularPrincipal.Caption = "Titular Principal";
            this.TitularPrincipal.FieldName = "TitularPrincipal";
            this.TitularPrincipal.Name = "TitularPrincipal";
            this.TitularPrincipal.Visible = true;
            this.TitularPrincipal.VisibleIndex = 4;
            this.TitularPrincipal.Width = 159;
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
            this.Valor.Width = 120;
            // 
            // RcdNoRadicado
            // 
            this.RcdNoRadicado.Caption = "RcdNoRadicado";
            this.RcdNoRadicado.DisplayFormat.FormatString = "{0:n2}";
            this.RcdNoRadicado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RcdNoRadicado.FieldName = "RcdNoRadicado";
            this.RcdNoRadicado.Name = "RcdNoRadicado";
            this.RcdNoRadicado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RcdNoRadicado", "{0:n2}")});
            this.RcdNoRadicado.Visible = true;
            this.RcdNoRadicado.VisibleIndex = 6;
            this.RcdNoRadicado.Width = 120;
            // 
            // RcdCapital
            // 
            this.RcdCapital.Caption = "Rcd Capital";
            this.RcdCapital.DisplayFormat.FormatString = "{0:n2}";
            this.RcdCapital.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RcdCapital.FieldName = "RcdCapital";
            this.RcdCapital.Name = "RcdCapital";
            this.RcdCapital.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RcdCapital", "{0:n2}")});
            this.RcdCapital.Visible = true;
            this.RcdCapital.VisibleIndex = 7;
            this.RcdCapital.Width = 120;
            // 
            // UltFechaRcd
            // 
            this.UltFechaRcd.Caption = "UltFechaRcd";
            this.UltFechaRcd.DisplayFormat.FormatString = "d";
            this.UltFechaRcd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.UltFechaRcd.FieldName = "UltFechaRcd";
            this.UltFechaRcd.Name = "UltFechaRcd";
            this.UltFechaRcd.Visible = true;
            this.UltFechaRcd.VisibleIndex = 8;
            this.UltFechaRcd.Width = 73;
            // 
            // Saldo
            // 
            this.Saldo.Caption = "Saldo";
            this.Saldo.DisplayFormat.FormatString = "{0:n2}";
            this.Saldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Saldo.FieldName = "SdoCapital";
            this.Saldo.Name = "Saldo";
            this.Saldo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SdoCapital", "{0:n2}")});
            this.Saldo.Visible = true;
            this.Saldo.VisibleIndex = 9;
            this.Saldo.Width = 120;
            // 
            // DiasMora
            // 
            this.DiasMora.Caption = "Mora";
            this.DiasMora.FieldName = "DiasMora";
            this.DiasMora.Name = "DiasMora";
            this.DiasMora.Visible = true;
            this.DiasMora.VisibleIndex = 10;
            this.DiasMora.Width = 40;
            // 
            // Mora
            // 
            this.Mora.Caption = "Valor Mora";
            this.Mora.DisplayFormat.FormatString = "{0:n2}";
            this.Mora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Mora.FieldName = "Mora";
            this.Mora.Name = "Mora";
            this.Mora.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mora", "{0:n2}")});
            this.Mora.Visible = true;
            this.Mora.VisibleIndex = 11;
            this.Mora.Width = 90;
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.Caption = "FechaEntrega";
            this.FechaEntrega.FieldName = "FechaEntrega";
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.Visible = true;
            this.FechaEntrega.VisibleIndex = 12;
            this.FechaEntrega.Width = 124;
            // 
            // XtraModuloRecaudosVigentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 545);
            this.Controls.Add(this.GrdAdjudicacion);
            this.Controls.Add(this.ribbon);
            this.Name = "XtraModuloRecaudosVigentes";
            this.Ribbon = this.ribbon;
            this.Text = "XtraModuloRecaudosVigentes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjudicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl GrdAdjudicacion;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdInmueble;
        private DevExpress.XtraGrid.Columns.GridColumn Contrato;
        private DevExpress.XtraGrid.Columns.GridColumn TitularPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn RcdCapital;
        private DevExpress.XtraGrid.Columns.GridColumn UltFechaRcd;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo;
        private DevExpress.XtraGrid.Columns.GridColumn DiasMora;
        private DevExpress.XtraBars.BarButtonItem BtnAdicionar;
        private DevExpress.XtraBars.BarButtonItem BtnModificar;
        private DevExpress.XtraBars.BarButtonItem BtnEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn Mora;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn FechaEntrega;
        private DevExpress.XtraBars.BarButtonItem BtnSalir;
        private DevExpress.XtraBars.BarButtonItem BtnEstadoCuenta;
        private DevExpress.XtraBars.BarButtonItem BtnRecaudosDetallados;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.BarButtonItem BtnExportar;
        private DevExpress.XtraGrid.Columns.GridColumn RcdNoRadicado;
    }
}