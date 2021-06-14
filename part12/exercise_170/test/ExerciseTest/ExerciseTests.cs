using System;
using System.IO;
using NUnit.Framework;
using Exercise;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ExerciseTest
{
  public class Tests
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


/*     [Test]
    public void TestCountUsingStatement()
    {
      string code = File.ReadAllText("src/Exercise/Program.cs");
      int count = Regex.Matches(code, @"using \(StreamWriter writer = new StreamWriter").Count;

      Assert.GreaterOrEqual(count, 1, "You should be using statement 'using (StreamWriter writer...' in your code!");
    }

    [Test]
    public void TestCountClose()
    {
      string code = File.ReadAllText("src/Exercise/Program.cs");
      int count = Regex.Matches(code, @"Close").Count;

      Assert.AreEqual(count, 0, "You should not be using Close in your code with using statement!");
    } */

  }
}
