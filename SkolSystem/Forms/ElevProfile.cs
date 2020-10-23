using SkolSystem.Klasser;
using System;
using System.Windows.Forms;

namespace SkolSystem.Forms
{
    /// <summary>
    /// Form componenten som öppnas när ett namn dubbelklickas i lära läget(inloggad som lärare)
    /// </summary>
    public partial class ElevProfile : Form
    {
        ElevKonto elevKonto;
        public ElevProfile(ElevKonto elevKonto)
        {
            this.elevKonto = elevKonto;
            InitializeComponent();
        }

        private void ElevProfile_Load(object sender, EventArgs e)
        {
            tbxPersonNummer.Text = elevKonto.personNummer;
            tbxNamn.Text = elevKonto.namn;
            lbxKlasser.Items.AddRange(elevKonto.studiePlan.kurser.ToArray());
            lblKurser.Text = $"{elevKonto.namn}s kurser";
        }

        private void BtnSpara_Click(object sender, EventArgs e)
        {
            ((Kurs)lbxKlasser.SelectedItem).resultat.stage = (Resultat.Stage)cmbStatus.SelectedIndex; 
            ((Kurs)lbxKlasser.SelectedItem).resultat.betygBokstav = (Resultat.Betyg)cmbBetyg.SelectedIndex; 

        }

        private void lbxKlasser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fyller betyg och stage med info
            cmbStatus.SelectedIndex = (int)((Kurs)lbxKlasser.SelectedItem).resultat.stage;
            cmbBetyg.SelectedIndex = (int)((Kurs)lbxKlasser.SelectedItem).resultat.betygBokstav;
        }
    }
}
