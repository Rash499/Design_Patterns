using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.SOLID.Single_Responsibility_Principle{
    public class User{
        public required string Username { get; set; }

        public required string Email { get; set; }

    /*
    public void Register(){
        //register user logic..

        //Send email
        EmailSender emailsender = new EmailSender();
        emailsender.SendEmail("Welcome to our platform!",Email);
    }
    */  
    }
}


//user class contain the user data and also register logic that means it's vioalating the SRP.
//To fix this issue use a seperate calss for registrations