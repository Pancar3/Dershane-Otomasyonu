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
    public partial class sınıflar : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = "Data Source=DESKTOP-CR6S4UH; Initial Catalog=Dershane; Integrated Security=True";

        public sınıflar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Class1.GridDoldur(dataGridView1, "Select * from student1 where sinif='" + textBox1.Text + "' AND sube='" + textBox2.Text + "' ");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Visible = true;
            this.Close();
        }
    }
}
