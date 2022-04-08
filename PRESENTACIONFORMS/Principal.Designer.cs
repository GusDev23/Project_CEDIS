namespace PRESENTACIONFORMS
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbCompras = new System.Windows.Forms.PictureBox();
            this.ptbProductos = new System.Windows.Forms.PictureBox();
            this.ptbProveedores = new System.Windows.Forms.PictureBox();
            this.ptbClientes = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 495);
            this.panel1.TabIndex = 0;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHora.Location = new System.Drawing.Point(252, 251);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(204, 73);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label7";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(249, 66);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(290, 123);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ptbCompras);
            this.panel2.Controls.Add(this.ptbProductos);
            this.panel2.Controls.Add(this.ptbProveedores);
            this.panel2.Controls.Add(this.ptbClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 495);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Compras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Proveedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Productos";
            // 
            // ptbCompras
            // 
            this.ptbCompras.Image = ((System.Drawing.Image)(resources.GetObject("ptbCompras.Image")));
            this.ptbCompras.Location = new System.Drawing.Point(33, 378);
            this.ptbCompras.Name = "ptbCompras";
            this.ptbCompras.Size = new System.Drawing.Size(112, 59);
            this.ptbCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCompras.TabIndex = 3;
            this.ptbCompras.TabStop = false;
            this.ptbCompras.Click += new System.EventHandler(this.ptbCompras_Click);
            // 
            // ptbProductos
            // 
            this.ptbProductos.Image = ((System.Drawing.Image)(resources.GetObject("ptbProductos.Image")));
            this.ptbProductos.Location = new System.Drawing.Point(33, 266);
            this.ptbProductos.Name = "ptbProductos";
            this.ptbProductos.Size = new System.Drawing.Size(112, 61);
            this.ptbProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProductos.TabIndex = 2;
            this.ptbProductos.TabStop = false;
            this.ptbProductos.Click += new System.EventHandler(this.ptbProductos_Click);
            // 
            // ptbProveedores
            // 
            this.ptbProveedores.Image = ((System.Drawing.Image)(resources.GetObject("ptbProveedores.Image")));
            this.ptbProveedores.Location = new System.Drawing.Point(33, 152);
            this.ptbProveedores.Name = "ptbProveedores";
            this.ptbProveedores.Size = new System.Drawing.Size(112, 58);
            this.ptbProveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProveedores.TabIndex = 1;
            this.ptbProveedores.TabStop = false;
            this.ptbProveedores.Click += new System.EventHandler(this.ptbProveedores_Click);
            // 
            // ptbClientes
            // 
            this.ptbClientes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ptbClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbClientes.Image = ((System.Drawing.Image)(resources.GetObject("ptbClientes.Image")));
            this.ptbClientes.Location = new System.Drawing.Point(33, 29);
            this.ptbClientes.Name = "ptbClientes";
            this.ptbClientes.Size = new System.Drawing.Size(112, 62);
            this.ptbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClientes.TabIndex = 0;
            this.ptbClientes.TabStop = false;
            this.ptbClientes.Click += new System.EventHandler(this.ptbClientes_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 495);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptbCompras;
        private System.Windows.Forms.PictureBox ptbProductos;
        private System.Windows.Forms.PictureBox ptbProveedores;
        private System.Windows.Forms.PictureBox ptbClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
    }
}