using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dershane_Otomat
{
    public partial class öğretmenler : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = "Data Source=DESKTOP-CR6S4UH; Initial Catalog=Dershane; Integrated Security=True";
        public öğretmenler()
        {
            InitializeComponent();
            Class1.GridDoldur(dataGridView1, "Select * from ogretmen");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO ogretmen(ogretmenisim,ogretmennumara,oğretmenmaas,brans) values (@name,@num,@maas,@brans)";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@num", textBox2.Text);
            cmd.Parameters.AddWithValue("@maas", textBox3.Text);
            cmd.Parameters.AddWithValue("@brans", textBox4.Text);
            

            cmd.ExecuteNonQuery();
            Class1.GridDoldur(dataGridView1, "Select * from ogretmen ");
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE from [ogretmen] where ogretmenID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            Class1.GridDoldur(dataGridView1, "Select * from ogretmen ");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE ogretmen SET oğretmenmaas=@payy where ogretmenID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@payy", textBox5.Text);
            cmd.ExecuteNonQuery();
            Class1.GridDoldur(dataGridView1, "Select * from ogretmen ");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE ogretmen SET ogretmennumara=@payy where ogretmenID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@payy", textBox6.Text);
            cmd.ExecuteNonQuery();
            Class1.GridDoldur(dataGridView1, "Select * from ogretmen ");
            con.Close();
        }
    }
}
