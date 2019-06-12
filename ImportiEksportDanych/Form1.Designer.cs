namespace ImportiEksportDanych
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.import = new System.Windows.Forms.Button();
            this.Eksport = new System.Windows.Forms.Button();
            this.wodaDataSet = new ImportiEksportDanych.WodaDataSet();
            this.watterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watterTableAdapter = new ImportiEksportDanych.WodaDataSetTableAdapters.WatterTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pojemnoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typbutelkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wodaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn,
            this.producentDataGridViewTextBoxColumn,
            this.pojemnoscDataGridViewTextBoxColumn,
            this.typbutelkiDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.watterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 283);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(557, 184);
            this.dataGridView2.TabIndex = 1;
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(12, 220);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(247, 57);
            this.import.TabIndex = 2;
            this.import.Text = "Import ";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // Eksport
            // 
            this.Eksport.Location = new System.Drawing.Point(322, 220);
            this.Eksport.Name = "Eksport";
            this.Eksport.Size = new System.Drawing.Size(247, 57);
            this.Eksport.TabIndex = 3;
            this.Eksport.Text = "Eksport";
            this.Eksport.UseVisualStyleBackColor = true;
            this.Eksport.Click += new System.EventHandler(this.Eksport_Click);
            // 
            // wodaDataSet
            // 
            this.wodaDataSet.DataSetName = "WodaDataSet";
            this.wodaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // watterBindingSource
            // 
            this.watterBindingSource.DataMember = "Watter";
            this.watterBindingSource.DataSource = this.wodaDataSet;
            // 
            // watterTableAdapter
            // 
            this.watterTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            // 
            // producentDataGridViewTextBoxColumn
            // 
            this.producentDataGridViewTextBoxColumn.DataPropertyName = "Producent";
            this.producentDataGridViewTextBoxColumn.HeaderText = "Producent";
            this.producentDataGridViewTextBoxColumn.Name = "producentDataGridViewTextBoxColumn";
            // 
            // pojemnoscDataGridViewTextBoxColumn
            // 
            this.pojemnoscDataGridViewTextBoxColumn.DataPropertyName = "Pojemnosc";
            this.pojemnoscDataGridViewTextBoxColumn.HeaderText = "Pojemnosc";
            this.pojemnoscDataGridViewTextBoxColumn.Name = "pojemnoscDataGridViewTextBoxColumn";
            // 
            // typbutelkiDataGridViewTextBoxColumn
            // 
            this.typbutelkiDataGridViewTextBoxColumn.DataPropertyName = "Typ_butelki";
            this.typbutelkiDataGridViewTextBoxColumn.HeaderText = "Typ_butelki";
            this.typbutelkiDataGridViewTextBoxColumn.Name = "typbutelkiDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 479);
            this.Controls.Add(this.Eksport);
            this.Controls.Add(this.import);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wodaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button Eksport;
        private WodaDataSet wodaDataSet;
        private System.Windows.Forms.BindingSource watterBindingSource;
        private WodaDataSetTableAdapters.WatterTableAdapter watterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pojemnoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typbutelkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
    }
}

