
namespace ControlTotal
{
    partial class GrillaCuota
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
            this.TxtTasa = new DevExpress.XtraEditors.TextEdit();
            this.TxtCuota = new DevExpress.XtraEditors.TextEdit();
            this.DtpInicio = new DevExpress.XtraEditors.DateEdit();
            this.TxtPlazo = new DevExpress.XtraEditors.TextEdit();
            this.TxtValor = new DevExpress.XtraEditors.TextEdit();
            this.CmbPeriodo = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LblValor = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblFechaInicio = new DevExpress.XtraLayout.LayoutControlItem();
            this.GrupoCuota = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPlazo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblFechaInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoCuota)).BeginInit();
            this.GrupoCuota.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TxtTasa);
            this.layoutControl1.Controls.Add(this.TxtCuota);
            this.layoutControl1.Controls.Add(this.DtpInicio);
            this.layoutControl1.Controls.Add(this.TxtPlazo);
            this.layoutControl1.Controls.Add(this.TxtValor);
            this.layoutControl1.Controls.Add(this.CmbPeriodo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(638, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(296, 125);
            this.layoutControl1.TabIndex = 37;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TxtTasa
            // 
            this.TxtTasa.EditValue = "0.00";
            this.TxtTasa.Location = new System.Drawing.Point(66, 12);
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
            this.TxtTasa.Size = new System.Drawing.Size(63, 20);
            this.TxtTasa.StyleController = this.layoutControl1;
            this.TxtTasa.TabIndex = 33;
            this.TxtTasa.EditValueChanged += new System.EventHandler(this.TxtValor_EditValueChanged);
            this.TxtTasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPeriodo_KeyPress);
            this.TxtTasa.Validated += new System.EventHandler(this.TxtValor_Validated);
            // 
            // TxtCuota
            // 
            this.TxtCuota.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtCuota.Location = new System.Drawing.Point(66, 84);
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
            this.TxtCuota.Properties.ReadOnly = true;
            this.TxtCuota.Size = new System.Drawing.Size(218, 20);
            this.TxtCuota.StyleController = this.layoutControl1;
            this.TxtCuota.TabIndex = 32;
            this.TxtCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPeriodo_KeyPress);
            this.TxtCuota.Validated += new System.EventHandler(this.TxtValor_Validated);
            // 
            // DtpInicio
            // 
            this.DtpInicio.EditValue = null;
            this.DtpInicio.Location = new System.Drawing.Point(187, 60);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtpInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtpInicio.Size = new System.Drawing.Size(97, 20);
            this.DtpInicio.StyleController = this.layoutControl1;
            this.DtpInicio.TabIndex = 29;
            this.DtpInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPeriodo_KeyPress);
            this.DtpInicio.Validated += new System.EventHandler(this.TxtValor_Validated);
            // 
            // TxtPlazo
            // 
            this.TxtPlazo.EditValue = "0";
            this.TxtPlazo.Location = new System.Drawing.Point(66, 60);
            this.TxtPlazo.Name = "TxtPlazo";
            this.TxtPlazo.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtPlazo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtPlazo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtPlazo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtPlazo.Size = new System.Drawing.Size(63, 20);
            this.TxtPlazo.StyleController = this.layoutControl1;
            this.TxtPlazo.TabIndex = 28;
            this.TxtPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPeriodo_KeyPress);
            this.TxtPlazo.Validated += new System.EventHandler(this.TxtValor_Validated);
            // 
            // TxtValor
            // 
            this.TxtValor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtValor.Location = new System.Drawing.Point(66, 36);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtValor.Properties.DisplayFormat.FormatString = "N2";
            this.TxtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtValor.Properties.EditFormat.FormatString = "N2";
            this.TxtValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtValor.Size = new System.Drawing.Size(218, 20);
            this.TxtValor.StyleController = this.layoutControl1;
            this.TxtValor.TabIndex = 27;
            this.TxtValor.EditValueChanged += new System.EventHandler(this.TxtValor_EditValueChanged);
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPeriodo_KeyPress);
            this.TxtValor.Validated += new System.EventHandler(this.TxtValor_Validated);
            // 
            // CmbPeriodo
            // 
            this.CmbPeriodo.Location = new System.Drawing.Point(187, 12);
            this.CmbPeriodo.Name = "CmbPeriodo";
            this.CmbPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbPeriodo.Size = new System.Drawing.Size(97, 20);
            this.CmbPeriodo.StyleController = this.layoutControl1;
            this.CmbPeriodo.TabIndex = 25;
            this.CmbPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPeriodo_KeyPress);
            this.CmbPeriodo.Validated += new System.EventHandler(this.TxtValor_Validated);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LblValor,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.LblFechaInicio});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(296, 125);
            this.Root.TextVisible = false;
            // 
            // LblValor
            // 
            this.LblValor.Control = this.TxtValor;
            this.LblValor.Location = new System.Drawing.Point(0, 24);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(276, 24);
            this.LblValor.Text = "Valor:";
            this.LblValor.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TxtPlazo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "LblPlazo";
            this.layoutControlItem1.Size = new System.Drawing.Size(121, 24);
            this.layoutControlItem1.Text = "Plazo";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TxtCuota;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "LblCuota";
            this.layoutControlItem2.Size = new System.Drawing.Size(276, 33);
            this.layoutControlItem2.Text = "Cuota:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TxtTasa;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "LblTasa";
            this.layoutControlItem3.Size = new System.Drawing.Size(121, 24);
            this.layoutControlItem3.Text = "Tasa:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CmbPeriodo;
            this.layoutControlItem4.Location = new System.Drawing.Point(121, 0);
            this.layoutControlItem4.Name = "LblPeriodo";
            this.layoutControlItem4.Size = new System.Drawing.Size(155, 24);
            this.layoutControlItem4.Text = "Periodo:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(51, 13);
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.Control = this.DtpInicio;
            this.LblFechaInicio.Location = new System.Drawing.Point(121, 48);
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(155, 24);
            this.LblFechaInicio.Text = "Fecha Ini :";
            this.LblFechaInicio.TextSize = new System.Drawing.Size(51, 13);
            // 
            // GrupoCuota
            // 
            this.GrupoCuota.Controls.Add(this.layoutControl1);
            this.GrupoCuota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrupoCuota.Location = new System.Drawing.Point(0, 0);
            this.GrupoCuota.Name = "GrupoCuota";
            this.GrupoCuota.Size = new System.Drawing.Size(300, 150);
            this.GrupoCuota.TabIndex = 38;
            this.GrupoCuota.Text = "groupControl1";
            // 
            // GrillaCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrupoCuota);
            this.Name = "GrillaCuota";
            this.Size = new System.Drawing.Size(300, 150);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtTasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPlazo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblFechaInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoCuota)).EndInit();
            this.GrupoCuota.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        public DevExpress.XtraEditors.TextEdit TxtTasa;
        public DevExpress.XtraEditors.TextEdit TxtCuota;
        public DevExpress.XtraEditors.DateEdit DtpInicio;
        public DevExpress.XtraEditors.TextEdit TxtPlazo;
        public DevExpress.XtraEditors.TextEdit TxtValor;
        public DevExpress.XtraEditors.LookUpEdit CmbPeriodo;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem LblValor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem LblFechaInicio;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.GroupControl GrupoCuota;
    }
}
