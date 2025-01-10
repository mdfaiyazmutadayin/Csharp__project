using System;
using System.Windows.Forms;

namespace AutoDoc
{
    public partial class ContributorsForm : Form
    {
        public ContributorsForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }
    }
}
