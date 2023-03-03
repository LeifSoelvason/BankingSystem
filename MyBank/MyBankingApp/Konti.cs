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
    public partial class Konti : Form
    {
        private DataAccess_Konto dataAccessKonto = new DataAccess_Konto();
        private List<Konto> kontoListe;

        public Konti()
        {
            InitializeComponent();
            OpdaterKontoListe();
        }

        private void OpdaterKontoListe()
        {
            int.TryParse(txt_kundenummer.Text, out int kundenummer);
                      
            kontoListe = dataAccessKonto.MineKonti(kundenummer);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kontoListe;
        }

        private void btnIndsæt_Click(object sender, EventArgs e)
        {
            int kontonummer = Convert.ToInt32(txt_kontonummer.Text);
            decimal beløb = Convert.ToDecimal(txt_beløb.Text);

            dataAccessKonto.IndsætPenge(kontonummer, beløb);

            OpdaterKontoListe();
        }

        private void btnHæv_Click(object sender, EventArgs e)
        {
            int kontonummer = Convert.ToInt32(txt_kontonummer.Text);
            decimal beløb = Convert.ToDecimal(txt_beløb.Text);

            dataAccessKonto.HævPenge(kontonummer, beløb);

            OpdaterKontoListe();
        }

        private void btnVisSaldo_Click(object sender, EventArgs e)
        {
            int kontonummer = Convert.ToInt32(txt_kontonummer);
            decimal saldo = dataAccessKonto.VisSaldo(kontonummer);

            MessageBox.Show($"Saldoen på konto {kontonummer} er {saldo}");
        }
    }
}
