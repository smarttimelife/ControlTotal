namespace ControlTotal
{
    partial class XtraLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraLogin));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.BtnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.DtpFecha = new DevExpress.XtraEditors.DateEdit();
            this.TxtClave = new DevExpress.XtraEditors.TextEdit();
            this.TxtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.CmbProyecto = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LblProyecto = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblClave = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProyecto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BtnSalir);
            this.layoutControl1.Controls.Add(this.BtnAceptar);
            this.layoutControl1.Controls.Add(this.DtpFecha);
            this.layoutControl1.Controls.Add(this.TxtClave);
            this.layoutControl1.Controls.Add(this.TxtUsuario);
            this.layoutControl1.Controls.Add(this.CmbProyecto);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(259, 148);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Appearance.Options.UseBackColor = true;
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.Location = new System.Drawing.Point(131, 108);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(116, 28);
            this.BtnSalir.StyleController = this.layoutControl1;
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnAceptar.Appearance.Options.UseBackColor = true;
            this.BtnAceptar.Location = new System.Drawing.Point(12, 108);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(115, 28);
            this.BtnAceptar.StyleController = this.layoutControl1;
            this.BtnAceptar.TabIndex = 8;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // DtpFecha
            // 
            this.DtpFecha.EditValue = null;
            this.DtpFecha.Location = new System.Drawing.Point(71, 84);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Properties.Appearance.Options.UseTextOptions = true;
            this.DtpFecha.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DtpFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtpFecha.Size = new System.Drawing.Size(176, 20);
            this.DtpFecha.StyleController = this.layoutControl1;
            this.DtpFecha.TabIndex = 7;
            // 
            // TxtClave
            // 
            this.TxtClave.EditValue = "";
            this.TxtClave.Location = new System.Drawing.Point(71, 60);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtClave.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtClave.Properties.UseSystemPasswordChar = true;
            this.TxtClave.Size = new System.Drawing.Size(176, 20);
            this.TxtClave.StyleController = this.layoutControl1;
            this.TxtClave.TabIndex = 6;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.EditValue = "";
            this.TxtUsuario.Location = new System.Drawing.Point(71, 36);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtUsuario.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtUsuario.Size = new System.Drawing.Size(176, 20);
            this.TxtUsuario.StyleController = this.layoutControl1;
            this.TxtUsuario.TabIndex = 5;
            // 
            // CmbProyecto
            // 
            this.CmbProyecto.Location = new System.Drawing.Point(71, 12);
            this.CmbProyecto.Name = "CmbProyecto";
            this.CmbProyecto.Properties.Appearance.Options.UseTextOptions = true;
            this.CmbProyecto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CmbProyecto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbProyecto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreProyecto", "NombreProyecto", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.False)});
            this.CmbProyecto.Properties.DropDownRows = 6;
            this.CmbProyecto.Size = new System.Drawing.Size(176, 20);
            this.CmbProyecto.StyleController = this.layoutControl1;
            this.CmbProyecto.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LblProyecto,
            this.LblUsuario,
            this.LblClave,
            this.LblFecha,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(259, 148);
            this.Root.TextVisible = false;
            // 
            // LblProyecto
            // 
            this.LblProyecto.Control = this.CmbProyecto;
            this.LblProyecto.Location = new System.Drawing.Point(0, 0);
            this.LblProyecto.Name = "LblProyecto";
            this.LblProyecto.Size = new System.Drawing.Size(239, 24);
            this.LblProyecto.Text = "Proyecto:";
            this.LblProyecto.TextSize = new System.Drawing.Size(47, 13);
            // 
            // LblUsuario
            // 
            this.LblUsuario.Control = this.TxtUsuario;
            this.LblUsuario.Location = new System.Drawing.Point(0, 24);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(239, 24);
            this.LblUsuario.Text = "Usuario";
            this.LblUsuario.TextSize = new System.Drawing.Size(47, 13);
            // 
            // LblClave
            // 
            this.LblClave.Control = this.TxtClave;
            this.LblClave.Location = new System.Drawing.Point(0, 48);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(239, 24);
            this.LblClave.Text = "Clave";
            this.LblClave.TextSize = new System.Drawing.Size(47, 13);
            // 
            // LblFecha
            // 
            this.LblFecha.Control = this.DtpFecha;
            this.LblFecha.Location = new System.Drawing.Point(0, 72);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(239, 24);
            this.LblFecha.Text = "Fecha";
            this.LblFecha.TextSize = new System.Drawing.Size(47, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BtnAceptar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(119, 32);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.BtnSalir;
            this.layoutControlItem2.Location = new System.Drawing.Point(119, 96);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(120, 32);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // XtraLogin
            // 
            this.AcceptButton = this.BtnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(259, 148);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraLogin.IconOptions.Icon")));
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraLogin.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login de Usuarios";
            this.Load += new System.EventHandler(this.XtraLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtpFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProyecto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem LblProyecto;
        private DevExpress.XtraEditors.SimpleButton BtnSalir;
        private DevExpress.XtraEditors.SimpleButton BtnAceptar;
        private DevExpress.XtraEditors.DateEdit DtpFecha;
        private DevExpress.XtraEditors.TextEdit TxtClave;
        private DevExpress.XtraEditors.TextEdit TxtUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LblUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LblClave;
        private DevExpress.XtraLayout.LayoutControlItem LblFecha;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit CmbProyecto;
    }
}