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
      string code = File.ReadAllText("../../src/Exercise/Program.cs");
      int count = Regex.Matches(code, @"public static void Main\(string\[\] args\)").Count;

      Assert.AreEqual(1, count, "Do not destroy the Main class from Program.cs!");
    }

    [Test]
    public void TestDictionaryIsUsedInClass()
    {
      string code = File.ReadAllText("../../src/Exercise/Program.cs");
      int count = Regex.Matches(code, @"Dictionary").Count;

      Assert.LessOrEqual(1, count, "Use Dictionary in your Program!");
    } */

    [Test]
    public void TestPrintValues()
    {
      using (StringWriter sw = new StringWriter())
      {
        Dictionary<string, Book> books = new Dictionary<string, Book>();
        Book senseAndSensibility = new Book("Sense and Sensibility", 1811, "...");
        Book prideAndPrejudice = new Book("Pride and Prejudice", 1813, "....");
        Book heikkisTerrificBook = new Book("Heikki's Terrific Book", 2022, "The end");
        books.Add(senseAndSensibility.name, senseAndSensibility);
        books.Add(prideAndPrejudice.name, prideAndPrejudice);
        books.Add(heikkisTerrificBook.name, heikkisTerrificBook);

        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.PrintValues(books);
        Console.SetOut(stdout);
        string expectedSense = "Name: Sense and Sensibility (1811)\nContent: ...";
        string expectedPride = "Name: Pride and Prejudice (1813)\nContent: ....";
        string expectedHeikki = "Name: Heikki's Terrific Book (2022)\nContent: The end";

        // Assert
        StringAssert.Contains(expectedSense, sw.ToString().Replace("\r\n", "\n"), "You should print all the books with PrintValues");
        StringAssert.Contains(expectedPride, sw.ToString().Replace("\r\n", "\n"), "You should print all the books with PrintValues");
        StringAssert.Contains(expectedHeikki, sw.ToString().Replace("\r\n", "\n"), "You should print all the books with PrintValues");
      }
    }

    [Test]
    public void TestPrintValueIfNameContainsPrejud()
    {
      using (StringWriter sw = new StringWriter())
      {
        Dictionary<string, Book> books = new Dictionary<string, Book>();
        Book senseAndSensibility = new Book("Sense and Sensibility", 1811, "...");
        Book prideAndPrejudice = new Book("Pride and Prejudice", 1813, "....");
        Book heikkisTerrificBook = new Book("Heikki's Terrific Book", 2022, "The end");
        books.Add(senseAndSensibility.name, senseAndSensibility);
        books.Add(prideAndPrejudice.name, prideAndPrejudice);
        books.Add(heikkisTerrificBook.name, heikkisTerrificBook);

        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.PrintValueIfNameContains(books, "prejud");
        Console.SetOut(stdout);
        string expectedPride = "Name: Pride and Prejudice (1813)\nContent: ....\n";

        // Assert
        Assert.AreEqual(expectedPride, sw.ToString().Replace("\r\n", "\n"), "You should print only the books that contain the part in their name\nWith PrintValueIfNameContains!");
      }
    }

    [Test]
    public void TestPrintValueIfNameContainsHeikki()
    {
      using (StringWriter sw = new StringWriter())
      {
        Dictionary<string, Book> books = new Dictionary<string, Book>();
        Book senseAndSensibility = new Book("Sense and Sensibility", 1811, "...");
        Book prideAndPrejudice = new Book("Pride and Prejudice", 1813, "....");
        Book heikkisTerrificBook = new Book("Heikki's Terrific Book", 2022, "The end");
        books.Add(senseAndSensibility.name, senseAndSensibility);
        books.Add(prideAndPrejudice.name, prideAndPrejudice);
        books.Add(heikkisTerrificBook.name, heikkisTerrificBook);

        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.PrintValueIfNameContains(books, "heikki");
        Console.SetOut(stdout);
        string expectedHeikki = "Name: Heikki's Terrific Book (2022)\nContent: The end\n";

        // Assert
        Assert.AreEqual(expectedHeikki, sw.ToString().Replace("\r\n", "\n"), "You should print only the books that contain the part in their name\nWith PrintValueIfNameContains!");
      }
    }

  }
}