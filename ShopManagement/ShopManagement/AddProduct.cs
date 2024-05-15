using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        Operations Op = new Operations();
        string query;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            query = "Insert INTO ProductTbl(ProdName, ProdBrand, ProdCat, ProdQty, ProdPrice) Values ('" + ProdNameTb.Text + "','" + BrandCb.SelectedItem.ToString() + "','"+CategoryCb.SelectedItem.ToString()+"','" + ProdQtyTb.Text + "','" + PriceTb.Text +"')";
            Op.insertdata(query);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }
    }
}
