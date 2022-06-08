using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace library
{
    public class libraryM
    {
        public static string sqlConnect = @" Data Source=DESKTOP-F0DS2US\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";


        public string Book()
        {
            Console.Write("Enter Book Id: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book name: ");
            string BookName = Console.ReadLine();


            SqlConnection sqlConnection = new SqlConnection(sqlConnect);
            SqlCommand obj1 = new SqlCommand("insert into Books values(" + ID + ",'" + BookName + "')", sqlConnection);
            sqlConnection.Open();
            obj1.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
        }
        public string aurthor()
        {
            Console.Write("Enter Aurthor Id: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Aurthor name: ");
            string aurthorName = Console.ReadLine();


            SqlConnection sqlConnection = new SqlConnection(sqlConnect);
            SqlCommand obj1 = new SqlCommand("insert into Aurthor values(" + ID + ",'" + aurthorName + "')", sqlConnection);
            sqlConnection.Open();
            obj1.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
        }






    }
}
