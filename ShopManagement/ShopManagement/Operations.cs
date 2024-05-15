using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    internal class Operations
    {
        protected OleDbConnection getCon()
        {
        OleDbConnection Con = new OleDbConnection("Provider=Microsoft.jet.OleDb.4.0;" +
        @"Data Source=C:\Users\Boss\Desktop\Code\C#\ShopManagement\DatabaseShop.mdb");
       
            return Con;
        }
        public void insertdata(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("สินค้าถูกเพิ่มสำเร็จ");
            Con.Close();
        }
        public void deleteProd(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("สินค้าถูกลบสำเร็จ");
            Con.Close();
        }

        public void updateProd(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("สินค้าอัพเดทสำเร็จ");
            Con.Close();
        }

        public void EditProd(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("สินค้าอัพเดทสำเร็จ");
            Con.Close();
        }
        //display DataGridView
        public DataSet populate(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = Con;
            cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
