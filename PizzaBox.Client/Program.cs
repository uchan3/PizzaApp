using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Recipes;
using System.Linq;

namespace PizzaBox.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
     
            var NewYork = new NewYork();
            Size NewYorkSize = new Size("Small");
            List<Topping> NewYorkTopping  = new List<Topping> ();
            NewYorkTopping.Add(new Topping("Cheese"));
            NewYorkTopping.Add(new Topping("Ham"));
            var NYStuff = NewYork.Make(NewYorkSize, NewYorkTopping);

            var Chicago  = new Chicago();
            Size ChicagoSize = new Size("Large");
            List<Topping> ChicagoTopping  = new List<Topping> ();
            ChicagoTopping.Add(new Topping("Pepperoni"));
            ChicagoTopping.Add(new Topping("Green Bell"));
            var ChicagoStuff = Chicago.Make(ChicagoSize, ChicagoTopping);

            Dictionary<string, List<AComponent>> PizzaTable = new Dictionary<string, List<AComponent>>();
            PizzaTable.Add(NewYork.ToString(), NYStuff);
            PizzaTable.Add(Chicago.ToString(), ChicagoStuff);

            foreach(var PizzaKey in PizzaTable.Keys)
            {
              Console.WriteLine(PizzaKey); //First disply the name of the pizza. 
              foreach(var PizzaItem in PizzaTable.GetValueOrDefault(PizzaKey)) //Get values based on specific key.
              {
                Console.WriteLine(PizzaItem.ToString());
              }
            }
            
            // ***This is the workking code***
            // List<Topping> TopTemp = new List<Topping>() {new Topping("Ham"), new Topping("Pepperoni")};
            // Size Sizey = new Size("Small");

            // var NY1 = MakeNewYork(Sizey, TopTemp);
            // OrderList.PizzaName.Add(MakeNewYork1());
            // PizzaTemp.AddRange(NY1);
            
            // Console.WriteLine(OrderList.PizzaName[0]);
            // foreach (var comp in PizzaTemp)
            //  {
            //    Console.WriteLine(comp.ToString());
            //  } ***End of the working code***

        } 
    }
}


