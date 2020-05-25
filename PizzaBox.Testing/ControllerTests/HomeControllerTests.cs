using System;
using Xunit;
using PizzaBox.MVCClient.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Testing.TestData;

namespace PizzaBox.Testing.ControllerTests
{
  public class HomeControllerTests
  {
    //TODO: Research how to unit test TempData. Shows as null. 
    private List<User> UserDirectory  = new List<User>()
    {
      new User { UserID = 1, FirstName = "John", LastName="Smith"}, 
      new User { UserID = 2, FirstName = "Joe", LastName="Cheung"}
    };

    [Fact]
    public void ReturnIndex()
    {
      //Arrange
      var HomeTest = new HomeController();
      //Act
      var result = HomeTest.Index(); 
      //Assert
      Assert.IsType<ViewResult>(result); 
    }

    [Fact]
    public void ReturnUserLogin()
    {
      var HomeTest = new HomeController(); 
      var result = HomeTest.UserLogin(); 
      Assert.IsType<ViewResult>(result); 
    }

    [Fact]
    public void PostUserLogin()
    {
      var HomeTest = new HomeController(); 
      //var tempDictionary  = HomeTest.TempData;
      var UserPost = new User { UserID = 1, FirstName = "John", LastName = "Smith"};
      var result1 = HomeTest.UserLogin(UserPost) as RedirectToActionResult;
      
      Assert.IsType<RedirectToActionResult>(result1);
    }

    [Theory]
    [ClassData(typeof(ErrorUserLogin))]
    public void ErrorPostUserLogin(User errorUserInfo)
    {
      var HomeTest = new HomeController(); 
      var result = HomeTest.UserLogin(errorUserInfo); 
      Assert.IsType<ViewResult>(result); 
    }

    [Fact]
    public void RegisterNewUser()
    {
      var HomeTest = new HomeController(); 
      var NewUser = new User { UserID = 3, FirstName = "Maria", LastName = "Martinez"};
      var result = HomeTest.Register(NewUser) as RedirectToActionResult;

      Assert.IsType<RedirectToActionResult>(result); 
    }
  }
}