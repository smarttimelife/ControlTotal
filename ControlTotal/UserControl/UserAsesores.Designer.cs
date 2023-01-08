namespace ControlTotal
{
    partial class UserAsesores
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrdAsesores = new DevExpress.XtraGrid.GridControl();
            this.GrvAsesores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RpsCargo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.RpsCargoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Asesor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RpsAsesor = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.RpsAsesorView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Com1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Com2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit8View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchLookUpEdit9View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAsesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAsesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsCargoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsAsesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsAsesorView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit8View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit9View)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdAsesores
            // 
            this.GrdAsesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdAsesores.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrdAsesores.Location = new System.Drawing.Point(0, 0);
            this.GrdAsesores.MainView = this.GrvAsesores;
            this.GrdAsesores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrdAsesores.Name = "GrdAsesores";
            this.GrdAsesores.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RpsAsesor,
            this.RpsCargo});
            this.GrdAsesores.Size = new System.Drawing.Size(536, 472);
            this.GrdAsesores.TabIndex = 2;
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
            this.GrvAsesores.CustomSummaryExists += new DevExpress.Data.CustomSummaryExistEventHandler(this.GrvAsesores_CustomSummaryExists);
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
            this.RpsCargo.PopupView = this.RpsCargoView;
            // 
            // RpsCargoView
            // 
            this.RpsCargoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.RpsCargoView.Name = "RpsCargoView";
            this.RpsCargoView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.RpsCargoView.OptionsView.ShowGroupPanel = false;
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
            this.RpsAsesor.PopupView = this.RpsAsesorView;
            // 
            // RpsAsesorView
            // 
            this.RpsAsesorView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.RpsAsesorView.Name = "RpsAsesorView";
            this.RpsAsesorView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.RpsAsesorView.OptionsView.ShowGroupPanel = false;
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
            // repositoryItemSearchLookUpEdit8View
            // 
            this.repositoryItemSearchLookUpEdit8View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit8View.Name = "repositoryItemSearchLookUpEdit8View";
            this.repositoryItemSearchLookUpEdit8View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit8View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchLookUpEdit9View
            // 
            this.repositoryItemSearchLookUpEdit9View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit9View.Name = "repositoryItemSearchLookUpEdit9View";
            this.repositoryItemSearchLookUpEdit9View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit9View.OptionsView.ShowGroupPanel = false;
            // 
            // UserAsesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrdAsesores);
            this.Name = "UserAsesores";
            this.Size = new System.Drawing.Size(536, 472);
            ((System.ComponentModel.ISupportInitialize)(this.GrdAsesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAsesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsCargoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsAsesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpsAsesorView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit8View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit9View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn Cargo;
        public DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit RpsCargo;
        private DevExpress.XtraGrid.Views.Grid.GridView RpsCargoView;
        private DevExpress.XtraGrid.Columns.GridColumn Asesor;
        public DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit RpsAsesor;
        private DevExpress.XtraGrid.Views.Grid.GridView RpsAsesorView;
        private DevExpress.XtraGrid.Columns.GridColumn Com1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit8View;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit9View;
        public DevExpress.XtraGrid.GridControl GrdAsesores;
        public DevExpress.XtraGrid.Views.Grid.GridView GrvAsesores;
        private DevExpress.XtraGrid.Columns.GridColumn Com2;
    }
}
