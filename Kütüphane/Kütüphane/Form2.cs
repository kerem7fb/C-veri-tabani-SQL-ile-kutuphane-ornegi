using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Kütüphane
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection yeni = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\user\\Desktop\\10-M\\Kütüphane\\Veri Tabanı.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            yeni.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Ürünler", yeni);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
            yeni.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }
    }
}
