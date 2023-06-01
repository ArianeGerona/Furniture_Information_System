using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void btnPurback_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string[] columnName = { "username","password" };
            string[] data = { tbxName.Text , tbxPassword.Text };
            InfoDB.createAccount(columnName, data);
        }
    }
}
