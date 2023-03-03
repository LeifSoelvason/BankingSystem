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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void btn_login_Click(object sender, EventArgs e)
        {
            txt_brugernavn.Select();


            DataAccess_Kunde db = new DataAccess_Kunde();

            var output = db.PasswordValidation(txt_brugernavn.Text, txt_password.Text);

            if (output.Count == 1)
            {
                this.Hide();
                Menu x = new Menu();
                x.Show();
            }
            else
            {
                MessageBox.Show("Brugernavn eller password er forkert. Prøv igen");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}