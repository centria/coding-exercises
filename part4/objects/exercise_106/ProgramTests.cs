using System;
using System.IO;
using exercise_106;
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
    public void TestToString42()
    {
      {
        PaymentCard card = new PaymentCard(42);

        // Assert
        Assert.AreEqual("The card has a balance of 42 euros", card.ToString(), "Remember to have a return from the ToString!");

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

/*     [Test]
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
    } */

  }
}
