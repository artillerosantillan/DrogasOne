namespace Presentation
{
    partial class frmRecuperarPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.recuperarUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.enviarButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intruduscar su nombre de usuario";
            // 
            // recuperarUsuarioTextBox
            // 
            this.recuperarUsuarioTextBox.Location = new System.Drawing.Point(128, 105);
            this.recuperarUsuarioTextBox.Name = "recuperarUsuarioTextBox";
            this.recuperarUsuarioTextBox.Size = new System.Drawing.Size(342, 22);
            this.recuperarUsuarioTextBox.TabIndex = 1;
            // 
            // enviarButton
            // 
            this.enviarButton.Location = new System.Drawing.Point(395, 133);
            this.enviarButton.Name = "enviarButton";
            this.enviarButton.Size = new System.Drawing.Size(75, 23);
            this.enviarButton.TabIndex = 2;
            this.enviarButton.Text = "Enviar";
            this.enviarButton.UseVisualStyleBackColor = true;
            this.enviarButton.Click += new System.EventHandler(this.enviarButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(125, 173);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(72, 17);
            this.resultadoLabel.TabIndex = 3;
            this.resultadoLabel.Text = "Resultado";
            // 
            // frmRecuperarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 311);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.enviarButton);
            this.Controls.Add(this.recuperarUsuarioTextBox);
            this.Controls.Add(this.label1);
            this.Name = "frmRecuperarPassword";
            this.Text = "frmRecuperarPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recuperarUsuarioTextBox;
        private System.Windows.Forms.Button enviarButton;
        private System.Windows.Forms.Label resultadoLabel;
    }
}