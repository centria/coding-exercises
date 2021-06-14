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

/*     [Test]
    public void TestMainExists()
    {

      string code = File.ReadAllText("../../src/Exercise/Program.cs");
      int count = Regex.Matches(code, @"public static void Main\(string\[\] args\)").Count;

      Assert.AreEqual(1, count, "Do not destroy the Main class from Program.cs!");
    }

    [Test]
    public void TestAbbreviationsIsCreated()
    {

      string code = File.ReadAllText("../../src/Exercise/Abbreviations.cs");
      int count = Regex.Matches(code, @"public class Abbreviations").Count;

      Assert.LessOrEqual(1, count, "Create the Abbreviations.cs file!");
    }

    [Test]
    public void TestDictionaryIsUsedInClass()
    {

      string code = File.ReadAllText("../../src/Exercise/Abbreviations.cs");
      int count = Regex.Matches(code, @"Dictionary").Count;

      Assert.LessOrEqual(1, count, "Use Dictionary in your Class!");
    } */

    [Test]
    public void TestAbbreviationsClassHasAbbs()
    {
      {
        Abbreviations abbs = new Abbreviations();
        abbs.AddAbbreviation("np", "no problem");
        // Assert
        Assert.AreEqual(true, abbs.HasAbbreviation("np"), "HasAbbrebiation should find the added abbreviation!");
      }
    }

    [Test]
    public void TestAbbreviationsClassFindExpNP()
    {
      {
        Abbreviations abbs = new Abbreviations();
        abbs.AddAbbreviation("np", "no problem");
        // Assert
        Assert.AreEqual("no problem", abbs.FindExplanationFor("np"), "FindExplanation should find the explanation!");
      }
    }

    [Test]
    public void TestAbbreviationsClassFindExpETC()
    {
      {
        Abbreviations abbs = new Abbreviations();
        abbs.AddAbbreviation("etc", "et cetera");
        // Assert
        Assert.AreEqual("et cetera", abbs.FindExplanationFor("etc"), "FindExplanation should find the explanation!");
      }
    }

    [Test]
    public void TestAbbreviationsClassFindExpJNE()
    {
      {
        Abbreviations abbs = new Abbreviations();
        abbs.AddAbbreviation("jne", "ja niin edelleen");
        // Assert
        Assert.AreEqual("ja niin edelleen", abbs.FindExplanationFor("jne"), "FindExplanation should find the explanation!");
      }
    }


    [Test]
    public void TestAbbreviationsClassDoNotFindUnexisting()
    {
      {
        Abbreviations abbs = new Abbreviations();
        // Assert
        Assert.AreEqual("not found", abbs.FindExplanationFor("jne"), "FindExplanation should return 'not found' if the abbreviation does not exist!");
      }
    }
  }
}