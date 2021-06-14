using System;
using System.IO;
using exercise_122;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    string target = "../../../";
    string current = Directory.GetCurrentDirectory();
    [SetUp]
    public void Init()
    {
      Directory.SetCurrentDirectory(target);
    }

    [TearDown]
    public void End()
    {
      Directory.SetCurrentDirectory(current);
    }

 /*    [Test]
    public void TestMainExists()
    {

      string code = File.ReadAllText("Program.cs");
      int count = Regex.Matches(code, @"public static void Main\(string\[\] args\)").Count;

      Assert.AreEqual(1, count, "Do not destroy the Main class from Program.cs!");
    }
 */
    [Test]
    public void TestTimerFileExists()
    {
      Assert.IsTrue(File.Exists("Product.cs"), "The Product file is not yet created.");
    }


    [Test]
    public void TestProductNameConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Product.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Product product = new Product("product");

      Assert.AreEqual(product.GetType(), typeof(Product), "The Product should be of type Product!");
    }

    [Test]
    public void TestProductNameAndLocationConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Product.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Product product = new Product("product", "testplace");

      Assert.AreEqual(product.GetType(), typeof(Product), "The Product should be of type Product!");
    }

    [Test]
    public void TestProductNameAndWeightConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Product.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Product product = new Product("product", 5);

      Assert.AreEqual(product.GetType(), typeof(Product), "The Product should be of type Product!");
    }

    [Test]
    public void TestProductNameAndWeightConstructorToString()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Product.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Product product = new Product("Master Blaster", 666);

      Assert.AreEqual("Master Blaster (666 kg) can be found from the warehouse.", product.ToString(), "The Product should be of type Product!");
    }

    [Test]
    public void TestProductNameConstructorToString()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Product.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Product product = new Product("Holy hand granade");

      Assert.AreEqual("Holy hand granade (1 kg) can be found from the shelf.", product.ToString(), "The Product should be of type Product!");
    }

    [Test]
    public void TestProductNameAndLocationConstructorToString()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Product.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Product product = new Product("Unholy water cannon", "Magic pond");

      Assert.AreEqual("Unholy water cannon (1 kg) can be found from the Magic pond.", product.ToString(), "The Product should be of type Product!");
    }


  }
}