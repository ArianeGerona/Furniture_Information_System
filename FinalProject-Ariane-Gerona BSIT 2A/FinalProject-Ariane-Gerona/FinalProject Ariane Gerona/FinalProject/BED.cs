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
    public partial class BED : Form
    {
        public BED()
        {
            InitializeComponent();
        }

        private void btnBback_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }

        private void btnPurchasebed_Click(object sender, EventArgs e)
        {
            this.Hide();
            PURCHASE_FORM form = new PURCHASE_FORM();
            this.Hide();
            form.Show();
        }

        private void BED_Load(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("BED",2.ToString(), dgvBed);
        }

        private void dgvBed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InfoStorage.infoSet.furnitureId = int.Parse(dgvBed.Rows[e.RowIndex].Cells[0].Value.ToString());
            InfoStorage.infoSet.furnitureName = dgvBed.Rows[e.RowIndex].Cells[2].Value.ToString();
            InfoStorage.infoSet.price = int.Parse(dgvBed.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void btnClearbed_Click(object sender, EventArgs e)
        {
        }

        private void btnSearchbed_Click(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("beds", tbxSearchbed.Text, dgvBed);
        }
    }
    
}
