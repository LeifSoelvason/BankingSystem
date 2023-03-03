namespace MyBankingApp
{
    partial class Konti
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kundenummer = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kontonummer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_beløb = new System.Windows.Forms.TextBox();
            this.btnIndsæt = new System.Windows.Forms.Button();
            this.btnHæv = new System.Windows.Forms.Button();
            this.btnVisSaldo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kundenummer";
            // 
            // txt_kundenummer
            // 
            this.txt_kundenummer.Location = new System.Drawing.Point(139, 30);
            this.txt_kundenummer.Name = "txt_kundenummer";
            this.txt_kundenummer.Size = new System.Drawing.Size(100, 20);
            this.txt_kundenummer.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(139, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kontonummer";
            // 
            // txt_kontonummer
            // 
            this.txt_kontonummer.Location = new System.Drawing.Point(139, 64);
            this.txt_kontonummer.Name = "txt_kontonummer";
            this.txt_kontonummer.Size = new System.Drawing.Size(100, 20);
            this.txt_kontonummer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Beløb";
            // 
            // txt_beløb
            // 
            this.txt_beløb.Location = new System.Drawing.Point(139, 103);
            this.txt_beløb.Name = "txt_beløb";
            this.txt_beløb.Size = new System.Drawing.Size(100, 20);
            this.txt_beløb.TabIndex = 6;
            // 
            // btnIndsæt
            // 
            this.btnIndsæt.Location = new System.Drawing.Point(139, 147);
            this.btnIndsæt.Name = "btnIndsæt";
            this.btnIndsæt.Size = new System.Drawing.Size(75, 31);
            this.btnIndsæt.TabIndex = 7;
            this.btnIndsæt.Text = "Indsæt";
            this.btnIndsæt.UseVisualStyleBackColor = true;
            this.btnIndsæt.Click += new System.EventHandler(this.btnIndsæt_Click);
            // 
            // btnHæv
            // 
            this.btnHæv.Location = new System.Drawing.Point(232, 147);
            this.btnHæv.Name = "btnHæv";
            this.btnHæv.Size = new System.Drawing.Size(75, 31);
            this.btnHæv.TabIndex = 8;
            this.btnHæv.Text = "Hæv";
            this.btnHæv.UseVisualStyleBackColor = true;
            this.btnHæv.Click += new System.EventHandler(this.btnHæv_Click);
            // 
            // btnVisSaldo
            // 
            this.btnVisSaldo.Location = new System.Drawing.Point(329, 146);
            this.btnVisSaldo.Name = "btnVisSaldo";
            this.btnVisSaldo.Size = new System.Drawing.Size(75, 32);
            this.btnVisSaldo.TabIndex = 9;
            this.btnVisSaldo.Text = "Vis Saldo";
            this.btnVisSaldo.UseVisualStyleBackColor = true;
            this.btnVisSaldo.Click += new System.EventHandler(this.btnVisSaldo_Click);
            // 
            // Konti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisSaldo);
            this.Controls.Add(this.btnHæv);
            this.Controls.Add(this.btnIndsæt);
            this.Controls.Add(this.txt_beløb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_kontonummer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_kundenummer);
            this.Controls.Add(this.label1);
            this.Name = "Konti";
            this.Text = "Konti";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kundenummer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kontonummer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_beløb;
        private System.Windows.Forms.Button btnIndsæt;
        private System.Windows.Forms.Button btnHæv;
        private System.Windows.Forms.Button btnVisSaldo;
    }
}