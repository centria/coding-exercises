using System;
using System.IO;
using exercise_136;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    string target = "../../../";
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

 /*    [Test]
    public void TestMainExists()
    {
      string code = File.ReadAllText("Program.cs");
      int count = Regex.Matches(code, @"public static void Main\(string\[\] args\)").Count;

      Assert.AreEqual(1, count, "Do not destroy the Main class from Program.cs!");
    } */

    [Test]
    public void TestProgramRun()
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

        Assert.AreEqual(sw.ToString().Replace("\r\n", "\n"), "Ada Lovelace has 2 names.\nJack The Ripper has 3 names.\nMike The Incredible Magic Mouse has 5 names.\n", "Did you count the names correctly?");
      }
    }


    [Test]
    public void TestPersonNameCount()
    {
      {
        Person jack = new Person("Jack The Ripper");

        Assert.AreEqual(3, jack.HowManyNames(), "Did you count correctly?");
      }
    }

        [Test]
    public void TestPersonNameMagicCount()
    {
      {
        Person jack = new Person("Mike the Magic house mouse");

        Assert.AreEqual(5, jack.HowManyNames(), "Names can be without capitals, remember that!");
      }
    }

  }
}


