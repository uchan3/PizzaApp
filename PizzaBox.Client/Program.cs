using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Recipes;
using System.Linq;

namespace PizzaBox.Client
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //1. Sign-In
            // Console.WriteLine("Enter the User ID.");
            // User UserID = new User();
            // UserID.UserID = Console.ReadLine();
            // SignIn(UserID); 

            //2. Select from list of locations.
            // Address Input = new Address();
            // Console.WriteLine("Enter the state.");
            // Input.StateProvince = Console.ReadLine();
            // Console.WriteLine("Enter the city.");
            // Input.City = Console.ReadLine();
            // Console.WriteLine("Enter the street.");
            // Input.Street = Console.ReadLine();
            // selectLocation(Input);

            //3. Create order. 
            // Console.WriteLine("Let's create a new order.");
            // //Order OrderList = new Order() {PizzaName = new List<string>(), PizzaComponents1 = new List<List<string>>() };
            // Order OrderTest = new Order();
            // OrderTest.MakeOrderDecision();
            
/*             //List<AComponent> PizzaTemp = new List<AComponent>();

            //Testing Code
            Console.WriteLine("Press <Enter> to start order. When you are done, press <Tab> to finish order.");
            
            int Count = 1;
            while (Console.ReadKey().Key != ConsoleKey.Tab || Count <=100)
           {
             List<AComponent> PizzaTemporary  = new List<AComponent>(); //Initialize temporary list of components.

             //Topping Information.
             Console.WriteLine("Please select two to five toppings. Press <Escape> when done.");
             List<Topping> TInput = new List<Topping> ();
             while (Console.ReadKey().Key != ConsoleKey.Escape)
             {
               string ReadTopping = Console.ReadLine();
               Topping ToppingInput = new Topping(ReadTopping);
               TInput.Add(ToppingInput);
               if(TInput.Count>=2 && TInput.Count<=5) //Condition to check # Toppings. 
                 {
                 Console.WriteLine("The number of toppings is in Range.");
                 }
               else if(TInput.Count == 1)
                 {
                 Console.WriteLine("Please select at least one more topping.");
                 }
               else
                 {
                 Console.WriteLine("You have reached the maximum number of toppings.");
                 }              
              }

             //Size information.  
             Console.WriteLine("\n Select the size.");
             string SizeInput = Console.ReadLine();
             Size SizeMake = new Size(SizeInput);
             
             //Make pizza!
             NewYork NY1 = new NewYork();
             PizzaTemporary = NY1.Make(SizeMake, TInput);
             string NewYorkS = NY1.ToString();
             //var List = MakeNewYork(SizeMake, TInput); 
             //MakeNewYork1();
             
             PizzaTemporary.ToString();
             OrderList.PizzaName.Add(NewYorkS);
             OrderList.PizzaComponents1.Add(PizzaTemporary.ConvertAll(x => Convert.ToString(x)));
        //     PizzaString.Add(MakeNewYork1());
        //     Component.AddRange(List); 
        //     //PizzaList.Pizzas.Add(new PizzaTemp);
             PizzaTemporary.Clear();
             Count = OrderList.PizzaName.Count();
             Console.WriteLine("You ordered " + Count + " Pizza");
             
             if(Console.ReadKey().Key == ConsoleKey.Tab)
               {
               Console.WriteLine("\n");
               break;
               }
           } 
        // } 
             Console.WriteLine("There are " + OrderList.PizzaComponents1.Count() + " sublists.");
             Console.WriteLine("There are " + OrderList.PizzaName.Count() + " pizzas.");

/*              foreach(var Pizza in OrderList.PizzaName) //Loop through the list of pizza names. 
             {
               Console.WriteLine(Pizza);
                foreach(var PizzaTemporary in OrderList.PizzaComponents1) //Loop through each "sublist" in the nested lists of components.
               {
                 foreach(var comp in PizzaTemporary) //Loop through each component in the sublist.
                 {
                   Console.WriteLine(comp.ToString());
                 }  
               }
             } */
              
            /*   int Index;
              //int SubIndex;
              int Count1 = OrderList.PizzaName.Count();
              for (Index = 0; Index<Count1; Index++) //Use this to avoid out of index ranges. 
              {
                Console.WriteLine(OrderList.PizzaName[Index]);
                foreach(var comp in OrderList.PizzaComponents1[Index]) //Loop through each "sublist" in the specified list.
                {
                  Console.WriteLine(comp.ToString());
                };
               } */
            
            // ************This is the workking code. 
            // List<Topping> TopTemp = new List<Topping>() {new Topping("Ham"), new Topping("Pepperoni")};
            // Size Sizey = new Size("Small");

            // var NY1 = MakeNewYork(Sizey, TopTemp);
            // OrderList.PizzaName.Add(MakeNewYork1());
            // PizzaTemp.AddRange(NY1);
            
            // Console.WriteLine(OrderList.PizzaName[0]);
            // foreach (var comp in PizzaTemp)
            //  {
            //    Console.WriteLine(comp.ToString());
            //  } ***************End of the working code. 

        } 
    }
}


