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
            this.label1 = new System.Windows.Forms.Label();
            this.lneon = new System.Windows.Forms.Label();
            this.rbneon = new System.Windows.Forms.RadioButton();
            this.lnaranja = new System.Windows.Forms.Label();
            this.rbnaranja = new System.Windows.Forms.RadioButton();
            this.imagenesBicis = new System.Windows.Forms.PictureBox();
            this.rbrosa = new System.Windows.Forms.RadioButton();
            this.lrosa = new System.Windows.Forms.Label();
            this.rbrojo = new System.Windows.Forms.RadioButton();
            this.rbverde = new System.Windows.Forms.RadioButton();
            this.rbazul = new System.Windows.Forms.RadioButton();
            this.lnegro = new System.Windows.Forms.Label();
            this.lverde = new System.Windows.Forms.Label();
            this.lazul = new System.Windows.Forms.Label();
            this.lrojo = new System.Windows.Forms.Label();
            this.rbnegro = new System.Windows.Forms.RadioButton();
            this.comboCambiarImagen = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.imagenesBicis)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBicicleta
            // 
            this.cbBicicleta.DataSource = this.bicicletasBindingSource;
            this.cbBicicleta.DisplayMember = "NombreModelo";
            this.cbBicicleta.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBicicleta.FormattingEnabled = true;
            this.cbBicicleta.Location = new System.Drawing.Point(400, 89);
            this.cbBicicleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBicicleta.Name = "cbBicicleta";
            this.cbBicicleta.Size = new System.Drawing.Size(188, 30);
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
            this.cbBaterias.Location = new System.Drawing.Point(400, 126);
            this.cbBaterias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBaterias.Name = "cbBaterias";
            this.cbBaterias.Size = new System.Drawing.Size(188, 30);
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
            this.cbMotores.Location = new System.Drawing.Point(400, 161);
            this.cbMotores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMotores.Name = "cbMotores";
            this.cbMotores.Size = new System.Drawing.Size(188, 30);
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
            this.lPrecio.Location = new System.Drawing.Point(395, 215);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(55, 36);
            this.lPrecio.TabIndex = 4;
            this.lPrecio.Text = "0 €";
            this.lPrecio.Click += new System.EventHandler(this.lPrecio_Click);
            // 
            // pbBicicletas
            // 
            this.pbBicicletas.Image = global::PF_48662379Z_49970058M_49478171L.Properties.Resources.BicicletaMontaña_1;
            this.pbBicicletas.Location = new System.Drawing.Point(5, 89);
            this.pbBicicletas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBicicletas.Name = "pbBicicletas";
            this.pbBicicletas.Size = new System.Drawing.Size(359, 198);
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
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 431);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(597, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PERSONALIZACION";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_carrito
            // 
            this.btn_carrito.Location = new System.Drawing.Point(400, 342);
            this.btn_carrito.Margin = new System.Windows.Forms.Padding(1);
            this.btn_carrito.Name = "btn_carrito";
            this.btn_carrito.Size = new System.Drawing.Size(167, 41);
            this.btn_carrito.TabIndex = 5;
            this.btn_carrito.Text = "Comprar";
            this.btn_carrito.UseVisualStyleBackColor = true;
            this.btn_carrito.Click += new System.EventHandler(this.btn_carrito_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lneon);
            this.tabPage2.Controls.Add(this.rbneon);
            this.tabPage2.Controls.Add(this.lnaranja);
            this.tabPage2.Controls.Add(this.rbnaranja);
            this.tabPage2.Controls.Add(this.imagenesBicis);
            this.tabPage2.Controls.Add(this.rbrosa);
            this.tabPage2.Controls.Add(this.lrosa);
            this.tabPage2.Controls.Add(this.rbrojo);
            this.tabPage2.Controls.Add(this.rbverde);
            this.tabPage2.Controls.Add(this.rbazul);
            this.tabPage2.Controls.Add(this.lnegro);
            this.tabPage2.Controls.Add(this.lverde);
            this.tabPage2.Controls.Add(this.lazul);
            this.tabPage2.Controls.Add(this.lrojo);
            this.tabPage2.Controls.Add(this.rbnegro);
            this.tabPage2.Controls.Add(this.comboCambiarImagen);
            this.tabPage2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(597, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MODELOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "SELECCIONA 1º UN COLOR";
            // 
            // lneon
            // 
            this.lneon.AutoSize = true;
            this.lneon.BackColor = System.Drawing.Color.Aqua;
            this.lneon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lneon.Location = new System.Drawing.Point(430, 122);
            this.lneon.Name = "lneon";
            this.lneon.Size = new System.Drawing.Size(32, 28);
            this.lneon.TabIndex = 17;
            this.lneon.Text = "   ";
            // 
            // rbneon
            // 
            this.rbneon.AutoSize = true;
            this.rbneon.BackColor = System.Drawing.Color.Transparent;
            this.rbneon.Location = new System.Drawing.Point(435, 151);
            this.rbneon.Name = "rbneon";
            this.rbneon.Size = new System.Drawing.Size(17, 16);
            this.rbneon.TabIndex = 16;
            this.rbneon.TabStop = true;
            this.rbneon.UseCompatibleTextRendering = true;
            this.rbneon.UseVisualStyleBackColor = false;
            this.rbneon.CheckedChanged += new System.EventHandler(this.comboCambiarImagen_SelectedIndexChanged);
            // 
            // lnaranja
            // 
            this.lnaranja.AutoSize = true;
            this.lnaranja.BackColor = System.Drawing.Color.OrangeRed;
            this.lnaranja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnaranja.Location = new System.Drawing.Point(370, 122);
            this.lnaranja.Name = "lnaranja";
            this.lnaranja.Size = new System.Drawing.Size(32, 28);
            this.lnaranja.TabIndex = 15;
            this.lnaranja.Text = "   ";
            // 
            // rbnaranja
            // 
            this.rbnaranja.AutoSize = true;
            this.rbnaranja.BackColor = System.Drawing.Color.Transparent;
            this.rbnaranja.Location = new System.Drawing.Point(375, 151);
            this.rbnaranja.Name = "rbnaranja";
            this.rbnaranja.Size = new System.Drawing.Size(17, 16);
            this.rbnaranja.TabIndex = 14;
            this.rbnaranja.TabStop = true;
            this.rbnaranja.UseCompatibleTextRendering = true;
            this.rbnaranja.UseVisualStyleBackColor = false;
            this.rbnaranja.CheckedChanged += new System.EventHandler(this.comboCambiarImagen_SelectedIndexChanged);
            // 
            // imagenesBicis
            // 
            this.imagenesBicis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenesBicis.Location = new System.Drawing.Point(23, 25);
            this.imagenesBicis.Name = "imagenesBicis";
            this.imagenesBicis.Size = new System.Drawing.Size(288, 247);
            this.imagenesBicis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenesBicis.TabIndex = 13;
            this.imagenesBicis.TabStop = false;
            // 
            // rbrosa
            // 
            this.rbrosa.AutoSize = true;
            this.rbrosa.BackColor = System.Drawing.Color.Transparent;
            this.rbrosa.Location = new System.Drawing.Point(487, 151);
            this.rbrosa.Name = "rbrosa";
            this.rbrosa.Size = new System.Drawing.Size(17, 16);
            this.rbrosa.TabIndex = 12;
            this.rbrosa.TabStop = true;
            this.rbrosa.UseCompatibleTextRendering = true;
            this.rbrosa.UseVisualStyleBackColor = false;
            this.rbrosa.CheckedChanged += new System.EventHandler(this.comboCambiarImagen_SelectedIndexChanged);
            // 
            // lrosa
            // 
            this.lrosa.AutoSize = true;
            this.lrosa.BackColor = System.Drawing.Color.HotPink;
            this.lrosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lrosa.Location = new System.Drawing.Point(482, 122);
            this.lrosa.Name = "lrosa";
            this.lrosa.Size = new System.Drawing.Size(32, 28);
            this.lrosa.TabIndex = 11;
            this.lrosa.Text = "   ";
            // 
            // rbrojo
            // 
            this.rbrojo.AutoSize = true;
            this.rbrojo.BackColor = System.Drawing.Color.Transparent;
            this.rbrojo.Location = new System.Drawing.Point(435, 92);
            this.rbrojo.Name = "rbrojo";
            this.rbrojo.Size = new System.Drawing.Size(17, 16);
            this.rbrojo.TabIndex = 10;
            this.rbrojo.TabStop = true;
            this.rbrojo.UseCompatibleTextRendering = true;
            this.rbrojo.UseVisualStyleBackColor = false;
            this.rbrojo.CheckedChanged += new System.EventHandler(this.comboCambiarImagen_SelectedIndexChanged);
            // 
            // rbverde
            // 
            this.rbverde.AutoSize = true;
            this.rbverde.BackColor = System.Drawing.Color.Transparent;
            this.rbverde.Location = new System.Drawing.Point(487, 92);
            this.rbverde.Name = "rbverde";
            this.rbverde.Size = new System.Drawing.Size(17, 16);
            this.rbverde.TabIndex = 9;
            this.rbverde.TabStop = true;
            this.rbverde.UseCompatibleTextRendering = true;
            this.rbverde.UseVisualStyleBackColor = false;
            this.rbverde.CheckedChanged += new System.EventHandler(this.comboCambiarImagen_SelectedIndexChanged);
            // 
            // rbazul
            // 
            this.rbazul.AutoSize = true;
            this.rbazul.BackColor = System.Drawing.Color.Transparent;
            this.rbazul.Location = new System.Drawing.Point(546, 92);
            this.rbazul.Name = "rbazul";
            this.rbazul.Size = new System.Drawing.Size(17, 16);
            this.rbazul.TabIndex = 8;
            this.rbazul.TabStop = true;
            this.rbazul.UseCompatibleTextRendering = true;
            this.rbazul.UseVisualStyleBackColor = false;
            this.rbazul.CheckedChanged += new System.EventHandler(this.comboCambiarImagen_SelectedIndexChanged);
            // 
            // lnegro
            // 
            this.lnegro.AutoSize = true;
            this.lnegro.BackColor = System.Drawing.Color.Black;
            this.lnegro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnegro.Location = new System.Drawing.Point(370, 63);
            this.lnegro.Name = "lnegro";
            this.lnegro.Size = new System.Drawing.Size(32, 28);
            this.lnegro.TabIndex = 7;
            this.lnegro.Text = "   ";
            // 
            // lverde
            // 
            this.lverde.AutoSize = true;
            this.lverde.BackColor = System.Drawing.Color.Lime;
            this.lverde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lverde.Location = new System.Drawing.Point(482, 63);
            this.lverde.Name = "lverde";
            this.lverde.Size = new System.Drawing.Size(32, 28);
            this.lverde.TabIndex = 6;
            this.lverde.Text = "   ";
            // 
            // lazul
            // 
            this.lazul.AutoSize = true;
            this.lazul.BackColor = System.Drawing.Color.DodgerBlue;
            this.lazul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lazul.Location = new System.Drawing.Point(541, 63);
            this.lazul.Name = "lazul";
            this.lazul.Size = new System.Drawing.Size(32, 28);
            this.lazul.TabIndex = 5;
            this.lazul.Text = "   ";
            // 
            // lrojo
            // 
            this.lrojo.AutoSize = true;
            this.lrojo.BackColor = System.Drawing.Color.Red;
            this.lrojo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lrojo.Location = new System.Drawing.Point(430, 63);
            this.lrojo.Name = "lrojo";
            this.lrojo.Size = new System.Drawing.Size(32, 28);
            this.lrojo.TabIndex = 3;
            this.lrojo.Text = "   ";
            // 
            // rbnegro
            // 
            this.rbnegro.AutoSize = true;
            this.rbnegro.BackColor = System.Drawing.Color.Transparent;
            this.rbnegro.Location = new System.Drawing.Point(375, 92);
            this.rbnegro.Name = "rbnegro";
            this.rbnegro.Size = new System.Drawing.Size(17, 16);
            this.rbnegro.TabIndex = 1;
            this.rbnegro.TabStop = true;
            this.rbnegro.UseCompatibleTextRendering = true;
            this.rbnegro.UseVisualStyleBackColor = false;
            this.rbnegro.CheckedChanged += new System.EventHandler(this.comboCambiarImagen_SelectedIndexChanged);
            // 
            // comboCambiarImagen
            // 
            this.comboCambiarImagen.FormattingEnabled = true;
            this.comboCambiarImagen.Items.AddRange(new object[] {
            "Carretera",
            "Paseo",
            "Montaña"});
            this.comboCambiarImagen.Location = new System.Drawing.Point(409, 203);
            this.comboCambiarImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCambiarImagen.Name = "comboCambiarImagen";
            this.comboCambiarImagen.Size = new System.Drawing.Size(121, 34);
            this.comboCambiarImagen.TabIndex = 0;
            this.comboCambiarImagen.SelectedIndexChanged += new System.EventHandler(this.comboCambiarImagen_SelectedIndexChanged);
            // 
            // MenuCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 474);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenesBicis)).EndInit();
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
        private System.Windows.Forms.ComboBox comboCambiarImagen;
        private System.Windows.Forms.Button btn_carrito;
        private System.Windows.Forms.Label lrojo;
        private System.Windows.Forms.RadioButton rbnegro;
        private System.Windows.Forms.RadioButton rbrosa;
        private System.Windows.Forms.Label lrosa;
        private System.Windows.Forms.RadioButton rbrojo;
        private System.Windows.Forms.RadioButton rbverde;
        private System.Windows.Forms.RadioButton rbazul;
        private System.Windows.Forms.Label lnegro;
        private System.Windows.Forms.Label lverde;
        private System.Windows.Forms.Label lazul;
        private System.Windows.Forms.PictureBox imagenesBicis;
        private System.Windows.Forms.Label lneon;
        private System.Windows.Forms.RadioButton rbneon;
        private System.Windows.Forms.Label lnaranja;
        private System.Windows.Forms.RadioButton rbnaranja;
        private System.Windows.Forms.Label label1;
    }
}