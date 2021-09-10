using EvolutionGym.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EvolutionGym.View.Users
{
    public partial class Users_Add : Form
    {
        public Users_Add()
        {
            InitializeComponent();
            using (Connection con = new Connection()) {
                var Role = con.tblRole.ToArray();
                cb_Role.Items.AddRange(Role);
                cb_Role.DisplayMember = "RoleDesc";
                cb_Role.ValueMember = "RoleID";
            }
        }

        private void btn_AddClient_Click(object sender, EventArgs e)
        {
            if (
                String.IsNullOrEmpty(tb_Rut.Text) ||
                String.IsNullOrEmpty(tb_Name.Text) ||
                String.IsNullOrEmpty(tb_FatherLastName.Text) ||
                String.IsNullOrEmpty(tb_MotherLastName.Text) ||
                String.IsNullOrEmpty(tb_User.Text) ||
                String.IsNullOrEmpty(tb_Pass.Text) ||
                cb_Role.SelectedIndex == -1)
            {
                Error.SetError(btn_AddUser, "Debe llenar todos los campos.");
            }
            else {
                User user = new User();
                user.UserRut = tb_Rut.Text;
                user.UserName = tb_Name.Text;
                user.UserFatherLastName = tb_FatherLastName.Text;
                user.UserMotherLastName = tb_MotherLastName.Text;
                user.UserUser = tb_User.Text;
                user.UserPass = tb_Pass.Text;
                Role role = (Role)cb_Role.SelectedItem;
                user.RoleID = role.RoleID;

                using (Connection con = new Connection()) {
                    con.tblUser.Add(user);
                    con.SaveChanges();
                    set_empty();
                    SuccessMessage sm = new SuccessMessage();
                    sm.ShowDialog();
                }

            }
        }

        private void set_empty()
        {
            tb_Rut.Text = "";
            tb_Name.Text = "";
            tb_FatherLastName.Text = "";
            tb_MotherLastName.Text = "";
            tb_User.Text = "";
            tb_Pass.Text = "";

        }
    }
}
