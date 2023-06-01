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
    public partial class CABINET : Form
    {
        public CABINET()
        {
            InitializeComponent();
        }

        private void btnCback_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }

        private void btnPurchasecabinet_Click(object sender, EventArgs e)
        {
            this.Hide();
            PURCHASE_FORM form = new PURCHASE_FORM();
            this.Hide();
            form.Show();
        }

        private void CABINET_Load(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("CABINET", 3.ToString(), dgvCabinet);
        }

        private void dgvCabinet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InfoStorage.infoSet.furnitureId = int.Parse(dgvCabinet.Rows[e.RowIndex].Cells[0].Value.ToString());
            InfoStorage.infoSet.furnitureName = dgvCabinet.Rows[e.RowIndex].Cells[2].Value.ToString();
            InfoStorage.infoSet.price = int.Parse(dgvCabinet.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void btnClearcabinet_Click(object sender, EventArgs e)
        {
        }

        private void btnSearchcabinet_Click(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("cabinets", tbxSearchcabinet.Text, dgvCabinet);
        }
    }
    
}
