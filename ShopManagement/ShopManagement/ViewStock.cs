using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ShopManagement
{
    public partial class ProdNameID : Form
    {
        public ProdNameID()
        {
            InitializeComponent();
        }
        Operations Op = new Operations();
        string myquery;
        private void GetProduct()
        {
            myquery = "select * from ProductTbl";
            var ds = Op.populate(myquery);
            ProductDGV.DataSource = ds.Tables[0];
        }
        private void ViewStock_Load(object sender, EventArgs e)
        {
            GetProduct();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                myquery = "Delete FROM ProductTbl where ID="+ProdIdTb.Text+";";
                Op.deleteProd(myquery);
                GetProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIdTb.Text = ProductDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTb.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdBrandCb.SelectedItem = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdCatCb.SelectedItem = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            ProdQtyTb.Text = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
            ProdPriceTb.Text = ProductDGV.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void clear()
        {
            ProdIdTb.Text = "";
            ProdNameTb.Text = "";
            ProdCatCb.Text = "";
            ProdBrandCb.Text= "";
            ProdQtyTb.Text = "";
            ProdPriceTb.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myquery = "UPDATE ProductTbl SET ProdName='"+ProdNameTb.Text+"'," +
                    "ProdBrand='"+ProdBrandCb.SelectedItem.ToString()+"'," +
                    "ProdCat='"+ProdCatCb.SelectedItem.ToString()+"'," +
                    "ProdQty="+ProdQtyTb.Text+"," +
                    "ProdPrice="+ProdPriceTb.Text+" " +
                    "where ID="+ProdIdTb.Text+";";
                   
                Op.updateProd(myquery);
                GetProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }
    }
}
