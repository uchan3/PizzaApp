using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing
{
   //Purpose: Check if UserID exists in account.
   public class AccountExists
    {
      [Fact]

      public void CheckUserIDTrue()
      {
        //Scenario 1: UserID exists within the list of users. 
        //arrange
        var UserT = new User();
        UserT.UserID = "User1";
        var expectedT = UserT.CheckAccountExist(UserT);

        //act
        var actualT = true;

        //assert 
        Assert.True(expectedT == actualT);
      }

      [Fact]

      public void CheckUserIDFalse()
      {
        //Scenario 2: User does not exist within the list of users.
        //arrange
        var UserF = new User();
        UserF.UserID = "User4";
        var expectedF = UserF.CheckAccountExist(UserF);

        //act
        var actualF = true;

        //assert 
        Assert.False(expectedF == actualF);
      }

      // [Fact]
      // public void CheckUserID_Invalid()
      // {
      //   //arrange
      //   //Scenario 2: A UserID is not associated with the account list.
      //   var Account2 = new Account();
      //   var User2 = new User();
      //   User2.UserID = "User4";
      //   var expected2 = Account2.CheckAccountExist(User2);

      //   //act
      //   var actual2 = true;

      //   //assert
      //   Assert.False(expected2 == actual2);
      // }
    }
}