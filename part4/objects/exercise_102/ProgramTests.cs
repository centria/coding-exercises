using System;
using System.IO;
using exercise_102;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestInitialValue()
    {
      {

        Gauge g = new Gauge();
        int test = g.value;
        // Assert
        Assert.AreEqual(0, test, "Gauge should start with 0!");
      }
    }

    [Test]
    public void TestIncrease()
    {
      {

        Gauge g = new Gauge();
        g.Increase();
        g.Increase();
        g.Increase();
        g.Increase();
        g.Increase();
        g.Increase();
        int test = g.value;

        // Assert
        Assert.AreEqual(5, test, "Gauge should only fill up to 5!");
      }
    }

    [Test]
    public void TestDecrease()
    {
      {

        Gauge g = new Gauge();
        g.Decrease();
        int test = g.value;

        // Assert
        Assert.AreEqual(0, test, "Gauge should not go below 0!");
      }
    }
/* 

    [Test]
    public void TestFileGaugeExists()
    {
      Assert.IsTrue(File.Exists("../../../Gauge.cs"), "You haven't created the file yet");
    }

    [Test]
    public void TestFindPublicIntValue()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Gauge.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "public int value").Count;

      Assert.AreEqual(1, count, "Remember to make the value public!");
    }

    [Test]
    public void TestFindMethodFull()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Gauge.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "public bool Full").Count;

      Assert.AreEqual(1, count, "Remember to create method Full!");
    }

    [Test]
    public void TestFindMethodIncrease()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Gauge.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "public void Increase").Count;

      Assert.AreEqual(1, count, "Remember to create method Increase!");
    }


    [Test]
    public void TestFindMethodDecrease()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Gauge.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "public void Decrease").Count;

      Assert.AreEqual(1, count, "Remember to create method Decrease!");
    } */

  }
}
