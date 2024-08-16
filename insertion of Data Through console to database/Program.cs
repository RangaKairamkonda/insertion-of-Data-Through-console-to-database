using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace insertion_of_Data_Through_console_to_database
{
   public class Program
    {

        class variables
        {
            public string sname;
            public decimal salary;
            public long phno;

            public void insert(string sname, decimal salary, long phno)
            {
                SqlConnection con = new SqlConnection("user id=sa;pwd=123;database=happy;Data source=.");
                SqlCommand cmd = new SqlCommand("proc_student_insert", con);
                cmd.Parameters.AddWithValue("@sname", sname);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@phno", phno);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


            }
        }
        static void Main(string[] args)
        {
            variables vb = new variables();
            Console.Write("Enter name:");
            vb.sname = Console.ReadLine();
            Console.Write("Enter salary");
            vb.salary = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter phno");
            vb.phno = Convert.ToInt64(Console.ReadLine());
            vb.insert(vb.sname,vb.salary,vb.phno);
            Console.ReadLine();

            
        }
    }
}
