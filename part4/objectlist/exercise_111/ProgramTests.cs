using System;
using System.IO;
using exercise_111;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestFileExists()
    {
      Assert.IsTrue(File.Exists("../../../PersonalInformation.cs"), "You have deleted the necessary file!");
    }

    [Test]
    public void TestToString()
    {
      {
        PersonalInformation person = new PersonalInformation("Heikki", "Ahonen", "01011970");

        // Assert
        Assert.AreEqual("Ahonen, Heikki (01011970)", person.ToString(), "Remember to have a return from the ToString!");

      }
    }

/*     [Test]
    public void TestFindList()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Program.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, @"List<PersonalInformation>\(\)").Count;

      Assert.AreEqual(1, count, "Remember to create the list for PersonalInformation only once!");
    }

    [Test]
    public void TestFindUserInput()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Program.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, @"Console.ReadLine").Count;

      Assert.AreEqual(3, count, "Remember to ask for user input three times!");
    } */

    [Test]
    public void TestAddingToListWorks()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "Mike",
                "Pence",
                "11111111",
                "Hank",
                "Toms",
                "12121912",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison1 = "First name:\nLast name:\nIdentification number:\nFirst name:\nLast name:\nIdentification number:\nFirst name:\n\nMike Pence\nHank Toms\n";
        Assert.AreEqual(comparison1, sw.ToString().Replace("\r\n", "\n"), "Are you asking the names with Console.WriteLine as you should?");
      }
    }

    [Test]
    public void TestAddingToListWorksMore()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "Mike",
                "Pence",
                "11111111",
                "Hank",
                "Toms",
                "12121912",
                "Hillary",
                "Claimer",
                "13131970",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison1 = "First name:\nLast name:\nIdentification number:\nFirst name:\nLast name:\nIdentification number:\nFirst name:\nLast name:\nIdentification number:\nFirst name:\n\nMike Pence\nHank Toms\nHillary Claimer\n";
        Assert.AreEqual(comparison1, sw.ToString().Replace("\r\n", "\n"), "Are you asking the names with Console.WriteLine as you should?");
      }
    }


  }
}
