using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PizzaBox.Domain.Ingredients;

namespace Pizza.Data
{
  public class PizzaEntity: APizza
  {
    [Key]
    public int PizzaID {get; set;}
    
    //For DB mapping purposes.  
    [ForeignKey("OrderEntity")]
    public int OrderID {get; set;}
    //Customer must select these options. 
    public int SizeID {get; set;}
    [ForeignKey("SizeID")]
    public Size PizzaSize {get; set; }
    //public int ToppingID {get; set;}
    //[ForeignKey("ToppingID")]
    public List<Topping> PizzaTopping {get; set;}
    public int CrustID {get; set;}
    [ForeignKey("CrustID")]
    public Crust PizzaCrust {get; set;}
    public int Quantity {get; set;}

    public PizzaEntity() {
      PizzaTopping = new List<Topping>(); 
    }
  }
}