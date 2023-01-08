namespace ControlTotal
{
    partial class XtraUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraUsuarios));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.BtnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.TxtIdUsuario = new DevExpress.XtraEditors.TextEdit();
            this.TxtNombreUsuario = new DevExpress.XtraEditors.TextEdit();
            this.TxtCorreoElectronico = new DevExpress.XtraEditors.TextEdit();
            this.CmbIdRol = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LblIdUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblNombreUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblCorreoElectronico = new DevExpress.XtraLayout.LayoutControlItem();
            this.LblIdRol = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCorreoElectronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIdRol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblNombreUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblCorreoElectronico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIdRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.BtnSalir);
            this.dataLayoutControl1.Controls.Add(this.BtnAceptar);
            this.dataLayoutControl1.Controls.Add(this.TxtIdUsuario);
            this.dataLayoutControl1.Controls.Add(this.TxtNombreUsuario);
            this.dataLayoutControl1.Controls.Add(this.TxtCorreoElectronico);
            this.dataLayoutControl1.Controls.Add(this.CmbIdRol);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(864, 0, 502, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(310, 145);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(223, 108);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 22);
            this.BtnSalir.StyleController = this.dataLayoutControl1;
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(137, 108);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(72, 22);
            this.BtnAceptar.StyleController = this.dataLayoutControl1;
            this.BtnAceptar.TabIndex = 8;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAcpetar_Click);
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Location = new System.Drawing.Point(107, 12);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(191, 20);
            this.TxtIdUsuario.StyleController = this.dataLayoutControl1;
            this.TxtIdUsuario.TabIndex = 4;
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(107, 36);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(191, 20);
            this.TxtNombreUsuario.StyleController = this.dataLayoutControl1;
            this.TxtNombreUsuario.TabIndex = 5;
            // 
            // TxtCorreoElectronico
            // 
            this.TxtCorreoElectronico.Location = new System.Drawing.Point(107, 60);
            this.TxtCorreoElectronico.Name = "TxtCorreoElectronico";
            this.TxtCorreoElectronico.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtCorreoElectronico.Size = new System.Drawing.Size(191, 20);
            this.TxtCorreoElectronico.StyleController = this.dataLayoutControl1;
            this.TxtCorreoElectronico.TabIndex = 6;
            // 
            // CmbIdRol
            // 
            this.CmbIdRol.Location = new System.Drawing.Point(107, 84);
            this.CmbIdRol.Name = "CmbIdRol";
            this.CmbIdRol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbIdRol.Properties.NullText = "";
            this.CmbIdRol.Properties.PopupSizeable = false;
            this.CmbIdRol.Properties.PopupView = this.gridLookUpEdit1View;
            this.CmbIdRol.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.CmbIdRol.Size = new System.Drawing.Size(191, 20);
            this.CmbIdRol.StyleController = this.dataLayoutControl1;
            this.CmbIdRol.TabIndex = 7;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LblIdUsuario,
            this.LblNombreUsuario,
            this.LblCorreoElectronico,
            this.LblIdRol,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(310, 145);
            this.Root.TextVisible = false;
            // 
            // LblIdUsuario
            // 
            this.LblIdUsuario.Control = this.TxtIdUsuario;
            this.LblIdUsuario.Location = new System.Drawing.Point(0, 0);
            this.LblIdUsuario.Name = "LblIdUsuario";
            this.LblIdUsuario.Size = new System.Drawing.Size(290, 24);
            this.LblIdUsuario.Text = "IdUsuario:";
            this.LblIdUsuario.TextSize = new System.Drawing.Size(92, 13);
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.Control = this.TxtNombreUsuario;
            this.LblNombreUsuario.Location = new System.Drawing.Point(0, 24);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(290, 24);
            this.LblNombreUsuario.Text = "Nombre Usuario:";
            this.LblNombreUsuario.TextSize = new System.Drawing.Size(92, 13);
            // 
            // LblCorreoElectronico
            // 
            this.LblCorreoElectronico.Control = this.TxtCorreoElectronico;
            this.LblCorreoElectronico.Location = new System.Drawing.Point(0, 48);
            this.LblCorreoElectronico.Name = "LblCorreoElectronico";
            this.LblCorreoElectronico.Size = new System.Drawing.Size(290, 24);
            this.LblCorreoElectronico.Text = "Correo Electronico:";
            this.LblCorreoElectronico.TextSize = new System.Drawing.Size(92, 13);
            // 
            // LblIdRol
            // 
            this.LblIdRol.Control = this.CmbIdRol;
            this.LblIdRol.Location = new System.Drawing.Point(0, 72);
            this.LblIdRol.Name = "LblIdRol";
            this.LblIdRol.Size = new System.Drawing.Size(290, 24);
            this.LblIdRol.Text = "IdRol:";
            this.LblIdRol.TextSize = new System.Drawing.Size(92, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(201, 96);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 29);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(125, 29);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BtnAceptar;
            this.layoutControlItem1.Location = new System.Drawing.Point(125, 96);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(76, 29);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.BtnSalir;
            this.layoutControlItem2.Location = new System.Drawing.Point(211, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(79, 29);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // XtraUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 145);
            this.Controls.Add(this.dataLayoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraUsuarios.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtIdUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCorreoElectronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbIdRol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblNombreUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblCorreoElectronico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblIdRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit TxtIdUsuario;
        private DevExpress.XtraEditors.TextEdit TxtNombreUsuario;
        private DevExpress.XtraEditors.TextEdit TxtCorreoElectronico;
        private DevExpress.XtraLayout.LayoutControlItem LblIdUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LblNombreUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LblCorreoElectronico;
        private DevExpress.XtraLayout.LayoutControlItem LblIdRol;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.GridLookUpEdit CmbIdRol;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton BtnSalir;
        private DevExpress.XtraEditors.SimpleButton BtnAceptar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}