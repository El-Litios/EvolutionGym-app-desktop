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
            
        }
    }
}
