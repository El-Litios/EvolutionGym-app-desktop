using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvolutionGym
{
    public partial class SuccessMessage : Form
    {
        public SuccessMessage()
        {
            InitializeComponent();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
