using System;
using System.IO;
using exercise_115;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise115()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "12",
                "11",
                "-1",
                "end"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("1728\n1331\n-1\n", sw.ToString().Replace("\r\n", "\n"), "Remember to count the powers, but not the end!");
      }
    }


    [Test]
    public void TestExercise115JustTheEnd()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "end"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("", sw.ToString().Replace("\r\n", "\n"), "End alone should print nothing!");
      }
    }



    [Test]
    public void TestExercise115DifferentInputs()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "11",
                "-3",
                "111",
                "13",
                "end"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("1331\n-27\n1367631\n2197\n", sw.ToString().Replace("\r\n", "\n"), "End alone should print nothing!");
      }
    }

/*     [Test]
    public void TestCountReadLines()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "Console.ReadLine").Count;

      Assert.AreEqual(1, count, "You were supposed to use Console.ReadLine once.");
    } */
  }
}