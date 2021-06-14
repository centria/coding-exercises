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
        LicensePlate li1 = new LicensePlate("FI", "ABC-123");

        // Assert
        Assert.AreEqual(false, li1.Equals("heh"), "LicencePlate should not equal to a string!");
      }
    }

    [Test]
    public void TestEqualsSamePlateDifferentObject()
    {
      using (StringWriter sw = new StringWriter())
      {
        LicensePlate li1 = new LicensePlate("FI", "ABC-123");
        LicensePlate li2 = new LicensePlate("FI", "ABC-123");

        // Assert
        Assert.AreEqual(true, li1.Equals(li2), "LicencePlate should not equal to a string!");
      }
    }

    [Test]
    public void TestEqualsSamePlateSameObject()
    {
      using (StringWriter sw = new StringWriter())
      {
        LicensePlate li1 = new LicensePlate("FI", "ABC-123");
        LicensePlate li2 = new LicensePlate("FI", "ABC-123");

        // Assert
        Assert.AreEqual(true, li1.Equals(li2), "LicencePlate should not equal to a string!");
      }
    }

    [Test]
    public void TestHashCodeSameObject()
    {
      using (StringWriter sw = new StringWriter())
      {
        LicensePlate li1 = new LicensePlate("FI", "ABC-123");

        // Assert
        Assert.AreEqual(li1.GetHashCode(), li1.GetHashCode(), "GetHashCode should work if compared to self!");
      }
    }

    [Test]
    public void TestHashCodeDifferentObjectSameDate()
    {
      using (StringWriter sw = new StringWriter())
      {
        LicensePlate li1 = new LicensePlate("FI", "ABC-123");
        LicensePlate li2 = new LicensePlate("FI", "ABC-123");

        // Assert
        Assert.AreEqual(li1.GetHashCode(), li2.GetHashCode(), "GetHashCode should work if compared to same date!");
      }
    }

    [Test]
    public void TestHashCodeDifferentObjectDifferentDate()
    {
      using (StringWriter sw = new StringWriter())
      {
        LicensePlate li1 = new LicensePlate("FI", "ABC-123");
        LicensePlate li2 = new LicensePlate("FI", "UXE-465");

        // Assert
        Assert.AreNotEqual(li1.GetHashCode(), li2.GetHashCode(), "GetHashCode should not work if compared to different date!");
      }
    }
  }
}