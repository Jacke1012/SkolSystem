using System;
using System.Windows.Forms;
using SkolSystem.Klasser;

namespace SkolSystem
{
    public partial class ElevForm : Form
    {
        ElevKonto elevKonto;
        public ElevForm(ElevKonto elevKonto)
        {
            this.elevKonto = elevKonto;
            InitializeComponent();
        }

        private void ElevForm_Load(object sender, EventArgs e)
        {
            lblWelcomeText.Text = $"Hej, {elevKonto.namn}";
            cmbKlasser.Items.AddRange(elevKonto.studiePlan.kurser.ToArray());

            tbxNamn.Text = elevKonto.namn;
            tbxPersonNummer.Text = elevKonto.personNummer;
        }

        private void cmbKlasser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Kurs selectedKlass = (Kurs)cmbKlasser.SelectedItem;
            tbxKursInfo.Text = selectedKlass.ToString();
        }

        private void cmbKlasser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fyller betyg och stage med info
            tbxKursStatus.Text = ((Kurs)cmbKlasser.SelectedItem).resultat.stage.ToString();
            tbxBetyg.Text = ((Kurs)cmbKlasser.SelectedItem).resultat.betygBokstav.ToString();
            tbxKursInfo.Text = ((Kurs)cmbKlasser.SelectedItem).kursInfo;
        }
    }
}
