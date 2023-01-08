
namespace ControlTotal
{
    partial class XtraModificarRecaudos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraModificarRecaudos));
            this.userAdjudicacion1 = new ControlTotal.UserAdjudicacion();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.GrdRecaudosDetallados = new DevExpress.XtraGrid.GridControl();
            this.GrvAdjudicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Eliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.IdRecaudo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Recibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Operacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRecaudosDetallados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // userAdjudicacion1
            // 
            this.userAdjudicacion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAdjudicacion1.Location = new System.Drawing.Point(0, 0);
            this.userAdjudicacion1.Name = "userAdjudicacion1";
            this.userAdjudicacion1.Size = new System.Drawing.Size(982, 152);
            this.userAdjudicacion1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.userAdjudicacion1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.GrdRecaudosDetallados);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(982, 412);
            this.splitContainerControl1.SplitterPosition = 152;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // GrdRecaudosDetallados
            // 
            this.GrdRecaudosDetallados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdRecaudosDetallados.Location = new System.Drawing.Point(0, 0);
            this.GrdRecaudosDetallados.MainView = this.GrvAdjudicacion;
            this.GrdRecaudosDetallados.Name = "GrdRecaudosDetallados";
            this.GrdRecaudosDetallados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BtnEliminar});
            this.GrdRecaudosDetallados.Size = new System.Drawing.Size(982, 250);
            this.GrdRecaudosDetallados.TabIndex = 5;
            this.GrdRecaudosDetallados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvAdjudicacion});
            // 
            // GrvAdjudicacion
            // 
            this.GrvAdjudicacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Eliminar,
            this.IdRecaudo,
            this.Fecha,
            this.Recibo,
            this.FormaPago,
            this.Operacion,
            this.Valor});
            this.GrvAdjudicacion.GridControl = this.GrdRecaudosDetallados;
            this.GrvAdjudicacion.Name = "GrvAdjudicacion";
            this.GrvAdjudicacion.OptionsBehavior.ReadOnly = true;
            this.GrvAdjudicacion.OptionsView.ShowFooter = true;
            this.GrvAdjudicacion.OptionsView.ShowGroupPanel = false;
            // 
            // Eliminar
            // 
            this.Eliminar.Caption = "Eliminar";
            this.Eliminar.ColumnEdit = this.BtnEliminar;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Visible = true;
            this.Eliminar.VisibleIndex = 6;
            this.Eliminar.Width = 46;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoHeight = false;
            this.BtnEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BtnEliminar.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.ContextImageOptions.Image")));
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // IdRecaudo
            // 
            this.IdRecaudo.Caption = "IdRecaudo";
            this.IdRecaudo.FieldName = "IdRecaudo";
            this.IdRecaudo.Name = "IdRecaudo";
            this.IdRecaudo.Visible = true;
            this.IdRecaudo.VisibleIndex = 0;
            this.IdRecaudo.Width = 165;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Fecha", "{0}")});
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 1;
            this.Fecha.Width = 165;
            // 
            // Recibo
            // 
            this.Recibo.Caption = "Recibo";
            this.Recibo.FieldName = "Recibo";
            this.Recibo.Name = "Recibo";
            this.Recibo.Visible = true;
            this.Recibo.VisibleIndex = 2;
            this.Recibo.Width = 165;
            // 
            // FormaPago
            // 
            this.FormaPago.Caption = "FormaPago";
            this.FormaPago.FieldName = "FormaPago";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.Visible = true;
            this.FormaPago.VisibleIndex = 3;
            this.FormaPago.Width = 165;
            // 
            // Operacion
            // 
            this.Operacion.Caption = "Operacion";
            this.Operacion.FieldName = "Operacion";
            this.Operacion.Name = "Operacion";
            this.Operacion.Visible = true;
            this.Operacion.VisibleIndex = 4;
            this.Operacion.Width = 165;
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
            this.Valor.Width = 190;
            // 
            // XtraModificarRecaudos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 412);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "XtraModificarRecaudos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraModificarRecaudos";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdRecaudosDetallados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvAdjudicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserAdjudicacion userAdjudicacion1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl GrdRecaudosDetallados;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvAdjudicacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdRecaudo;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn Recibo;
        private DevExpress.XtraGrid.Columns.GridColumn FormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn Operacion;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn Eliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnEliminar;
    }
}