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
    public partial class ORDER_DETAIL : Form
    {
        public ORDER_DETAIL()
        {
            InitializeComponent();
        }

        private void btnBackdetail_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }

        private void ORDER_DETAIL_Load(object sender, EventArgs e)
        {
             InfoDB.dgvViewing("ord", dgvOrderdetail);
        }


        private void btnPaid_Click(object sender, EventArgs e)
        {
            InfoDB.updateData(Convert.ToInt32( lblId.Text));
            InfoDB.dgvViewing("ord", dgvOrderdetail);
        }

        private void btnSearchdetail_Click(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("order" , tbxOrderdetail.Text , dgvOrderdetail);
        }

        private void btnViewdetail_Click(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("ord", dgvOrderdetail);
        }

        private void dgvOrderdetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            lblId.Text = (dgvOrderdetail.Rows[e.RowIndex].Cells[0].Value.ToString());

        }
    }
}
