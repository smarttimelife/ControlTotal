namespace ControlTotal
{
    partial class XtraConfigAnticipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraConfigAnticipos));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.GrvConfig = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RpsCargos = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Recaudo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Anticipo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Recaudo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Anticipo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.BtnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.Adicionar = new DevExpress.XtraBars.BarButtonItem();
            this.Eliminar = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.GrvConfig;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RpsCargos});
            this.gridControl1.Size = new System.Drawing.Size(481, 168);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvConfig});
            // 
            // GrvConfig
            // 
            this.GrvConfig.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdCargo,
            this.Recaudo1,
            this.Anticipo1,
            this.Recaudo2,
            this.Anticipo2});
            this.GrvConfig.GridControl = this.gridControl1;
            this.GrvConfig.Name = "GrvConfig";
            this.GrvConfig.OptionsCustomization.AllowColumnMoving = false;
            this.GrvConfig.OptionsCustomization.AllowFilter = false;
            this.GrvConfig.OptionsCustomization.AllowGroup = false;
            this.GrvConfig.OptionsCustomization.AllowSort = false;
            this.GrvConfig.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GrvConfig_MouseUp);
            // 
            // IdCargo
            // 
            this.IdCargo.Caption = "IdCargo";
            this.IdCargo.ColumnEdit = this.RpsCargos;
            this.IdCargo.FieldName = "IdCargo";
            this.IdCargo.Name = "IdCargo";
            this.IdCargo.Visible = true;
            this.IdCargo.VisibleIndex = 0;
            // 
            // RpsCargos
            // 
            this.RpsCargos.AutoHeight = false;
            this.RpsCargos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RpsCargos.Name = "RpsCargos";
            this.RpsCargos.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Recaudo1
            // 
            this.Recaudo1.Caption = "Recaudo1";
            this.Recaudo1.DisplayFormat.FormatString = "{0:n2}";
            this.Recaudo1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Recaudo1.FieldName = "Recaudo1";
            this.Recaudo1.Name = "Recaudo1";
            this.Recaudo1.Visible = true;
            this.Recaudo1.VisibleIndex = 1;
            // 
            // Anticipo1
            // 
            this.Anticipo1.Caption = "Anticipo1";
            this.Anticipo1.DisplayFormat.FormatString = "{0:n2}";
            this.Anticipo1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Anticipo1.FieldName = "Anticipo1";
            this.Anticipo1.Name = "Anticipo1";
            this.Anticipo1.Visible = true;
            this.Anticipo1.VisibleIndex = 2;
            // 
            // Recaudo2
            // 
            this.Recaudo2.Caption = "Recaudo2";
            this.Recaudo2.DisplayFormat.FormatString = "{0:n2}";
            this.Recaudo2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Recaudo2.FieldName = "Recaudo2";
            this.Recaudo2.Name = "Recaudo2";
            this.Recaudo2.Visible = true;
            this.Recaudo2.VisibleIndex = 3;
            // 
            // Anticipo2
            // 
            this.Anticipo2.Caption = "Anticipo2";
            this.Anticipo2.DisplayFormat.FormatString = "{0:n2}";
            this.Anticipo2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Anticipo2.FieldName = "Anticipo2";
            this.Anticipo2.Name = "Anticipo2";
            this.Anticipo2.Visible = true;
            this.Anticipo2.VisibleIndex = 4;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BtnSalir);
            this.layoutControl1.Controls.Add(this.BtnGuardar);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 12, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(505, 232);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BtnSalir
            // 
            this.BtnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSalir.ImageOptions.SvgImage")));
            this.BtnSalir.Location = new System.Drawing.Point(390, 184);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(103, 36);
            this.BtnSalir.StyleController = this.layoutControl1;
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGuardar.ImageOptions.SvgImage")));
            this.BtnGuardar.Location = new System.Drawing.Point(274, 184);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(112, 36);
            this.BtnGuardar.StyleController = this.layoutControl1;
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(505, 232);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(485, 172);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 172);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(262, 40);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.BtnGuardar;
            this.layoutControlItem2.Location = new System.Drawing.Point(262, 172);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(116, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.BtnSalir;
            this.layoutControlItem3.Location = new System.Drawing.Point(378, 172);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(107, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.Adicionar),
            new DevExpress.XtraBars.LinkPersistInfo(this.Eliminar)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // Adicionar
            // 
            this.Adicionar.Caption = "Adicionar";
            this.Adicionar.Id = 0;
            this.Adicionar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Adicionar.ImageOptions.SvgImage")));
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Adicionar_ItemClick);
            // 
            // Eliminar
            // 
            this.Eliminar.Caption = "Eliminar";
            this.Eliminar.Id = 1;
            this.Eliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Eliminar.ImageOptions.SvgImage")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Eliminar_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Adicionar,
            this.Eliminar,
            this.barStaticItem1});
            this.barManager1.MaxItemId = 9;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(505, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 232);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(505, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 232);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(505, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 232);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Acciones";
            this.barStaticItem1.Id = 8;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // XtraConfigAnticipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 232);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraConfigAnticipos.IconOptions.SvgImage")));
            this.Name = "XtraConfigAnticipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cofigurar Anticipos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvConfig;
        private DevExpress.XtraGrid.Columns.GridColumn IdCargo;
        private DevExpress.XtraGrid.Columns.GridColumn Recaudo1;
        private DevExpress.XtraGrid.Columns.GridColumn Anticipo1;
        private DevExpress.XtraGrid.Columns.GridColumn Recaudo2;
        private DevExpress.XtraGrid.Columns.GridColumn Anticipo2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RpsCargos;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton BtnSalir;
        private DevExpress.XtraEditors.SimpleButton BtnGuardar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem Adicionar;
        private DevExpress.XtraBars.BarButtonItem Eliminar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}