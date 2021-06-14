using System;
using System.IO;
using exercise_128;
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

/*     [Test]
    public void TestMainExists()
    {

      string code = File.ReadAllText("Program.cs");
      int count = Regex.Matches(code, @"public static void Main\(string\[\] args\)").Count;

      Assert.AreEqual(1, count, "Do not destroy the Main class from Program.cs!");
    }
 */
    [Test]
    public void TestApartmentExists()
    {
      Assert.IsTrue(File.Exists("Apartment.cs"), "Do not remove the Apartment.cs");
    }


    [Test]
    public void TestApartmentConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Person.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Apartment house = new Apartment(2, 3, 100);

      Assert.AreEqual(house.GetType(), typeof(Apartment), "The Counter should be of type Counter!");
    }

    [Test]
    public void TestApartmentMoreExpensiveFirst()
    {
      Apartment house = new Apartment(2, 3, 100);
      Apartment house2 = new Apartment(2, 3, 50);
      Assert.AreEqual(true, house.MoreExpensiveThan(house2), "Check your Price calculation");
    }

    [Test]
    public void TestApartmentMoreExpensiveSecond()
    {
      Apartment house = new Apartment(2, 3, 100);
      Apartment house2 = new Apartment(2, 3, 500);
      Assert.AreEqual(false, house.MoreExpensiveThan(house2), "Check your Price calculation");
    }

    [Test]
    public void TestApartmentMoreExpensiveSecondSmall()
    {
      Apartment house = new Apartment(2, 300, 100);
      Apartment house2 = new Apartment(6, 3, 50000);
      Assert.AreEqual(false, house.MoreExpensiveThan(house2), "Check your Price calculation");
    }

    [Test]
    public void TestApartmentPriceDifferenceFirst()
    {
      Apartment house = new Apartment(2, 350, 1000);
      Apartment house2 = new Apartment(2, 30, 3500);
      Assert.AreEqual(245000, house.PriceDifference(house2), "Check your Price calculation");
    }

    [Test]
    public void TestApartmentPriceDifferenceSecond()
    {
      Apartment house = new Apartment(2, 35, 1000);
      Apartment house2 = new Apartment(2, 30, 3500);
      Assert.AreEqual(70000, house.PriceDifference(house2), "Check your Price calculation");
    }

    [Test]
    public void TestLargerThanFirst()
    {
      Apartment house = new Apartment(2, 35, 1000);
      Apartment house2 = new Apartment(2, 30, 3500);
      Assert.AreEqual(true, house.LargerThan(house2), "Check your Price calculation");
    }

    [Test]
    public void TestLargerThanSecond()
    {
      Apartment house = new Apartment(2, 35, 1000);
      Apartment house2 = new Apartment(2, 36, 3500);
      Assert.AreEqual(false, house.LargerThan(house2), "Check your Price calculation");
    }



  }
}