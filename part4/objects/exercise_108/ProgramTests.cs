using System;
using System.IO;
using exercise_108;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestFileExists()
    {
      Assert.IsTrue(File.Exists("../../../PaymentCard.cs"), "You haven't created the file yet");
    }

    [Test]
    public void TestToString()
    {
      {
        PaymentCard card = new PaymentCard(501);

        // Assert
        Assert.AreEqual("The card has a balance of 501 euros", card.ToString(), "Remember to have a return from the ToString!");

      }
    }

    [Test]
    public void TestToStringDouble()
    {
      {
        PaymentCard card = new PaymentCard(42.42);

        // Assert
        Assert.AreEqual("The card has a balance of 42.42 euros", card.ToString().Replace(",", "."), "Remember to have a return from the ToString!");

      }
    }

    [Test]
    public void TestToString42()
    {
      {
        PaymentCard card = new PaymentCard(42);

        // Assert
        Assert.AreEqual("The card has a balance of 42 euros", card.ToString(), "Remember to have a return from the ToString!");

      }
    }

    [Test]
    public void TestEatLunch()
    {
      {
        PaymentCard card = new PaymentCard(12.6);
        card.EatLunch();

        // Assert
        Assert.AreEqual("The card has a balance of 2 euros", card.ToString(), "Eating Lunch should cost 10.6!");

      }
    }

    [Test]
    public void TestEatLunchNotEnoughMoney()
    {
      {
        PaymentCard card = new PaymentCard(8);
        card.EatLunch();

        // Assert
        Assert.AreEqual("The card has a balance of 8 euros", card.ToString(), "You cannot eat without money!");

      }
    }

    [Test]
    public void TestDrinkCoffee()
    {
      {
        PaymentCard card = new PaymentCard(10);
        card.DrinkCoffee();

        // Assert
        Assert.AreEqual("The card has a balance of 8 euros", card.ToString(), "Drinking coffee should cost 2!");

      }
    }

    [Test]
    public void TestDrinkTooMuchCoffee()
    {
      {
        PaymentCard card = new PaymentCard(9);
        card.DrinkCoffee();
        card.DrinkCoffee();
        card.DrinkCoffee();
        card.DrinkCoffee();
        card.DrinkCoffee();

        // Assert
        Assert.AreEqual("The card has a balance of 1 euros", card.ToString(), "You cannot drink coffee on credit!");

      }
    }
/* 
    [Test]
    public void TestFindConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../PaymentCard.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, @"public PaymentCard\(double openingBalance\)").Count;

      Assert.AreEqual(1, count, "Remember to create the constructor!");
    }

    [Test]
    public void TestFindEatLunch()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../PaymentCard.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, @"public void EatLunch").Count;

      Assert.AreEqual(1, count, "Remember to create  EatLunch!");
    }

    [Test]
    public void TestFindDrinkCoffee()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../PaymentCard.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, @"public void DrinkCoffee").Count;

      Assert.AreEqual(1, count, "Remember to create the DrinkCoffee!");
    }
 */
  }
}
