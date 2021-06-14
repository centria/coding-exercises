using System;
using System.IO;
using Exercise;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    string target = "../../../../../";
    string current = Directory.GetCurrentDirectory();

    [SetUp]
    public void Init()
    {
      Directory.SetCurrentDirectory(target);
    }

    [TearDown]
    public void End()
    {
      Directory.SetCurrentDirectory(current);
    }
    [Test]
    public void TestSimpleInput()
    {
      // ADD USING STATEMENT HERE
      // We need a 'StringWriter sw'
      
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


    [Test]
    public void TestZeroInput()
    {
      // ADD USING STATEMENT HERE
      // We need a 'StringWriter sw'

      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;
        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "0"
                });
        Console.SetIn(new System.IO.StringReader(data));
        // Call student's code
        Program.Main(null);
        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "0\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Zero input should print only 0");
      }
    }


    // DO NOT TOUCH TESTS BELOW THIS LINE!
/*     [Test]
    public void TestCountTestsInThisFile()
    {
      string code = File.ReadAllText("test/ExerciseTest/ExerciseTests.cs");
      int count = Regex.Matches(code, @"\[Test\]").Count;
      Assert.AreEqual(4, count, "Do not remove or add any tests!");
    }

    [Test]
    public void TestCountUsingsInThisFile()
    {
      string code = File.ReadAllText("test/ExerciseTest/ExerciseTests.cs");
      int count = Regex.Matches(code, @"using \(StringWriter sw = new StringWriter\(\)\)").Count;
      Assert.AreEqual(2, count, "Did add the 'using StringWriter'?");
    } */

  }
}