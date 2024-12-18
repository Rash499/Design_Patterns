//----------------------------------------------------------------------------------------------------------------------------

//Encapsulation

//----------------------------------------------------------------------------------------------------------------------------

/*
using ConsoleApp1.src.OOP.Encapsulation;

BankAccount bankaccount = new BankAccount(100); //create a new object

System.Console.WriteLine(bankaccount.GetBalance()); //using getbalance function for access the private data members

bankaccount.Deposit(50); //call the deposit function
System.Console.WriteLine(bankaccount.GetBalance());

bankaccount.Withdraw(100); //call the withraw function
System.Console.WriteLine(bankaccount.GetBalance()); */

//----------------------------------------------------------------------------------------------------------------------------

//Abstraction

//----------------------------------------------------------------------------------------------------------------------------

/*
using ConsoleApp1.src.OOP.Abstraction;

EmailService emailservice = new EmailService();
emailservice.SendEmail();  

//Inheritance [is-a]

using ConsoleApp1.src.OOP.Inheritance;

var Car = new Car();
Car.NumberofDoors = 4;
Car.Brand = "Ford";
Car.start();
Car.stop();   */

//----------------------------------------------------------------------------------------------------------------------------

//Polymorphism

//----------------------------------------------------------------------------------------------------------------------------
/*
using ConsoleApp1.src.OOP.Polymorphism;

List<Vehicle> vehicle = new List<Vehicle>();

vehicle.Add(new Car { Brand="Toyota", Model="Camry", Year=2020, NumberofDoors=4, NumberofWheels=4 });
vehicle.Add(new Bike{ Brand="Honda", Model="ct-100", Year=2000, NumberofWheels=2 });

foreach (var vehicle1 in vehicle){
    vehicle1.start();
} 
*/
//----------------------------------------------------------------------------------------------------------------------------

//Coupling

//----------------------------------------------------------------------------------------------------------------------------

/*
using ConsoleApp1.src.OOP.Coupling;

var order = new Order(new EmailSender());
order.PlaceOrder();  
*/
//----------------------------------------------------------------------------------------------------------------------------

//Composition [has-a]

//----------------------------------------------------------------------------------------------------------------------------

/*
using ConsoleApp1.src.OOP.Composition;

var car = new Car();
car.StartCar();  */

//----------------------------------------------------------------------------------------------------------------------------

//SOLID PRINCIPLES 
//Single Resposibility Principle (SRP)

//A class should have only one reason to change, meaning that it should have only one responsibility or purpose

//----------------------------------------------------------------------------------------------------------------------------
/*
using ConsoleApp1.src.SOLID.Single_Responsibility_Principle;

var user = new User{
    Username = "Rashmika Dilmin",
    Email = "rashmikadilmin@gmail.com"
};
var userser = new UserService();
userser.Register(user); */

//----------------------------------------------------------------------------------------------------------------------------

//Open/Colse Principle (OCP)

//Software entities (classes, modules, functions, etc..) should be open for extension but closed for modification.

//----------------------------------------------------------------------------------------------------------------------------


//----------------------------------------------------------------------------------------------------------------------------

//Liskov Substitution Principle (LSP)

//Objects of a superclass should be replaceable with objects of its subclass without affecting the correctness
//of the program

//----------------------------------------------------------------------------------------------------------------------------


using ConsoleApp1.src.SOLID.Liskov_Substitution_Principle;

var rect = new Rectangle();
rect.Width = 32;
rect.Height = 45;

System.Console.WriteLine("Area: "+ rect.Area +"\n");

var sqr = new Square();
sqr.SideLength = 20;

System.Console.WriteLine("Area: " + sqr.Area);