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
/* 
    [Test]
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
    public void TestPrintKeys()
    {
      using (StringWriter sw = new StringWriter())
      {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add("f.e", "for example");
        dict.Add("etc.", "and so on");
        dict.Add("i.e", "more precisely");
        dict.Add("jne", "ja niin edelleen");

        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.PrintKeys(dict);
        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("f.e", sw.ToString().Replace("\r\n", "\n"), "You should print the keys with PrintKeys!");
        StringAssert.Contains("etc", sw.ToString().Replace("\r\n", "\n"), "You should print the keys with PrintKeys!");
        StringAssert.Contains("i.e", sw.ToString().Replace("\r\n", "\n"), "You should print the keys with PrintKeys!");
        StringAssert.Contains("jne", sw.ToString().Replace("\r\n", "\n"), "You should print the keys with PrintKeys!");
      }
    }

    [Test]
    public void TestPrintKeysWhereI()
    {
      using (StringWriter sw = new StringWriter())
      {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add("f.e", "for example");
        dict.Add("etc.", "and so on");
        dict.Add("i.e", "more precisely");
        dict.Add("jne", "ja niin edelleen");

        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.PrintKeysWhere(dict, "i");
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("i.e\n", sw.ToString().Replace("\r\n", "\n"), "You should only print the keys with given letter\nWith PrintKeysWhere!");
      }
    }


    [Test]
    public void TestPrintKeysWhereJ()
    {
      using (StringWriter sw = new StringWriter())
      {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add("f.e", "for example");
        dict.Add("etc.", "and so on");
        dict.Add("i.e", "more precisely");
        dict.Add("jne", "ja niin edelleen");

        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.PrintKeysWhere(dict, "j");
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("jne\n", sw.ToString().Replace("\r\n", "\n"), "You should only print the keys with given letter\nWith PrintKeysWhere!");
      }
    }

    [Test]
    public void TestPrintKeysWhereDotE()
    {
      using (StringWriter sw = new StringWriter())
      {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add("f.e", "for example");
        dict.Add("etc.", "and so on");
        dict.Add("i.e", "more precisely");
        dict.Add("jne", "ja niin edelleen");

        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.PrintKeysWhere(dict, ".e");
        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("f.e", sw.ToString().Replace("\r\n", "\n"), "You should only print the keys with given letter\nWith PrintKeysWhere!");
        StringAssert.Contains("i.e", sw.ToString().Replace("\r\n", "\n"), "You should only print the keys with given letter\nWith PrintKeysWhere!");
      }
    }

    [Test]
    public void TestPrintValuesWhereDotE()
    {
      using (StringWriter sw = new StringWriter())
      {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add("f.e", "for example");
        dict.Add("etc.", "and so on");
        dict.Add("i.e", "more precisely");
        dict.Add("jne", "ja niin edelleen");

        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.PrintValuesOfKeysWhere(dict, ".e");
        Console.SetOut(stdout);

        // Assert
        StringAssert.Contains("for example", sw.ToString().Replace("\r\n", "\n"), "You should print the values!");
        StringAssert.Contains("more precisely", sw.ToString().Replace("\r\n", "\n"), "You should print the values!");
        StringAssert.DoesNotContain("ja niin edelleen", sw.ToString().Replace("\r\n", "\n"), "You should print the values!");
      }
    }

  }
}