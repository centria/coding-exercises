using System;
using System.IO;
using exercise_133;
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
    } */

    [Test]
    public void TestConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Money.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Money money = new Money(100, 1);

      Assert.AreEqual(money.GetType(), typeof(Money), "The Money should be of type Money!");
    }

    [Test]
    public void TestToString()
    {
      Money money = new Money(100, 1);

      Assert.AreEqual("100.01e", money.ToString(), "Do not change the ToString!");
    }

    [Test]
    public void TestToString2()
    {
      Money money = new Money(100, 11);

      Assert.AreEqual("100.11e", money.ToString(), "Do not change the ToString!");
    }

    [Test]
    public void TestPlus()
    {
      Money money = new Money(100, 11);
      Money newMoney = money.Plus(money);

      Assert.AreEqual("200.22e", newMoney.ToString(), "Plus should create new Money object!");
    }

    [Test]
    public void TestPlusCents()
    {
      Money money = new Money(100, 59);
      Money newMoney = money.Plus(money);

      Assert.AreEqual("201.18e", newMoney.ToString(), "Plus should create new Money object!");
    }

    [Test]
    public void TestMinusCents()
    {
      Money money = new Money(100, 59);
      Money lessMoney = new Money(10, 69);
      Money newMoney = money.Minus(lessMoney);

      Assert.AreEqual("89.90e", newMoney.ToString(), "Plus should create new Money object!");
    }

    [Test]
    public void TestMinusOverValue()
    {
      Money money = new Money(100, 59);
      Money lessMoney = new Money(100, 69);
      Money newMoney = money.Minus(lessMoney);

      Assert.AreEqual("0.00e", newMoney.ToString(), "Plus should create new Money object!");
    }


    [Test]
    public void TestMinusLessThanFirst()
    {
      Money money = new Money(100, 59);
      Money lessMoney = new Money(100, 69);

      Assert.AreEqual(false, lessMoney.LessThan(money), "Plus should create new Money object!");
    }

        [Test]
    public void TestMinusLessThanSecond()
    {
      Money money = new Money(101, 69);
      Money lessMoney = new Money(100, 69);

      Assert.AreEqual(true, lessMoney.LessThan(money), "Plus should create new Money object!");
    }

  }
}