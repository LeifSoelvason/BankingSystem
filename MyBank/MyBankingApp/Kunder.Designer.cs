namespace MyBankingApp
{
    partial class Kunder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kundenummer = new System.Windows.Forms.TextBox();
            this.txt_fornavn = new System.Windows.Forms.TextBox();
            this.txt_efternavn = new System.Windows.Forms.TextBox();
            this.btn_NyKonto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kontonummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundenummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet4 = new MyBankingApp.BankDataSet4();
            this.kontoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet2 = new MyBankingApp.BankDataSet2();
            this.kontoTableAdapter = new MyBankingApp.BankDataSet2TableAdapters.KontoTableAdapter();
            this.bankDataSet3 = new MyBankingApp.BankDataSet3();
            this.kontoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kontoTableAdapter1 = new MyBankingApp.BankDataSet3TableAdapters.KontoTableAdapter();
            this.kontoTableAdapter2 = new MyBankingApp.BankDataSet4TableAdapters.KontoTableAdapter();
            this.btn_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_søg = new System.Windows.Forms.TextBox();
            this.btn_søg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kundenummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fornavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Efternavn";
            // 
            // txt_kundenummer
            // 
            this.txt_kundenummer.Location = new System.Drawing.Point(102, 23);
            this.txt_kundenummer.Name = "txt_kundenummer";
            this.txt_kundenummer.Size = new System.Drawing.Size(156, 20);
            this.txt_kundenummer.TabIndex = 3;
            // 
            // txt_fornavn
            // 
            this.txt_fornavn.Location = new System.Drawing.Point(102, 60);
            this.txt_fornavn.Name = "txt_fornavn";
            this.txt_fornavn.Size = new System.Drawing.Size(156, 20);
            this.txt_fornavn.TabIndex = 4;
            // 
            // txt_efternavn
            // 
            this.txt_efternavn.Location = new System.Drawing.Point(102, 97);
            this.txt_efternavn.Name = "txt_efternavn";
            this.txt_efternavn.Size = new System.Drawing.Size(156, 20);
            this.txt_efternavn.TabIndex = 5;
            // 
            // btn_NyKonto
            // 
            this.btn_NyKonto.Location = new System.Drawing.Point(102, 135);
            this.btn_NyKonto.Name = "btn_NyKonto";
            this.btn_NyKonto.Size = new System.Drawing.Size(75, 23);
            this.btn_NyKonto.TabIndex = 6;
            this.btn_NyKonto.Text = "Ny Konto";
            this.btn_NyKonto.UseVisualStyleBackColor = true;
            this.btn_NyKonto.Click += new System.EventHandler(this.btn_NyKonto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kontonummerDataGridViewTextBoxColumn,
            this.fornavnDataGridViewTextBoxColumn,
            this.efternavnDataGridViewTextBoxColumn,
            this.datoDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.kundenummerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kontoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(102, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 360);
            this.dataGridView1.TabIndex = 7;
            // 
            // kontonummerDataGridViewTextBoxColumn
            // 
            this.kontonummerDataGridViewTextBoxColumn.DataPropertyName = "Kontonummer";
            this.kontonummerDataGridViewTextBoxColumn.HeaderText = "Kontonummer";
            this.kontonummerDataGridViewTextBoxColumn.Name = "kontonummerDataGridViewTextBoxColumn";
            this.kontonummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornavnDataGridViewTextBoxColumn
            // 
            this.fornavnDataGridViewTextBoxColumn.DataPropertyName = "Fornavn";
            this.fornavnDataGridViewTextBoxColumn.HeaderText = "Fornavn";
            this.fornavnDataGridViewTextBoxColumn.Name = "fornavnDataGridViewTextBoxColumn";
            // 
            // efternavnDataGridViewTextBoxColumn
            // 
            this.efternavnDataGridViewTextBoxColumn.DataPropertyName = "Efternavn";
            this.efternavnDataGridViewTextBoxColumn.HeaderText = "Efternavn";
            this.efternavnDataGridViewTextBoxColumn.Name = "efternavnDataGridViewTextBoxColumn";
            // 
            // datoDataGridViewTextBoxColumn
            // 
            this.datoDataGridViewTextBoxColumn.DataPropertyName = "Dato";
            this.datoDataGridViewTextBoxColumn.HeaderText = "Dato";
            this.datoDataGridViewTextBoxColumn.Name = "datoDataGridViewTextBoxColumn";
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            // 
            // kundenummerDataGridViewTextBoxColumn
            // 
            this.kundenummerDataGridViewTextBoxColumn.DataPropertyName = "Kundenummer";
            this.kundenummerDataGridViewTextBoxColumn.HeaderText = "Kundenummer";
            this.kundenummerDataGridViewTextBoxColumn.Name = "kundenummerDataGridViewTextBoxColumn";
            // 
            // kontoBindingSource2
            // 
            this.kontoBindingSource2.DataMember = "Konto";
            this.kontoBindingSource2.DataSource = this.bankDataSet4;
            // 
            // bankDataSet4
            // 
            this.bankDataSet4.DataSetName = "BankDataSet4";
            this.bankDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontoBindingSource
            // 
            this.kontoBindingSource.DataMember = "Konto";
            this.kontoBindingSource.DataSource = this.bankDataSet2;
            // 
            // bankDataSet2
            // 
            this.bankDataSet2.DataSetName = "BankDataSet2";
            this.bankDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontoTableAdapter
            // 
            this.kontoTableAdapter.ClearBeforeFill = true;
            // 
            // bankDataSet3
            // 
            this.bankDataSet3.DataSetName = "BankDataSet3";
            this.bankDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontoBindingSource1
            // 
            this.kontoBindingSource1.DataMember = "Konto";
            this.kontoBindingSource1.DataSource = this.bankDataSet3;
            // 
            // kontoTableAdapter1
            // 
            this.kontoTableAdapter1.ClearBeforeFill = true;
            // 
            // kontoTableAdapter2
            // 
            this.kontoTableAdapter2.ClearBeforeFill = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(183, 135);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 24);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "(Kundenummer)";
            // 
            // txt_søg
            // 
            this.txt_søg.Location = new System.Drawing.Point(481, 166);
            this.txt_søg.Name = "txt_søg";
            this.txt_søg.Size = new System.Drawing.Size(180, 20);
            this.txt_søg.TabIndex = 10;
            // 
            // btn_søg
            // 
            this.btn_søg.Location = new System.Drawing.Point(667, 164);
            this.btn_søg.Name = "btn_søg";
            this.btn_søg.Size = new System.Drawing.Size(75, 23);
            this.btn_søg.TabIndex = 11;
            this.btn_søg.Text = "Søg";
            this.btn_søg.UseVisualStyleBackColor = true;
            this.btn_søg.Click += new System.EventHandler(this.btn_søg_Click);
            // 
            // Kunder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 565);
            this.Controls.Add(this.btn_søg);
            this.Controls.Add(this.txt_søg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_NyKonto);
            this.Controls.Add(this.txt_efternavn);
            this.Controls.Add(this.txt_fornavn);
            this.Controls.Add(this.txt_kundenummer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kunder";
            this.Text = "Kunder";
            this.Load += new System.EventHandler(this.Kunder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kundenummer;
        private System.Windows.Forms.TextBox txt_fornavn;
        private System.Windows.Forms.TextBox txt_efternavn;
        private System.Windows.Forms.Button btn_NyKonto;
        private BankDataSet2 bankDataSet2;
        private System.Windows.Forms.BindingSource kontoBindingSource;
        private BankDataSet2TableAdapters.KontoTableAdapter kontoTableAdapter;
        private BankDataSet3 bankDataSet3;
        private System.Windows.Forms.BindingSource kontoBindingSource1;
        private BankDataSet3TableAdapters.KontoTableAdapter kontoTableAdapter1;
        private BankDataSet4 bankDataSet4;
        private System.Windows.Forms.BindingSource kontoBindingSource2;
        private BankDataSet4TableAdapters.KontoTableAdapter kontoTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontonummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundenummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_søg;
        private System.Windows.Forms.Button btn_søg;
    }
}