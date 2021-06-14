using System;
using System.IO;
using exercise_112;
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
      Assert.IsTrue(File.Exists("../../../TelevisionProgram.cs"), "You have deleted the necessary file!");
    }
/* 
    [Test]
    public void TestFindList()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Program.cs");
      }
      catch
      {
        Console.WriteLine("You have deleted the necessary file!");
      }
      int count = Regex.Matches(code, @"List<TelevisionProgram>\(\)").Count;

      Assert.AreEqual(1, count, "Remember to create the list for TelevisionProgram only once!");
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
    }
 */
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
                "Hoolahoop",
                "30",
                "Potato show",
                "45",
                "Masterchef",
                "60",
                "",
                "45"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison1 = "Name: Duration: Name: Duration: Name: Duration: Name: \nProgram's maximum duration? Hoolahoop, 30 minutes\nPotato show, 45 minutes\n";
        Assert.AreEqual(comparison1, sw.ToString().Replace("\r\n", "\n"), "Check your printing!");
      }
    }

        [Test]
    public void TestAddingToListWorksSingleTooShort()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "Hoolahoop",
                "60",
                "",
                "45"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison1 = "Name: Duration: Name: \nProgram's maximum duration? ";
        Assert.AreEqual(comparison1, sw.ToString().Replace("\r\n", "\n"), "If there are not long enough programs, don't print any");
      }
    }

  }
}
