namespace ControlTotal
{
    partial class GrillaControl
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
            this.GrdControl = new DevExpress.XtraGrid.GridControl();
            this.GrvInicial = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupGrilla = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGrilla)).BeginInit();
            this.GroupGrilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdControl
            // 
            this.GrdControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdControl.Location = new System.Drawing.Point(2, 23);
            this.GrdControl.MainView = this.GrvInicial;
            this.GrdControl.Name = "GrdControl";
            this.GrdControl.Size = new System.Drawing.Size(246, 125);
            this.GrdControl.TabIndex = 0;
            this.GrdControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvInicial});
            // 
            // GrvInicial
            // 
            this.GrvInicial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Fecha,
            this.Valor});
            this.GrvInicial.GridControl = this.GrdControl;
            this.GrvInicial.Name = "GrvInicial";
            this.GrvInicial.OptionsView.ShowFooter = true;
            this.GrvInicial.OptionsView.ShowGroupPanel = false;
            this.GrvInicial.CustomSummaryExists += new DevExpress.Data.CustomSummaryExistEventHandler(this.GrvControl_CustomSummaryExists);
            this.GrvInicial.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GrvInicial_CellValueChanged);
            this.GrvInicial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GrvControl_KeyUp);
            this.GrvInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GrvInicial_KeyPress);
            this.GrvInicial.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.GrvControl_ValidatingEditor);
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Fecha", "{0}")});
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 0;
            this.Fecha.Width = 81;
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
            this.Valor.VisibleIndex = 1;
            this.Valor.Width = 144;
            // 
            // GroupGrilla
            // 
            this.GroupGrilla.Controls.Add(this.GrdControl);
            this.GroupGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupGrilla.Location = new System.Drawing.Point(0, 0);
            this.GroupGrilla.Name = "GroupGrilla";
            this.GroupGrilla.Size = new System.Drawing.Size(250, 150);
            this.GroupGrilla.TabIndex = 1;
            this.GroupGrilla.Text = "Cuota Inicial";
            // 
            // GrillaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupGrilla);
            this.Name = "GrillaControl";
            this.Size = new System.Drawing.Size(250, 150);
            ((System.ComponentModel.ISupportInitialize)(this.GrdControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGrilla)).EndInit();
            this.GroupGrilla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraEditors.GroupControl GroupGrilla;
        public DevExpress.XtraGrid.Views.Grid.GridView GrvInicial;
        public DevExpress.XtraGrid.GridControl GrdControl;
    }
}
