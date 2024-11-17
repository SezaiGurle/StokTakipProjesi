namespace StokTakip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            dbUrunlerBindingSource = new BindingSource(components);
            dbBirimlerBindingSource = new BindingSource(components);
            dbKategorilerBindingSource = new BindingSource(components);
            btnKaydet = new Button();
            btnCikis = new Button();
            urunKoduDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            urunAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            urunAciklamaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minStokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maksStokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            birimDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            stokGirislerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stokCikislarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ColSil = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbUrunlerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbBirimlerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbKategorilerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { urunKoduDataGridViewTextBoxColumn, urunAdDataGridViewTextBoxColumn, urunAciklamaDataGridViewTextBoxColumn, minStokDataGridViewTextBoxColumn, maksStokDataGridViewTextBoxColumn, kategoriDataGridViewComboBoxColumn, birimDataGridViewTextBoxColumn, stokGirislerDataGridViewTextBoxColumn, stokCikislarDataGridViewTextBoxColumn, ColSil });
            dataGridView1.DataSource = dbUrunlerBindingSource;
            dataGridView1.Location = new Point(12, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(979, 364);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // dbUrunlerBindingSource
            // 
            dbUrunlerBindingSource.DataSource = typeof(Modeller.DbUrunler);
            // 
            // dbBirimlerBindingSource
            // 
            dbBirimlerBindingSource.DataSource = typeof(Modeller.DbBirimler);
            // 
            // dbKategorilerBindingSource
            // 
            dbKategorilerBindingSource.DataSource = typeof(Modeller.DbKategoriler);
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(852, 418);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(139, 36);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(897, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 29);
            btnCikis.TabIndex = 2;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // urunKoduDataGridViewTextBoxColumn
            // 
            urunKoduDataGridViewTextBoxColumn.DataPropertyName = "UrunKodu";
            urunKoduDataGridViewTextBoxColumn.HeaderText = "UrunKodu";
            urunKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            urunKoduDataGridViewTextBoxColumn.Name = "urunKoduDataGridViewTextBoxColumn";
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            urunAdDataGridViewTextBoxColumn.DataPropertyName = "UrunAd";
            urunAdDataGridViewTextBoxColumn.HeaderText = "UrunAd";
            urunAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            // 
            // urunAciklamaDataGridViewTextBoxColumn
            // 
            urunAciklamaDataGridViewTextBoxColumn.DataPropertyName = "UrunAciklama";
            urunAciklamaDataGridViewTextBoxColumn.HeaderText = "UrunAciklama";
            urunAciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            urunAciklamaDataGridViewTextBoxColumn.Name = "urunAciklamaDataGridViewTextBoxColumn";
            // 
            // minStokDataGridViewTextBoxColumn
            // 
            minStokDataGridViewTextBoxColumn.DataPropertyName = "MinStok";
            minStokDataGridViewTextBoxColumn.HeaderText = "MinStok";
            minStokDataGridViewTextBoxColumn.MinimumWidth = 6;
            minStokDataGridViewTextBoxColumn.Name = "minStokDataGridViewTextBoxColumn";
            // 
            // maksStokDataGridViewTextBoxColumn
            // 
            maksStokDataGridViewTextBoxColumn.DataPropertyName = "MaksStok";
            maksStokDataGridViewTextBoxColumn.HeaderText = "MaksStok";
            maksStokDataGridViewTextBoxColumn.MinimumWidth = 6;
            maksStokDataGridViewTextBoxColumn.Name = "maksStokDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewComboBoxColumn
            // 
            kategoriDataGridViewComboBoxColumn.DataPropertyName = "KategoriId";
            kategoriDataGridViewComboBoxColumn.HeaderText = "Kategori";
            kategoriDataGridViewComboBoxColumn.MinimumWidth = 6;
            kategoriDataGridViewComboBoxColumn.Name = "kategoriDataGridViewComboBoxColumn";
            kategoriDataGridViewComboBoxColumn.Resizable = DataGridViewTriState.True;
            kategoriDataGridViewComboBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // birimDataGridViewTextBoxColumn
            // 
            birimDataGridViewTextBoxColumn.DataPropertyName = "BirimId";
            birimDataGridViewTextBoxColumn.HeaderText = "Birim";
            birimDataGridViewTextBoxColumn.MinimumWidth = 6;
            birimDataGridViewTextBoxColumn.Name = "birimDataGridViewTextBoxColumn";
            birimDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            birimDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // stokGirislerDataGridViewTextBoxColumn
            // 
            stokGirislerDataGridViewTextBoxColumn.DataPropertyName = "StokGirisler";
            stokGirislerDataGridViewTextBoxColumn.HeaderText = "StokGirisler";
            stokGirislerDataGridViewTextBoxColumn.MinimumWidth = 6;
            stokGirislerDataGridViewTextBoxColumn.Name = "stokGirislerDataGridViewTextBoxColumn";
            // 
            // stokCikislarDataGridViewTextBoxColumn
            // 
            stokCikislarDataGridViewTextBoxColumn.DataPropertyName = "StokCikislar";
            stokCikislarDataGridViewTextBoxColumn.HeaderText = "StokCikislar";
            stokCikislarDataGridViewTextBoxColumn.MinimumWidth = 6;
            stokCikislarDataGridViewTextBoxColumn.Name = "stokCikislarDataGridViewTextBoxColumn";
            // 
            // ColSil
            // 
            ColSil.HeaderText = "Sil";
            ColSil.MinimumWidth = 6;
            ColSil.Name = "ColSil";
            ColSil.Resizable = DataGridViewTriState.True;
            ColSil.SortMode = DataGridViewColumnSortMode.Automatic;
            ColSil.Text = "Sil";
            ColSil.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 466);
            Controls.Add(btnCikis);
            Controls.Add(btnKaydet);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbUrunlerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbBirimlerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbKategorilerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource dbKategorilerBindingSource;
        private BindingSource dbBirimlerBindingSource;
        private BindingSource dbUrunlerBindingSource;
        private Button btnKaydet;
        private Button btnCikis;
        private DataGridViewTextBoxColumn urunKoduDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn urunAciklamaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minStokDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maksStokDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn kategoriDataGridViewComboBoxColumn;
        private DataGridViewComboBoxColumn birimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stokGirislerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stokCikislarDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn ColSil;
    }
}
