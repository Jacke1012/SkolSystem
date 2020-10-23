using SkolSystem.Forms;
using SkolSystem.Klasser;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkolSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Database.Load();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.Save();
        }
    }
}
