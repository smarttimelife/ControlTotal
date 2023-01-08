namespace ControlTotal
{
    partial class XtraUsuarioProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraUsuarioProyectos));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GrdUsuarioProyecto = new DevExpress.XtraGrid.GridControl();
            this.GrvUsuarioProyecto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdProyecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RpsProyecto = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdSoftware = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RpsSoftware = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnAdicionar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.CmbSoftware = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CmbProyectos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreProyecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TxtIdUsuario = new DevExpress.XtraEditors.TextEdit();
            this.TxtNombreUsuario = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LblNombreUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblIdUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblProyectos = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblSoftware = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuarioProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvUsuarioProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsSoftware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbSoftware.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProyectos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblNombreUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblSoftware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GrdUsuarioProyecto);
            this.layoutControl1.Controls.Add(this.BtnAdicionar);
            this.layoutControl1.Controls.Add(this.BtnEliminar);
            this.layoutControl1.Controls.Add(this.CmbSoftware);
            this.layoutControl1.Controls.Add(this.CmbProyectos);
            this.layoutControl1.Controls.Add(this.TxtIdUsuario);
            this.layoutControl1.Controls.Add(this.TxtNombreUsuario);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(559, 254);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GrdUsuarioProyecto
            // 
            this.GrdUsuarioProyecto.Location = new System.Drawing.Point(12, 62);
            this.GrdUsuarioProyecto.MainView = this.GrvUsuarioProyecto;
            this.GrdUsuarioProyecto.Name = "GrdUsuarioProyecto";
            this.GrdUsuarioProyecto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RpsSoftware,
            this.RpsProyecto});
            this.GrdUsuarioProyecto.Size = new System.Drawing.Size(535, 180);
            this.GrdUsuarioProyecto.TabIndex = 10;
            this.GrdUsuarioProyecto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvUsuarioProyecto});
            // 
            // GrvUsuarioProyecto
            // 
            this.GrvUsuarioProyecto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdProyecto,
            this.IdSoftware});
            this.GrvUsuarioProyecto.GridControl = this.GrdUsuarioProyecto;
            this.GrvUsuarioProyecto.Name = "GrvUsuarioProyecto";
            this.GrvUsuarioProyecto.OptionsView.ShowGroupPanel = false;
            // 
            // IdProyecto
            // 
            this.IdProyecto.Caption = "IdProyecto";
            this.IdProyecto.ColumnEdit = this.RpsProyecto;
            this.IdProyecto.FieldName = "IdProyecto";
            this.IdProyecto.Name = "IdProyecto";
            this.IdProyecto.Visible = true;
            this.IdProyecto.VisibleIndex = 0;
            // 
            // RpsProyecto
            // 
            this.RpsProyecto.AutoHeight = false;
            this.RpsProyecto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RpsProyecto.Name = "RpsProyecto";
            this.RpsProyecto.PopupView = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // IdSoftware
            // 
            this.IdSoftware.Caption = "IdSoftware";
            this.IdSoftware.ColumnEdit = this.RpsSoftware;
            this.IdSoftware.FieldName = "IdSoftware";
            this.IdSoftware.Name = "IdSoftware";
            this.IdSoftware.Visible = true;
            this.IdSoftware.VisibleIndex = 1;
            // 
            // RpsSoftware
            // 
            this.RpsSoftware.AutoHeight = false;
            this.RpsSoftware.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RpsSoftware.Name = "RpsSoftware";
            this.RpsSoftware.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(443, 36);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(51, 22);
            this.BtnAdicionar.StyleController = this.layoutControl1;
            this.BtnAdicionar.TabIndex = 9;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(498, 36);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(49, 22);
            this.BtnEliminar.StyleController = this.layoutControl1;
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // CmbSoftware
            // 
            this.CmbSoftware.Location = new System.Drawing.Point(304, 36);
            this.CmbSoftware.Name = "CmbSoftware";
            this.CmbSoftware.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbSoftware.Properties.PopupView = this.gridLookUpEdit2View;
            this.CmbSoftware.Size = new System.Drawing.Size(135, 20);
            this.CmbSoftware.StyleController = this.layoutControl1;
            this.CmbSoftware.TabIndex = 7;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // CmbProyectos
            // 
            this.CmbProyectos.Location = new System.Drawing.Point(95, 36);
            this.CmbProyectos.Name = "CmbProyectos";
            this.CmbProyectos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbProyectos.Properties.PopupView = this.gridLookUpEdit1View;
            this.CmbProyectos.Size = new System.Drawing.Size(122, 20);
            this.CmbProyectos.StyleController = this.layoutControl1;
            this.CmbProyectos.TabIndex = 6;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.NombreProyecto});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            // 
            // NombreProyecto
            // 
            this.NombreProyecto.Caption = "NombreProyecto";
            this.NombreProyecto.FieldName = "NombreProyecto";
            this.NombreProyecto.Name = "NombreProyecto";
            this.NombreProyecto.Visible = true;
            this.NombreProyecto.VisibleIndex = 1;
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Location = new System.Drawing.Point(95, 12);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Properties.ReadOnly = true;
            this.TxtIdUsuario.Size = new System.Drawing.Size(122, 20);
            this.TxtIdUsuario.StyleController = this.layoutControl1;
            this.TxtIdUsuario.TabIndex = 5;
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(304, 12);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Properties.ReadOnly = true;
            this.TxtNombreUsuario.Size = new System.Drawing.Size(243, 20);
            this.TxtNombreUsuario.StyleController = this.layoutControl1;
            this.TxtNombreUsuario.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LblNombreUsuario,
            this.LblIdUsuario,
            this.LblProyectos,
            this.LblSoftware,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(559, 254);
            this.Root.TextVisible = false;
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.Control = this.TxtNombreUsuario;
            this.LblNombreUsuario.Location = new System.Drawing.Point(209, 0);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(330, 24);
            this.LblNombreUsuario.Text = "Nombre Usuario:";
            this.LblNombreUsuario.TextSize = new System.Drawing.Size(80, 13);
            // 
            // LblIdUsuario
            // 
            this.LblIdUsuario.Control = this.TxtIdUsuario;
            this.LblIdUsuario.Location = new System.Drawing.Point(0, 0);
            this.LblIdUsuario.Name = "LblIdUsuario";
            this.LblIdUsuario.Size = new System.Drawing.Size(209, 24);
            this.LblIdUsuario.Text = "IdUsuario:";
            this.LblIdUsuario.TextSize = new System.Drawing.Size(80, 13);
            // 
            // LblProyectos
            // 
            this.LblProyectos.Control = this.CmbProyectos;
            this.LblProyectos.Location = new System.Drawing.Point(0, 24);
            this.LblProyectos.Name = "LblProyectos";
            this.LblProyectos.Size = new System.Drawing.Size(209, 26);
            this.LblProyectos.Text = "Proyectos:";
            this.LblProyectos.TextSize = new System.Drawing.Size(80, 13);
            // 
            // LblSoftware
            // 
            this.LblSoftware.Control = this.CmbSoftware;
            this.LblSoftware.Location = new System.Drawing.Point(209, 24);
            this.LblSoftware.Name = "LblSoftware";
            this.LblSoftware.Size = new System.Drawing.Size(222, 26);
            this.LblSoftware.Text = "Software:";
            this.LblSoftware.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.BtnEliminar;
            this.layoutControlItem3.Location = new System.Drawing.Point(486, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(53, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.BtnAdicionar;
            this.layoutControlItem4.Location = new System.Drawing.Point(431, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(55, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GrdUsuarioProyecto;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(539, 184);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // XtraUsuarioProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 254);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraUsuarioProyectos.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraUsuarioProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraUsuarioProyectos";
            this.Activated += new System.EventHandler(this.XtraUsuarioProyectos_Activated);
            this.Load += new System.EventHandler(this.XtraUsuarioProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsuarioProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvUsuarioProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsSoftware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbSoftware.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProyectos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblNombreUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblSoftware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl GrdUsuarioProyecto;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvUsuarioProyecto;
        private DevExpress.XtraGrid.Columns.GridColumn IdProyecto;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RpsProyecto;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn IdSoftware;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RpsSoftware;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton BtnAdicionar;
        private DevExpress.XtraEditors.SimpleButton BtnEliminar;
        private DevExpress.XtraEditors.GridLookUpEdit CmbSoftware;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit CmbProyectos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit TxtIdUsuario;
        private DevExpress.XtraEditors.TextEdit TxtNombreUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LblNombreUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LblIdUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LblProyectos;
        private DevExpress.XtraLayout.LayoutControlItem LblSoftware;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn NombreProyecto;
    }
}