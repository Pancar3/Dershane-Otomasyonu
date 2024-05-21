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
    public partial class öğrenciler: Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = "Data Source=DESKTOP-CR6S4UH; Initial Catalog=Dershane; Integrated Security=True";
        public öğrenciler()
        {
            InitializeComponent();
            Class1.GridDoldur(dataGridView1, "Select * from Student1 ");
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Visible = true;
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) {

            string sorgu = "INSERT INTO Student1(studentname,number,sinif,sube,debt,payyed) values (@name,@num,@sinif,@sube,@debt,@payy)";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@num", textBox2.Text);
            cmd.Parameters.AddWithValue("@sinif", textBox3.Text);
            cmd.Parameters.AddWithValue("@sube", textBox4.Text);
            cmd.Parameters.AddWithValue("@debt", textBox5.Text);
            cmd.Parameters.AddWithValue("@payy", textBox6.Text);
            
            cmd.ExecuteNonQuery();
            Class1.GridDoldur(dataGridView1, "Select * from Student1 ");
            con.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE from [Student1] where studentID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            Class1.GridDoldur(dataGridView1, "Select * from Student1 ");
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlCon);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Student1 SET payyed=@payy where studentID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@payy", textBox7.Text);
            cmd.ExecuteNonQuery();
            Class1.GridDoldur(dataGridView1, "Select * from Student1 ");
            con.Close();

        }
    }
}
