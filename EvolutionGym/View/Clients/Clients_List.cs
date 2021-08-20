﻿using EvolutionGym.Model;
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
        }

        private void lv_Clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_EditForm.Enabled = true;
            btn_Delete.Enabled = true;
        }
    }
}