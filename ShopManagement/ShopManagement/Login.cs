using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.OleDb.4.0;" +
        @"Data Source=C:\Users\Boss\Desktop\Code\C#\ShopManagement\DatabaseShop.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            if(UidTb.Text =="Admin" || PasswordTb.Text == "Pass")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            if (con.State == ConnectionState.Closed)
                con.Open();
            string login = "SELECT * FROM tbl_username WHERE username = '" + UidTb.Text + "'and password = '" + PasswordTb.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                new Selling().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ค้นห้าชื่อในระบบไม่เจอ");
                UidTb.Text = "";
                PasswordTb.Text = "";
                UidTb.Focus();
            }
            con.Close();
            
        }
 

        private void label3_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
