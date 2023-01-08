namespace ControlTotal
{
    partial class XtraRadicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraRadicacion));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.RpRadicacion = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RpgRadicacion = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GrdAsesores = new DevExpress.XtraGrid.GridControl();
            this.GrvAsesores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RpsCargo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Asesor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RpsAsesor = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Com1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Com2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CmbIdAdjudicacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.GrvAdjudicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdAdj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TitularPrincipal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TxtInmueble = new DevExpress.XtraEditors.TextEdit();
            this.TxtContrato = new DevExpress.XtraEditors.TextEdit();
            this.TxtValor = new DevExpress.XtraEditors.TextEdit();
            this.TxtTitular = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LblTitular = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblValor = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblContrato = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblInmueble = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblIdAdjudicacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAsesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAsesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsAsesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIdAdjudicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInmueble.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContrato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblTitular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblInmueble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIdAdjudicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.BtnGuardar,
            this.BtnImprimir,
            this.BtnSalir});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RpRadicacion});
            this.ribbon.Size = new System.Drawing.Size(634, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Caption = "Guardar";
            this.BtnGuardar.Id = 1;
            this.BtnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGuardar.ImageOptions.SvgImage")));
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGuardar_ItemClick);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Caption = "Imprimir";
            this.BtnImprimir.Enabled = false;
            this.BtnImprimir.Id = 2;
            this.BtnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnImprimir.ImageOptions.SvgImage")));
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnImprimir_ItemClick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Caption = "Salir";
            this.BtnSalir.Id = 3;
            this.BtnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSalir.ImageOptions.SvgImage")));
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSalir_ItemClick);
            // 
            // RpRadicacion
            // 
            this.RpRadicacion.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RpgRadicacion});
            this.RpRadicacion.Name = "RpRadicacion";
            this.RpRadicacion.Text = "Radicacion Negocios";
            // 
            // RpgRadicacion
            // 
            this.RpgRadicacion.ItemLinks.Add(this.BtnGuardar);
            this.RpgRadicacion.ItemLinks.Add(this.BtnImprimir);
            this.RpgRadicacion.ItemLinks.Add(this.BtnSalir);
            this.RpgRadicacion.Name = "RpgRadicacion";
            this.RpgRadicacion.Text = "Operaciones ";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 503);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(634, 24);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GrdAsesores);
            this.layoutControl1.Controls.Add(this.CmbIdAdjudicacion);
            this.layoutControl1.Controls.Add(this.TxtInmueble);
            this.layoutControl1.Controls.Add(this.TxtContrato);
            this.layoutControl1.Controls.Add(this.TxtValor);
            this.layoutControl1.Controls.Add(this.TxtTitular);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 158);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(634, 345);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GrdAsesores
            // 
            this.GrdAsesores.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrdAsesores.Location = new System.Drawing.Point(12, 60);
            this.GrdAsesores.MainView = this.GrvAsesores;
            this.GrdAsesores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrdAsesores.Name = "GrdAsesores";
            this.GrdAsesores.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RpsAsesor,
            this.RpsCargo});
            this.GrdAsesores.Size = new System.Drawing.Size(610, 273);
            this.GrdAsesores.TabIndex = 11;
            this.GrdAsesores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvAsesores});
            this.GrdAsesores.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GrdAsesores_KeyUp);
            // 
            // GrvAsesores
            // 
            this.GrvAsesores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Cargo,
            this.Asesor,
            this.Com1,
            this.Com2});
            this.GrvAsesores.DetailHeight = 280;
            this.GrvAsesores.GridControl = this.GrdAsesores;
            this.GrvAsesores.Name = "GrvAsesores";
            this.GrvAsesores.OptionsCustomization.AllowColumnMoving = false;
            this.GrvAsesores.OptionsCustomization.AllowColumnResizing = false;
            this.GrvAsesores.OptionsCustomization.AllowFilter = false;
            this.GrvAsesores.OptionsCustomization.AllowGroup = false;
            this.GrvAsesores.OptionsCustomization.AllowSort = false;
            this.GrvAsesores.OptionsView.ShowFooter = true;
            this.GrvAsesores.OptionsView.ShowGroupPanel = false;
            // 
            // Cargo
            // 
            this.Cargo.Caption = "Cargo";
            this.Cargo.ColumnEdit = this.RpsCargo;
            this.Cargo.FieldName = "IdCargo";
            this.Cargo.MinWidth = 22;
            this.Cargo.Name = "Cargo";
            this.Cargo.Visible = true;
            this.Cargo.VisibleIndex = 0;
            this.Cargo.Width = 201;
            // 
            // RpsCargo
            // 
            this.RpsCargo.AutoHeight = false;
            this.RpsCargo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RpsCargo.Name = "RpsCargo";
            this.RpsCargo.PopupView = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Asesor
            // 
            this.Asesor.Caption = "Asesor";
            this.Asesor.ColumnEdit = this.RpsAsesor;
            this.Asesor.FieldName = "IdTercero";
            this.Asesor.MinWidth = 22;
            this.Asesor.Name = "Asesor";
            this.Asesor.Visible = true;
            this.Asesor.VisibleIndex = 1;
            this.Asesor.Width = 229;
            // 
            // RpsAsesor
            // 
            this.RpsAsesor.AutoHeight = false;
            this.RpsAsesor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RpsAsesor.Name = "RpsAsesor";
            this.RpsAsesor.PopupView = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Com1
            // 
            this.Com1.Caption = "Com1";
            this.Com1.DisplayFormat.FormatString = "{0:n2}";
            this.Com1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Com1.FieldName = "Com1";
            this.Com1.MinWidth = 22;
            this.Com1.Name = "Com1";
            this.Com1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Com1", "{0:n2}", new decimal(new int[] {
                            0,
                            0,
                            0,
                            0}))});
            this.Com1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Com1.Visible = true;
            this.Com1.VisibleIndex = 2;
            this.Com1.Width = 81;
            // 
            // Com2
            // 
            this.Com2.Caption = "Com2";
            this.Com2.DisplayFormat.FormatString = "{0:n2}";
            this.Com2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Com2.FieldName = "Com2";
            this.Com2.Name = "Com2";
            this.Com2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Com2", "{0:n2}")});
            this.Com2.Visible = true;
            this.Com2.VisibleIndex = 3;
            // 
            // CmbIdAdjudicacion
            // 
            this.CmbIdAdjudicacion.Location = new System.Drawing.Point(94, 12);
            this.CmbIdAdjudicacion.MenuManager = this.ribbon;
            this.CmbIdAdjudicacion.Name = "CmbIdAdjudicacion";
            this.CmbIdAdjudicacion.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.CmbIdAdjudicacion.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.CmbIdAdjudicacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbIdAdjudicacion.Properties.PopupView = this.GrvAdjudicacion;
            this.CmbIdAdjudicacion.Size = new System.Drawing.Size(123, 20);
            this.CmbIdAdjudicacion.StyleController = this.layoutControl1;
            this.CmbIdAdjudicacion.TabIndex = 10;
            this.CmbIdAdjudicacion.EditValueChanged += new System.EventHandler(this.CmbIdAdjudicacion_EditValueChanged);
            // 
            // GrvAdjudicacion
            // 
            this.GrvAdjudicacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdAdj,
            this.TitularPrincipal});
            this.GrvAdjudicacion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GrvAdjudicacion.Name = "GrvAdjudicacion";
            this.GrvAdjudicacion.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GrvAdjudicacion.OptionsView.ShowGroupPanel = false;
            // 
            // IdAdj
            // 
            this.IdAdj.Caption = "Adjudicacion";
            this.IdAdj.FieldName = "IdAdjudicacion";
            this.IdAdj.Name = "IdAdj";
            this.IdAdj.Visible = true;
            this.IdAdj.VisibleIndex = 0;
            // 
            // TitularPrincipal
            // 
            this.TitularPrincipal.Caption = "TitulaPrincipal";
            this.TitularPrincipal.FieldName = "TitularPrincipal";
            this.TitularPrincipal.Name = "TitularPrincipal";
            this.TitularPrincipal.Visible = true;
            this.TitularPrincipal.VisibleIndex = 1;
            // 
            // TxtInmueble
            // 
            this.TxtInmueble.Location = new System.Drawing.Point(505, 36);
            this.TxtInmueble.MenuManager = this.ribbon;
            this.TxtInmueble.Name = "TxtInmueble";
            this.TxtInmueble.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtInmueble.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtInmueble.Properties.ReadOnly = true;
            this.TxtInmueble.Size = new System.Drawing.Size(117, 20);
            this.TxtInmueble.StyleController = this.layoutControl1;
            this.TxtInmueble.TabIndex = 8;
            // 
            // TxtContrato
            // 
            this.TxtContrato.Location = new System.Drawing.Point(303, 36);
            this.TxtContrato.MenuManager = this.ribbon;
            this.TxtContrato.Name = "TxtContrato";
            this.TxtContrato.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtContrato.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtContrato.Properties.ReadOnly = true;
            this.TxtContrato.Size = new System.Drawing.Size(116, 20);
            this.TxtContrato.StyleController = this.layoutControl1;
            this.TxtContrato.TabIndex = 7;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(94, 36);
            this.TxtValor.MenuManager = this.ribbon;
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtValor.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtValor.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtValor.Properties.DisplayFormat.FormatString = "{0:n2}";
            this.TxtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtValor.Properties.EditFormat.FormatString = "{0:n2}";
            this.TxtValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtValor.Properties.ReadOnly = true;
            this.TxtValor.Size = new System.Drawing.Size(123, 20);
            this.TxtValor.StyleController = this.layoutControl1;
            this.TxtValor.TabIndex = 6;
            // 
            // TxtTitular
            // 
            this.TxtTitular.Location = new System.Drawing.Point(303, 12);
            this.TxtTitular.MenuManager = this.ribbon;
            this.TxtTitular.Name = "TxtTitular";
            this.TxtTitular.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtTitular.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtTitular.Properties.ReadOnly = true;
            this.TxtTitular.Size = new System.Drawing.Size(319, 20);
            this.TxtTitular.StyleController = this.layoutControl1;
            this.TxtTitular.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LblTitular,
            this.LblValor,
            this.LblContrato,
            this.LblInmueble,
            this.LblIdAdjudicacion,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(634, 345);
            this.Root.TextVisible = false;
            // 
            // LblTitular
            // 
            this.LblTitular.Control = this.TxtTitular;
            this.LblTitular.Location = new System.Drawing.Point(209, 0);
            this.LblTitular.Name = "LblTitular";
            this.LblTitular.Size = new System.Drawing.Size(405, 24);
            this.LblTitular.Text = "Titular";
            this.LblTitular.TextSize = new System.Drawing.Size(70, 13);
            // 
            // LblValor
            // 
            this.LblValor.Control = this.TxtValor;
            this.LblValor.Location = new System.Drawing.Point(0, 24);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(209, 24);
            this.LblValor.Text = "Valor";
            this.LblValor.TextSize = new System.Drawing.Size(70, 13);
            // 
            // LblContrato
            // 
            this.LblContrato.Control = this.TxtContrato;
            this.LblContrato.Location = new System.Drawing.Point(209, 24);
            this.LblContrato.Name = "LblContrato";
            this.LblContrato.Size = new System.Drawing.Size(202, 24);
            this.LblContrato.Text = "Contrato";
            this.LblContrato.TextSize = new System.Drawing.Size(70, 13);
            // 
            // LblInmueble
            // 
            this.LblInmueble.Control = this.TxtInmueble;
            this.LblInmueble.Location = new System.Drawing.Point(411, 24);
            this.LblInmueble.Name = "LblInmueble";
            this.LblInmueble.Size = new System.Drawing.Size(203, 24);
            this.LblInmueble.Text = "lInmueble";
            this.LblInmueble.TextSize = new System.Drawing.Size(70, 13);
            // 
            // LblIdAdjudicacion
            // 
            this.LblIdAdjudicacion.Control = this.CmbIdAdjudicacion;
            this.LblIdAdjudicacion.Location = new System.Drawing.Point(0, 0);
            this.LblIdAdjudicacion.Name = "LblIdAdjudicacion";
            this.LblIdAdjudicacion.Size = new System.Drawing.Size(209, 24);
            this.LblIdAdjudicacion.Text = "IdAdjudicacion";
            this.LblIdAdjudicacion.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GrdAsesores;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(614, 277);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // XtraRadicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 527);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraRadicacion.IconOptions.SvgImage")));
            this.MinimizeBox = false;
            this.Name = "XtraRadicacion";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "XtraRadicacion";
            this.Load += new System.EventHandler(this.XtraRadicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdAsesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAsesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsAsesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIdAdjudicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInmueble.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContrato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTitular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblTitular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblInmueble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIdAdjudicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage RpRadicacion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RpgRadicacion;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BtnGuardar;
        private DevExpress.XtraBars.BarButtonItem BtnImprimir;
        private DevExpress.XtraBars.BarButtonItem BtnSalir;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit TxtInmueble;
        private DevExpress.XtraEditors.TextEdit TxtContrato;
        private DevExpress.XtraEditors.TextEdit TxtValor;
        private DevExpress.XtraEditors.TextEdit TxtTitular;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem LblTitular;
        private DevExpress.XtraLayout.LayoutControlItem LblValor;
        private DevExpress.XtraLayout.LayoutControlItem LblContrato;
        private DevExpress.XtraLayout.LayoutControlItem LblInmueble;
        private DevExpress.XtraEditors.GridLookUpEdit CmbIdAdjudicacion;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvAdjudicacion;
        private DevExpress.XtraLayout.LayoutControlItem LblIdAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdAdj;
        private DevExpress.XtraGrid.Columns.GridColumn TitularPrincipal;
        public DevExpress.XtraGrid.GridControl GrdAsesores;
        public DevExpress.XtraGrid.Views.Grid.GridView GrvAsesores;
        private DevExpress.XtraGrid.Columns.GridColumn Cargo;
        public DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit RpsCargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Asesor;
        public DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit RpsAsesor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Com1;
        private DevExpress.XtraGrid.Columns.GridColumn Com2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}