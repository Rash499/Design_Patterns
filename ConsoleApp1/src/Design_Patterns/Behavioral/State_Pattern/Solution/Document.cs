using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.SOLID.Single_Responsibility_Principle;

namespace ConsoleApp1.src.Design_Patterns.State_Pattern.Solution{
    public class Document{
        public State State {get; set;}
        public UserRoles CurrentUserRoles {get; set;}

        public Document(UserRoles currentUserRole){
            State = new DraftState(this);
            CurrentUserRoles = currentUserRole;
        }

        public void Publish(){
            State.Publish();
        }

    }
}