using System;
using System.IO;
using exercise_98;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestFileProductExists()
    {
      Assert.IsTrue(File.Exists("../../../Product.cs"), "You haven't created the file yet");
    }
/* 
    [Test]
    public void TestFindPrivateStringName()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Product.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "private string name;").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class 'private string name'!");
    }

    [Test]
    public void TestFindPrivateIntQuantity()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Product.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "private int quantity;").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class 'private int quantity'!");
    }

    [Test]
    public void TestFindPrivateDoublePrice()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Product.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "private double price;").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class 'private price quantity'!");
    }

    [Test]
    public void TestFindConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Product.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, @"public Product\(string name, double price, int quantity\)").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class a constructor!");
    }
 */
    [Test]
    public void TestExerciseProductCreation()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Product Product = new Product("test", 11.0, 12);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual(Product.GetType(), typeof(Product), "The Product should be able to be created with constructor call!");
      }
    }

    [Test]
    public void TestExercisePrintProduct()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        new Product("tomato", 13.2, 666).PrintProduct();

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("tomato: price 13.2: 666 pcs\n".Replace(",", "."), sw.ToString().Replace("\r\n", "\n").Replace(",", "."), "The Product should have a PrintProduct() !");
      }
    }

        [Test]
    public void TestExercisePrintProductPotato()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        new Product("Potato", 0.99, 9001).PrintProduct();

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Potato: price 0.99: 9001 pcs\n".Replace(",", "."), sw.ToString().Replace("\r\n", "\n").Replace(",", "."), "The Product should have a PrintProduct() !");
      }
    }

  }
}
