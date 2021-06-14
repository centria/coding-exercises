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
        Person ada = new Person("Ada Lovelace");
        Person jack = new Person("Jack The Ripper");
        Person mike = new Person("Mike The Incredible Magic House Mouse");

        Program.HowManyNames(ada);
        Program.HowManyNames(jack);
        Program.HowManyNames(mike);

        // Restore the original standard output.
        Console.SetOut(stdout);

        Assert.AreEqual(sw.ToString().Replace("\r\n", "\n"), "Ada Lovelace has 2 names.\nJack The Ripper has 3 names.\nMike The Incredible Magic House Mouse has 6 names.\n", "Did you count the names correctly?");
      }

    }


    [Test]
    public void TestProgramRunAgain()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Person ada = new Person("Ada Lovelace");
        Person jack = new Person("Jack The Ripper");
        Person mike = new Person("Mike The Incredible Magic House Mouse");

        Program.HowManyNames(ada);
        Program.HowManyNames(jack);
        Program.HowManyNames(mike);
        Program.HowManyNames(mike);

        // Restore the original standard output.
        Console.SetOut(stdout);

        Assert.AreEqual(sw.ToString().Replace("\r\n", "\n"), "Ada Lovelace has 2 names.\nJack The Ripper has 3 names.\nMike The Incredible Magic House Mouse has 6 names.\nMike The Incredible Magic House Mouse has 6 names.\n", "Did you print the exact output?");
      }

    }
  }
}

