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
            this.bicicletasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new PF_48662379Z_49970058M_49478171L.masterDataSet();
            this.cbBaterias = new System.Windows.Forms.ComboBox();
            this.bateriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet2 = new PF_48662379Z_49970058M_49478171L.masterDataSet2();
            this.cbMotores = new System.Windows.Forms.ComboBox();
            this.motoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet3 = new PF_48662379Z_49970058M_49478171L.masterDataSet3();
            this.lPrecio = new System.Windows.Forms.Label();
            this.pbBicicletas = new System.Windows.Forms.PictureBox();
            this.bicicletasTableAdapter = new PF_48662379Z_49970058M_49478171L.masterDataSetTableAdapters.BicicletasTableAdapter();
            this.bateriasTableAdapter = new PF_48662379Z_49970058M_49478171L.masterDataSet2TableAdapters.BateriasTableAdapter();
            this.motoresTableAdapter = new PF_48662379Z_49970058M_49478171L.masterDataSet3TableAdapters.MotoresTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_carrito = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bicicletasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bateriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBicicletas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBicicleta
            // 
            this.cbBicicleta.DataSource = this.bicicletasBindingSource;
            this.cbBicicleta.DisplayMember = "NombreModelo";
            this.cbBicicleta.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBicicleta.FormattingEnabled = true;
            this.cbBicicleta.Location = new System.Drawing.Point(300, 72);
            this.cbBicicleta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBicicleta.Name = "cbBicicleta";
            this.cbBicicleta.Size = new System.Drawing.Size(142, 26);
            this.cbBicicleta.TabIndex = 1;
            this.cbBicicleta.ValueMember = "ID";
            this.cbBicicleta.SelectedIndexChanged += new System.EventHandler(this.cbModelos_SelectedIndexChanged);
            // 
            // bicicletasBindingSource
            // 
            this.bicicletasBindingSource.DataMember = "Bicicletas";
            this.bicicletasBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbBaterias
            // 
            this.cbBaterias.DataSource = this.bateriasBindingSource;
            this.cbBaterias.DisplayMember = "Nombre";
            this.cbBaterias.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaterias.FormattingEnabled = true;
            this.cbBaterias.Location = new System.Drawing.Point(300, 102);
            this.cbBaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBaterias.Name = "cbBaterias";
            this.cbBaterias.Size = new System.Drawing.Size(142, 26);
            this.cbBaterias.TabIndex = 2;
            this.cbBaterias.ValueMember = "ID";
            // 
            // bateriasBindingSource
            // 
            this.bateriasBindingSource.DataMember = "Baterias";
            this.bateriasBindingSource.DataSource = this.masterDataSet2;
            // 
            // masterDataSet2
            // 
            this.masterDataSet2.DataSetName = "masterDataSet2";
            this.masterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbMotores
            // 
            this.cbMotores.DataSource = this.motoresBindingSource;
            this.cbMotores.DisplayMember = "Nombre";
            this.cbMotores.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotores.FormattingEnabled = true;
            this.cbMotores.Location = new System.Drawing.Point(300, 131);
            this.cbMotores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMotores.Name = "cbMotores";
            this.cbMotores.Size = new System.Drawing.Size(142, 26);
            this.cbMotores.TabIndex = 3;
            this.cbMotores.ValueMember = "ID";
            // 
            // motoresBindingSource
            // 
            this.motoresBindingSource.DataMember = "Motores";
            this.motoresBindingSource.DataSource = this.masterDataSet3;
            // 
            // masterDataSet3
            // 
            this.masterDataSet3.DataSetName = "masterDataSet3";
            this.masterDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(296, 175);
            this.lPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(44, 29);
            this.lPrecio.TabIndex = 4;
            this.lPrecio.Text = "0 €";
            this.lPrecio.Click += new System.EventHandler(this.lPrecio_Click);
            // 
            // pbBicicletas
            // 
            this.pbBicicletas.Image = global::PF_48662379Z_49970058M_49478171L.Properties.Resources.BicicletaMontaña_1;
            this.pbBicicletas.Location = new System.Drawing.Point(4, 72);
            this.pbBicicletas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBicicletas.Name = "pbBicicletas";
            this.pbBicicletas.Size = new System.Drawing.Size(269, 161);
            this.pbBicicletas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBicicletas.TabIndex = 1;
            this.pbBicicletas.TabStop = false;
            // 
            // bicicletasTableAdapter
            // 
            this.bicicletasTableAdapter.ClearBeforeFill = true;
            // 
            // bateriasTableAdapter
            // 
            this.bateriasTableAdapter.ClearBeforeFill = true;
            // 
            // motoresTableAdapter
            // 
            this.motoresTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 350);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_carrito);
            this.tabPage1.Controls.Add(this.pbBicicletas);
            this.tabPage1.Controls.Add(this.lPrecio);
            this.tabPage1.Controls.Add(this.cbBaterias);
            this.tabPage1.Controls.Add(this.cbMotores);
            this.tabPage1.Controls.Add(this.cbBicicleta);
            this.tabPage1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(446, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PERSONALIZACION";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_carrito
            // 
            this.btn_carrito.Location = new System.Drawing.Point(300, 278);
            this.btn_carrito.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_carrito.Name = "btn_carrito";
            this.btn_carrito.Size = new System.Drawing.Size(125, 33);
            this.btn_carrito.TabIndex = 5;
            this.btn_carrito.Text = "Comprar";
            this.btn_carrito.UseVisualStyleBackColor = true;
            this.btn_carrito.Click += new System.EventHandler(this.btn_carrito_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(446, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MODELOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 69);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 29);
            this.comboBox1.TabIndex = 0;
            // 
            // MenuCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 385);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuCompra";
            this.Text = "MURCIA E-BIKES";
            this.Load += new System.EventHandler(this.MenuCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bicicletasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bateriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBicicletas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_carrito;
    }
}