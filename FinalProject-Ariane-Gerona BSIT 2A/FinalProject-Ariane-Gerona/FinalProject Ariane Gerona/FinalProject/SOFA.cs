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
    public partial class SOFA : Form
    {
        public SOFA()
        {
            InitializeComponent();
        }

        private void btnSback_Click(object sender, EventArgs e)
        {
            this.Close();
           Form2 back = new Form2();
            back.Show();
        }

        private void btnPurchasesofa_Click(object sender, EventArgs e)
        {
            this.Hide();
            PURCHASE_FORM form = new PURCHASE_FORM();
            this.Hide();
            form.Show();
        }

        private void SOFA_Load(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("SOFA", 1.ToString(), dgvSofa);
        }

        private void dgvSofa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InfoStorage.infoSet.furnitureId = int.Parse(dgvSofa.Rows[e.RowIndex].Cells[0].Value.ToString());
            InfoStorage.infoSet.furnitureName = dgvSofa.Rows[e.RowIndex].Cells[2].Value.ToString();
            InfoStorage.infoSet.price = int.Parse(dgvSofa.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void btnClearsofa_Click(object sender, EventArgs e)
        {
        }

        private void btnSearchsofa_Click(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("Sofas" , tbxSearchsofa.Text , dgvSofa);
        }
    }
}
