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
    public partial class Users_List : Form
    {
        public Users_List()
        {
            InitializeComponent();
        }

        private void List_Load(List<User> list) 
        {
            lv_Users.Items.Clear();
            using (Connection con = new Connection()) 
            {
                foreach (var u in list)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = u.UserID.ToString();
                    lvi.SubItems.Add(u.UserRut.ToString());
                    lvi.SubItems.Add(u.UserFullName.ToString());
                    lvi.SubItems.Add(u.UserUser.ToString());
                    lvi.SubItems.Add(u.Role.RoleDesc);

                    lvi.ForeColor = Color.WhiteSmoke;

                    lv_Users.Items.Add(lvi);
                }

                
            }
        }

        private void Users_List_Load(object sender, EventArgs e)
        {
            using (Connection con = new Connection()) 
            {
                var list = con.tblUser.Include(r => r.Role).ToList();
                List_Load(list);
            }
        }

        private void tb_SearchField_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void btn_AddForm_Click(object sender, EventArgs e)
        {
            Users_Add u_add_form = new Users_Add();
            u_add_form.ShowDialog();
            using (Connection con = new Connection())
            {
                List_Load(con.tblUser.Include(u => u.Role).ToList());
            }
        }

        private void btn_EditForm_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(lv_Users.SelectedItems[0].Text);
            using (Connection con = new Connection())
            {
                var User = con.tblUser.Where(u => u.UserID == user_id).FirstOrDefault();
                if (User != null)
                {
                    Users_Edit u_edit_form = new Users_Edit(User);
                    u_edit_form.ShowDialog();
                    btn_Delete.Enabled = false;
                    btn_EditForm.Enabled = false;

                    List_Load(con.tblUser.Include(u => u.Role).ToList());
                }
            }
        }

        private void lv_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_EditForm.Enabled = true;
            btn_Delete.Enabled = true;
            tb_SearchField.Text = "";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            ConfirmationForm cform = new ConfirmationForm();
            DialogResult res = new DialogResult();
            res = cform.ShowDialog();
            if (res == DialogResult.OK)
            {
                int user_id = Convert.ToInt32(lv_Users.SelectedItems[0].Text);
                using (Connection con = new Connection())
                {
                    var User = con.tblUser.Where(u => u.UserID == user_id).FirstOrDefault();

                    con.Entry(User).State = EntityState.Deleted;
                    con.SaveChanges();

                    btn_Delete.Enabled = false;
                    btn_EditForm.Enabled = false;

                    List_Load(con.tblUser.Include(u => u.Role).ToList());
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var searching = tb_SearchField.Text;
            using (Connection con = new Connection())
            {
                var Filtered_Users = con.tblUser
                    .Include(u => u.Role)
                    .Where(u =>
                        u.UserRut.Contains(searching) ||
                        u.UserName.Contains(searching))
                    .ToList();
                List_Load(Filtered_Users);
            }
        }
    }
}
