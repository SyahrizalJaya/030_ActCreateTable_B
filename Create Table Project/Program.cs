using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Create_Table_Project
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-SVN0V6C;database=ProdiTI; Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Mahasiswa_Coba (NIM char(12) not null primary key, Nama varchar(50), Alamat varchar(255), Jenis_Kelamin char(1))",con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Table Sukses dibuat!!!");
                Console.ReadKey();
            }catch(Exception e)
            {
                Console.WriteLine("Oops, Sepertinya ada kesalahan. " + e);
                Console.ReadKey();
            }
            finally {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }
    }
}
