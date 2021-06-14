using System;
using System.IO;
using exercise_113;
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
      Assert.IsTrue(File.Exists("../../../Book.cs"), "You have not created the necessary file Book.cs!");
    }

 /*    [Test]
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

      Assert.AreEqual(4, count, "Remember to ask for user input four times!");
    } */

    [Test]
    public void TestPrintEverything()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "My book",
                "30",
                "1945",
                "Your book",
                "60",
                "1999",
                "",
                "everything"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison1 = "Name: Pages: Publication year: Name: Pages: Publication year: Name: \nWhat information will be printed? My book, 30 pages, 1945\nYour book, 60 pages, 1999\n";
        Assert.AreEqual(comparison1, sw.ToString().Replace("\r\n", "\n"), "Check your printing with everything, use ToString!");
      }
    }

    [Test]
    public void TestPrintName()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "My book",
                "30",
                "1945",
                "Your book",
                "60",
                "1999",
                "",
                "title"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison1 = "Name: Pages: Publication year: Name: Pages: Publication year: Name: \nWhat information will be printed? My book\nYour book\n";
        Assert.AreEqual(comparison1, sw.ToString().Replace("\r\n", "\n"), "Check your printing with everything, use book.name!");
      }
    }

        [Test]
    public void TestPrintWrongInput()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "My book",
                "30",
                "1945",
                "Your book",
                "60",
                "1999",
                "",
                "names"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison1 = "Name: Pages: Publication year: Name: Pages: Publication year: Name: \nWhat information will be printed? ";
        Assert.AreEqual(comparison1, sw.ToString().Replace("\r\n", "\n"), "With wrong print command, you should not print!");
      }
    }

  }
}
