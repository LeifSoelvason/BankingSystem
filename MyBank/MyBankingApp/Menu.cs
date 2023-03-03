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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_kunder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kunder x = new Kunder();
            x.Show();
        }

        private void btn_konti_Click(object sender, EventArgs e)
        {
            this.Hide();
            Konti x = new Konti();
            x.Show();
        }
    }
}
