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

namespace EvolutionGym.View.Memberships
{
    public partial class Memberships_List : Form
    {
        private int userID;
        public Memberships_List(int uID)
        {
            InitializeComponent();
            userID = uID;
        }

        private void btn_AddForm_Click(object sender, EventArgs e)
        {
            Memberships_Add m_add_form = new Memberships_Add(userID);
            m_add_form.ShowDialog();
            using (Connection con = new Connection())
            {
                var Membership = con.tblMembership
                                .Include(m => m.User)
                                .Include(m => m.Client)
                                .Include(m => m.Payment)
                                .Include(m => m.Type)
                                .ToList();
                List_Load(Membership);
            }
        }

        private void List_Load(List<Members> list)
        {
            lv_Membership.Items.Clear();
            using (Connection con = new Connection())
            {
                foreach (var m in list)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = m.MembershipID.ToString();
                    lvi.SubItems.Add(m.Client.ClientRut);
                    lvi.SubItems.Add(m.Client.ClientFullName);
                    lvi.SubItems.Add(String.Format("{0:MM/dd/yyyy}", m.MembershipDateBegin));
                    lvi.SubItems.Add(String.Format("{0:MM/dd/yyyy}", m.MembershipDateEnd));
                    lvi.ForeColor = Color.WhiteSmoke;

                    lv_Membership.Items.Add(lvi);
                }
            }
        }

        private void Memberships_List_Load(object sender, EventArgs e)
        {
            using (Connection con = new Connection()) {
                var Membership = con.tblMembership
                                .Include(m => m.User)
                                .Include(m => m.Client)
                                .Include(m => m.Payment)
                                .Include(m => m.Type)
                                .ToList();
                List_Load(Membership);
            }
        }

        private void tb_SearchField_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (Connection con = new Connection()) 
            {
                var Search = con.tblMembership
                    .Include(m => m.Client)
                    .Where(m => m.Client.ClientRut
                    .Contains(tb_SearchField.Text) || m.Client.ClientName.Contains(tb_SearchField.Text))
                    .ToList();
                List_Load(Search);
            }
        }

        private void btn_DetailsForm_Click(object sender, EventArgs e)
        {
            int membership_id = Convert.ToInt32(lv_Membership.SelectedItems[0].Text);
            using (Connection con = new Connection()) {
                var Membership = con.tblMembership.Include(m => m.Client)
                                                  .Include(m => m.User)
                                                  .Include(m => m.Type)
                                                  .Include(m => m.Payment)
                                                  .Where(m => m.MembershipID.Equals(membership_id)).FirstOrDefault();
                if (Membership != null)
                {
                    Memberships_Details m_details_form = new Memberships_Details(Membership);
                    m_details_form.ShowDialog();
                    
                }
            }
                
        }

        private void lv_Membership_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_DetailsForm.Enabled = true;
            btn_Delete.Enabled = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            ConfirmationForm cform = new ConfirmationForm();
            DialogResult res = new DialogResult();
            res = cform.ShowDialog();
            if (res == DialogResult.OK)
            {
                int membership_id = Convert.ToInt32(lv_Membership.SelectedItems[0].Text);
                using (Connection con = new Connection())
                {
                    var Membership = con.tblMembership.Where(m => m.MembershipID == membership_id).FirstOrDefault();

                    con.Entry(Membership).State = EntityState.Deleted;
                    con.SaveChanges();

                    btn_Delete.Enabled = false;
                    btn_DetailsForm.Enabled = false;

                    List_Load(con.tblMembership
                                        .Include(m => m.User)
                                        .Include(m => m.Client)
                                        .Include(m => m.Payment)
                                        .Include(m => m.Type)
                                        .ToList());
                    
                }
            }
        }
    }
}
