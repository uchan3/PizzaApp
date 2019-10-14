using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Recipes;

namespace PizzaBox.Client
{
    partial class Program
    {
      //Validate SignIn. 
        // static void SignIn(User First)
        // {
        //   string Result;
        //   //User Customer = new User();
        //   Account VerifyAccount = new Account();
        //   Result = VerifyAccount.CheckAccountExist(First);
        //   Console.WriteLine(Result);
        // }
      //Select Location. 
      //  static void selectLocation(Address Input)
      //   {
      //     string Output;
      //     Output = Input.CheckLocationID(Input);
      //     Console.WriteLine(Output);
      //   }
      //Select Recipe. 
      //  static List<AComponent> MakeNewYork(Size SizeInput, List<Topping> ToppingInput )
      //   {
      //     var NY1 = new NewYork();
      //     List<AComponent> ComponentList = new List<AComponent>();
      //     string StringTest;
      //     ComponentList = NY1.Make(SizeInput, ToppingInput);
      //     StringTest = NY1.ToString();
      //     return ComponentList;
          
      //   } 

      //  static string MakeNewYork1()
      //   {
      //     var NY1 = new NewYork();
      //     return NY1.ToString();
      //   }

      //Customize recipe with size and toppings.   
        // static void Decision(List<AComponent> Component, List<string> PizzaString)
        // {
        //   int Count = 1;
        //   Console.WriteLine("Press <Enter> to start order. When you are done, press <Tab> to finish order.");

        //   while (Console.ReadKey().Key != ConsoleKey.Tab || Count <=100)
        //   {

        //     Console.WriteLine("Please select two to five toppings. Press <Escape> when done.");
        //     List<Topping> TInput = new List<Topping> ();
        //     while (Console.ReadKey().Key != ConsoleKey.Escape)
        //     {
        //       string ReadTopping = Console.ReadLine();
        //       Topping ToppingInput = new Topping(ReadTopping);
        //       TInput.Add(ToppingInput);
        //       if(TInput.Count>=2 && TInput.Count<=5) //Condition to check # Toppings. 
        //         {
        //         Console.WriteLine("The number of toppings is in Range.");
        //         }
        //       else
        //         {
        //         Console.WriteLine("The number of toppings is out of range.");
        //         }              
        //       }
              
        //     Console.WriteLine("\n Select the size.");
        //     string SizeInput = Console.ReadLine();
        //     Size SizeMake = new Size(SizeInput);

        //     //List<APizzaMaker> PizzaTemp = new List<APizzaMaker>();
        //     var List = MakeNewYork(SizeMake, TInput); 
        //     //MakeNewYork1();
        //     PizzaString.Add(MakeNewYork1());
        //     Component.AddRange(List); 
        //     //PizzaList.Pizzas.Add(new PizzaTemp);
        //     Console.WriteLine("You ordered " + Count + " Pizza");
        //     Count = Count + 1;
        //     if(Console.ReadKey().Key == ConsoleKey.Tab)
        //       {
        //       break;
        //       }
        //   } 
        // } 
    }
}