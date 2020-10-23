using SkolSystem.Klasser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkolSystem.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Konto loginKonto = null;
            Predicate<Konto> correctAccount = new Predicate<Konto>(x => x.namn == tbxNamn.Text && x.password == tbxPassword.Text);
            if (Database.data.allaKonton.Exists(correctAccount))
            {
                loginKonto = Database.data.allaKonton.Find(correctAccount);
            }
            else
            {
                MessageBox.Show("Fel namn eller lösenord", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (loginKonto is LäraKonto)
            {
                LärareForm lärareForm = new LärareForm((LäraKonto)loginKonto);
                lärareForm.Show();
                Close();
            }
            else if(loginKonto is ElevKonto)
            {
                ElevForm elevform = new ElevForm((ElevKonto)loginKonto);
                elevform.Show();
                Close();
            }
            
            
        }
    }
}
