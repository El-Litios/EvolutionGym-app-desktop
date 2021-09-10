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

namespace EvolutionGym.View.Clients
{
    public partial class Clients_List : Form
    {
        public Clients_List()
        {
            InitializeComponent();
        }

        private void Clients_List_Load(object sender, EventArgs e)
        {
            using (Connection con = new Connection())
            {
                var Client = con.tblClient.ToList();
                List_Load(Client);
            }
        }

        private void List_Load(List<Client> list)
        {
            lv_Clients.Items.Clear();
            using (Connection con = new Connection()) 
            {
                foreach (var c in list)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = c.ClientID.ToString();
                    lvi.SubItems.Add(c.ClientRut.ToString());
                    lvi.SubItems.Add(c.ClientFullName.ToString());
                    lvi.SubItems.Add(c.ClientEmail.ToString());
                    lvi.SubItems.Add(c.ClientPhone.ToString());
                    lvi.ForeColor = Color.WhiteSmoke;

                    lv_Clients.Items.Add(lvi);
                }
            }
        }

        private void btn_AddForm_Click(object sender, EventArgs e)
        {
            Clients_Add c_add_form = new Clients_Add();
            c_add_form.ShowDialog();
            using (Connection con = new Connection()) 
            {
                List_Load(con.tblClient.ToList());
            }
        }

        private void lv_Clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_EditForm.Enabled = true;
            btn_Delete.Enabled = true;
        }

        private void btn_EditForm_Click(object sender, EventArgs e)
        {
            int client_id = Convert.ToInt32(lv_Clients.SelectedItems[0].Text);
            using (Connection con = new Connection()) 
            {
                var Client = con.tblClient.Where(c => c.ClientID == client_id).FirstOrDefault();
                if (Client != null)
                {
                    Clients_Edit c_edit_form = new Clients_Edit(Client);
                    c_edit_form.ShowDialog();
                    btn_Delete.Enabled = false;
                    btn_EditForm.Enabled = false;

                    List_Load(con.tblClient.ToList());
                }
            }
                

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            ConfirmationForm cform = new ConfirmationForm();
            DialogResult res = new DialogResult();
            res = cform.ShowDialog();
            if (res == DialogResult.OK)
            {
                int client_id = Convert.ToInt32(lv_Clients.SelectedItems[0].Text);
                using (Connection con = new Connection()) 
                {
                    var Client = con.tblClient.Where(c => c.ClientID == client_id).FirstOrDefault();

                    con.Entry(Client).State = EntityState.Deleted;
                    con.SaveChanges();

                    btn_Delete.Enabled = false;
                    btn_EditForm.Enabled = false;

                    List_Load(con.tblClient.ToList());
                }
            }
        }

        private void tb_User_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_SearchField.Text))
            {
                btn_Search.Enabled = true;
            }
            else 
            {
                btn_Search.Enabled = false;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var searching = tb_SearchField.Text;
            using (Connection con = new Connection())
            {
                var Filtered_Clients = con.tblClient
                    .Where(c =>
                        c.ClientRut.Contains(searching) || 
                        c.ClientName.Contains(searching))
                    .ToList();
                List_Load(Filtered_Clients);
            }
        }
    }
}
