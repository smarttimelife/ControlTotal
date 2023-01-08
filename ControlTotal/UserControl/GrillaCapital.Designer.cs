namespace ControlTotal
{
    partial class GrillaCapital
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.TxtValor = new DevExpress.XtraEditors.TextEdit();
            this.DtpInicio = new DevExpress.XtraEditors.DateEdit();
            this.TxtPlazo = new DevExpress.XtraEditors.TextEdit();
            this.TxtCuota = new DevExpress.XtraEditors.TextEdit();
            this.TxtTasa = new DevExpress.XtraEditors.TextEdit();
            this.CmbPeriodo = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LblPeriodo = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblTasa = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblCuota = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblPlazo = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblInicio = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.GrupoCuota = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPlazo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPlazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoCuota)).BeginInit();
            this.GrupoCuota.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TxtValor);
            this.layoutControl1.Controls.Add(this.DtpInicio);
            this.layoutControl1.Controls.Add(this.TxtPlazo);
            this.layoutControl1.Controls.Add(this.TxtCuota);
            this.layoutControl1.Controls.Add(this.TxtTasa);
            this.layoutControl1.Controls.Add(this.CmbPeriodo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(613, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(296, 125);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TxtValor
            // 
            this.TxtValor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtValor.Location = new System.Drawing.Point(55, 84);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.TxtValor.Properties.Appearance.Options.UseBackColor = true;
            this.TxtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtValor.Properties.DisplayFormat.FormatString = "N2";
            this.TxtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtValor.Properties.EditFormat.FormatString = "N2";
            this.TxtValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtValor.Properties.ReadOnly = true;
            this.TxtValor.Size = new System.Drawing.Size(229, 20);
            this.TxtValor.StyleController = this.layoutControl1;
            this.TxtValor.TabIndex = 45;
            // 
            // DtpInicio
            // 
            this.DtpInicio.EditValue = null;
            this.DtpInicio.Location = new System.Drawing.Point(166, 60);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtpInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtpInicio.Size = new System.Drawing.Size(118, 20);
            this.DtpInicio.StyleController = this.layoutControl1;
            this.DtpInicio.TabIndex = 44;
            // 
            // TxtPlazo
            // 
            this.TxtPlazo.EditValue = "0";
            this.TxtPlazo.Location = new System.Drawing.Point(55, 60);
            this.TxtPlazo.Name = "TxtPlazo";
            this.TxtPlazo.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtPlazo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtPlazo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtPlazo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtPlazo.Size = new System.Drawing.Size(64, 20);
            this.TxtPlazo.StyleController = this.layoutControl1;
            this.TxtPlazo.TabIndex = 43;
            // 
            // TxtCuota
            // 
            this.TxtCuota.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtCuota.Location = new System.Drawing.Point(55, 36);
            this.TxtCuota.Name = "TxtCuota";
            this.TxtCuota.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtCuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtCuota.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.TxtCuota.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtCuota.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.TxtCuota.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtCuota.Properties.DisplayFormat.FormatString = "N2";
            this.TxtCuota.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtCuota.Properties.EditFormat.FormatString = "N2";
            this.TxtCuota.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtCuota.Size = new System.Drawing.Size(229, 20);
            this.TxtCuota.StyleController = this.layoutControl1;
            this.TxtCuota.TabIndex = 42;
            // 
            // TxtTasa
            // 
            this.TxtTasa.EditValue = "0.00";
            this.TxtTasa.Location = new System.Drawing.Point(55, 12);
            this.TxtTasa.Name = "TxtTasa";
            this.TxtTasa.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtTasa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.TxtTasa.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtTasa.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.TxtTasa.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtTasa.Properties.DisplayFormat.FormatString = "N2";
            this.TxtTasa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTasa.Properties.EditFormat.FormatString = "N2";
            this.TxtTasa.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtTasa.Properties.ReadOnly = true;
            this.TxtTasa.Size = new System.Drawing.Size(61, 20);
            this.TxtTasa.StyleController = this.layoutControl1;
            this.TxtTasa.TabIndex = 41;
            // 
            // CmbPeriodo
            // 
            this.CmbPeriodo.Location = new System.Drawing.Point(163, 12);
            this.CmbPeriodo.Name = "CmbPeriodo";
            this.CmbPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbPeriodo.Size = new System.Drawing.Size(121, 20);
            this.CmbPeriodo.StyleController = this.layoutControl1;
            this.CmbPeriodo.TabIndex = 37;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LblPeriodo,
            this.LblTasa,
            this.LblCuota,
            this.LblPlazo,
            this.LblInicio,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(296, 125);
            this.Root.TextVisible = false;
            // 
            // LblPeriodo
            // 
            this.LblPeriodo.Control = this.CmbPeriodo;
            this.LblPeriodo.Location = new System.Drawing.Point(108, 0);
            this.LblPeriodo.Name = "LblPeriodo";
            this.LblPeriodo.Size = new System.Drawing.Size(168, 24);
            this.LblPeriodo.Text = "Periodo:";
            this.LblPeriodo.TextSize = new System.Drawing.Size(40, 13);
            // 
            // LblTasa
            // 
            this.LblTasa.Control = this.TxtTasa;
            this.LblTasa.Location = new System.Drawing.Point(0, 0);
            this.LblTasa.Name = "LblTasa";
            this.LblTasa.Size = new System.Drawing.Size(108, 24);
            this.LblTasa.Text = "Tasa:";
            this.LblTasa.TextSize = new System.Drawing.Size(40, 13);
            // 
            // LblCuota
            // 
            this.LblCuota.Control = this.TxtCuota;
            this.LblCuota.Location = new System.Drawing.Point(0, 24);
            this.LblCuota.Name = "LblCuota";
            this.LblCuota.Size = new System.Drawing.Size(276, 24);
            this.LblCuota.Text = "Cuota:";
            this.LblCuota.TextSize = new System.Drawing.Size(40, 13);
            // 
            // LblPlazo
            // 
            this.LblPlazo.Control = this.TxtPlazo;
            this.LblPlazo.Location = new System.Drawing.Point(0, 48);
            this.LblPlazo.Name = "LblPlazo";
            this.LblPlazo.Size = new System.Drawing.Size(111, 24);
            this.LblPlazo.Text = "Plazo:";
            this.LblPlazo.TextSize = new System.Drawing.Size(40, 13);
            // 
            // LblInicio
            // 
            this.LblInicio.Control = this.DtpInicio;
            this.LblInicio.Location = new System.Drawing.Point(111, 48);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(165, 24);
            this.LblInicio.Text = "Inicio:";
            this.LblInicio.TextSize = new System.Drawing.Size(40, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TxtValor;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(276, 33);
            this.layoutControlItem1.Text = "Valo:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 13);
            // 
            // GrupoCuota
            // 
            this.GrupoCuota.Controls.Add(this.layoutControl1);
            this.GrupoCuota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrupoCuota.Location = new System.Drawing.Point(0, 0);
            this.GrupoCuota.Name = "GrupoCuota";
            this.GrupoCuota.Size = new System.Drawing.Size(300, 150);
            this.GrupoCuota.TabIndex = 1;
            this.GrupoCuota.Text = "groupControl1";
            // 
            // GrillaCapital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrupoCuota);
            this.Name = "GrillaCapital";
            this.Size = new System.Drawing.Size(300, 150);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPlazo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPlazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoCuota)).EndInit();
            this.GrupoCuota.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        public DevExpress.XtraEditors.LookUpEdit CmbPeriodo;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem LblPeriodo;
        public DevExpress.XtraEditors.TextEdit TxtTasa;
        private DevExpress.XtraLayout.LayoutControlItem LblTasa;
        public DevExpress.XtraEditors.TextEdit TxtCuota;
        private DevExpress.XtraLayout.LayoutControlItem LblCuota;
        public DevExpress.XtraEditors.TextEdit TxtPlazo;
        private DevExpress.XtraLayout.LayoutControlItem LblPlazo;
        public DevExpress.XtraEditors.DateEdit DtpInicio;
        private DevExpress.XtraLayout.LayoutControlItem LblInicio;
        public DevExpress.XtraEditors.TextEdit TxtValor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.GroupControl GrupoCuota;
    }
}
