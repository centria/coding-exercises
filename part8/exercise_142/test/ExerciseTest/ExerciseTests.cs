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
    public void TestDictionaryIsUsedInClass()
    {
      string code = File.ReadAllText("../../src/Exercise/IOU.cs");
      int count = Regex.Matches(code, @"Dictionary").Count;

      Assert.LessOrEqual(1, count, "Use Dictionary in your IOU!");
    } */


    [Test]
    public void TestSimpleAdd()
    {
      using (StringWriter sw = new StringWriter())
      {
        IOU myIou = new IOU();
        myIou.ChangeDebt("You", 69);

        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Console.WriteLine(myIou.HowMuchDoIOweTo("You"));
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("69\n", sw.ToString().Replace("\r\n", "\n"), "Single Change should still update the value!");
      }
    }

    [Test]
    public void TestSimpleNegativeAdd()
    {
      using (StringWriter sw = new StringWriter())
      {
        IOU myIou = new IOU();
        myIou.ChangeDebt("You", -69);

        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Console.WriteLine(myIou.HowMuchDoIOweTo("You"));
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("0\n", sw.ToString().Replace("\r\n", "\n"), "Initial negative should not add debt!");
      }
    }

    [Test]
    public void TestExample()
    {
      using (StringWriter sw = new StringWriter())
      {
        IOU mattsIOU = new IOU();
        mattsIOU.ChangeDebt("Arthur", 51);
        mattsIOU.ChangeDebt("Michael", 30);

        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));
        Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Michael"));
        Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Heikki"));
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("51\n30\n0\n", sw.ToString().Replace("\r\n", "\n"), "The example should work!");
      }
    }

    [Test]
    public void TestSecondExample()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        IOU mattsIOU = new IOU();
        mattsIOU.ChangeDebt("Arthur", -10);
        Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));
        mattsIOU.ChangeDebt("Arthur", 51);
        mattsIOU.ChangeDebt("Arthur", 30);
        Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));
        mattsIOU.ChangeDebt("Arthur", -30);
        Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));
        mattsIOU.ChangeDebt("Arthur", -80);
        Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));
        Console.SetOut(stdout);
        Assert.AreEqual("0\n81\n51\n0\n", sw.ToString().Replace("\r\n", "\n"), "The second example should work!");
      }
    }

    [Test]
    public void TestMultipleChanges()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        IOU mattsIOU = new IOU();
        mattsIOU.ChangeDebt("Heikki", 81);
        mattsIOU.ChangeDebt("Heikki", -30);
        Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Heikki"));
        mattsIOU.ChangeDebt("Heikki", 20);
        Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Heikki"));
        mattsIOU.ChangeDebt("Heikki", 80);
        Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Heikki"));
        mattsIOU.ChangeDebt("Heikki", -121);
        Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Heikki"));
        Console.SetOut(stdout);
        Assert.AreEqual("51\n71\n151\n30\n", sw.ToString().Replace("\r\n", "\n"), "Multiple changes should change the value multiple times!");
      }
    }

  }
}