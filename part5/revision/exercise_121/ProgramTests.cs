using System;
using System.IO;
using exercise_121;
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
      Assert.IsTrue(File.Exists("Fitbyte.cs"), "The Fitbyte.cs file is not yet created.");
    }


    [Test]
    public void TestFitbyteConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Fitbyte.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Fitbyte Fitbyte = new Fitbyte(20, 80);

      Assert.AreEqual(Fitbyte.GetType(), typeof(Fitbyte), "The Fitbyte should be of Type Fitbyte!");
    }


    [Test]
    public void TestRandomFitbyte()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Fitbyte.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Random rnd = new Random();
      int rand1 = rnd.Next(1, 100);
      int rand2 = rnd.Next(25, 200);
      Fitbyte Fitbyte = new Fitbyte(rand1, rand2);
      double rand3 = rnd.NextDouble();
      double result = (206.3 - (0.711 * rand1) - rand2) * rand3 + rand2;

      Assert.AreEqual(result, Fitbyte.TargetHeartRate(rand3), "Called new Fitbyte({0}, {1})", rand1, rand2);
    }

    [Test]
    public void TestAnotherRandomFitbyte()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Fitbyte.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Random rnd = new Random();
      int rand1 = rnd.Next(1, 100);
      int rand2 = rnd.Next(25, 200);
      Fitbyte Fitbyte = new Fitbyte(rand1, rand2);
      double rand3 = rnd.NextDouble();
      double result = (206.3 - (0.711 * rand1) - rand2) * rand3 + rand2;

      Assert.AreEqual(result, Fitbyte.TargetHeartRate(rand3), "Called new Fitbyte({0}, {1})", rand1, rand2);
    }

  }
}