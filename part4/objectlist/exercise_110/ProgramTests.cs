using System;
using System.IO;
using exercise_110;
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
      Assert.IsTrue(File.Exists("../../../Item.cs"), "You have deleted the necessary file!");
    }

    [Test]
    public void TestToString()
    {
      {
        Item item = new Item("testName");

        // Assert
        Assert.AreEqual(item.name + " (created at: " + item.createdAt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fi-FI")) + ")", item.ToString(), "Remember to have a return from the ToString!");

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
      int count = Regex.Matches(code, @"List<Item> items = new List<Item>()").Count;

      Assert.AreEqual(1, count, "Remember to create the list 'items' only once!");
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

      Assert.AreEqual(1, count, "Remember to ask for user input!");
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
                "Matt",
                "Hank",
                "Lily",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison1 = "Name: Name: Name: Name: Name:";
        StringAssert.Contains(comparison1, sw.ToString().Replace("\r\n", "\n"), "Are you asking the names with Console.Write as you should?");

        string comparison2 = "Mike (created at: ";
        StringAssert.Contains(comparison2, sw.ToString().Replace("\r\n", "\n"), "Are you saving everything in the list?");

        string comparison3 = "Hank (created at: ";
        StringAssert.Contains(comparison3, sw.ToString().Replace("\r\n", "\n"), "Are you saving everything in the list?");

        string comparison4 = "Lily (created at: ";
        StringAssert.Contains(comparison4, sw.ToString().Replace("\r\n", "\n"), "Are you saving everything in the list?");

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
                "Matt",
                "Hank",
                "Lily",
                "Lilly",
                "Eliza",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison1 = "Name: Name: Name: Name: Name: Name: Name: \n";
        StringAssert.Contains(comparison1, sw.ToString().Replace("\r\n", "\n"), "Are you asking the names with Console.Write as you should?");
        string comparison2 = "Mike (created at: ";
        StringAssert.Contains(comparison2, sw.ToString().Replace("\r\n", "\n"), "Are you saving everything in the list?");
        string comparison3 = "Hank (created at: ";
        StringAssert.Contains(comparison3, sw.ToString().Replace("\r\n", "\n"), "Are you saving everything in the list?");
        string comparison4 = "Lily (created at: ";
        StringAssert.Contains(comparison4, sw.ToString().Replace("\r\n", "\n"), "Are you saving everything in the list?");
        string comparison5 = "Lilly (created at: ";
        StringAssert.Contains(comparison5, sw.ToString().Replace("\r\n", "\n"), "Are you saving everything in the list?");
        string comparison6 = "Eliza (created at: ";
        StringAssert.Contains(comparison6, sw.ToString().Replace("\r\n", "\n"), "Are you saving everything in the list?");

      }
    }



  }
}
