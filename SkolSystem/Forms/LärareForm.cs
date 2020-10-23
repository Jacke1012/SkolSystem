using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkolSystem.Forms;
using SkolSystem.Klasser;

namespace SkolSystem
{
    public partial class LärareForm : Form
    {
        LäraKonto läraKonto;
        public LärareForm(LäraKonto läraKonto)
        {
            this.läraKonto = läraKonto;
            InitializeComponent();
        }

        private void LärareForm_Load(object sender, EventArgs e)
        {
            lblWelcomeText.Text = $"Hej, {läraKonto.namn}";
            cmbKlasser.Items.AddRange(läraKonto.klasser.ToArray());

            tbxNamn.Text = läraKonto.namn;
            tbxPersonNummer.Text = läraKonto.personNummer;
        }

        private void cmbKlasser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbxElever.Items.Clear();
            Klass selectedKlass = (Klass)cmbKlasser.SelectedItem;
            lbxElever.Items.AddRange(selectedKlass.GetElever().ToArray());
        }

        private void BtnNyKurs_Click(object sender, EventArgs e)
        {
            SkapaNyKurs skapaNyKurs = new SkapaNyKurs(läraKonto);
            skapaNyKurs.ShowDialog();
            ReDraw();
        }

        public void ReDraw()
        {
            cmbKlasser.Items.AddRange(läraKonto.klasser.ToArray());
        }

        private void lbxElever_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ((ElevKonto)lbxElever.SelectedItem).OpenProfilePage();
        }

        private void cmbKlasser_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxKursInfo.Text = ((Kurs)cmbKlasser.SelectedItem).kursInfo;
        }
    }
}
