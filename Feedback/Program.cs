using System;
using Dapper;
using System.Data.SqlClient;
using Feedback.Repository;
using Feedbacks.Business;
using Feedback.Models;
using Feedback.Repository;


namespace Feedback
{
    class Program
    {
        static void Main(string[] args)
        {
            Menucs obj = new Menucs();
            obj.Dowhilemenu();
        }
    }
}
