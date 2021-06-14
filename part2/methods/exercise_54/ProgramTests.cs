using System;
using System.IO;
using exercise_54;
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
      int count = Regex.Matches(code, "public static void DivisibleByThreeInRange").Count;

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
      int count = Regex.Matches(code, "DivisibleByThreeInRange").Count;

      Assert.AreEqual(2, count, "You were supposed to call DivisibleByThreeInRange from your Main!");
    }
 */

    [Test]
    public void TestExercise54Method34()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.DivisibleByThreeInRange(3, 4);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("3\n", sw.ToString().Replace("\r\n", "\n"), "Check your calculations!");
      }
    }

    [Test]
    public void TestExercise54Method12()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.DivisibleByThreeInRange(1, 2);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("", sw.ToString().Replace("\r\n", "\n"), "Check your code! Did you calculate divisable correctly?");
      }
    }

        [Test]
    public void TestExercise54Method115()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.DivisibleByThreeInRange(1, 15);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("3\n6\n9\n12\n15\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! Did you calculate divisable correctly?");
      }
    }

  }
}