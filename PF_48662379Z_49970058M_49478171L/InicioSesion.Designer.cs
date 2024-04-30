namespace PF_48662379Z_49970058M_49478171L
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar_inicio_sesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_app = new System.Windows.Forms.Label();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lbl_app);
            this.panel1.Controls.Add(this.btn_cerrar_inicio_sesion);
            this.panel1.Location = new System.Drawing.Point(-18, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 99);
            this.panel1.TabIndex = 0;
            // 
            // btn_cerrar_inicio_sesion
            // 
            this.btn_cerrar_inicio_sesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_inicio_sesion.Location = new System.Drawing.Point(961, 3);
            this.btn_cerrar_inicio_sesion.Name = "btn_cerrar_inicio_sesion";
            this.btn_cerrar_inicio_sesion.Size = new System.Drawing.Size(120, 93);
            this.btn_cerrar_inicio_sesion.TabIndex = 0;
            this.btn_cerrar_inicio_sesion.Text = "Cerrar";
            this.btn_cerrar_inicio_sesion.UseVisualStyleBackColor = false;
            this.btn_cerrar_inicio_sesion.Click += new System.EventHandler(this.btn_cerrar_inicio_sesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_app
            // 
            this.lbl_app.AutoSize = true;
            this.lbl_app.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_app.Location = new System.Drawing.Point(29, 20);
            this.lbl_app.Name = "lbl_app";
            this.lbl_app.Size = new System.Drawing.Size(421, 62);
            this.lbl_app.TabIndex = 1;
            this.lbl_app.Text = "MURCIA E-BIKES";
            this.lbl_app.Click += new System.EventHandler(this.label1_Click);
            // 
            // txb_usuario
            // 
            this.txb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_usuario.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_usuario.Location = new System.Drawing.Point(262, 584);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(551, 49);
            this.txb_usuario.TabIndex = 2;
            this.txb_usuario.Text = "Ingrese su usuario";
            this.txb_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "____________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 919);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "____________________________________________";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(262, 823);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(551, 49);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Ingrese su contraseña";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1068, 1404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "InicioSesion";
            this.Text = "MURCIA E-BIKES";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cerrar_inicio_sesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_app;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

