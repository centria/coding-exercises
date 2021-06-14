using System;
using System.IO;
using exercise_118;
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

/*     [Test]
    public void TestCountReadLines()
    {

      string code = File.ReadAllText("Program.cs");
      int count = Regex.Matches(code, "File.Read").Count;

      Assert.AreEqual(1, count, "You were supposed to read the File only once.");
    } */

    [Test]
    public void TestExercise118NamesFileContent()
    {
      using (StringWriter sw = new StringWriter())
      {

        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "names.txt",
                "arto",
                "leena",
                "test",
                "matthew",
                "dotnet",
                "heikki",
                "ada",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Name of the file:\n\nEnter names, an empty line quits.\nThe name is on the list.\nThe name is on the list.\nThe name is on the list.\nThe name is not on the list.\nThe name is not on the list.\nThe name is on the list.\nThe name is on the list.\nThank you!\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

    [Test]
    public void TestExercise118OtherFilesHeikki()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Force the test to find the data.txt

        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "other-names.txt",
                "heikki",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Name of the file:\n\nEnter names, an empty line quits.\nThe name is not on the list.\nThank you!\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

    [Test]
    public void TestExercise118OtherNamesFileContent()
    {
      using (StringWriter sw = new StringWriter())
      {

        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
          "other-names.txt",
          "leo",
          "jarmo",
          "alicia",
          "mike",
          "potato",
          "\n"
        });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Name of the file:\n\nEnter names, an empty line quits.\nThe name is on the list.\nThe name is on the list.\nThe name is on the list.\nThe name is on the list.\nThe name is on the list.\nThank you!\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }


  }
}