namespace Presentation.Modulos
{
    partial class frmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.proveedorDataGridView = new System.Windows.Forms.DataGridView();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.nuevoButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.busquedaProveedorTextBox = new System.Windows.Forms.TextBox();
            this.cajaTextopictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaTextopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // proveedorDataGridView
            // 
            this.proveedorDataGridView.AllowUserToAddRows = false;
            this.proveedorDataGridView.AllowUserToDeleteRows = false;
            this.proveedorDataGridView.AllowUserToOrderColumns = true;
            this.proveedorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedorDataGridView.Location = new System.Drawing.Point(21, 76);
            this.proveedorDataGridView.Name = "proveedorDataGridView";
            this.proveedorDataGridView.ReadOnly = true;
            this.proveedorDataGridView.RowTemplate.Height = 24;
            this.proveedorDataGridView.Size = new System.Drawing.Size(1354, 395);
            this.proveedorDataGridView.TabIndex = 0;
            // 
            // eliminarButton
            // 
            this.eliminarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eliminarButton.Location = new System.Drawing.Point(443, 504);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(163, 49);
            this.eliminarButton.TabIndex = 9;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editarButton.Location = new System.Drawing.Point(228, 504);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(163, 49);
            this.editarButton.TabIndex = 8;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // nuevoButton
            // 
            this.nuevoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nuevoButton.Location = new System.Drawing.Point(21, 504);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(163, 49);
            this.nuevoButton.TabIndex = 7;
            this.nuevoButton.Text = "Nuevo";
            this.nuevoButton.UseVisualStyleBackColor = true;
            this.nuevoButton.Click += new System.EventHandler(this.nuevoButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(28, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 87;
            this.pictureBox3.TabStop = false;
            // 
            // busquedaProveedorTextBox
            // 
            this.busquedaProveedorTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.busquedaProveedorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busquedaProveedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaProveedorTextBox.Location = new System.Drawing.Point(78, 26);
            this.busquedaProveedorTextBox.Name = "busquedaProveedorTextBox";
            this.busquedaProveedorTextBox.Size = new System.Drawing.Size(544, 21);
            this.busquedaProveedorTextBox.TabIndex = 85;
            this.busquedaProveedorTextBox.TextChanged += new System.EventHandler(this.busquedaProveedorTextBox_TextChanged);
            // 
            // cajaTextopictureBox
            // 
            this.cajaTextopictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cajaTextopictureBox.Image")));
            this.cajaTextopictureBox.Location = new System.Drawing.Point(21, 10);
            this.cajaTextopictureBox.Name = "cajaTextopictureBox";
            this.cajaTextopictureBox.Size = new System.Drawing.Size(623, 52);
            this.cajaTextopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cajaTextopictureBox.TabIndex = 86;
            this.cajaTextopictureBox.TabStop = false;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 565);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.busquedaProveedorTextBox);
            this.Controls.Add(this.cajaTextopictureBox);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.nuevoButton);
            this.Controls.Add(this.proveedorDataGridView);
            this.Name = "frmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaTextopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView proveedorDataGridView;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button nuevoButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox busquedaProveedorTextBox;
        private System.Windows.Forms.PictureBox cajaTextopictureBox;
    }
}