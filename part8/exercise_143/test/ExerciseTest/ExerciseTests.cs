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

  /*   [Test]
    public void TestMainExists()
    {
      string code = File.ReadAllText("../../src/Exercise/Program.cs");
      int count = Regex.Matches(code, @"public static void Main\(string\[\] args\)").Count;

      Assert.AreEqual(1, count, "Do not destroy the Main class from Program.cs!");
    } */

    [Test]
    public void TestEqualsString()
    {
      using (StringWriter sw = new StringWriter())
      {
        SimpleDate d = new SimpleDate(1, 2, 2000);

        // Assert
        Assert.AreEqual(false, d.Equals("heh"), "SimpleDate should not equal to a string!");
      }
    }

    [Test]
    public void TestEqualsDifferentDate()
    {
      using (StringWriter sw = new StringWriter())
      {
        SimpleDate d = new SimpleDate(1, 2, 2000);

        // Assert
        Assert.AreEqual(false, d.Equals(new SimpleDate(5, 2, 2012)), "SimpleDate should not equal to different date!");
      }
    }
    [Test]
    public void TestEqualsSameDate()
    {
      using (StringWriter sw = new StringWriter())
      {
        SimpleDate d = new SimpleDate(1, 2, 2000);

        // Assert
        Assert.AreEqual(true, d.Equals(new SimpleDate(1, 2, 2000)), "SimpleDate should equal to same date!");
      }
    }

    [Test]
    public void TestHashCodeSameObject()
    {
      using (StringWriter sw = new StringWriter())
      {
        SimpleDate d = new SimpleDate(1, 2, 2000);

        // Assert
        Assert.AreEqual(d.GetHashCode(), d.GetHashCode(), "GetHashCode should work if compared to self!");
      }
    }

    [Test]
    public void TestHashCodeDifferentObjectSameDate()
    {
      using (StringWriter sw = new StringWriter())
      {
        SimpleDate d = new SimpleDate(1, 2, 2000);
        SimpleDate d2 = new SimpleDate(1, 2, 2000);

        // Assert
        Assert.AreEqual(d.GetHashCode(), d2.GetHashCode(), "GetHashCode should work if compared to same date!");
      }
    }

    [Test]
    public void TestHashCodeDifferentObjectDifferentDate()
    {
      using (StringWriter sw = new StringWriter())
      {
        SimpleDate d = new SimpleDate(1, 2, 2000);
        SimpleDate d2 = new SimpleDate(5, 2, 2000);

        // Assert
        Assert.AreNotEqual(d.GetHashCode(), d2.GetHashCode(), "GetHashCode should not work if compared to different date!");
      }
    }
  }
}