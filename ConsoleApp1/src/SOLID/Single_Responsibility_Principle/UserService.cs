using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.SOLID.Single_Responsibility_Principle{
    public class UserService{
         public void Register(User user){ //pass the user to the register method in Users class
            //register user logic..

            //Send email
            EmailSender emailsender = new EmailSender();
            emailsender.SendEmail("Welcome to our platform!",user.Email);
    }
    }
}