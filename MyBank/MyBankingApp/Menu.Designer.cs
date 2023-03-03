namespace MyBankingApp
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_kunder = new System.Windows.Forms.Button();
            this.btn_konti = new System.Windows.Forms.Button();
            this.btn_bank = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kunder
            // 
            this.btn_kunder.BackColor = System.Drawing.Color.Silver;
            this.btn_kunder.Location = new System.Drawing.Point(39, 66);
            this.btn_kunder.Name = "btn_kunder";
            this.btn_kunder.Size = new System.Drawing.Size(89, 50);
            this.btn_kunder.TabIndex = 0;
            this.btn_kunder.Text = "Kunder";
            this.btn_kunder.UseVisualStyleBackColor = false;
            this.btn_kunder.Click += new System.EventHandler(this.btn_kunder_Click);
            // 
            // btn_konti
            // 
            this.btn_konti.BackColor = System.Drawing.Color.Silver;
            this.btn_konti.Location = new System.Drawing.Point(39, 162);
            this.btn_konti.Name = "btn_konti";
            this.btn_konti.Size = new System.Drawing.Size(89, 50);
            this.btn_konti.TabIndex = 1;
            this.btn_konti.Text = "Konti";
            this.btn_konti.UseVisualStyleBackColor = false;
            this.btn_konti.Click += new System.EventHandler(this.btn_konti_Click);
            // 
            // btn_bank
            // 
            this.btn_bank.BackColor = System.Drawing.Color.Silver;
            this.btn_bank.Location = new System.Drawing.Point(39, 258);
            this.btn_bank.Name = "btn_bank";
            this.btn_bank.Size = new System.Drawing.Size(89, 50);
            this.btn_bank.TabIndex = 2;
            this.btn_bank.Text = "Bank";
            this.btn_bank.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_bank);
            this.Controls.Add(this.btn_konti);
            this.Controls.Add(this.btn_kunder);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kunder;
        private System.Windows.Forms.Button btn_konti;
        private System.Windows.Forms.Button btn_bank;
        private System.Windows.Forms.Label label1;
    }
}