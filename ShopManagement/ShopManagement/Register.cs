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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.OleDb.4.0;" +
        @"Data Source=C:\Users\Boss\Desktop\Code\C#\ShopManagement\DatabaseShop.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTb.Text == "" || PasswordTb.Text == "" || ConPasswordTb.Text == "")
            {
                MessageBox.Show("กรอกข้อมูลให้ครบ.");
            }
            else if (PasswordTb.Text == ConPasswordTb.Text)
            {
                try
                {
                    con.Open();
                    string register = "INSERT INTO tbl_username (username, [password]) VALUES ('" + UidTb.Text + "','" + PasswordTb.Text + "')";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ลงทะเบียนสำเร็จ");

                    UidTb.Text = "";
                    PasswordTb.Text = "";
                    ConPasswordTb.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("รหัสไม่เหมือนกัน, กรุณาลองใหม่");
                UidTb.Text = "";
                ConPasswordTb.Text = "";
                PasswordTb.Focus();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
