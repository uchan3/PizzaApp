using System;
using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Recipes;

namespace PizzaBox.Domain.Models
{
    public class Order
    {
      //Properties. 
 
    public List<string> PizzaName {get; set;} //Test String
      //Methods. 
    
    //public List<APizzaMaker> Pizzas { get; set; } 
    //public List<string> PizzaComponents {get; set;}

    public List<List<string>> PizzaComponents1 {get; set;}

    public decimal Price { get; set; }

    public DateTime OrderDate()
    {
      return DateTime.Now;
    }
    
    public void MakeOrderDecision()
    {
       //PizzaName = this.PizzaName;
       PizzaName = new List<string>(); //Need to instantiate PizzaName. 
       //PizzaComponents1 = this.PizzaComponents1;
       PizzaComponents1 = new List<List<string>>(); //Instantiation needed. 
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
             //OrderList.PizzaName.Add(NewYorkS);
             PizzaName.Add(NewYorkS);
             //OrderList.PizzaComponents1.Add(PizzaTemporary.ConvertAll(x => Convert.ToString(x)));
             PizzaComponents1.Add(PizzaTemporary.ConvertAll(x => Convert.ToString(x)));
        //     PizzaString.Add(MakeNewYork1());
        //     Component.AddRange(List); 
        //     //PizzaList.Pizzas.Add(new PizzaTemp);
             PizzaTemporary.Clear();
             //Count = OrderList.PizzaName.Count();
             
             Count = PizzaName.Count; //Need to remove () in Count. This allows the method access operator. 
             Console.WriteLine("You ordered " + Count + " Pizza");
             
             if(Console.ReadKey().Key == ConsoleKey.Tab)
               {
               Console.WriteLine("\n");
               break;
               }
           } 
        // } 
             //Console.WriteLine("There are " + OrderList.PizzaComponents1.Count() + " sublists.");
             Console.WriteLine("There are " + PizzaComponents1.Count + " sublists.");
             //Console.WriteLine("There are " + OrderList.PizzaName.Count() + " pizzas.");
             Console.WriteLine("There are " + PizzaName.Count + " pizzas.");

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
              
              int Index;
              //int SubIndex;
              //int Count1 = OrderList.PizzaName.Count();
              int Count1 = PizzaName.Count;
              for (Index = 0; Index<Count1; Index++) //Use this to avoid out of index ranges. 
              {
                Console.WriteLine(PizzaName[Index]);
                foreach(var comp in PizzaComponents1[Index]) //Loop through each "sublist" in the specified list.
                {
                  Console.WriteLine(comp.ToString());
                };
               }
    }
    }
    
}
    

