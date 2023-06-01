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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            bool checker = InfoDB.GetAdminPassword(txtUsername, txtPassword);

            if (checker)
            {
                Form2 login = new Form2();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("LOG IN FAILED");
            }
        }
        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            CreateAccountForm createAccount = new CreateAccountForm();
            createAccount.Show();
            this.Hide();

        }

       
    }
    }

    