using System;
using System.IO;
using exercise_53;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
/*     [Test]
    public void TestFindMethodName()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "public static void Division").Count;

      Assert.AreEqual(1, count, "Check the instructions on what the method should be called!");
    }

    [Test]
    public void TestFindMethodPrint()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "Console.WriteLine").Count;

      Assert.AreEqual(1, count, "You were NOT supposed to use WriteLine in main, only in the method!");
    }

    [Test]
    public void TestFindMethodCall()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "Division").Count;

      Assert.AreEqual(2, count, "You were supposed to call Division from your Main!");
    } */


    [Test]
    public void TestExercise53Method34()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.Division(3, 4);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual((Convert.ToDouble("0.75", System.Globalization.CultureInfo.InvariantCulture).ToString()+"\n").Replace(",", "."), sw.ToString().Replace(",", ".").Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

    [Test]
    public void TestExercise53Method12()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.Division(1, 2);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual((Convert.ToDouble("0.5", System.Globalization.CultureInfo.InvariantCulture).ToString()+"\n").Replace(",", "."), sw.ToString().Replace(",", ".").Replace("\r\n", "\n"), "Check your code! The test requires double for printing!");
      }
    }

  }
}