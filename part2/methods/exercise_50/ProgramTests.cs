using System;
using System.IO;
using exercise_50;
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
      int count = Regex.Matches(code, "public static void PrintPhrase").Count;

      Assert.AreEqual(1, count, "You were supposed to create your own method!");
    }

    [Test]
    public void TestFindMethodPrint()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "Console.WriteLine").Count;

      Assert.AreEqual(2, count, "You were supposed to use WriteLine inside the method!");
    }

    [Test]
    public void TestFindMethodCall()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "PrintPhrase()").Count;

      Assert.AreEqual(2, count, "You were supposed to call PrintPhrase(); from your Main!");
    }
 */

    [Test]
    public void TestExercise50More()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "3"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "How many times?\nIn a hole in the ground there lived a method\nIn a hole in the ground there lived a method\nIn a hole in the ground there lived a method\n";
        
        // Assert
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Print as many times as asked!");
      }
    }

  }
}