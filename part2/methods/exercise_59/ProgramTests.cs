using System;
using System.IO;
using exercise_59;
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
      int count = Regex.Matches(code, "public static int Greatest").Count;

      Assert.AreEqual(1, count, "Check the instructions on what the method should be called!");
    }
 */
    [Test]
    public void TestFindMethodPrint()
    {
      string code = File.ReadAllText("../../../Program.cs");

      StringAssert.Contains("return", code, "You were supposed to use return in the method, and only in the method!");
    }


    [Test]
    public void TestExerciseMethodCall()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int number = Program.Greatest(3, 8, 4);
        // Call student's code


        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual(8, number, "The program should return the Greatest number!");
      }
    }

    [Test]
    public void TestExerciseMethodCallFlip()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int number = Program.Greatest(38, 8, 14);
        // Call student's code


        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual(38, number, "The program should return the Greatest number!");
      }
    }

        [Test]
    public void TestExerciseMethodCallFlipThree()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int number = Program.Greatest(38, 8, 140);
        // Call student's code


        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual(140, number, "The program should return the Greatest number!");
      }
    }

            [Test]
    public void TestExerciseMethodCallEquals()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int number = Program.Greatest(8, 8, 8);
        // Call student's code


        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual(8, number, "The program should return the Greatest number!");
      }
    }

  }
}