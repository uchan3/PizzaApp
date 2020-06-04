using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data
{
  public class OrderEntity
  {
    [Key]
    public int OrderID {get; set;} //TODO: Refactor with GUID in future. 
    //public List<PizzaEntity> PizzaList {get; set;}

    //public int PizzaID {get; set;}
    //[ForeignKey("PizzaID")]
    public List<PizzaEntity> PizzaList {get; set;}
    
    public int UserID {get; set;}
    [ForeignKey("UserID")]
    public User UserInfo {get; set;}

    public int LocationID {get; set;}
    [ForeignKey("LocationID")]
    public Location LocationIdentifier {get; set;}
    public DateTime OrderDate {get; set;}

    public OrderEntity () {
      PizzaList = new List<PizzaEntity>(); //Debugging
    }
  }
}