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
    public partial class CHAIR : Form
    {
        public CHAIR()
        {
            InitializeComponent();
        }

        private void btnChback_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }

        private void btnPurchasechair_Click(object sender, EventArgs e)
        {
            this.Hide();
            PURCHASE_FORM form = new PURCHASE_FORM();
            this.Hide();
            form.Show();
        }

        private void CHAIR_Load(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("CHAIR", 5.ToString(), dgvChair);
        }

        private void dgvChair_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InfoStorage.infoSet.furnitureId = int.Parse(dgvChair.Rows[e.RowIndex].Cells[0].Value.ToString());
            InfoStorage.infoSet.furnitureName = dgvChair.Rows[e.RowIndex].Cells[2].Value.ToString();
            InfoStorage.infoSet.price = int.Parse(dgvChair.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void dgvChair_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClearchair_Click(object sender, EventArgs e)
        {
        }

        private void btnSearchchair_Click(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("chairs" , tbxSearchchair.Text , dgvChair);
        }
    }
    
}
