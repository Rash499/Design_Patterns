﻿//----------------------------------------------------------------------------------------------------------------------------

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
/*

using ConsoleApp1.src.SOLID.Liskov_Substitution_Principle;

var rect = new Rectangle();
rect.Width = 32;
rect.Height = 45;

System.Console.WriteLine("Area: "+ rect.Area +"\n");

var sqr = new Square();
sqr.SideLength = 20;

System.Console.WriteLine("Area: " + sqr.Area); */

//----------------------------------------------------------------------------------------------------------------------------

//Interface Segregation principle (ISP)

//Clients should not be forced to depend on interfaces they do not use

//----------------------------------------------------------------------------------------------------------------------------

/*
using ConsoleApp1.src.SOLID.Interface_Segregation_Principle;

var circle = new Circle();
circle.Radius = 10;

System.Console.WriteLine(circle.Area());  */

//----------------------------------------------------------------------------------------------------------------------------

//Dependency Inversion Principle (DIP)

//High level modules should not depend on low level modules, Both should depend on abstractions

//----------------------------------------------------------------------------------------------------------------------------

/*
using ConsoleApp1.src.SOLID.Dependency_Inversion_Principle;

var car = new Car(new Engine()); //dependecy injection
car.StartCar(); */

//----------------------------------------------------------------------------------------------------------------------------


//Design Patterns


//----------------------------------------------------------------------------------------------------------------------------



//----------------------------------------------------------------------------------------------------------------------------


//Behavioral Design Patterns
//Memento Pattern

//----------------------------------------------------------------------------------------------------------------------------


//Behavioral design patterns focus on how objects interct with each other and how they communicate 
//to accomplish specific tasks. These patterns address communication, responsibility, and algorithmic 
//issues in OO software design. They help in defining clear and efficient communication mechanisms between
//objects and classes.

using ConsoleApp1.src.Design_Patterns.Behavioral.Memento_Pattern;

var editor = new Editor();
var history = new History(editor);
history.BackUp();
editor.Title = "Test";
history.BackUp();
editor.Content = "This is test for memento";
history.BackUp();
editor.Title = "The life of a dev: my mementos";

System.Console.WriteLine("Title: " + editor.Title);
System.Console.WriteLine("Content: " + editor.Content);

history.Undo();

System.Console.WriteLine("Title: " + editor.Title);
System.Console.WriteLine("Content: " + editor.Content);

history.ShowHistory();

history.Undo();

System.Console.WriteLine("Title: " + editor.Title);
System.Console.WriteLine("Content: " + editor.Content);
