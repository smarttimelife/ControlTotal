
namespace ControlTotal
{
    partial class XtraOficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraOficina));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.BtnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.BnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.TxtNombreOficina = new DevExpress.XtraEditors.TextEdit();
            this.TxtMora = new DevExpress.XtraEditors.TextEdit();
            this.TxtIntCorriente = new DevExpress.XtraEditors.TextEdit();
            this.TxtPorcentaje = new DevExpress.XtraEditors.TextEdit();
            this.TxtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LblId = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblNombreOficina = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblMora = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblIntCorriente = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblPorcentaje = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblPeriodo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CheAutomatico = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreOficina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIntCorriente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPorcentaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblNombreOficina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIntCorriente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheAutomatico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.BtnGuardar);
            this.dataLayoutControl1.Controls.Add(this.BnSalir);
            this.dataLayoutControl1.Controls.Add(this.TxtId);
            this.dataLayoutControl1.Controls.Add(this.TxtNombreOficina);
            this.dataLayoutControl1.Controls.Add(this.TxtMora);
            this.dataLayoutControl1.Controls.Add(this.TxtIntCorriente);
            this.dataLayoutControl1.Controls.Add(this.TxtPorcentaje);
            this.dataLayoutControl1.Controls.Add(this.TxtPeriodo);
            this.dataLayoutControl1.Controls.Add(this.CheAutomatico);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(298, 226);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(12, 180);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(135, 22);
            this.BtnGuardar.StyleController = this.dataLayoutControl1;
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BnSalir
            // 
            this.BnSalir.Location = new System.Drawing.Point(151, 180);
            this.BnSalir.Name = "BnSalir";
            this.BnSalir.Size = new System.Drawing.Size(135, 22);
            this.BnSalir.StyleController = this.dataLayoutControl1;
            this.BnSalir.TabIndex = 10;
            this.BnSalir.Text = "Salir";
            this.BnSalir.Click += new System.EventHandler(this.BnSalir_Click);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(119, 12);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(167, 20);
            this.TxtId.StyleController = this.dataLayoutControl1;
            this.TxtId.TabIndex = 4;
            // 
            // TxtNombreOficina
            // 
            this.TxtNombreOficina.Location = new System.Drawing.Point(119, 36);
            this.TxtNombreOficina.Name = "TxtNombreOficina";
            this.TxtNombreOficina.Size = new System.Drawing.Size(167, 20);
            this.TxtNombreOficina.StyleController = this.dataLayoutControl1;
            this.TxtNombreOficina.TabIndex = 5;
            // 
            // TxtMora
            // 
            this.TxtMora.Location = new System.Drawing.Point(119, 60);
            this.TxtMora.Name = "TxtMora";
            this.TxtMora.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtMora.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtMora.Properties.DisplayFormat.FormatString = "{0:n2}";
            this.TxtMora.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtMora.Properties.EditFormat.FormatString = "{0:n2}";
            this.TxtMora.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtMora.Size = new System.Drawing.Size(167, 20);
            this.TxtMora.StyleController = this.dataLayoutControl1;
            this.TxtMora.TabIndex = 6;
            // 
            // TxtIntCorriente
            // 
            this.TxtIntCorriente.Location = new System.Drawing.Point(119, 84);
            this.TxtIntCorriente.Name = "TxtIntCorriente";
            this.TxtIntCorriente.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtIntCorriente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtIntCorriente.Properties.DisplayFormat.FormatString = "{0:n2}";
            this.TxtIntCorriente.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtIntCorriente.Properties.EditFormat.FormatString = "{0:n2}";
            this.TxtIntCorriente.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtIntCorriente.Size = new System.Drawing.Size(167, 20);
            this.TxtIntCorriente.StyleController = this.dataLayoutControl1;
            this.TxtIntCorriente.TabIndex = 7;
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.Location = new System.Drawing.Point(119, 108);
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtPorcentaje.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TxtPorcentaje.Properties.BeepOnError = false;
            this.TxtPorcentaje.Properties.DisplayFormat.FormatString = "P";
            this.TxtPorcentaje.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtPorcentaje.Properties.EditFormat.FormatString = "P";
            this.TxtPorcentaje.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtPorcentaje.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtPorcentaje.Properties.MaskSettings.Set("mask", "p");
            this.TxtPorcentaje.Size = new System.Drawing.Size(167, 20);
            this.TxtPorcentaje.StyleController = this.dataLayoutControl1;
            this.TxtPorcentaje.TabIndex = 8;
            // 
            // TxtPeriodo
            // 
            this.TxtPeriodo.Location = new System.Drawing.Point(119, 132);
            this.TxtPeriodo.Name = "TxtPeriodo";
            this.TxtPeriodo.Properties.MaxLength = 6;
            this.TxtPeriodo.Size = new System.Drawing.Size(167, 20);
            this.TxtPeriodo.StyleController = this.dataLayoutControl1;
            this.TxtPeriodo.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LblId,
            this.LblNombreOficina,
            this.LblMora,
            this.LblIntCorriente,
            this.LblPorcentaje,
            this.LblPeriodo,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(298, 226);
            this.Root.TextVisible = false;
            // 
            // LblId
            // 
            this.LblId.Control = this.TxtId;
            this.LblId.Location = new System.Drawing.Point(0, 0);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(278, 24);
            this.LblId.Text = "Id";
            this.LblId.TextSize = new System.Drawing.Size(95, 13);
            // 
            // LblNombreOficina
            // 
            this.LblNombreOficina.Control = this.TxtNombreOficina;
            this.LblNombreOficina.Location = new System.Drawing.Point(0, 24);
            this.LblNombreOficina.Name = "LblNombreOficina";
            this.LblNombreOficina.Size = new System.Drawing.Size(278, 24);
            this.LblNombreOficina.Text = "NombreOficina";
            this.LblNombreOficina.TextSize = new System.Drawing.Size(95, 13);
            // 
            // LblMora
            // 
            this.LblMora.Control = this.TxtMora;
            this.LblMora.Location = new System.Drawing.Point(0, 48);
            this.LblMora.Name = "LblMora";
            this.LblMora.Size = new System.Drawing.Size(278, 24);
            this.LblMora.Text = "Mora";
            this.LblMora.TextSize = new System.Drawing.Size(95, 13);
            // 
            // LblIntCorriente
            // 
            this.LblIntCorriente.Control = this.TxtIntCorriente;
            this.LblIntCorriente.Location = new System.Drawing.Point(0, 72);
            this.LblIntCorriente.Name = "LblIntCorriente";
            this.LblIntCorriente.Size = new System.Drawing.Size(278, 24);
            this.LblIntCorriente.Text = "IntCorriente";
            this.LblIntCorriente.TextSize = new System.Drawing.Size(95, 13);
            // 
            // LblPorcentaje
            // 
            this.LblPorcentaje.Control = this.TxtPorcentaje;
            this.LblPorcentaje.Location = new System.Drawing.Point(0, 96);
            this.LblPorcentaje.Name = "LblPorcentaje";
            this.LblPorcentaje.Size = new System.Drawing.Size(278, 24);
            this.LblPorcentaje.Text = "Porcentaje de Inical";
            this.LblPorcentaje.TextSize = new System.Drawing.Size(95, 13);
            // 
            // LblPeriodo
            // 
            this.LblPeriodo.Control = this.TxtPeriodo;
            this.LblPeriodo.CustomizationFormText = "Periodo";
            this.LblPeriodo.Location = new System.Drawing.Point(0, 120);
            this.LblPeriodo.Name = "LblPeriodo";
            this.LblPeriodo.Size = new System.Drawing.Size(278, 24);
            this.LblPeriodo.Text = "Periodo";
            this.LblPeriodo.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BnSalir;
            this.layoutControlItem1.Location = new System.Drawing.Point(139, 168);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(139, 38);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.BtnGuardar;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(139, 38);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // CheAutomatico
            // 
            this.CheAutomatico.Location = new System.Drawing.Point(12, 156);
            this.CheAutomatico.Name = "CheAutomatico";
            this.CheAutomatico.Properties.Caption = "Tasa Automatica";
            this.CheAutomatico.Size = new System.Drawing.Size(274, 20);
            this.CheAutomatico.StyleController = this.dataLayoutControl1;
            this.CheAutomatico.TabIndex = 12;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CheAutomatico;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(278, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // XtraOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 226);
            this.Controls.Add(this.dataLayoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraOficina.IconOptions.SvgImage")));
            this.Name = "XtraOficina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraOficina";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreOficina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIntCorriente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPorcentaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblNombreOficina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIntCorriente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheAutomatico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.TextEdit TxtNombreOficina;
        private DevExpress.XtraEditors.TextEdit TxtMora;
        private DevExpress.XtraEditors.TextEdit TxtIntCorriente;
        private DevExpress.XtraEditors.TextEdit TxtPorcentaje;
        private DevExpress.XtraEditors.TextEdit TxtPeriodo;
        private DevExpress.XtraLayout.LayoutControlItem LblId;
        private DevExpress.XtraLayout.LayoutControlItem LblNombreOficina;
        private DevExpress.XtraLayout.LayoutControlItem LblMora;
        private DevExpress.XtraLayout.LayoutControlItem LblIntCorriente;
        private DevExpress.XtraLayout.LayoutControlItem LblPorcentaje;
        private DevExpress.XtraLayout.LayoutControlItem LblPeriodo;
        private DevExpress.XtraEditors.SimpleButton BtnGuardar;
        private DevExpress.XtraEditors.SimpleButton BnSalir;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.CheckEdit CheAutomatico;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}