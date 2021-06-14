using System;
using System.IO;
using exercise_114;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise114()
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
                "Ada",
                "Data Scientist",
                "Is a cool person",
                "end"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("3\n", sw.ToString().Replace("\r\n", "\n"), "Remember to count the strings, but not the end!");
      }
    }


    [Test]
    public void TestExercise114JustTheEnd()
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
        Assert.AreEqual("0\n", sw.ToString().Replace("\r\n", "\n"), "End alone should make the sum zero!");
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