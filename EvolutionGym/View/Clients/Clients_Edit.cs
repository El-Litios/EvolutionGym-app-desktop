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
    }
}
