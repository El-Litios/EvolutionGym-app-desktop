using EvolutionGym.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvolutionGym.View.Clients
{
    public partial class Clients_Edit : Form
    {
        private Client _c;
        public Clients_Edit(Client c)
        {
            InitializeComponent();
            _c = c;
            tb_Rut.Text = _c.ClientRut;
            tb_Name.Text = _c.ClientName;
            tb_FatherLastName.Text = _c.ClientFatherLastName;
            tb_MotherLastName.Text = _c.ClientMotherLastName;
            tb_Email.Text = _c.ClientEmail;
            tb_Cellphone.Text = _c.ClientPhone;
        }

        private void btn_EditClient_Click(object sender, EventArgs e)
        {
            if (
                String.IsNullOrEmpty(tb_Rut.Text) ||
                String.IsNullOrEmpty(tb_Name.Text) ||
                String.IsNullOrEmpty(tb_FatherLastName.Text) ||
                String.IsNullOrEmpty(tb_MotherLastName.Text) ||
                String.IsNullOrEmpty(tb_Email.Text) ||
                String.IsNullOrEmpty(tb_Cellphone.Text)
               )
            {
                Error_Message.SetError(btn_EditClient, "Debe llenar todos los campos.");
            }
            else 
            {
                _c.ClientRut = tb_Rut.Text;
                _c.ClientName = tb_Name.Text;
                _c.ClientFatherLastName = tb_FatherLastName.Text;
                _c.ClientMotherLastName = tb_MotherLastName.Text;
                _c.ClientEmail = tb_Email.Text;
                _c.ClientPhone = tb_Cellphone.Text;

                using (Connection con = new Connection()) 
                {
                    con.Entry(_c).State = EntityState.Modified;
                    con.SaveChanges();

                    SuccessMessage sm = new SuccessMessage();
                    sm.ShowDialog();
                    this.Dispose();
                }
            }
        }
    }
}
