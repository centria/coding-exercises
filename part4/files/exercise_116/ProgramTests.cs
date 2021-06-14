using System;
using System.IO;
using exercise_116;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {


/*     [Test]
    public void TestCountReadLines()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "File.Read").Count;

      Assert.Greater(count, 0, "You were supposed to read the File only once.");
    } */

    [Test]
    public void TestExercise116FileContent()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Force the test to find the data.txt
        Directory.SetCurrentDirectory("../../../");
        
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("In a world\nWhere code is built\nThere are magical creatures\nWe call them unicorns\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }
  }
}