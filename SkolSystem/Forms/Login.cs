using SkolSystem.Klasser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private bool AccountExist(string kontoNamn)
        {
            int temp = -1;
            //using (SqlConnection conn = new SqlConnection(SqlLoader.connectionString))
            //{
            //    conn.Open();
            //    string query = $"SELECT COUNT(Namn) FROM Konton WHERE Namn = '{kontoNamn}'";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        SqlDataReader reader = cmd.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            temp = reader.GetInt32(0);
            //        }
            //    }
            //}

            temp = (int)SqlLoader.SendQuery($"SELECT COUNT(Namn) FROM Konton WHERE Namn='{kontoNamn}'", 1)[0][0];

            if (temp <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckPassword(string namn, string password)
        {
            string lösenord = (string)SqlLoader.SendQuery($"SELECT Lösenord FROM Konton WHERE Namn='{namn}'", 1)[0][0];
            if (password == lösenord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (AccountExist(tbxNamn.Text))
            {
                if (CheckPassword(tbxNamn.Text, tbxPassword.Text))
                {
                    string test = (string)SqlLoader.SendQuery($"SELECT KontoTyp FROM Konton WHERE Namn = {tbxNamn.Text}",1)[0][0];

                }
            }






            #region Old
            //Konto loginKonto = null;
            //Predicate<Konto> correctAccount = new Predicate<Konto>(x => x.namn == tbxNamn.Text && x.password == tbxPassword.Text);
            //if (Database.data.allaKonton.Exists(correctAccount))
            //{
            //    loginKonto = Database.data.allaKonton.Find(correctAccount);
            //}
            //else
            //{
            //    MessageBox.Show("Fel namn eller lösenord", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (loginKonto is LäraKonto)
            //{
            //    LärareForm lärareForm = new LärareForm((LäraKonto)loginKonto);
            //    lärareForm.Show();
            //    Close();
            //}
            //else if(loginKonto is ElevKonto)
            //{
            //    ElevForm elevform = new ElevForm((ElevKonto)loginKonto);
            //    elevform.Show();
            //    Close();
            //}
            #endregion


            

        }
    }
}
