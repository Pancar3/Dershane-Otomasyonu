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
    public partial class form1 : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static DataSet ds;
        static SqlDataReader dr;
        public static string SqlCon = "Data Source=DESKTOP-CR6S4UH; Initial Catalog=Dershane; Integrated Security=True";
       
        public form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * from yonetici where username=@user and password=@pass";
                con = new SqlConnection(SqlCon);
                cmd = new SqlCommand(sorgu, con);
            con.Open();
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                
                Form2 form2 = new Form2();
                form2.Show();
                this.Visible = false;



            }
            else
            {
                MessageBox.Show("Giriş Başarısız Lütfen Tekrar Deneyiniz");
            }
            
            con.Close();

        }
    }
}
