using System;
using System.IO;
using exercise_123;
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
    public void TestTimerFileExists()
    {
      Assert.IsTrue(File.Exists("Counter.cs"), "The Product file is not yet created.");
    }


    [Test]
    public void TestCounterNullConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Counter.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Counter counter = new Counter();

      Assert.AreEqual(counter.GetType(), typeof(Counter), "The Counter should be of type Counter!");
    }

    [Test]
    public void TestCounterStartNumberConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Counter.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Counter counter = new Counter(2);

      Assert.AreEqual(counter.GetType(), typeof(Counter), "The Counter should be of type Counter!");
    }

    [Test]
    public void TestCounterIncrease()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Counter.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Counter counter = new Counter(2);
      counter.Increase();

      Assert.AreEqual(3, counter.value, "Increase should increase the value by one!");
    }

    [Test]
    public void TestCounterIncreaseMore()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Counter.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Counter counter = new Counter();
      counter.Increase();

      Assert.AreEqual(1, counter.value, "Increase should increase the value by one!");
    }

    [Test]
    public void TestDecrease()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Counter.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Counter counter = new Counter();
      counter.Decrease();

      Assert.AreEqual(-1, counter.value, "Decrease should decrease the value by one!");
    }

    [Test]
    public void TestDecreaseBy10()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Counter.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Counter counter = new Counter();
      counter.Decrease(10);

      Assert.AreEqual(-10, counter.value, "Decrease by 10 should decrease the value by 10!");
    }

    [Test]
    public void TestIncreaseBy12()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Counter.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Counter counter = new Counter();
      counter.Increase(12);

      Assert.AreEqual(12, counter.value, "Increase by 12 should increase the value by 12!");
    }

    [Test]
    public void TestDecreaseByNEGATIVE10()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Counter.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Counter counter = new Counter();
      counter.Decrease(-10);

      Assert.AreEqual(0, counter.value, "Decrease by -10 should not decrease the value!");
    }

    [Test]
    public void TestIncreaseByNEGATIVE10()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Counter.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Counter counter = new Counter();
      counter.Increase(-10);

      Assert.AreEqual(0, counter.value, "Increase by -10 should not change the value!");
    }

    [Test]
    public void TestRandom()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Counter.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Random rand = new Random();
      int rando1 = rand.Next(1, 100);
      Counter counter = new Counter(rando1);
      int rando2 = rand.Next(2, 10000);
      counter.Increase(rando2);

      Assert.AreEqual(rando1 + rando2, counter.value, $"Increase by {rando1} should change the value by that much!");
    }


  }
}