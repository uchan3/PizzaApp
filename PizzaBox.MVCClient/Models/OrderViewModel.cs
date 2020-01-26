using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Models;

namespace PizzaBox.MVCClient.Models
{
    public class OrderViewModel 
    {
      public List<Location> LocationList {get; set;}
      public List<StorePizzaDefinition> PizzaTypeList {get; set;}
      public List<CrustDefinition> CrustList {get; set;}
      public List<SizeDefinition> SizeList {get; set;}
      public List<ToppingDefinition> ToppingList {get; set;}
      //[BindProperty]
      public string LocationStreet {get; set;}
    }
}