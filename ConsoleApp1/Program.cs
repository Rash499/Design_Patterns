//Encapsulation
/*
using ConsoleApp1.src.OOP.Encapsulation;

BankAccount bankaccount = new BankAccount(100); //create a new object

System.Console.WriteLine(bankaccount.GetBalance()); //using getbalance function for access the private data members

bankaccount.Deposit(50); //call the deposit function
System.Console.WriteLine(bankaccount.GetBalance());

bankaccount.Withdraw(100); //call the withraw function
System.Console.WriteLine(bankaccount.GetBalance()); 

//Abstarction

using ConsoleApp1.src.OOP.Abstraction;

EmailService emailservice = new EmailService();
emailservice.SendEmail();  

//Inheritance

using ConsoleApp1.src.OOP.Inheritance;

var Car = new Car();
Car.NumberofDoors = 4;
Car.Brand = "Ford";
Car.start();
Car.stop(); 

//polymorphism
using ConsoleApp1.src.OOP.Polymorphism;

List<Vehicle> vehicle = new List<Vehicle>();

vehicle.Add(new Car { Brand="Toyota", Model="Camry", Year=2020, NumberofDoors=4, NumberofWheels=4 });
vehicle.Add(new Bike{ Brand="Honda", Model="ct-100", Year=2000, NumberofWheels=2 });

foreach (var vehicle1 in vehicle){
    vehicle1.start();
} */

//coupling

using ConsoleApp1.src.OOP.Coupling;

var order = new Order(new EmailSender());
order.PlaceOrder();




