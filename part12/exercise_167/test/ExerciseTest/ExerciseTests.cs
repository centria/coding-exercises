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

    [Test]
    public void TestSystemUsing()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.Main(null);

        Console.SetOut(stdout);
        string example = "This needs a using!\n";
        StringAssert.Contains(example, sw.ToString().Replace("\r\n", "\n"), "You should be using 'using' four times!");
      }
    }

/*     [Test]
    public void TestCountWriteLines()
    {
      string code = File.ReadAllText("src/Exercise/Program.cs");
      int count = Regex.Matches(code, "using System").Count;

      Assert.GreaterOrEqual(count, 4, "You should be using 'using System...' four times!");
    } */

  }
}
