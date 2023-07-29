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
                connectionString = @"Data source=ANIYAAN-1006;Initial catalog=CustomerFeedback;User Id=Anaiyaan;Password=Anaiyaan@123";
            }


        public iv.FeedbackModel method()
        {
            iv.FeedbackModel obj1 = new iv.FeedbackModel();
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

        
        /*public IEnumerable<iv.FeedbackModel> GetAllregistration()
        {
            throw new NotImplementedException();
        }*/

        public void insert(iv.FeedbackModel a)
        {
                try
                {

                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();
                    con.Execute($"exec insertFeedback '{a.Customername}','{a.Comments}','{a.ProductName}',{a.Rating},'{Convert.ToDateTime(a.Createddate).ToString("MM-dd-yyyy")}' ");



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
       

        
            public List<iv.FeedbackModel> Select()
            {
                try
                {
                    List<iv.FeedbackModel> con = new List<iv.FeedbackModel>();

                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();
                    con = connection.Query<iv.FeedbackModel>("exec selectFeedback; ").ToList();

                    return con;

                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }




        public List<iv.FeedbackModel> Select(string Customername)
        {
            try
            {
                List<iv.FeedbackModel> con = new List<iv.FeedbackModel>();

                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                con = connection.Query<iv.FeedbackModel>($"exec selectFeedbackID {Customername}; ", connectionString).ToList();

               

                return con;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void deletesp(string Customerid)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);
                // Console.WriteLine("enter the first name to delete the whole record");        //dynamic value 
                // string del = Convert.ToString(Console.ReadLine());
                con.Open();

                con.Execute($"delete from Feedback where Customername ='{Customerid}' ");

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




       
        public void updatesp(iv.FeedbackModel e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                
                con.Open();
                con.Execute($" update Feedback set Customerid ='{e.Customerid}' where  ProductName='{e.ProductName}'");
                con.Close();

            }
            catch (SqlException )
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

   

}


