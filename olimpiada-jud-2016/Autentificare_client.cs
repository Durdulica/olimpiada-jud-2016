using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olimpiada_jud_2016
{
    public partial class Autentificare_client : Form
    {
        public Autentificare_client()
        {
            InitializeComponent();
        }

        private void Autentificare_client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnIntra_Click(object sender, EventArgs e)
        {
            //txtEmail.Text txtParola.Text
            MessageBox.Show("Eroare autentificare!", "Autentificare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtEmail.Text = string.Empty;
            txtParola.Text = string.Empty;
            txtEmail.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
