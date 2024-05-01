namespace PF_48662379Z_49970058M_49478171L
{
    partial class MenuCompra
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
            this.cbModelos = new System.Windows.Forms.ComboBox();
            this.cbBaterias = new System.Windows.Forms.ComboBox();
            this.cbMotores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBicicletas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBicicletas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbModelos
            // 
            this.cbModelos.FormattingEnabled = true;
            this.cbModelos.Location = new System.Drawing.Point(394, 89);
            this.cbModelos.Name = "cbModelos";
            this.cbModelos.Size = new System.Drawing.Size(134, 24);
            this.cbModelos.TabIndex = 0;
            // 
            // cbBaterias
            // 
            this.cbBaterias.FormattingEnabled = true;
            this.cbBaterias.Location = new System.Drawing.Point(394, 119);
            this.cbBaterias.Name = "cbBaterias";
            this.cbBaterias.Size = new System.Drawing.Size(134, 24);
            this.cbBaterias.TabIndex = 2;
            // 
            // cbMotores
            // 
            this.cbMotores.FormattingEnabled = true;
            this.cbMotores.Location = new System.Drawing.Point(394, 149);
            this.cbMotores.Name = "cbMotores";
            this.cbMotores.Size = new System.Drawing.Size(134, 24);
            this.cbMotores.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "0 €";
            // 
            // pbBicicletas
            // 
            this.pbBicicletas.Image = global::PF_48662379Z_49970058M_49478171L.Properties.Resources.BicicletaMontaña_1;
            this.pbBicicletas.Location = new System.Drawing.Point(12, 89);
            this.pbBicicletas.Name = "pbBicicletas";
            this.pbBicicletas.Size = new System.Drawing.Size(359, 198);
            this.pbBicicletas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBicicletas.TabIndex = 1;
            this.pbBicicletas.TabStop = false;
            // 
            // MenuCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 576);
            this.Controls.Add(this.pbBicicletas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMotores);
            this.Controls.Add(this.cbBaterias);
            this.Controls.Add(this.cbModelos);
            this.Name = "MenuCompra";
            this.Text = "MURCIA E-BIKES";
            ((System.ComponentModel.ISupportInitialize)(this.pbBicicletas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbModelos;
        private System.Windows.Forms.PictureBox pbBicicletas;
        private System.Windows.Forms.ComboBox cbBaterias;
        private System.Windows.Forms.ComboBox cbMotores;
        private System.Windows.Forms.Label label1;
    }
}