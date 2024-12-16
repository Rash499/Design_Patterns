using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.SOLID.Single_Responsibility_Principle{
    public class EmailSender{
        public void SendEmail(string message, string recipient){
            Console.WriteLine($"Sending email to {recipient}: {message}");
            
        }
    }
}