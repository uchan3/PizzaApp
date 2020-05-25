using System;
using System.Collections;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Testing.TestData
{
  public class ErrorUserLogin : IEnumerable<object[]>
  {
    public IEnumerator<object[]> GetEnumerator()
    {
      //yield returns one statement at a time. 
      //Case 1: User enters incorrect first name. 
      yield return new object[] {
        new User { UserID = 1, FirstName = "Joe55", LastName= "Smith"}
      };
      //Case 2: User enters incorrect last name. 
      yield return new object[] {
        new User { UserID = 1, FirstName = "John", LastName= "9Samara"}
      };
      //Case 3: User enters information that does not exist in user directory.
      yield return new object[] {
        new User { UserID = 3, FirstName = "Maria", LastName= "Ramirez"}
      };
      //throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
      //throw new NotImplementedException();
    }
  }
}