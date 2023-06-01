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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void btnSofa_Click(object sender, EventArgs e)
        {
            SOFA furniture = new SOFA();
            furniture.Show();
            this.Hide();
        }

        private void btnBed_Click(object sender, EventArgs e)
        {
            BED furniture = new BED();
            furniture.Show();
            this.Hide();
        }

        private void btnCabinet_Click(object sender, EventArgs e)
        {
            CABINET furniture = new CABINET();
            furniture.Show();
            this.Hide();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            TABLE furniture = new TABLE();
            furniture.Show();
            this.Hide();
        }

        private void btnChair_Click(object sender, EventArgs e)
        {
            CHAIR furniture = new CHAIR();
            furniture.Show();
            this.Hide();
        }

       

        private void btnView_Click(object sender, EventArgs e)
        {
            ORDER_DETAIL furniture = new ORDER_DETAIL();
            furniture.Show();
            this.Hide();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            CONTACT furniture = new CONTACT();
            furniture.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }
    }
}
