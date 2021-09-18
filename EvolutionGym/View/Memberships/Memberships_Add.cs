using EvolutionGym.Model;
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
    public partial class Memberships_Add : Form
    {
        private int userID;
        public Memberships_Add(int uID)
        {
            InitializeComponent();
            userID = uID;
            using (Connection con = new Connection()) {
                var Type = con.tblTypeMembership.ToArray();
                cb_TypeMembership.Items.AddRange(Type);
                cb_TypeMembership.DisplayMember = "TypeDesc";
                cb_TypeMembership.ValueMember = "TypeID";

                var Payment = con.tblPaymentMethod.ToArray();
                cb_PaymentMethod.Items.AddRange(Payment);
                cb_PaymentMethod.DisplayMember = "MethodDesc";
                cb_PaymentMethod.ValueMember = "PaymentMethodID";
            }
        }

        public void Clients_List_Load(List<Client> list) {
            lv_Clients.Items.Clear();
            using (Connection con = new Connection())
            {
                foreach (var c in list)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = c.ClientID.ToString();
                    lvi.SubItems.Add(c.ClientRut.ToString());
                    lvi.SubItems.Add(c.ClientFullName.ToString());
                    lvi.ForeColor = Color.WhiteSmoke;

                    lv_Clients.Items.Add(lvi);
                }
            }
        }

        private void Memberships_Add_Load(object sender, EventArgs e)
        {
            using (Connection con = new Connection())
            {
                var Clients = con.tblClient.ToList();
                Clients_List_Load(Clients);
            }
        }

        private void tb_SearchField_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string search = tb_SearchField.Text;
            using (Connection con = new Connection())
            {
                var Filter = con.tblClient
                    .Where(c => c.ClientRut.Contains(search) || c.ClientName.Contains(search) || c.ClientFatherLastName.Contains(search))
                    .ToList();

                Clients_List_Load(Filter);
            }
        }

        private void lv_Clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_AddToList.Enabled = true;
        }

        private void btn_AddToList_Click(object sender, EventArgs e)
        {
            int client_id = Convert.ToInt32(lv_Clients.SelectedItems[0].Text);
            using (Connection con = new Connection()) {
                var Client_To_List = con.tblClient.Where(c => c.ClientID.Equals(client_id));

                foreach (var c in Client_To_List)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = c.ClientID.ToString();
                    lvi.SubItems.Add(c.ClientRut);
                    lvi.SubItems.Add(c.ClientFullName);
                    lvi.SubItems.Add(c.ClientEmail);
                    lvi.SubItems.Add(c.ClientPhone);

                    lvi.ForeColor = Color.WhiteSmoke;

                    lv_SelectedClients.Items.Add(lvi);
                }
            }

            
        }

        private void btn_AddMembership_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(num_MembershipCost.ToString()) ||
                String.IsNullOrEmpty(dt_DateBegin.ToString()) ||
                cb_PaymentMethod.SelectedIndex == -1 || cb_TypeMembership.SelectedIndex == -1 ||
                lv_SelectedClients.Items.Count == 0)
            {
                Error.SetError(btn_AddMembership, "Debe llenar todos los campos");
            }
            else 
            {
                
                foreach (ListViewItem c in lv_SelectedClients.Items)
                {
                    Members Membership = new Members();
                    Membership.MembershipDateBegin = dt_DateBegin.Value;
                    TypeMembership Type = (TypeMembership)cb_TypeMembership.SelectedItem;
                    Membership.TypeID = Type.TypeID;
                    PaymentMethod Payment = (PaymentMethod)cb_PaymentMethod.SelectedItem;
                    Membership.PaymentMethodID = Payment.PaymentMethodID;
                    Membership.MembershipCost = Convert.ToInt32(num_MembershipCost.Value);
                    Membership.UserID = userID;
                    Membership.ClientID = Convert.ToInt32(c.Text);
                    var Months = dt_DateBegin.Value;

                    switch (Type.TypeDesc) {
                        case "1 MES":
                            Membership.MembershipDateEnd = Months.AddMonths(1);
                            break;
                        case "3 MESES":
                            Membership.MembershipDateEnd = Months.AddMonths(3);
                            break;
                        case "12 MESES":
                            Membership.MembershipDateEnd = Months.AddMonths(12);
                            break;
                    }

                    using (Connection con = new Connection())
                    {
                        con.tblMembership.Add(Membership);
                        con.SaveChanges();
                        
                    }
                }
                SuccessMessage sm = new SuccessMessage();
                sm.ShowDialog();
            }
        }
    }
}
