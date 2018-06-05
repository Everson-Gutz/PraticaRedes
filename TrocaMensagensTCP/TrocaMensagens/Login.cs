using System;
using System.Windows.Forms;

namespace TrocaMensagens
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Configuration.UserId = txbUser.Text;
            Configuration.Password = txbPassword.Text;

            Hide();
            var form2 = new frmTrocaMensagens();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }
    }
}
