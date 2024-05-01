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
            this.lbl_app = new System.Windows.Forms.Label();
            this.btn_cerrar_inicio_sesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_contraseña = new System.Windows.Forms.TextBox();
            this.checkBox_mostrar_contraseña = new System.Windows.Forms.CheckBox();
            this.btn_entrar_inicio_sesion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_registrarse_inicio_sesion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbx_roles_inicio_sesion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lbl_app);
            this.panel1.Controls.Add(this.btn_cerrar_inicio_sesion);
            this.panel1.Location = new System.Drawing.Point(-11, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 54);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_app
            // 
            this.lbl_app.AutoSize = true;
            this.lbl_app.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_app.Location = new System.Drawing.Point(16, 11);
            this.lbl_app.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_app.Name = "lbl_app";
            this.lbl_app.Size = new System.Drawing.Size(238, 35);
            this.lbl_app.TabIndex = 1;
            this.lbl_app.Text = "MURCIA E-BIKES";
            this.lbl_app.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_cerrar_inicio_sesion
            // 
            this.btn_cerrar_inicio_sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cerrar_inicio_sesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cerrar_inicio_sesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_inicio_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_inicio_sesion.Location = new System.Drawing.Point(532, -2);
            this.btn_cerrar_inicio_sesion.Margin = new System.Windows.Forms.Padding(1);
            this.btn_cerrar_inicio_sesion.Name = "btn_cerrar_inicio_sesion";
            this.btn_cerrar_inicio_sesion.Size = new System.Drawing.Size(95, 58);
            this.btn_cerrar_inicio_sesion.TabIndex = 0;
            this.btn_cerrar_inicio_sesion.Text = "Cerrar";
            this.btn_cerrar_inicio_sesion.UseVisualStyleBackColor = false;
            this.btn_cerrar_inicio_sesion.Click += new System.EventHandler(this.btn_cerrar_inicio_sesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txb_usuario
            // 
            this.txb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_usuario.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_usuario.Location = new System.Drawing.Point(149, 309);
            this.txb_usuario.Margin = new System.Windows.Forms.Padding(1);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(315, 27);
            this.txb_usuario.TabIndex = 2;
            this.txb_usuario.Text = "Ingrese su usuario";
            this.txb_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_usuario.Enter += new System.EventHandler(this.txb_usuario_Enter);
            this.txb_usuario.Leave += new System.EventHandler(this.txb_usuario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "____________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "____________________________________________";
            // 
            // txb_contraseña
            // 
            this.txb_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_contraseña.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_contraseña.Location = new System.Drawing.Point(149, 432);
            this.txb_contraseña.Margin = new System.Windows.Forms.Padding(1);
            this.txb_contraseña.Name = "txb_contraseña";
            this.txb_contraseña.Size = new System.Drawing.Size(315, 27);
            this.txb_contraseña.TabIndex = 5;
            this.txb_contraseña.Text = "Ingrese su contraseña";
            this.txb_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_contraseña.Enter += new System.EventHandler(this.txb_contraseña_Enter);
            this.txb_contraseña.Leave += new System.EventHandler(this.txb_contraseña_Leave);
            // 
            // checkBox_mostrar_contraseña
            // 
            this.checkBox_mostrar_contraseña.AutoSize = true;
            this.checkBox_mostrar_contraseña.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_mostrar_contraseña.Location = new System.Drawing.Point(308, 501);
            this.checkBox_mostrar_contraseña.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox_mostrar_contraseña.Name = "checkBox_mostrar_contraseña";
            this.checkBox_mostrar_contraseña.Size = new System.Drawing.Size(164, 24);
            this.checkBox_mostrar_contraseña.TabIndex = 7;
            this.checkBox_mostrar_contraseña.Text = "Mostrar contraseña";
            this.checkBox_mostrar_contraseña.UseVisualStyleBackColor = true;
            this.checkBox_mostrar_contraseña.CheckedChanged += new System.EventHandler(this.checkBox_mostrar_contraseña_CheckedChanged);
            // 
            // btn_entrar_inicio_sesion
            // 
            this.btn_entrar_inicio_sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_entrar_inicio_sesion.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar_inicio_sesion.Location = new System.Drawing.Point(211, 571);
            this.btn_entrar_inicio_sesion.Margin = new System.Windows.Forms.Padding(1);
            this.btn_entrar_inicio_sesion.Name = "btn_entrar_inicio_sesion";
            this.btn_entrar_inicio_sesion.Size = new System.Drawing.Size(192, 64);
            this.btn_entrar_inicio_sesion.TabIndex = 9;
            this.btn_entrar_inicio_sesion.Text = "Entrar";
            this.btn_entrar_inicio_sesion.UseVisualStyleBackColor = false;
            this.btn_entrar_inicio_sesion.Click += new System.EventHandler(this.btn_entrar_inicio_sesion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 656);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "¿No estas registrado?";
            // 
            // btn_registrarse_inicio_sesion
            // 
            this.btn_registrarse_inicio_sesion.BackColor = System.Drawing.Color.White;
            this.btn_registrarse_inicio_sesion.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarse_inicio_sesion.ForeColor = System.Drawing.Color.Blue;
            this.btn_registrarse_inicio_sesion.Location = new System.Drawing.Point(211, 710);
            this.btn_registrarse_inicio_sesion.Margin = new System.Windows.Forms.Padding(1);
            this.btn_registrarse_inicio_sesion.Name = "btn_registrarse_inicio_sesion";
            this.btn_registrarse_inicio_sesion.Size = new System.Drawing.Size(192, 33);
            this.btn_registrarse_inicio_sesion.TabIndex = 11;
            this.btn_registrarse_inicio_sesion.Text = "Registrarme";
            this.btn_registrarse_inicio_sesion.UseVisualStyleBackColor = false;
            this.btn_registrarse_inicio_sesion.Click += new System.EventHandler(this.btn_registrarse_inicio_sesion_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(267, 773);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 55);
            this.panel2.TabIndex = 13;
            // 
            // cbx_roles_inicio_sesion
            // 
            this.cbx_roles_inicio_sesion.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_roles_inicio_sesion.FormattingEnabled = true;
            this.cbx_roles_inicio_sesion.Items.AddRange(new object[] {
            "Administrador",
            "Cliente"});
            this.cbx_roles_inicio_sesion.Location = new System.Drawing.Point(12, 127);
            this.cbx_roles_inicio_sesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_roles_inicio_sesion.Name = "cbx_roles_inicio_sesion";
            this.cbx_roles_inicio_sesion.Size = new System.Drawing.Size(187, 34);
            this.cbx_roles_inicio_sesion.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rol";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(611, 806);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_roles_inicio_sesion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_registrarse_inicio_sesion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_entrar_inicio_sesion);
            this.Controls.Add(this.checkBox_mostrar_contraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_contraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txb_contraseña;
        private System.Windows.Forms.CheckBox checkBox_mostrar_contraseña;
        private System.Windows.Forms.Button btn_entrar_inicio_sesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_registrarse_inicio_sesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbx_roles_inicio_sesion;
        private System.Windows.Forms.Label label4;
    }
}

