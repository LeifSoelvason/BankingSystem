using MyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBankingApp
{
    
    public partial class Kunder : Form
    {
        //private List<Konto> konti = new List<Konto>(); // Initialize an empty list of accounts

        public Kunder()
        {
            InitializeComponent();
        }

        private void btn_NyKonto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_kundenummer.Text, out int kundenummer))
            {
                MessageBox.Show("Kundenummer must be an integer.");
                return;
            }

            DataAccess_Konto db = new DataAccess_Konto();
            db.NyKonto(txt_fornavn.Text, txt_efternavn.Text, kundenummer);

            // Reload the data in the DataGridView to display the newly added account
            this.kontoTableAdapter2.Fill(this.bankDataSet4.Konto);

        }



        private void Kunder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet4.Konto' table. You can move, or remove it, as needed.
            this.kontoTableAdapter2.Fill(this.bankDataSet4.Konto);
            
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_søg_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_søg.Text, out int kundenummer))
            {
                MessageBox.Show("Kundenummer must be an integer.");
                return;
            }

            DataAccess_Konto db = new DataAccess_Konto();
            db.MineKonti(kundenummer);

            // Reload the data in the DataGridView to display the newly added account
            this.kontoTableAdapter2.Fill(this.bankDataSet4.Konto);
        }
    }
}
