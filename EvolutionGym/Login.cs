using EvolutionGym.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolutionGym
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var Username = tb_User.Text;
            var Pass = tb_Pass.Text;

            using (Connection con = new Connection()) 
            {
                var Users = con.tblUser
                    
                    .FirstOrDefault(u => u.UserUser == Username && u.UserPass == Pass);
                if (Users != null)
                {
                    Menu menu = new Menu(Users);
                    menu.Show();
                    this.Visible = false;
                }
                else 
                {
                    lb_Error.Visible = true;
                }
            }
        }

        private void Validation() 
        {
            if (String.IsNullOrEmpty(tb_User.Text) || String.IsNullOrEmpty(tb_Pass.Text))
            {
                btn_login.Enabled = false;
            }
            if (!String.IsNullOrEmpty(tb_User.Text) && !String.IsNullOrEmpty(tb_Pass.Text)) 
            {
                btn_login.Enabled = true;
            }
        }

        private void tb_User_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void tb_Pass_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }
    }
}
