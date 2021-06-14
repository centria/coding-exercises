using System;
using System.IO;
using exercise_61;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
/*     [Test]
    public void TestFindMethodNameSection0()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "public static void PrintStars").Count;

      Assert.AreEqual(1, count, "Remember to create PrintStars!!");
    }

    [Test]
    public void TestFindMethodNameSection1()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "public static void PrintSpaces").Count;

      Assert.AreEqual(1, count, "Remember to create PrintSpaces!");
    }

    [Test]
    public void TestFindMethodNameSection2()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "public static void PrintRightTriangle").Count;

      Assert.AreEqual(1, count, "Remember to create PrintRightTriangle!");
    }

    [Test]
    public void TestFindMethodNameSection3()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "public static void ChristmasTree").Count;

      Assert.AreEqual(1, count, "Remember to create ChristmasTree!");
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

        // Call student's code
        Program.PrintStars(12);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("************\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

    [Test]
    public void TestExerciseMethodCallPrintSpaces()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Program.PrintSpaces(5);
        // Call student's code


        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("     ", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

    [Test]
    public void TestExerciseMethodCallPrintRightTriangle()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Program.PrintRightTriangle(3);
        // Call student's code


        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("  *\n **\n***\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

    [Test]
    public void TestExerciseMethodCallChristmasTree()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Program.ChristmasTree(5);
        // Call student's code


        // Restore the original standard output.
        Console.SetOut(stdout);


        // Assert
        Assert.AreEqual("    *\n   ***\n  *****\n *******\n*********\n   ***\n   ***\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

  }
}