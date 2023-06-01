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
    public partial class PURCHASE_FORM : Form
    {
        public PURCHASE_FORM()
        {
            InitializeComponent();
        }

        private void PURCHASE_FORM_Load(object sender, EventArgs e)
        {
            InfoDB.getMax();
            lblId.Text = InfoStorage.infoSet.furnitureId.ToString();
            tbxFurniture.Text = InfoStorage.infoSet.furnitureName;
            tbxPrice.Text = InfoStorage.infoSet.price.ToString();
        }

        private void btnPurback_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string[] columnName = { "CustomerID","Name","Address","PhoneNumber" };
            string[] data = { InfoStorage.infoSet.maxId.ToString() , tbxName.Text , tbxAddress.Text , tbxPhoneNumber.Text };
            string[] columnName1 = { "CustomerID", "FurnitureID", "Quantity", "Price", "Subtotal", "Order_Date" };
            string[] data1 = { InfoStorage.infoSet.maxId.ToString() , lblId.Text , tbxQuantity.Text , tbxPrice.Text , tbxSubtotal.Text };
            InfoDB.saveData("customer_info",columnName, data);
            InfoDB.saveData("order_detail", columnName1, data1);
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }

        private void tbxQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbxSubtotal.Text = (int.Parse(tbxPrice.Text) * int.Parse(tbxQuantity.Text)).ToString();
            }
            catch
            {

            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

