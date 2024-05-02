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
            this.components = new System.ComponentModel.Container();
            this.cbBicicleta = new System.Windows.Forms.ComboBox();
            this.cbBaterias = new System.Windows.Forms.ComboBox();
            this.cbMotores = new System.Windows.Forms.ComboBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.pbBicicletas = new System.Windows.Forms.PictureBox();
            this.masterDataSet = new PF_48662379Z_49970058M_49478171L.masterDataSet();
            this.bicicletasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bicicletasTableAdapter = new PF_48662379Z_49970058M_49478171L.masterDataSetTableAdapters.BicicletasTableAdapter();
            this.masterDataSet2 = new PF_48662379Z_49970058M_49478171L.masterDataSet2();
            this.bateriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bateriasTableAdapter = new PF_48662379Z_49970058M_49478171L.masterDataSet2TableAdapters.BateriasTableAdapter();
            this.masterDataSet3 = new PF_48662379Z_49970058M_49478171L.masterDataSet3();
            this.motoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoresTableAdapter = new PF_48662379Z_49970058M_49478171L.masterDataSet3TableAdapters.MotoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbBicicletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicletasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bateriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBicicleta
            // 
            this.cbBicicleta.DataSource = this.bicicletasBindingSource;
            this.cbBicicleta.DisplayMember = "NombreModelo";
            this.cbBicicleta.FormattingEnabled = true;
            this.cbBicicleta.Location = new System.Drawing.Point(394, 89);
            this.cbBicicleta.Name = "cbBicicleta";
            this.cbBicicleta.Size = new System.Drawing.Size(134, 24);
            this.cbBicicleta.TabIndex = 1;
            this.cbBicicleta.ValueMember = "ID";
            this.cbBicicleta.SelectedIndexChanged += new System.EventHandler(this.cbModelos_SelectedIndexChanged);
            // 
            // cbBaterias
            // 
            this.cbBaterias.DataSource = this.bateriasBindingSource;
            this.cbBaterias.DisplayMember = "Nombre";
            this.cbBaterias.FormattingEnabled = true;
            this.cbBaterias.Location = new System.Drawing.Point(394, 119);
            this.cbBaterias.Name = "cbBaterias";
            this.cbBaterias.Size = new System.Drawing.Size(134, 24);
            this.cbBaterias.TabIndex = 2;
            this.cbBaterias.ValueMember = "ID";
            // 
            // cbMotores
            // 
            this.cbMotores.DataSource = this.motoresBindingSource;
            this.cbMotores.DisplayMember = "Nombre";
            this.cbMotores.FormattingEnabled = true;
            this.cbMotores.Location = new System.Drawing.Point(394, 149);
            this.cbMotores.Name = "cbMotores";
            this.cbMotores.Size = new System.Drawing.Size(134, 24);
            this.cbMotores.TabIndex = 3;
            this.cbMotores.ValueMember = "ID";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(432, 193);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(55, 36);
            this.lPrecio.TabIndex = 4;
            this.lPrecio.Text = "0 €";
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
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bicicletasBindingSource
            // 
            this.bicicletasBindingSource.DataMember = "Bicicletas";
            this.bicicletasBindingSource.DataSource = this.masterDataSet;
            // 
            // bicicletasTableAdapter
            // 
            this.bicicletasTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSet2
            // 
            this.masterDataSet2.DataSetName = "masterDataSet2";
            this.masterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bateriasBindingSource
            // 
            this.bateriasBindingSource.DataMember = "Baterias";
            this.bateriasBindingSource.DataSource = this.masterDataSet2;
            // 
            // bateriasTableAdapter
            // 
            this.bateriasTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSet3
            // 
            this.masterDataSet3.DataSetName = "masterDataSet3";
            this.masterDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motoresBindingSource
            // 
            this.motoresBindingSource.DataMember = "Motores";
            this.motoresBindingSource.DataSource = this.masterDataSet3;
            // 
            // motoresTableAdapter
            // 
            this.motoresTableAdapter.ClearBeforeFill = true;
            // 
            // MenuCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 576);
            this.Controls.Add(this.pbBicicletas);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.cbMotores);
            this.Controls.Add(this.cbBaterias);
            this.Controls.Add(this.cbBicicleta);
            this.Name = "MenuCompra";
            this.Text = "MURCIA E-BIKES";
            this.Load += new System.EventHandler(this.MenuCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBicicletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicletasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bateriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBicicleta;
        private System.Windows.Forms.PictureBox pbBicicletas;
        private System.Windows.Forms.ComboBox cbBaterias;
        private System.Windows.Forms.ComboBox cbMotores;
        private System.Windows.Forms.Label lPrecio;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource bicicletasBindingSource;
        private masterDataSetTableAdapters.BicicletasTableAdapter bicicletasTableAdapter;
        private masterDataSet2 masterDataSet2;
        private System.Windows.Forms.BindingSource bateriasBindingSource;
        private masterDataSet2TableAdapters.BateriasTableAdapter bateriasTableAdapter;
        private masterDataSet3 masterDataSet3;
        private System.Windows.Forms.BindingSource motoresBindingSource;
        private masterDataSet3TableAdapters.MotoresTableAdapter motoresTableAdapter;
    }
}