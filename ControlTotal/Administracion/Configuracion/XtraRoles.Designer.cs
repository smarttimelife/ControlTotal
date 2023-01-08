namespace ControlTotal
{
    partial class XtraRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraRoles));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GrdRoles = new DevExpress.XtraGrid.GridControl();
            this.GrvRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NombreFormulario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSoftware = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RpsSotware = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Ver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adicionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Modificar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Eliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cerrar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Imprimir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aprobar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Desaprobar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChkMarcar = new DevExpress.XtraEditors.CheckEdit();
            this.TxtNombreRol = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LblNombreRol = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsSotware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkMarcar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreRol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblNombreRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.BtnGuardar,
            this.BtnSalir});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbon.Size = new System.Drawing.Size(1299, 89);
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
            // BtnSalir
            // 
            this.BtnSalir.Caption = "Salir";
            this.BtnSalir.Id = 2;
            this.BtnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSalir.ImageOptions.SvgImage")));
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSalir_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Roles de Usuarios";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnSalir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Operaciones";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 523);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1299, 24);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GrdRoles);
            this.layoutControl1.Controls.Add(this.ChkMarcar);
            this.layoutControl1.Controls.Add(this.TxtNombreRol);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 89);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1299, 434);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GrdRoles
            // 
            this.GrdRoles.Location = new System.Drawing.Point(12, 36);
            this.GrdRoles.MainView = this.GrvRoles;
            this.GrdRoles.MenuManager = this.ribbon;
            this.GrdRoles.Name = "GrdRoles";
            this.GrdRoles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RpsSotware});
            this.GrdRoles.Size = new System.Drawing.Size(1275, 386);
            this.GrdRoles.TabIndex = 6;
            this.GrdRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvRoles});
            // 
            // GrvRoles
            // 
            this.GrvRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NombreFormulario,
            this.IdSoftware,
            this.Ver,
            this.Adicionar,
            this.Modificar,
            this.Eliminar,
            this.Cerrar,
            this.Imprimir,
            this.Aprobar,
            this.Desaprobar});
            this.GrvRoles.GridControl = this.GrdRoles;
            this.GrvRoles.Name = "GrvRoles";
            this.GrvRoles.OptionsFind.AlwaysVisible = true;
            // 
            // NombreFormulario
            // 
            this.NombreFormulario.Caption = "NombreFormulario";
            this.NombreFormulario.FieldName = "NombreFormulario";
            this.NombreFormulario.Name = "NombreFormulario";
            this.NombreFormulario.OptionsColumn.ReadOnly = true;
            this.NombreFormulario.Visible = true;
            this.NombreFormulario.VisibleIndex = 0;
            this.NombreFormulario.Width = 243;
            // 
            // IdSoftware
            // 
            this.IdSoftware.Caption = "IdSoftware";
            this.IdSoftware.ColumnEdit = this.RpsSotware;
            this.IdSoftware.FieldName = "IdSoftware";
            this.IdSoftware.Name = "IdSoftware";
            this.IdSoftware.Visible = true;
            this.IdSoftware.VisibleIndex = 1;
            // 
            // RpsSotware
            // 
            this.RpsSotware.AutoHeight = false;
            this.RpsSotware.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RpsSotware.Name = "RpsSotware";
            // 
            // Ver
            // 
            this.Ver.Caption = "Ver";
            this.Ver.FieldName = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.Visible = true;
            this.Ver.VisibleIndex = 2;
            this.Ver.Width = 77;
            // 
            // Adicionar
            // 
            this.Adicionar.Caption = "Adicionar";
            this.Adicionar.FieldName = "Adicionar";
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Visible = true;
            this.Adicionar.VisibleIndex = 3;
            this.Adicionar.Width = 77;
            // 
            // Modificar
            // 
            this.Modificar.Caption = "Modificar";
            this.Modificar.FieldName = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Visible = true;
            this.Modificar.VisibleIndex = 4;
            this.Modificar.Width = 77;
            // 
            // Eliminar
            // 
            this.Eliminar.Caption = "Eliminar";
            this.Eliminar.FieldName = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Visible = true;
            this.Eliminar.VisibleIndex = 5;
            this.Eliminar.Width = 77;
            // 
            // Cerrar
            // 
            this.Cerrar.Caption = "Cerrar";
            this.Cerrar.FieldName = "Cerrar";
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Visible = true;
            this.Cerrar.VisibleIndex = 6;
            this.Cerrar.Width = 77;
            // 
            // Imprimir
            // 
            this.Imprimir.Caption = "Imprimir";
            this.Imprimir.FieldName = "Imprimir";
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Visible = true;
            this.Imprimir.VisibleIndex = 7;
            this.Imprimir.Width = 77;
            // 
            // Aprobar
            // 
            this.Aprobar.Caption = "Aprobar";
            this.Aprobar.FieldName = "Aprobar";
            this.Aprobar.Name = "Aprobar";
            this.Aprobar.Visible = true;
            this.Aprobar.VisibleIndex = 8;
            this.Aprobar.Width = 77;
            // 
            // Desaprobar
            // 
            this.Desaprobar.Caption = "Desaprobar";
            this.Desaprobar.FieldName = "Desaprobar";
            this.Desaprobar.Name = "Desaprobar";
            this.Desaprobar.Visible = true;
            this.Desaprobar.VisibleIndex = 9;
            this.Desaprobar.Width = 98;
            // 
            // ChkMarcar
            // 
            this.ChkMarcar.Location = new System.Drawing.Point(651, 12);
            this.ChkMarcar.MenuManager = this.ribbon;
            this.ChkMarcar.Name = "ChkMarcar";
            this.ChkMarcar.Properties.Caption = "Marcar Todos";
            this.ChkMarcar.Size = new System.Drawing.Size(636, 20);
            this.ChkMarcar.StyleController = this.layoutControl1;
            this.ChkMarcar.TabIndex = 5;
            this.ChkMarcar.CheckedChanged += new System.EventHandler(this.ChkMarcar_CheckedChanged);
            // 
            // TxtNombreRol
            // 
            this.TxtNombreRol.Location = new System.Drawing.Point(91, 12);
            this.TxtNombreRol.MenuManager = this.ribbon;
            this.TxtNombreRol.Name = "TxtNombreRol";
            this.TxtNombreRol.Size = new System.Drawing.Size(556, 20);
            this.TxtNombreRol.StyleController = this.layoutControl1;
            this.TxtNombreRol.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LblNombreRol,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1299, 434);
            this.Root.TextVisible = false;
            // 
            // LblNombreRol
            // 
            this.LblNombreRol.Control = this.TxtNombreRol;
            this.LblNombreRol.Location = new System.Drawing.Point(0, 0);
            this.LblNombreRol.Name = "LblNombreRol";
            this.LblNombreRol.Size = new System.Drawing.Size(639, 24);
            this.LblNombreRol.Text = "Nombre del Rol:";
            this.LblNombreRol.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ChkMarcar;
            this.layoutControlItem2.Location = new System.Drawing.Point(639, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(640, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.GrdRoles;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1279, 390);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // XtraRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 547);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraRoles.IconOptions.SvgImage")));
            this.Name = "XtraRoles";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "XtraRoles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsSotware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkMarcar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreRol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblNombreRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BtnGuardar;
        private DevExpress.XtraBars.BarButtonItem BtnSalir;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl GrdRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvRoles;
        private DevExpress.XtraGrid.Columns.GridColumn NombreFormulario;
        private DevExpress.XtraGrid.Columns.GridColumn Ver;
        private DevExpress.XtraGrid.Columns.GridColumn Adicionar;
        private DevExpress.XtraGrid.Columns.GridColumn Modificar;
        private DevExpress.XtraGrid.Columns.GridColumn Eliminar;
        private DevExpress.XtraGrid.Columns.GridColumn Cerrar;
        private DevExpress.XtraGrid.Columns.GridColumn Imprimir;
        private DevExpress.XtraGrid.Columns.GridColumn Aprobar;
        private DevExpress.XtraGrid.Columns.GridColumn Desaprobar;
        private DevExpress.XtraEditors.CheckEdit ChkMarcar;
        private DevExpress.XtraEditors.TextEdit TxtNombreRol;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem LblNombreRol;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RpsSotware;
        private DevExpress.XtraGrid.Columns.GridColumn IdSoftware;
    }
}