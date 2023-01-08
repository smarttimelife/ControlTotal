namespace ControlTotal
{
    partial class XtraAceptarDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraAceptarDocumento));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.userAdjudicacion1 = new ControlTotal.UserAdjudicacion();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.BtnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.TxtComentarioRecibe = new DevExpress.XtraEditors.TextEdit();
            this.TxtComentarioEnvio = new DevExpress.XtraEditors.TextEdit();
            this.TxtOperacion = new DevExpress.XtraEditors.TextEdit();
            this.TxtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.DtpFecha = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LblFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblOperacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblComentario = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblComentarioEnvio = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComentarioRecibe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComentarioEnvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblComentario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblComentarioEnvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.userAdjudicacion1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(879, 283);
            this.splitContainerControl1.SplitterPosition = 141;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // userAdjudicacion1
            // 
            this.userAdjudicacion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAdjudicacion1.Location = new System.Drawing.Point(0, 0);
            this.userAdjudicacion1.Name = "userAdjudicacion1";
            this.userAdjudicacion1.Size = new System.Drawing.Size(879, 141);
            this.userAdjudicacion1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BtnSalir);
            this.layoutControl1.Controls.Add(this.BtnAceptar);
            this.layoutControl1.Controls.Add(this.TxtComentarioRecibe);
            this.layoutControl1.Controls.Add(this.TxtComentarioEnvio);
            this.layoutControl1.Controls.Add(this.TxtOperacion);
            this.layoutControl1.Controls.Add(this.TxtUsuario);
            this.layoutControl1.Controls.Add(this.DtpFecha);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(879, 132);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BtnSalir
            // 
            this.BtnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSalir.ImageOptions.SvgImage")));
            this.BtnSalir.Location = new System.Drawing.Point(762, 84);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(105, 36);
            this.BtnSalir.StyleController = this.layoutControl1;
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAceptar.ImageOptions.SvgImage")));
            this.BtnAceptar.Location = new System.Drawing.Point(654, 84);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(104, 36);
            this.BtnAceptar.StyleController = this.layoutControl1;
            this.BtnAceptar.TabIndex = 9;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // TxtComentarioRecibe
            // 
            this.TxtComentarioRecibe.Location = new System.Drawing.Point(96, 60);
            this.TxtComentarioRecibe.Name = "TxtComentarioRecibe";
            this.TxtComentarioRecibe.Size = new System.Drawing.Size(771, 20);
            this.TxtComentarioRecibe.StyleController = this.layoutControl1;
            this.TxtComentarioRecibe.TabIndex = 8;
            // 
            // TxtComentarioEnvio
            // 
            this.TxtComentarioEnvio.Location = new System.Drawing.Point(96, 36);
            this.TxtComentarioEnvio.Name = "TxtComentarioEnvio";
            this.TxtComentarioEnvio.Properties.ReadOnly = true;
            this.TxtComentarioEnvio.Size = new System.Drawing.Size(771, 20);
            this.TxtComentarioEnvio.StyleController = this.layoutControl1;
            this.TxtComentarioEnvio.TabIndex = 7;
            // 
            // TxtOperacion
            // 
            this.TxtOperacion.Location = new System.Drawing.Point(303, 12);
            this.TxtOperacion.Name = "TxtOperacion";
            this.TxtOperacion.Properties.ReadOnly = true;
            this.TxtOperacion.Size = new System.Drawing.Size(245, 20);
            this.TxtOperacion.StyleController = this.layoutControl1;
            this.TxtOperacion.TabIndex = 6;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(636, 12);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Properties.ReadOnly = true;
            this.TxtUsuario.Size = new System.Drawing.Size(231, 20);
            this.TxtUsuario.StyleController = this.layoutControl1;
            this.TxtUsuario.TabIndex = 5;
            // 
            // DtpFecha
            // 
            this.DtpFecha.EditValue = null;
            this.DtpFecha.Location = new System.Drawing.Point(96, 12);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtpFecha.Properties.ReadOnly = true;
            this.DtpFecha.Size = new System.Drawing.Size(119, 20);
            this.DtpFecha.StyleController = this.layoutControl1;
            this.DtpFecha.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LblFecha,
            this.LblUsuario,
            this.LblOperacion,
            this.LblComentario,
            this.LblComentarioEnvio,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(879, 132);
            this.Root.TextVisible = false;
            // 
            // LblFecha
            // 
            this.LblFecha.Control = this.DtpFecha;
            this.LblFecha.Location = new System.Drawing.Point(0, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(207, 24);
            this.LblFecha.Text = "Fecha";
            this.LblFecha.TextSize = new System.Drawing.Size(81, 13);
            // 
            // LblUsuario
            // 
            this.LblUsuario.Control = this.TxtUsuario;
            this.LblUsuario.Location = new System.Drawing.Point(540, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(319, 24);
            this.LblUsuario.Text = "Usuario";
            this.LblUsuario.TextSize = new System.Drawing.Size(81, 13);
            // 
            // LblOperacion
            // 
            this.LblOperacion.Control = this.TxtOperacion;
            this.LblOperacion.Location = new System.Drawing.Point(207, 0);
            this.LblOperacion.Name = "LblOperacion";
            this.LblOperacion.Size = new System.Drawing.Size(333, 24);
            this.LblOperacion.Text = "Operacion";
            this.LblOperacion.TextSize = new System.Drawing.Size(81, 13);
            // 
            // LblComentario
            // 
            this.LblComentario.Control = this.TxtComentarioEnvio;
            this.LblComentario.Location = new System.Drawing.Point(0, 24);
            this.LblComentario.Name = "LblComentario";
            this.LblComentario.Size = new System.Drawing.Size(859, 24);
            this.LblComentario.Text = "Comentario";
            this.LblComentario.TextSize = new System.Drawing.Size(81, 13);
            // 
            // LblComentarioEnvio
            // 
            this.LblComentarioEnvio.Control = this.TxtComentarioRecibe;
            this.LblComentarioEnvio.Location = new System.Drawing.Point(0, 48);
            this.LblComentarioEnvio.Name = "LblComentarioEnvio";
            this.LblComentarioEnvio.Size = new System.Drawing.Size(859, 24);
            this.LblComentarioEnvio.Text = "ComentarioEnvio";
            this.LblComentarioEnvio.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.BtnAceptar;
            this.layoutControlItem2.Location = new System.Drawing.Point(642, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(108, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.BtnSalir;
            this.layoutControlItem3.Location = new System.Drawing.Point(750, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(109, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(642, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // XtraAceptarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 283);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "XtraAceptarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraAceptarDocumento";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtComentarioRecibe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComentarioEnvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblComentario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblComentarioEnvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private UserAdjudicacion userAdjudicacion1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit TxtComentarioEnvio;
        private DevExpress.XtraEditors.TextEdit TxtOperacion;
        private DevExpress.XtraEditors.TextEdit TxtUsuario;
        private DevExpress.XtraEditors.DateEdit DtpFecha;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem LblFecha;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem LblUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LblOperacion;
        private DevExpress.XtraLayout.LayoutControlItem LblComentario;
        private DevExpress.XtraEditors.SimpleButton BtnSalir;
        private DevExpress.XtraEditors.SimpleButton BtnAceptar;
        private DevExpress.XtraEditors.TextEdit TxtComentarioRecibe;
        private DevExpress.XtraLayout.LayoutControlItem LblComentarioEnvio;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}