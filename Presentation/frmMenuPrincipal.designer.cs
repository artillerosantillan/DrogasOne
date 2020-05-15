namespace Presentation
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.cerrarSesionButton = new System.Windows.Forms.Button();
            this.reportesButton = new System.Windows.Forms.Button();
            this.usuariosButton = new System.Windows.Forms.Button();
            this.kardexButton = new System.Windows.Forms.Button();
            this.comprasButton = new System.Windows.Forms.Button();
            this.proveedoresButton = new System.Windows.Forms.Button();
            this.centroSaludButton = new System.Windows.Forms.Button();
            this.salidasButton = new System.Windows.Forms.Button();
            this.productoButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tituloBarraPanel = new System.Windows.Forms.Panel();
            this.minimizarButton = new System.Windows.Forms.Button();
            this.maximizarButton = new System.Windows.Forms.Button();
            this.cerrarButton = new System.Windows.Forms.Button();
            this.cerrarFormHijoButton = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.panelEscritorioPanel = new System.Windows.Forms.Panel();
            this.inferiorPanel = new System.Windows.Forms.Panel();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.horaLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.pocisionLabel = new System.Windows.Forms.Label();
            this.nombresLabel = new System.Windows.Forms.Label();
            this.imagenUserPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.editProfileLinkLabel = new System.Windows.Forms.LinkLabel();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.tituloBarraPanel.SuspendLayout();
            this.panelEscritorioPanel.SuspendLayout();
            this.inferiorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(134)))));
            this.menuPanel.Controls.Add(this.cerrarSesionButton);
            this.menuPanel.Controls.Add(this.reportesButton);
            this.menuPanel.Controls.Add(this.usuariosButton);
            this.menuPanel.Controls.Add(this.kardexButton);
            this.menuPanel.Controls.Add(this.comprasButton);
            this.menuPanel.Controls.Add(this.proveedoresButton);
            this.menuPanel.Controls.Add(this.centroSaludButton);
            this.menuPanel.Controls.Add(this.salidasButton);
            this.menuPanel.Controls.Add(this.productoButton);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(219, 822);
            this.menuPanel.TabIndex = 0;
            // 
            // cerrarSesionButton
            // 
            this.cerrarSesionButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cerrarSesionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cerrarSesionButton.FlatAppearance.BorderSize = 0;
            this.cerrarSesionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarSesionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionButton.ForeColor = System.Drawing.Color.White;
            this.cerrarSesionButton.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesionButton.Image")));
            this.cerrarSesionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrarSesionButton.Location = new System.Drawing.Point(0, 763);
            this.cerrarSesionButton.Name = "cerrarSesionButton";
            this.cerrarSesionButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.cerrarSesionButton.Size = new System.Drawing.Size(219, 59);
            this.cerrarSesionButton.TabIndex = 9;
            this.cerrarSesionButton.Text = "    Cerrar Sesión";
            this.cerrarSesionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrarSesionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cerrarSesionButton.UseVisualStyleBackColor = true;
            this.cerrarSesionButton.Click += new System.EventHandler(this.cerrarSesionButton_Click);
            // 
            // reportesButton
            // 
            this.reportesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reportesButton.FlatAppearance.BorderSize = 0;
            this.reportesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesButton.ForeColor = System.Drawing.Color.White;
            this.reportesButton.Image = ((System.Drawing.Image)(resources.GetObject("reportesButton.Image")));
            this.reportesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportesButton.Location = new System.Drawing.Point(0, 493);
            this.reportesButton.Name = "reportesButton";
            this.reportesButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.reportesButton.Size = new System.Drawing.Size(219, 59);
            this.reportesButton.TabIndex = 8;
            this.reportesButton.Text = "    Reportes";
            this.reportesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportesButton.UseVisualStyleBackColor = true;
            this.reportesButton.Click += new System.EventHandler(this.reportesButton_Click);
            // 
            // usuariosButton
            // 
            this.usuariosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.usuariosButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usuariosButton.FlatAppearance.BorderSize = 0;
            this.usuariosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuariosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosButton.ForeColor = System.Drawing.Color.White;
            this.usuariosButton.Image = ((System.Drawing.Image)(resources.GetObject("usuariosButton.Image")));
            this.usuariosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usuariosButton.Location = new System.Drawing.Point(0, 434);
            this.usuariosButton.Name = "usuariosButton";
            this.usuariosButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.usuariosButton.Size = new System.Drawing.Size(219, 59);
            this.usuariosButton.TabIndex = 7;
            this.usuariosButton.Text = "    Usuarios";
            this.usuariosButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usuariosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usuariosButton.UseVisualStyleBackColor = true;
            this.usuariosButton.Click += new System.EventHandler(this.usuariosButton_Click);
            // 
            // kardexButton
            // 
            this.kardexButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.kardexButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kardexButton.FlatAppearance.BorderSize = 0;
            this.kardexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kardexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kardexButton.ForeColor = System.Drawing.Color.White;
            this.kardexButton.Image = ((System.Drawing.Image)(resources.GetObject("kardexButton.Image")));
            this.kardexButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kardexButton.Location = new System.Drawing.Point(0, 375);
            this.kardexButton.Name = "kardexButton";
            this.kardexButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.kardexButton.Size = new System.Drawing.Size(219, 59);
            this.kardexButton.TabIndex = 6;
            this.kardexButton.Text = "    Kardex";
            this.kardexButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kardexButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kardexButton.UseVisualStyleBackColor = true;
            this.kardexButton.Click += new System.EventHandler(this.kardexButton_Click);
            // 
            // comprasButton
            // 
            this.comprasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.comprasButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comprasButton.FlatAppearance.BorderSize = 0;
            this.comprasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comprasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasButton.ForeColor = System.Drawing.Color.White;
            this.comprasButton.Image = ((System.Drawing.Image)(resources.GetObject("comprasButton.Image")));
            this.comprasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comprasButton.Location = new System.Drawing.Point(0, 316);
            this.comprasButton.Name = "comprasButton";
            this.comprasButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.comprasButton.Size = new System.Drawing.Size(219, 59);
            this.comprasButton.TabIndex = 5;
            this.comprasButton.Text = "    Compras";
            this.comprasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comprasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.comprasButton.UseVisualStyleBackColor = true;
            this.comprasButton.Click += new System.EventHandler(this.comprasButton_Click);
            // 
            // proveedoresButton
            // 
            this.proveedoresButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.proveedoresButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.proveedoresButton.FlatAppearance.BorderSize = 0;
            this.proveedoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proveedoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedoresButton.ForeColor = System.Drawing.Color.White;
            this.proveedoresButton.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresButton.Image")));
            this.proveedoresButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedoresButton.Location = new System.Drawing.Point(0, 257);
            this.proveedoresButton.Name = "proveedoresButton";
            this.proveedoresButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.proveedoresButton.Size = new System.Drawing.Size(219, 59);
            this.proveedoresButton.TabIndex = 4;
            this.proveedoresButton.Text = "    Proveedores";
            this.proveedoresButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedoresButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.proveedoresButton.UseVisualStyleBackColor = true;
            this.proveedoresButton.Click += new System.EventHandler(this.proveedoresButton_Click);
            // 
            // centroSaludButton
            // 
            this.centroSaludButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.centroSaludButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.centroSaludButton.FlatAppearance.BorderSize = 0;
            this.centroSaludButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.centroSaludButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centroSaludButton.ForeColor = System.Drawing.Color.White;
            this.centroSaludButton.Image = ((System.Drawing.Image)(resources.GetObject("centroSaludButton.Image")));
            this.centroSaludButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.centroSaludButton.Location = new System.Drawing.Point(0, 198);
            this.centroSaludButton.Name = "centroSaludButton";
            this.centroSaludButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.centroSaludButton.Size = new System.Drawing.Size(219, 59);
            this.centroSaludButton.TabIndex = 3;
            this.centroSaludButton.Text = "    Centros Salud";
            this.centroSaludButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.centroSaludButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.centroSaludButton.UseVisualStyleBackColor = true;
            this.centroSaludButton.Click += new System.EventHandler(this.centroSaludButton_Click);
            // 
            // salidasButton
            // 
            this.salidasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.salidasButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.salidasButton.FlatAppearance.BorderSize = 0;
            this.salidasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salidasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidasButton.ForeColor = System.Drawing.Color.White;
            this.salidasButton.Image = ((System.Drawing.Image)(resources.GetObject("salidasButton.Image")));
            this.salidasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salidasButton.Location = new System.Drawing.Point(0, 139);
            this.salidasButton.Name = "salidasButton";
            this.salidasButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.salidasButton.Size = new System.Drawing.Size(219, 59);
            this.salidasButton.TabIndex = 2;
            this.salidasButton.Text = "    Salidas";
            this.salidasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salidasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salidasButton.UseVisualStyleBackColor = true;
            this.salidasButton.Click += new System.EventHandler(this.salidasButton_Click);
            // 
            // productoButton
            // 
            this.productoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.productoButton.FlatAppearance.BorderSize = 0;
            this.productoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoButton.ForeColor = System.Drawing.Color.White;
            this.productoButton.Image = ((System.Drawing.Image)(resources.GetObject("productoButton.Image")));
            this.productoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productoButton.Location = new System.Drawing.Point(0, 80);
            this.productoButton.Name = "productoButton";
            this.productoButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.productoButton.Size = new System.Drawing.Size(219, 59);
            this.productoButton.TabIndex = 1;
            this.productoButton.Text = "    Productos";
            this.productoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productoButton.UseVisualStyleBackColor = true;
            this.productoButton.Click += new System.EventHandler(this.productoButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.logoPanel.Controls.Add(this.label1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(219, 80);
            this.logoPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drogas One CNS";
            // 
            // tituloBarraPanel
            // 
            this.tituloBarraPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(213)))), ((int)(((byte)(139)))));
            this.tituloBarraPanel.Controls.Add(this.minimizarButton);
            this.tituloBarraPanel.Controls.Add(this.maximizarButton);
            this.tituloBarraPanel.Controls.Add(this.cerrarButton);
            this.tituloBarraPanel.Controls.Add(this.cerrarFormHijoButton);
            this.tituloBarraPanel.Controls.Add(this.tituloLabel);
            this.tituloBarraPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tituloBarraPanel.Location = new System.Drawing.Point(219, 0);
            this.tituloBarraPanel.Name = "tituloBarraPanel";
            this.tituloBarraPanel.Size = new System.Drawing.Size(1014, 80);
            this.tituloBarraPanel.TabIndex = 1;
            this.tituloBarraPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tituloBarraPanel_MouseDown);
            // 
            // minimizarButton
            // 
            this.minimizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizarButton.FlatAppearance.BorderSize = 0;
            this.minimizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizarButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizarButton.Image")));
            this.minimizarButton.Location = new System.Drawing.Point(897, 3);
            this.minimizarButton.Name = "minimizarButton";
            this.minimizarButton.Size = new System.Drawing.Size(30, 30);
            this.minimizarButton.TabIndex = 4;
            this.minimizarButton.UseVisualStyleBackColor = true;
            this.minimizarButton.Click += new System.EventHandler(this.minimizarButton_Click);
            // 
            // maximizarButton
            // 
            this.maximizarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizarButton.FlatAppearance.BorderSize = 0;
            this.maximizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizarButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizarButton.Image")));
            this.maximizarButton.Location = new System.Drawing.Point(939, 3);
            this.maximizarButton.Name = "maximizarButton";
            this.maximizarButton.Size = new System.Drawing.Size(30, 30);
            this.maximizarButton.TabIndex = 3;
            this.maximizarButton.UseVisualStyleBackColor = true;
            this.maximizarButton.Click += new System.EventHandler(this.maximizarButton_Click);
            // 
            // cerrarButton
            // 
            this.cerrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarButton.FlatAppearance.BorderSize = 0;
            this.cerrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarButton.Image = ((System.Drawing.Image)(resources.GetObject("cerrarButton.Image")));
            this.cerrarButton.Location = new System.Drawing.Point(972, 3);
            this.cerrarButton.Name = "cerrarButton";
            this.cerrarButton.Size = new System.Drawing.Size(30, 30);
            this.cerrarButton.TabIndex = 2;
            this.cerrarButton.UseVisualStyleBackColor = true;
            this.cerrarButton.Click += new System.EventHandler(this.cerrarButton_Click);
            // 
            // cerrarFormHijoButton
            // 
            this.cerrarFormHijoButton.FlatAppearance.BorderSize = 0;
            this.cerrarFormHijoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarFormHijoButton.Image = ((System.Drawing.Image)(resources.GetObject("cerrarFormHijoButton.Image")));
            this.cerrarFormHijoButton.Location = new System.Drawing.Point(37, 39);
            this.cerrarFormHijoButton.Name = "cerrarFormHijoButton";
            this.cerrarFormHijoButton.Size = new System.Drawing.Size(41, 23);
            this.cerrarFormHijoButton.TabIndex = 1;
            this.cerrarFormHijoButton.UseVisualStyleBackColor = true;
            this.cerrarFormHijoButton.Click += new System.EventHandler(this.cerrarFormHijoButton_Click);
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.White;
            this.tituloLabel.Location = new System.Drawing.Point(411, 13);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(85, 35);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "INICIO";
            // 
            // panelEscritorioPanel
            // 
            this.panelEscritorioPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEscritorioPanel.Controls.Add(this.inferiorPanel);
            this.panelEscritorioPanel.Controls.Add(this.pictureBox1);
            this.panelEscritorioPanel.Location = new System.Drawing.Point(219, 80);
            this.panelEscritorioPanel.Name = "panelEscritorioPanel";
            this.panelEscritorioPanel.Size = new System.Drawing.Size(1014, 742);
            this.panelEscritorioPanel.TabIndex = 2;
            // 
            // inferiorPanel
            // 
            this.inferiorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.inferiorPanel.Controls.Add(this.editProfileLinkLabel);
            this.inferiorPanel.Controls.Add(this.fechaLabel);
            this.inferiorPanel.Controls.Add(this.horaLabel);
            this.inferiorPanel.Controls.Add(this.emailLabel);
            this.inferiorPanel.Controls.Add(this.pocisionLabel);
            this.inferiorPanel.Controls.Add(this.nombresLabel);
            this.inferiorPanel.Controls.Add(this.imagenUserPictureBox);
            this.inferiorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inferiorPanel.Location = new System.Drawing.Point(0, 639);
            this.inferiorPanel.Name = "inferiorPanel";
            this.inferiorPanel.Size = new System.Drawing.Size(1014, 103);
            this.inferiorPanel.TabIndex = 1;
            // 
            // fechaLabel
            // 
            this.fechaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel.Location = new System.Drawing.Point(698, 70);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(266, 25);
            this.fechaLabel.TabIndex = 5;
            this.fechaLabel.Text = "Lunes, 12 de Diciembre 2020";
            // 
            // horaLabel
            // 
            this.horaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.horaLabel.AutoSize = true;
            this.horaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaLabel.Location = new System.Drawing.Point(705, 13);
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(253, 67);
            this.horaLabel.TabIndex = 4;
            this.horaLabel.Text = "21:49:45";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(130, 49);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            // 
            // pocisionLabel
            // 
            this.pocisionLabel.AutoSize = true;
            this.pocisionLabel.Location = new System.Drawing.Point(130, 13);
            this.pocisionLabel.Name = "pocisionLabel";
            this.pocisionLabel.Size = new System.Drawing.Size(46, 17);
            this.pocisionLabel.TabIndex = 2;
            this.pocisionLabel.Text = "Cargo";
            // 
            // nombresLabel
            // 
            this.nombresLabel.AutoSize = true;
            this.nombresLabel.Location = new System.Drawing.Point(130, 31);
            this.nombresLabel.Name = "nombresLabel";
            this.nombresLabel.Size = new System.Drawing.Size(65, 17);
            this.nombresLabel.TabIndex = 1;
            this.nombresLabel.Text = "Nombres";
            // 
            // imagenUserPictureBox
            // 
            this.imagenUserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagenUserPictureBox.Image")));
            this.imagenUserPictureBox.Location = new System.Drawing.Point(17, 13);
            this.imagenUserPictureBox.Name = "imagenUserPictureBox";
            this.imagenUserPictureBox.Size = new System.Drawing.Size(87, 80);
            this.imagenUserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenUserPictureBox.TabIndex = 0;
            this.imagenUserPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1014, 644);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // editProfileLinkLabel
            // 
            this.editProfileLinkLabel.AutoSize = true;
            this.editProfileLinkLabel.Location = new System.Drawing.Point(130, 70);
            this.editProfileLinkLabel.Name = "editProfileLinkLabel";
            this.editProfileLinkLabel.Size = new System.Drawing.Size(58, 17);
            this.editProfileLinkLabel.TabIndex = 6;
            this.editProfileLinkLabel.TabStop = true;
            this.editProfileLinkLabel.Text = "Mi Perfil";
            this.editProfileLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editProfileLinkLabel_LinkClicked);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 822);
            this.Controls.Add(this.panelEscritorioPanel);
            this.Controls.Add(this.tituloBarraPanel);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.tituloBarraPanel.ResumeLayout(false);
            this.tituloBarraPanel.PerformLayout();
            this.panelEscritorioPanel.ResumeLayout(false);
            this.inferiorPanel.ResumeLayout(false);
            this.inferiorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button reportesButton;
        private System.Windows.Forms.Button usuariosButton;
        private System.Windows.Forms.Button kardexButton;
        private System.Windows.Forms.Button comprasButton;
        private System.Windows.Forms.Button proveedoresButton;
        private System.Windows.Forms.Button centroSaludButton;
        private System.Windows.Forms.Button salidasButton;
        private System.Windows.Forms.Button productoButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel tituloBarraPanel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEscritorioPanel;
        private System.Windows.Forms.Button cerrarFormHijoButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button minimizarButton;
        private System.Windows.Forms.Button maximizarButton;
        private System.Windows.Forms.Button cerrarButton;
        private System.Windows.Forms.Button cerrarSesionButton;
        private System.Windows.Forms.Panel inferiorPanel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label horaLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label pocisionLabel;
        private System.Windows.Forms.Label nombresLabel;
        private System.Windows.Forms.PictureBox imagenUserPictureBox;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.LinkLabel editProfileLinkLabel;
    }
}

