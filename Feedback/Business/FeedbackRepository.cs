using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using iv= Feedback.Models;



namespace Feedbacks.Business
{
     public class FeedbackRepository
     {
            public readonly string connectionString;



            public FeedbackRepository ()
            {
                connectionString = @"Data source=ANIYAAN-1006;Initial catalog=Feedback;User Id=Anaiyaan;Password=Anaiyaan@123";
            }


        public iv.Feedback method()
        {
            iv.Feedback obj1 = new iv.Feedback();
            Console.WriteLine("Enter CustomerName");
            obj1.Customername = Console.ReadLine();
            Console.WriteLine("Enter Comments");
            obj1.Comments = Console.ReadLine();
            Console.WriteLine("Enter Product");
            obj1.ProductName = Console.ReadLine();
            Console.WriteLine("Enetr Rating");
            obj1.Rating = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr date");
            obj1.Createddate = Console.ReadLine();
            return obj1;

        }
        public void insert(iv.Feedback a)
        {
                try
                {

                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();
                    con.Execute($"exec insertFeedback '{a.Customername}','{a.Comments}','{a.ProductName}',{a.Rating},'{a.Createddate}' ");



                    con.Close();

                }
                catch (SqlException e)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }
            public List<iv.Feedback> Select()
            {
                try
                {
                    List<iv.Feedback> con = new List<iv.Feedback>();

                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();
                    con = connection.Query<iv.Feedback>("exec selectFeedback; ", connectionString).ToList();

                    // con = connection.Query<details>("exec selectFeedback").ToList();
                    connection.Close();

                    foreach (var constrai in con)
                    {
                        Console.WriteLine($"Customername ->{constrai.Customername}      Comments ->{constrai.Comments}   ProductName ->{constrai.ProductName}   Rating ->{constrai.Rating}  date ->{constrai.Createddate} ");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");

                    }

                    return con;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


     }
    
}
