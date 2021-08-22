using EvolutionGym.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvolutionGym.View.Clients
{
    public partial class Clients_Add : Form
    {
        public Clients_Add()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_AddClient_Click(object sender, EventArgs e)
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
                Error_Message.SetError(btn_AddClient, "Debe llenar todos los campos.");
            }
            else 
            {
                Client client = new Client();
                client.ClientRut = tb_Rut.Text;
                client.ClientName = tb_Name.Text;
                client.ClientFatherLastName = tb_FatherLastName.Text;
                client.ClientMotherLastName = tb_MotherLastName.Text;
                client.ClientEmail = tb_Email.Text;
                client.ClientPhone = tb_Cellphone.Text;

                using (Connection con = new Connection()) 
                {
                    con.tblClient.Add(client);
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
            tb_Email.Text = "";
            tb_Cellphone.Text = "";

        }

      
    }
}
