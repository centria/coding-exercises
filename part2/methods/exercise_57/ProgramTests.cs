using System;
using System.IO;
using exercise_57;
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
      int count = Regex.Matches(code, "public static int Sum").Count;

      Assert.AreEqual(1, count, "You were supposed to use the method base!");
    }

    [Test]
    public void TestFindMethodPrint()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "Console.WriteLine").Count;

      Assert.AreEqual(1, count, "You were NOT supposed to use WriteLine inside the method!");
    }

        [Test]
    public void TestFindMethodCall()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "Sum[^:]").Count;

      Assert.AreEqual(2, count, "You were supposed to call Sum from your Main!");
    }
 */

    [Test]
    public void TestExercise57Main()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Sum: 14\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }

    }

    [Test]
    public void TestExercise57MethodSum()
    {
      using (StringWriter sw = new StringWriter())
      {
        int count = Program.Sum(1,2,3,4);

        // Assert
        Assert.AreEqual(10, count);
      }

    }

  }
}