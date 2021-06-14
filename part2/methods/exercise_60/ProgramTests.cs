using System;
using System.IO;
using exercise_60;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
/*     [Test]
    public void TestFindMethodNameSection1()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "public static void PrintStars").Count;

      Assert.AreEqual(1, count, "Check the section 1 instructions for method name!!");
    }

    [Test]
    public void TestFindMethodNameSection2()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "public static void PrintSquare").Count;

      Assert.AreEqual(1, count, "Check the section 2 instructions for method name!!");
    }

    [Test]
    public void TestFindMethodNameSection3()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "public static void PrintRectangle").Count;

      Assert.AreEqual(1, count, "Check the section 3 instructions for method name!!");
    }

        [Test]
    public void TestFindMethodNameSection4()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "public static void PrintTriangle").Count;

      Assert.AreEqual(1, count, "Check the section 4 instructions for method name!!");
    }
 */
    [Test]
    public void TestExerciseMethodCallPrintStars()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Program.PrintStars(3);
        // Call student's code


        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("***\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

    [Test]
    public void TestExerciseMethodCallPrintSquare()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Program.PrintSquare(5);
        // Call student's code


        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("*****\n*****\n*****\n*****\n*****\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

    [Test]
    public void TestExerciseMethodCallPrintRectangle()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Program.PrintRectangle(8, 4);
        // Call student's code


        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("********\n********\n********\n********\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

        [Test]
    public void TestExerciseMethodCallPrintTriangle()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Program.PrintTriangle(5);
        // Call student's code


        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("*\n**\n***\n****\n*****\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

  }
}