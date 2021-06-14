using System;
using System.IO;
using exercise_45;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise45Test1()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "7"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "0\n1\n2\n3\n4\n5\n6\n7\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Did you print all the numbers?");
      }
    }

/*         [Test]
        public void TestCountWriteLines()
        {
            string code = File.ReadAllText("../../../Program.cs");
            int count = Regex.Matches(code, "Console.WriteLine").Count;

            Assert.AreEqual(1, count, "You were supposed to use Console.WriteLine only once!. Are you truly looping?");
        }
 */
  }
}