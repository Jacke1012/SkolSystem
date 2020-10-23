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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BtnRegeriser_Click(object sender, EventArgs e)
        {
            Konto tempKonto = null;
            if (cmbTyp.SelectedIndex == 0)
            {
                tempKonto = new LäraKonto(tbxNamn.Text, tbxPersonNummber.Text);
            }
            else if(cmbTyp.SelectedIndex == 1)
            {
                tempKonto = new ElevKonto(tbxNamn.Text, tbxPersonNummber.Text);
            }
            tempKonto.password = tbxPassword.Text;
            Database.data.allaKonton.Add((Konto)tempKonto);
            this.Close();

        }
    }
}
