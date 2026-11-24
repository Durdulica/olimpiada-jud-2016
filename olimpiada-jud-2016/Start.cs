using System.Windows.Forms;

namespace olimpiada_jud_2016
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnAutentificare_Click(object sender, System.EventArgs e)
        {
            Autentificare_client autentificare_Client = new Autentificare_client();
            Hide();
            autentificare_Client.ShowDialog();
        }

        private void btnInregistrare_Click(object sender, System.EventArgs e)
        {
            Creare_Cont_Client creare_Cont_Client = new Creare_Cont_Client();
            Hide();
            creare_Cont_Client.ShowDialog();
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
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
