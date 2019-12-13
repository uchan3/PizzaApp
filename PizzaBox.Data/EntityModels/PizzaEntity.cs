using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Ingredients;

namespace Pizza.Data
{
  public class PizzaEntity: APizza
  {
    [Key]
    public int PizzaID {get; set;}
    
    //Customer must select these options. 
    public Size PizzaSize {get; set; }
    public List<Topping> PizzaTopping {get; set;}
    public int Quantity {get; set;}
  }
}