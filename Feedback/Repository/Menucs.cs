﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feedbacks.Business;

namespace Feedback.Repository
{
    class Menucs
    {
    
        public void Dowhilemenu()
        {
            int b;
            do
            {
                Console.WriteLine("Choose the option");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Insert");
                Console.WriteLine("2.Select");
                FeedbackRepository objcrud = new FeedbackRepository();

                b = Convert.ToInt32(Console.ReadLine());
                switch (b)
                {
                    case 1:

                        var add = objcrud.method();
                        objcrud.insert(add);

                        break;
                    case 2:

                        objcrud.Select();

                        break;
                    default:
                        Console.WriteLine("Please give a valid OPtion");
                        break;
                }

            } while (b != 0);

        }


    }
}
