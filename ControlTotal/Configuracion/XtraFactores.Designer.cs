namespace ControlTotal
{
    partial class XtraFactores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFactores));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.BtnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.TxtTasa = new DevExpress.XtraEditors.TextEdit();
            this.TxtPlazo = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LblPlazo = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblTasa = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPlazo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPlazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BtnSalir);
            this.layoutControl1.Controls.Add(this.BtnAceptar);
            this.layoutControl1.Controls.Add(this.TxtTasa);
            this.layoutControl1.Controls.Add(this.TxtPlazo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(244, 106);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(124, 60);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(108, 34);
            this.BtnSalir.StyleController = this.layoutControl1;
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(12, 60);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(108, 34);
            this.BtnAceptar.StyleController = this.layoutControl1;
            this.BtnAceptar.TabIndex = 6;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtTasa
            // 
            this.TxtTasa.Location = new System.Drawing.Point(44, 36);
            this.TxtTasa.Name = "TxtTasa";
            this.TxtTasa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTasa.Size = new System.Drawing.Size(188, 20);
            this.TxtTasa.StyleController = this.layoutControl1;
            this.TxtTasa.TabIndex = 5;
            // 
            // TxtPlazo
            // 
            this.TxtPlazo.Location = new System.Drawing.Point(44, 12);
            this.TxtPlazo.Name = "TxtPlazo";
            this.TxtPlazo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtPlazo.Size = new System.Drawing.Size(188, 20);
            this.TxtPlazo.StyleController = this.layoutControl1;
            this.TxtPlazo.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.LblTasa,
            this.LblPlazo});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(244, 106);
            this.Root.TextVisible = false;
            // 
            // LblPlazo
            // 
            this.LblPlazo.Control = this.TxtPlazo;
            this.LblPlazo.Location = new System.Drawing.Point(0, 0);
            this.LblPlazo.Name = "LblPlazo";
            this.LblPlazo.Size = new System.Drawing.Size(224, 24);
            this.LblPlazo.Text = "Plazo:";
            this.LblPlazo.TextSize = new System.Drawing.Size(29, 13);
            // 
            // LblTasa
            // 
            this.LblTasa.Control = this.TxtTasa;
            this.LblTasa.Location = new System.Drawing.Point(0, 24);
            this.LblTasa.Name = "LblTasa";
            this.LblTasa.Size = new System.Drawing.Size(224, 24);
            this.LblTasa.Text = "Tasa:";
            this.LblTasa.TextSize = new System.Drawing.Size(29, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BtnAceptar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(112, 38);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.BtnSalir;
            this.layoutControlItem2.Location = new System.Drawing.Point(112, 48);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(112, 38);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // XtraFactores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 106);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraFactores.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFactores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraFactores";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtTasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPlazo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPlazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit TxtPlazo;
        private DevExpress.XtraLayout.LayoutControlItem LblPlazo;
        private DevExpress.XtraEditors.TextEdit TxtTasa;
        private DevExpress.XtraLayout.LayoutControlItem LblTasa;
        private DevExpress.XtraEditors.SimpleButton BtnSalir;
        private DevExpress.XtraEditors.SimpleButton BtnAceptar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}