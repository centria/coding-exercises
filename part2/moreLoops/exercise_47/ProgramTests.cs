using System;
using System.IO;
using exercise_47;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise47TestSmall()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "9",
                "7"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Where to?\nWhere from?\n7\n8\n9\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Did you print all the numbers?");
      }
    }

    [Test]
    public void TestExercise47TestLarger()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "100",
                "12"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Where to?\nWhere from?\n";
        for (int i = 12; i <= 100; i++)
        {
          comparison += i + "\n";
        }
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Did you print all the numbers?");
      }
    }


    [Test]
    public void TestExercise47TestNegative()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "100",
                "-12"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Where to?\nWhere from?\n";
        for (int i = -12; i <= 100; i++)
        {
          comparison += i + "\n";
        }
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Did you print all the numbers?");
      }
    }

[Test]
    public void TestExercise47TestWrongOrder()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "12",
                "100"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "Where to?\nWhere from?\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Did you print all the numbers?");
      }
    }

/*     [Test]
    public void TestCountWriteLines()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "Console.WriteLine").Count;

      Assert.AreEqual(3, count, "You were supposed to use Console.WriteLine only three times!. Are you truly looping?");
    }
 */
  }
}