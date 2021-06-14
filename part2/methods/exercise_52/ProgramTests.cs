using System;
using System.IO;
using exercise_52;
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
      int count = Regex.Matches(code, "public static void PrintFromNumberToOne").Count;

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
      int count = Regex.Matches(code, "PrintFromNumberToOne").Count;

      Assert.AreEqual(2, count, "You were supposed to call PrintFromNumberToOne from your Main!");
    }
 */

    [Test]
    public void TestExercise52Method4()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.PrintFromNumberToOne(4);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("4\n3\n2\n1\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }

    }

    [Test]
    public void TestExercise52Method37()
    {
      using (StringWriter sw = new StringWriter())
      {
        int upp = 37;
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.PrintFromNumberToOne(37);

        // Restore the original standard output.
        Console.SetOut(stdout);

        string compare = "";
        for (int i = upp; i >= 1; i--) {
          compare += i+"\n";
        }
        // Assert
        Assert.AreEqual(compare, sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }

    }

  }
}