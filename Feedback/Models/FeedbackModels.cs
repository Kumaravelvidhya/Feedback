using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Feedback.Models
{
    
    
        public class FeedbackModel
        {
             public int Customerid { get; set; }
            public string Customername { get; set; }
            public string Comments {get; set; }
            public string ProductName { get; set; }
           public int Rating { get; set; }
           public string Createddate { get; set; }
        }
    
}
