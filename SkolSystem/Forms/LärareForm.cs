using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        private void cmbKlasser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Klass selectedKlass = (Klass)cmbKlasser.SelectedItem;
            lbxElever.Items.AddRange(selectedKlass.GetElever().ToArray());
        }
    }
}
