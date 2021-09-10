using EvolutionGym.Model;
using Microsoft.EntityFrameworkCore;
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
    public partial class Users_Edit : Form
    {
        User _u;
        public Users_Edit(User u)
        {
            InitializeComponent();
            _u = u;
            using (Connection con = new Connection()) {
                var Role = con.tblRole.ToArray();
                cb_Role.Items.AddRange(Role);
                cb_Role.DisplayMember = "RoleDesc";
                cb_Role.ValueMember = "RoleID";
            }

            tb_Rut.Text = u.UserRut;
            tb_Name.Text = u.UserName;
            tb_FatherLastName.Text = u.UserFatherLastName;
            tb_MotherLastName.Text = u.UserMotherLastName;
            tb_User.Text = u.UserUser;
        }


        private void set_empty()
        {
            tb_Rut.Text = "";
            tb_Name.Text = "";
            tb_FatherLastName.Text = "";
            tb_MotherLastName.Text = "";
            tb_User.Text = "";


        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            if (
                String.IsNullOrEmpty(tb_Rut.Text) ||
                String.IsNullOrEmpty(tb_Name.Text) ||
                String.IsNullOrEmpty(tb_FatherLastName.Text) ||
                String.IsNullOrEmpty(tb_MotherLastName.Text) ||
                String.IsNullOrEmpty(tb_User.Text) ||
                cb_Role.SelectedIndex == -1)
            {
                Error.SetError(btn_EditUser, "Debe llenar todos los campos.");
            }
            else
            {
                _u.UserRut = tb_Rut.Text;
                _u.UserName = tb_Name.Text;
                _u.UserFatherLastName = tb_FatherLastName.Text;
                _u.UserMotherLastName = tb_MotherLastName.Text;
                _u.UserUser = tb_User.Text;
                Role role = (Role)cb_Role.SelectedItem;
                _u.RoleID = role.RoleID;

                using (Connection con = new Connection())
                {
                    con.Entry(_u).State = EntityState.Modified;
                    con.SaveChanges();
                    set_empty();
                    SuccessMessage sm = new SuccessMessage();
                    sm.ShowDialog();
                }

            }
        }
    }
}
