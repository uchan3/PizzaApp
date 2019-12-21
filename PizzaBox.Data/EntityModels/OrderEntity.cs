using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pizza.Data;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data
{
  public class OrderEntity
  {
    [Key]
    public int OrderID {get; set;} //TODO: Refactor with GUID in future. 
    //public List<PizzaEntity> PizzaList {get; set;}
    public List<PizzaEntity> PizzaList {get; set;}
    public User UserInfo {get; set;}
    public Location LocationIdentifier {get; set;}
    public DateTime OrderDate {get; set;}

    public OrderEntity () {
      PizzaList = new List<PizzaEntity>(); //Debugging
    }
  }
}