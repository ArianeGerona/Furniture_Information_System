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
    public partial class TABLE : Form
    {
        public TABLE()
        {
            InitializeComponent();
        }

        private void btnTback_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }

        private void btnPurchasetable_Click(object sender, EventArgs e)
        {
            this.Hide();
            PURCHASE_FORM form = new PURCHASE_FORM();
            this.Hide();
            form.Show();
        }

        private void TABLE_Load(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("SOFA", 4.ToString(), dgvTable);
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InfoStorage.infoSet.furnitureId = int.Parse(dgvTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            InfoStorage.infoSet.furnitureName = dgvTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            InfoStorage.infoSet.price = int.Parse(dgvTable.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void btnCleartable_Click(object sender, EventArgs e)
        {
        }

        private void btnSearchtable_Click(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("Sofas" , tbxSearchtable.Text , dgvTable);
        }
    }
    
}
