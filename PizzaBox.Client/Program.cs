using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Recipes;
using System.Linq;
using System.Reflection;
using PizzaBox.Domain.Application;

namespace PizzaBox.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            Application RunPizzaApp = new Application();
            Order1 CustomerOrder = RunPizzaApp.CreateOrder();
            RunPizzaApp.ViewOrder(CustomerOrder);
            //TODO: Reflection to get list of classes in namespace.
            
            // Type NYPizza = typeof(NewYork);
            // object NYInstance = Activator.CreateInstance(NYPizza);
            // MethodInfo createNYPizza = NYPizza.GetMethod("Make");

            // TEST
            // NewYork NewYork1 = new NewYork();
            // Size NewYorkSize = new Size("Small");
            // List<Topping> NewYorkTopping  = new List<Topping> ();
            // NewYorkTopping.Add(new Topping("Cheese"));
            // NewYorkTopping.Add(new Topping("Ham"));
            // var NYStuff = NewYork1.Make(NewYorkSize, NewYorkTopping);

            // var NYReflect = createNYPizza.Invoke(NYInstance, new object[] {NewYorkSize, NewYorkTopping})

            // Logic to use reflection.
            // Order1 ReflectionOrder = new Order1();
            // ReflectionOrder.PizzaTable.Add(NYPizza.Name, NYReflect as List<AComponent>);
            // foreach (var KeyReflect in ReflectionOrder.PizzaTable.Keys)
            // {
            //     Console.WriteLine(KeyReflect);
            //     foreach (var ItemPizza in ReflectionOrder.PizzaTable.GetValueOrDefault(KeyReflect))
            //     {
            //         Console.WriteLine(ItemPizza.ToString());
            //     }
            // }

        } 
    }
}


