using System;
using System.IO;
using exercise_64;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise64Exception()
    {
      using (StringWriter sw = new StringWriter())
      {
        Assert.Throws<ArgumentOutOfRangeException>(() => Program.Main(null), "Does your program give ArgumentOutOfRangeException?");
      }
    }

/*     [Test]
    public void TestCountReadLines()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "Console.ReadLine").Count;

      Assert.AreEqual(0, count, "You should not use user input!");
    } */
  }
}