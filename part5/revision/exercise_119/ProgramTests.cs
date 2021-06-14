using System;
using System.IO;
using exercise_119;
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
      Assert.IsTrue(File.Exists("Timer.cs"), "The Timer.cs file is not yet created.");
    }


    [Test]
    public void TestTimerConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Timer.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Timer testTimer = new Timer();

      Assert.AreEqual("00:00", testTimer.ToString(), "The timer should start at 00:00");
    }

    [Test]
    public void TestTimerAdvance()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Timer.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Timer testTimer = new Timer();
      testTimer.Advance();

      Assert.AreEqual("00:01", testTimer.ToString(), "One advance should advance the time by one 100th of a second.");
    }

    [Test]
    public void TestTimerAdvanceOneHundred()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Timer.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Timer testTimer = new Timer();
      for (int i = 0; i < 100; i++)
      {
        testTimer.Advance();
      }
      Assert.AreEqual("01:00", testTimer.ToString(), "100 advance should advance the time by one second.");
    }

    [Test]
    public void TestTimerAdvanceOneMinute()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Timer.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Timer testTimer = new Timer();
      for (int i = 0; i < 6000; i++)
      {
        testTimer.Advance();
      }
      Assert.AreEqual("00:00", testTimer.ToString(), "6000 advance should move the timer by 6000, so from 00:00 to 00:00.");
    }

    [Test]
    public void TestTimerAdvance5999()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Timer.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Timer testTimer = new Timer();
      for (int i = 0; i < 5999; i++)
      {
        testTimer.Advance();
      }
      Assert.AreEqual("59:99", testTimer.ToString(), "5999 advance should move the timer to 59:99 from 00:00");
    }
  }
}