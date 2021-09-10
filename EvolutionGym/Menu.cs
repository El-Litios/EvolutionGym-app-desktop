using EvolutionGym.Model;
using EvolutionGym.View.Clients;
using EvolutionGym.View.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvolutionGym
{
    public partial class Menu : Form
    {
        private User u;
        public Menu(User _u)
        {
            InitializeComponent();
            u = _u;
            lbl_mensaje.Text = "Bienvenido: " + u.UserName + " " + u.UserFatherLastName;
            switch (u.RoleID)
            {
                case 1:
                    btn_ClientFRM.Visible = true;
                    btn_ClientFRM.Enabled = true;

                    btn_MembershipFRM.Visible = true;
                    btn_MembershipFRM.Enabled = true;

                    btn_TypeMembershipFRM.Visible = true;
                    btn_TypeMembershipFRM.Enabled = true;

                    btn_UsersFRM.Visible = true;
                    btn_UsersFRM.Enabled = true;
                    break;
            
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_HourNow.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_DateNow.Text = DateTime.Now.ToLongDateString();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btn_ClientFRM_Click(object sender, EventArgs e)
        {
            Close_All();
            Panel_Control.Controls.Clear();
            Clients_List Clients_list = new Clients_List();
            Clients_list.TopLevel = false;
            Clients_list.AutoScroll = true;
            Panel_Control.Controls.Add(Clients_list);
            Clients_list.Show();

        }

        private void Close_All() 
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Menu" && Application.OpenForms[i].Name != "Login")
                    Application.OpenForms[i].Close();
            }
        }

        private void btn_UsersFRM_Click(object sender, EventArgs e)
        {
            Close_All();
            Panel_Control.Controls.Clear();
            Users_List Users_list = new Users_List();
            Users_list.TopLevel = false;
            Users_list.AutoScroll = true;
            Panel_Control.Controls.Add(Users_list);
            Users_list.Show();
        }
    }
}
