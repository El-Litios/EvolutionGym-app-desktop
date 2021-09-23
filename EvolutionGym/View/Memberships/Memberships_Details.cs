using EvolutionGym.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvolutionGym.View.Memberships
{
    public partial class Memberships_Details : Form
    {
        Members _m;
        public Memberships_Details(Members m)
        {
            InitializeComponent();
            _m = m;
            lbl_ClientRut.Text = _m.Client.ClientRut;
            lbl_ClientFullName.Text = _m.Client.ClientFullName;
            lbl_TrainerRut.Text = _m.User.UserRut;
            lbl_TrainerFullName.Text = _m.User.UserFullName;
            lbl_MembershipCost.Text = _m.MembershipCost.ToString();
            lbl_PaymentMethod.Text = _m.Payment.MethodDesc;
            lbl_MembershipDateBegin.Text = String.Format("{0:MM/dd/yyyy}", _m.MembershipDateBegin);
            lbl_MembershipDateEnd.Text = String.Format("{0:MM/dd/yyyy}", _m.MembershipDateEnd);
            lbl_TypeMembership.Text = _m.Type.TypeDesc;
        }
    }
}
