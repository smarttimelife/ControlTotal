namespace ControlTotal
{
    partial class XtraReasignarClaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReasignarClaves));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.BtnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.TxtConfirmarClave = new DevExpress.XtraEditors.TextEdit();
            this.TxtClave = new DevExpress.XtraEditors.TextEdit();
            this.TxtNombreUsuario = new DevExpress.XtraEditors.TextEdit();
            this.TxtIdUsuario = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LblIdUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblNombreUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblClave = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblConfirmarClave = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtClaveActual = new DevExpress.XtraEditors.TextEdit();
            this.LblClaveActual = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConfirmarClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblNombreUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblConfirmarClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtClaveActual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblClaveActual)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TxtClaveActual);
            this.layoutControl1.Controls.Add(this.BtnSalir);
            this.layoutControl1.Controls.Add(this.BtnAceptar);
            this.layoutControl1.Controls.Add(this.TxtConfirmarClave);
            this.layoutControl1.Controls.Add(this.TxtClave);
            this.layoutControl1.Controls.Add(this.TxtNombreUsuario);
            this.layoutControl1.Controls.Add(this.TxtIdUsuario);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(622, 7, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(386, 168);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(195, 132);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(179, 24);
            this.BtnSalir.StyleController = this.layoutControl1;
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(12, 132);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(179, 24);
            this.BtnAceptar.StyleController = this.layoutControl1;
            this.BtnAceptar.TabIndex = 8;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtConfirmarClave
            // 
            this.TxtConfirmarClave.Location = new System.Drawing.Point(95, 108);
            this.TxtConfirmarClave.Name = "TxtConfirmarClave";
            this.TxtConfirmarClave.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtConfirmarClave.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtConfirmarClave.Properties.UseSystemPasswordChar = true;
            this.TxtConfirmarClave.Size = new System.Drawing.Size(279, 20);
            this.TxtConfirmarClave.StyleController = this.layoutControl1;
            this.TxtConfirmarClave.TabIndex = 7;
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(95, 84);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtClave.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtClave.Properties.UseSystemPasswordChar = true;
            this.TxtClave.Size = new System.Drawing.Size(279, 20);
            this.TxtClave.StyleController = this.layoutControl1;
            this.TxtClave.TabIndex = 6;
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(95, 36);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.TxtNombreUsuario.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtNombreUsuario.Properties.ReadOnly = true;
            this.TxtNombreUsuario.Size = new System.Drawing.Size(279, 20);
            this.TxtNombreUsuario.StyleController = this.layoutControl1;
            this.TxtNombreUsuario.TabIndex = 5;
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Location = new System.Drawing.Point(95, 12);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.TxtIdUsuario.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtIdUsuario.Properties.ReadOnly = true;
            this.TxtIdUsuario.Size = new System.Drawing.Size(279, 20);
            this.TxtIdUsuario.StyleController = this.layoutControl1;
            this.TxtIdUsuario.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LblIdUsuario,
            this.LblNombreUsuario,
            this.LblClave,
            this.LblConfirmarClave,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.LblClaveActual});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(386, 168);
            this.Root.TextVisible = false;
            // 
            // LblIdUsuario
            // 
            this.LblIdUsuario.Control = this.TxtIdUsuario;
            this.LblIdUsuario.Location = new System.Drawing.Point(0, 0);
            this.LblIdUsuario.Name = "LblIdUsuario";
            this.LblIdUsuario.Size = new System.Drawing.Size(366, 24);
            this.LblIdUsuario.Text = "IdUsuario:";
            this.LblIdUsuario.TextSize = new System.Drawing.Size(80, 13);
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.Control = this.TxtNombreUsuario;
            this.LblNombreUsuario.Location = new System.Drawing.Point(0, 24);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(366, 24);
            this.LblNombreUsuario.Text = "Nombre Usuario:";
            this.LblNombreUsuario.TextSize = new System.Drawing.Size(80, 13);
            // 
            // LblClave
            // 
            this.LblClave.Control = this.TxtClave;
            this.LblClave.Location = new System.Drawing.Point(0, 72);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(366, 24);
            this.LblClave.Text = "Clave:";
            this.LblClave.TextSize = new System.Drawing.Size(80, 13);
            // 
            // LblConfirmarClave
            // 
            this.LblConfirmarClave.Control = this.TxtConfirmarClave;
            this.LblConfirmarClave.Location = new System.Drawing.Point(0, 96);
            this.LblConfirmarClave.Name = "LblConfirmarClave";
            this.LblConfirmarClave.Size = new System.Drawing.Size(366, 24);
            this.LblConfirmarClave.Text = "ConfirmarClave:";
            this.LblConfirmarClave.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.BtnAceptar;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(78, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(183, 28);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.BtnSalir;
            this.layoutControlItem6.Location = new System.Drawing.Point(183, 120);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(78, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(183, 28);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // TxtClaveActual
            // 
            this.TxtClaveActual.Location = new System.Drawing.Point(95, 60);
            this.TxtClaveActual.Name = "TxtClaveActual";
            this.TxtClaveActual.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtClaveActual.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtClaveActual.Properties.UseSystemPasswordChar = true;
            this.TxtClaveActual.Size = new System.Drawing.Size(279, 20);
            this.TxtClaveActual.StyleController = this.layoutControl1;
            this.TxtClaveActual.TabIndex = 10;
            // 
            // LblClaveActual
            // 
            this.LblClaveActual.Control = this.TxtClaveActual;
            this.LblClaveActual.Location = new System.Drawing.Point(0, 48);
            this.LblClaveActual.Name = "LblClaveActual";
            this.LblClaveActual.Size = new System.Drawing.Size(366, 24);
            this.LblClaveActual.Text = "Clave Actual:";
            this.LblClaveActual.TextSize = new System.Drawing.Size(80, 13);
            this.LblClaveActual.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // XtraReasignarClaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 168);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraReasignarClaves.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraReasignarClaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reasignar Claves";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtConfirmarClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblNombreUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblConfirmarClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtClaveActual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblClaveActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton BtnSalir;
        private DevExpress.XtraEditors.SimpleButton BtnAceptar;
        private DevExpress.XtraEditors.TextEdit TxtConfirmarClave;
        private DevExpress.XtraEditors.TextEdit TxtClave;
        private DevExpress.XtraEditors.TextEdit TxtNombreUsuario;
        private DevExpress.XtraEditors.TextEdit TxtIdUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LblIdUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LblNombreUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LblClave;
        private DevExpress.XtraLayout.LayoutControlItem LblConfirmarClave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit TxtClaveActual;
        private DevExpress.XtraLayout.LayoutControlItem LblClaveActual;
    }
}