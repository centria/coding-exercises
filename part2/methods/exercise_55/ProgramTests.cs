using System;
using System.IO;
using exercise_55;
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
      int count = Regex.Matches(code, "public static int NumberUno").Count;

      Assert.AreEqual(1, count, "Check the instructions on what the method should be called!");
    }

    [Test]
    public void TestFindMethodPrint()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "return").Count;

      Assert.AreEqual(1, count, "You were  supposed to use return in the method, and only in the method!");
    }
 */

    [Test]
    public void TestExerciseMethodCall()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        int uno = Program.NumberUno();

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual(1, uno, "The program should always return 1!");
      }
    }

        [Test]
    public void TestExerciseMethodReturnType()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        int uno = Program.NumberUno();
        // Call student's code


        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual(uno.GetType(), typeof(Int32), "The program should return an integer!");
      }
    }

  }
}