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
    public partial class SkapaNyKurs : Form
    {
        LäraKonto läraKonto;
        public SkapaNyKurs(LäraKonto läraKonto)
        {
            this.läraKonto = läraKonto;
            InitializeComponent();
        }

        private void BtnSkapa_Click(object sender, EventArgs e)
        {
            List<ElevKonto> tempList = new List<ElevKonto>();
            for (int i = 0; i < lbxAddElever.Items.Count ; i++)
            {
            	if (lbxAddElever.GetSelected(i) == true)
            	{
                    tempList.Add((ElevKonto)lbxAddElever.Items[i]);
            	}
            }
            Klass tempKlass = new Klass(läraKonto, tempList,cmbKursTyp.SelectedItem as KursTyp, tbxÅrsKurs.Text);
            läraKonto.klasser.Add(tempKlass);
            Close();
        }

        private void SkapaNyKurs_Load(object sender, EventArgs e)
        {
            lbxAddElever.Items.AddRange(Database.data.allaKonton.Where(x => x.GetType() == typeof(ElevKonto)).ToArray());
            cmbKursTyp.Items.AddRange(Database.data.kursTyper.ToArray());
        }
    }
}
