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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection yeni = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\user\\Desktop\\10-M\\Kütüphane\\Veri Tabanı.mdb");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeni.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Kullanıcı_Adı",yeni);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
            yeni.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }
    }
}
