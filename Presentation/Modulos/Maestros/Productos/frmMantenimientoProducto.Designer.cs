namespace Presentation.Modulos.Maestros.Productos
{
    partial class frmMantenimientoProducto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label cantidadVigenteLabel;
            System.Windows.Forms.Label cantidadKardexLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label iDIVALabel;
            System.Windows.Forms.Label iDAlmacenLabel;
            System.Windows.Forms.Label iDUnidadManejoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label iDProductoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoProducto));
            this.IzquierdoPanel = new System.Windows.Forms.Panel();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.cantidadVigenteTextBox = new System.Windows.Forms.TextBox();
            this.cantidadKardexTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.iDIVAComboBox = new System.Windows.Forms.ComboBox();
            this.iDAlmacenComboBox = new System.Windows.Forms.ComboBox();
            this.iDUnidadManejoComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.iDProductoTextBox = new System.Windows.Forms.TextBox();
            this.guardarBunifuFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            notasLabel = new System.Windows.Forms.Label();
            cantidadVigenteLabel = new System.Windows.Forms.Label();
            cantidadKardexLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            iDIVALabel = new System.Windows.Forms.Label();
            iDAlmacenLabel = new System.Windows.Forms.Label();
            iDUnidadManejoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            iDProductoLabel = new System.Windows.Forms.Label();
            this.IzquierdoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.ForeColor = System.Drawing.Color.White;
            notasLabel.Location = new System.Drawing.Point(55, 346);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(49, 17);
            notasLabel.TabIndex = 21;
            notasLabel.Text = "Notas:";
            // 
            // cantidadVigenteLabel
            // 
            cantidadVigenteLabel.AutoSize = true;
            cantidadVigenteLabel.ForeColor = System.Drawing.Color.White;
            cantidadVigenteLabel.Location = new System.Drawing.Point(280, 292);
            cantidadVigenteLabel.Name = "cantidadVigenteLabel";
            cantidadVigenteLabel.Size = new System.Drawing.Size(120, 17);
            cantidadVigenteLabel.TabIndex = 19;
            cantidadVigenteLabel.Text = "Cantidad Vigente:";
            // 
            // cantidadKardexLabel
            // 
            cantidadKardexLabel.AutoSize = true;
            cantidadKardexLabel.ForeColor = System.Drawing.Color.White;
            cantidadKardexLabel.Location = new System.Drawing.Point(55, 292);
            cantidadKardexLabel.Name = "cantidadKardexLabel";
            cantidadKardexLabel.Size = new System.Drawing.Size(116, 17);
            cantidadKardexLabel.TabIndex = 17;
            cantidadKardexLabel.Text = "Cantidad Kardex:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.ForeColor = System.Drawing.Color.White;
            precioLabel.Location = new System.Drawing.Point(51, 233);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(52, 17);
            precioLabel.TabIndex = 10;
            precioLabel.Text = "Precio:";
            // 
            // iDIVALabel
            // 
            iDIVALabel.AutoSize = true;
            iDIVALabel.ForeColor = System.Drawing.Color.White;
            iDIVALabel.Location = new System.Drawing.Point(279, 236);
            iDIVALabel.Name = "iDIVALabel";
            iDIVALabel.Size = new System.Drawing.Size(33, 17);
            iDIVALabel.TabIndex = 12;
            iDIVALabel.Text = "IVA:";
            // 
            // iDAlmacenLabel
            // 
            iDAlmacenLabel.AutoSize = true;
            iDAlmacenLabel.ForeColor = System.Drawing.Color.White;
            iDAlmacenLabel.Location = new System.Drawing.Point(279, 176);
            iDAlmacenLabel.Name = "iDAlmacenLabel";
            iDAlmacenLabel.Size = new System.Drawing.Size(66, 17);
            iDAlmacenLabel.TabIndex = 8;
            iDAlmacenLabel.Text = "Almacen:";
            // 
            // iDUnidadManejoLabel
            // 
            iDUnidadManejoLabel.AutoSize = true;
            iDUnidadManejoLabel.ForeColor = System.Drawing.Color.White;
            iDUnidadManejoLabel.Location = new System.Drawing.Point(51, 176);
            iDUnidadManejoLabel.Name = "iDUnidadManejoLabel";
            iDUnidadManejoLabel.Size = new System.Drawing.Size(127, 17);
            iDUnidadManejoLabel.TabIndex = 6;
            iDUnidadManejoLabel.Text = "Unidad de Manejo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.ForeColor = System.Drawing.Color.White;
            descripcionLabel.Location = new System.Drawing.Point(51, 119);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripción:";
            // 
            // iDProductoLabel
            // 
            iDProductoLabel.AutoSize = true;
            iDProductoLabel.ForeColor = System.Drawing.Color.White;
            iDProductoLabel.Location = new System.Drawing.Point(51, 68);
            iDProductoLabel.Name = "iDProductoLabel";
            iDProductoLabel.Size = new System.Drawing.Size(86, 17);
            iDProductoLabel.TabIndex = 1;
            iDProductoLabel.Text = "ID Producto:";
            // 
            // IzquierdoPanel
            // 
            this.IzquierdoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(49)))));
            this.IzquierdoPanel.Controls.Add(notasLabel);
            this.IzquierdoPanel.Controls.Add(this.notasTextBox);
            this.IzquierdoPanel.Controls.Add(cantidadVigenteLabel);
            this.IzquierdoPanel.Controls.Add(this.cantidadVigenteTextBox);
            this.IzquierdoPanel.Controls.Add(cantidadKardexLabel);
            this.IzquierdoPanel.Controls.Add(this.cantidadKardexTextBox);
            this.IzquierdoPanel.Controls.Add(precioLabel);
            this.IzquierdoPanel.Controls.Add(iDIVALabel);
            this.IzquierdoPanel.Controls.Add(this.precioTextBox);
            this.IzquierdoPanel.Controls.Add(iDAlmacenLabel);
            this.IzquierdoPanel.Controls.Add(this.iDIVAComboBox);
            this.IzquierdoPanel.Controls.Add(iDUnidadManejoLabel);
            this.IzquierdoPanel.Controls.Add(this.iDAlmacenComboBox);
            this.IzquierdoPanel.Controls.Add(this.iDUnidadManejoComboBox);
            this.IzquierdoPanel.Controls.Add(descripcionLabel);
            this.IzquierdoPanel.Controls.Add(this.descripcionTextBox);
            this.IzquierdoPanel.Controls.Add(iDProductoLabel);
            this.IzquierdoPanel.Controls.Add(this.iDProductoTextBox);
            this.IzquierdoPanel.Controls.Add(this.guardarBunifuFlatButton);
            this.IzquierdoPanel.Controls.Add(this.label15);
            this.IzquierdoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.IzquierdoPanel.Location = new System.Drawing.Point(0, 0);
            this.IzquierdoPanel.Name = "IzquierdoPanel";
            this.IzquierdoPanel.Size = new System.Drawing.Size(499, 617);
            this.IzquierdoPanel.TabIndex = 5;
            this.IzquierdoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.IzquierdoPanel_Paint);
            // 
            // notasTextBox
            // 
            this.notasTextBox.BackColor = System.Drawing.Color.Silver;
            this.notasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasTextBox.Location = new System.Drawing.Point(54, 370);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.Size = new System.Drawing.Size(410, 51);
            this.notasTextBox.TabIndex = 22;
            // 
            // cantidadVigenteTextBox
            // 
            this.cantidadVigenteTextBox.BackColor = System.Drawing.Color.Silver;
            this.cantidadVigenteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadVigenteTextBox.Location = new System.Drawing.Point(283, 314);
            this.cantidadVigenteTextBox.Name = "cantidadVigenteTextBox";
            this.cantidadVigenteTextBox.Size = new System.Drawing.Size(181, 27);
            this.cantidadVigenteTextBox.TabIndex = 20;
            // 
            // cantidadKardexTextBox
            // 
            this.cantidadKardexTextBox.BackColor = System.Drawing.Color.Silver;
            this.cantidadKardexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadKardexTextBox.Location = new System.Drawing.Point(54, 314);
            this.cantidadKardexTextBox.Name = "cantidadKardexTextBox";
            this.cantidadKardexTextBox.Size = new System.Drawing.Size(203, 27);
            this.cantidadKardexTextBox.TabIndex = 18;
            // 
            // precioTextBox
            // 
            this.precioTextBox.BackColor = System.Drawing.Color.Silver;
            this.precioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.Location = new System.Drawing.Point(54, 256);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(199, 27);
            this.precioTextBox.TabIndex = 11;
            // 
            // iDIVAComboBox
            // 
            this.iDIVAComboBox.BackColor = System.Drawing.Color.Silver;
            this.iDIVAComboBox.DisplayMember = "Descripcion";
            this.iDIVAComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDIVAComboBox.FormattingEnabled = true;
            this.iDIVAComboBox.Location = new System.Drawing.Point(279, 256);
            this.iDIVAComboBox.Name = "iDIVAComboBox";
            this.iDIVAComboBox.Size = new System.Drawing.Size(181, 28);
            this.iDIVAComboBox.TabIndex = 13;
            this.iDIVAComboBox.ValueMember = "IDIVA";
            // 
            // iDAlmacenComboBox
            // 
            this.iDAlmacenComboBox.BackColor = System.Drawing.Color.Silver;
            this.iDAlmacenComboBox.DisplayMember = "Descripcion";
            this.iDAlmacenComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDAlmacenComboBox.FormattingEnabled = true;
            this.iDAlmacenComboBox.Location = new System.Drawing.Point(279, 196);
            this.iDAlmacenComboBox.Name = "iDAlmacenComboBox";
            this.iDAlmacenComboBox.Size = new System.Drawing.Size(181, 28);
            this.iDAlmacenComboBox.TabIndex = 9;
            this.iDAlmacenComboBox.ValueMember = "IDAlmacen";
            // 
            // iDUnidadManejoComboBox
            // 
            this.iDUnidadManejoComboBox.BackColor = System.Drawing.Color.Silver;
            this.iDUnidadManejoComboBox.DisplayMember = "Descripcion";
            this.iDUnidadManejoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDUnidadManejoComboBox.FormattingEnabled = true;
            this.iDUnidadManejoComboBox.Location = new System.Drawing.Point(54, 196);
            this.iDUnidadManejoComboBox.Name = "iDUnidadManejoComboBox";
            this.iDUnidadManejoComboBox.Size = new System.Drawing.Size(199, 28);
            this.iDUnidadManejoComboBox.TabIndex = 7;
            this.iDUnidadManejoComboBox.ValueMember = "IDUnidadManejo";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.BackColor = System.Drawing.Color.Silver;
            this.descripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(54, 140);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(406, 27);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // iDProductoTextBox
            // 
            this.iDProductoTextBox.BackColor = System.Drawing.Color.Silver;
            this.iDProductoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDProductoTextBox.Location = new System.Drawing.Point(54, 91);
            this.iDProductoTextBox.Name = "iDProductoTextBox";
            this.iDProductoTextBox.Size = new System.Drawing.Size(199, 27);
            this.iDProductoTextBox.TabIndex = 2;
            // 
            // guardarBunifuFlatButton
            // 
            this.guardarBunifuFlatButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(91)))));
            this.guardarBunifuFlatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(91)))));
            this.guardarBunifuFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardarBunifuFlatButton.BorderRadius = 7;
            this.guardarBunifuFlatButton.ButtonText = "Guardar";
            this.guardarBunifuFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarBunifuFlatButton.DisabledColor = System.Drawing.Color.Gray;
            this.guardarBunifuFlatButton.Iconcolor = System.Drawing.Color.Transparent;
            this.guardarBunifuFlatButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("guardarBunifuFlatButton.Iconimage")));
            this.guardarBunifuFlatButton.Iconimage_right = null;
            this.guardarBunifuFlatButton.Iconimage_right_Selected = null;
            this.guardarBunifuFlatButton.Iconimage_Selected = null;
            this.guardarBunifuFlatButton.IconMarginLeft = 0;
            this.guardarBunifuFlatButton.IconMarginRight = 0;
            this.guardarBunifuFlatButton.IconRightVisible = true;
            this.guardarBunifuFlatButton.IconRightZoom = 0D;
            this.guardarBunifuFlatButton.IconVisible = true;
            this.guardarBunifuFlatButton.IconZoom = 50D;
            this.guardarBunifuFlatButton.IsTab = false;
            this.guardarBunifuFlatButton.Location = new System.Drawing.Point(142, 461);
            this.guardarBunifuFlatButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guardarBunifuFlatButton.Name = "guardarBunifuFlatButton";
            this.guardarBunifuFlatButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(91)))));
            this.guardarBunifuFlatButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(91)))));
            this.guardarBunifuFlatButton.OnHoverTextColor = System.Drawing.Color.White;
            this.guardarBunifuFlatButton.selected = false;
            this.guardarBunifuFlatButton.Size = new System.Drawing.Size(218, 48);
            this.guardarBunifuFlatButton.TabIndex = 0;
            this.guardarBunifuFlatButton.Text = "Guardar";
            this.guardarBunifuFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guardarBunifuFlatButton.Textcolor = System.Drawing.Color.White;
            this.guardarBunifuFlatButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBunifuFlatButton.Click += new System.EventHandler(this.guardarBunifuFlatButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(175, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "Productos";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 617);
            this.Controls.Add(this.IzquierdoPanel);
            this.Name = "frmMantenimientoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoProducto";
            this.IzquierdoPanel.ResumeLayout(false);
            this.IzquierdoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel IzquierdoPanel;
        private Bunifu.Framework.UI.BunifuFlatButton guardarBunifuFlatButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox notasTextBox;
        public System.Windows.Forms.TextBox cantidadVigenteTextBox;
        public System.Windows.Forms.TextBox cantidadKardexTextBox;
        public System.Windows.Forms.TextBox precioTextBox;
        public System.Windows.Forms.ComboBox iDIVAComboBox;
        public System.Windows.Forms.ComboBox iDAlmacenComboBox;
        public System.Windows.Forms.ComboBox iDUnidadManejoComboBox;
        public System.Windows.Forms.TextBox descripcionTextBox;
        public System.Windows.Forms.TextBox iDProductoTextBox;
    }
}