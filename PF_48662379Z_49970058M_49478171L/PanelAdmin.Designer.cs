namespace PF_48662379Z_49970058M_49478171L
{
    partial class PanelAdmin
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
            this.listViewusuarios = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_contraseña = new System.Windows.Forms.TextBox();
            this.colum_nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colum_contra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewusuarios
            // 
            this.listViewusuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colum_nombre,
            this.colum_contra});
            this.listViewusuarios.HideSelection = false;
            this.listViewusuarios.Location = new System.Drawing.Point(25, 40);
            this.listViewusuarios.Name = "listViewusuarios";
            this.listViewusuarios.Size = new System.Drawing.Size(789, 590);
            this.listViewusuarios.TabIndex = 0;
            this.listViewusuarios.UseCompatibleStateImageBehavior = false;
            this.listViewusuarios.View = System.Windows.Forms.View.Details;
            this.listViewusuarios.SelectedIndexChanged += new System.EventHandler(this.listViewusuarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(888, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(893, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 717);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 3;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(659, 717);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(244, 88);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 746);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(618, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleccione uno y pulse el boton para eliminar un usuario";
            // 
            // btn_añadir
            // 
            this.btn_añadir.Location = new System.Drawing.Point(893, 365);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(261, 88);
            this.btn_añadir.TabIndex = 6;
            this.btn_añadir.Text = "Añadir";
            this.btn_añadir.UseVisualStyleBackColor = true;
            this.btn_añadir.Click += new System.EventHandler(this.btn_añadir_Click);
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(893, 129);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(261, 35);
            this.txb_usuario.TabIndex = 7;
            // 
            // txb_contraseña
            // 
            this.txb_contraseña.Location = new System.Drawing.Point(893, 278);
            this.txb_contraseña.Name = "txb_contraseña";
            this.txb_contraseña.Size = new System.Drawing.Size(261, 35);
            this.txb_contraseña.TabIndex = 8;
            // 
            // colum_nombre
            // 
            this.colum_nombre.Text = "Usuario";
            // 
            // colum_contra
            // 
            this.colum_contra.Text = "Contraseña";
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 921);
            this.Controls.Add(this.txb_contraseña);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.btn_añadir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewusuarios);
            this.Name = "PanelAdmin";
            this.Text = "PanelAdmin";
            this.Load += new System.EventHandler(this.PanelAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewusuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_añadir;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_contraseña;
        private System.Windows.Forms.ColumnHeader colum_nombre;
        private System.Windows.Forms.ColumnHeader colum_contra;
    }
}