using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Dershane_Otomat
{
    
    class Class1
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static System.Data.DataSet ds;
        public static string SqlCon = "Data Source=DESKTOP-CR6S4UH;Initial Catalog=Dershane;Integrated Security=True";

        
        public static void ogrencikayit(string sqlkomut)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sqlkomut, con);
            ds = new System.Data.DataSet();
            con.Open();
            cmd = new SqlCommand(sqlkomut, con);
            cmd.ExecuteNonQuery(); 
            con.Close();



        }


        public static DataGridView GridDoldur(DataGridView gridim, String sqlselectsorgu)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sqlselectsorgu, con);
            ds = new System.Data.DataSet();
            con.Open();
            da.Fill(ds, sqlselectsorgu);
            gridim.DataSource = ds.Tables[sqlselectsorgu];
            con.Close();
            return gridim;
        }

     

        
       
    }
}
