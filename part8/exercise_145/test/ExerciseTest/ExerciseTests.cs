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
 */
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

    [Test]
    public void AddShouldReturnTrue()
    {
      Assert.AreEqual(true, new VehicleRegistry().Add(new LicensePlate("FI", "ABC-123"), "Arto"), "Adding new plate to registry should return true!");
    }

    [Test]
    public void AddShouldReturnFalse()
    {
      VehicleRegistry register = new VehicleRegistry();
      LicensePlate li5 = new LicensePlate("D", "B WQ-433");
      register.Add(li5, "Jürgen");
      Assert.AreEqual(false, register.Add(new LicensePlate("D", "B WQ-433"), "Arto"), "Adding owner to existing plate should return false!");
    }

    [Test]
    public void GetShouldReturnOwner()
    {
      VehicleRegistry register = new VehicleRegistry();
      LicensePlate li5 = new LicensePlate("D", "B WQ-433");
      LicensePlate li2 = new LicensePlate("FI", "UXE-465");
      register.Add(li2, "Arto");
      register.Add(li5, "Jürgen");
      Assert.AreEqual("Jürgen", register.Get(li5), "Get should return the license plate owner!");
    }

    [Test]
    public void GetShouldReturnNotOwner()
    {
      VehicleRegistry register = new VehicleRegistry();
      LicensePlate li5 = new LicensePlate("D", "B WQ-433");
      LicensePlate li2 = new LicensePlate("FI", "UXE-465");
      register.Add(li2, "Arto");
      Assert.AreNotEqual("Arto", register.Get(li5), "If plate is not added, it return an error");
    }

    [Test]
    public void RemoveShouldReturnTrue()
    {
      VehicleRegistry register = new VehicleRegistry();
      LicensePlate li5 = new LicensePlate("D", "B WQ-433");
      LicensePlate li2 = new LicensePlate("FI", "UXE-465");
      register.Add(li2, "Arto");
      Assert.AreEqual(true, register.Remove(li2), "Remove should return true if the plate is removed");
    }

    [Test]
    public void RemoveShouldReturnFalse()
    {
      VehicleRegistry register = new VehicleRegistry();
      LicensePlate li5 = new LicensePlate("D", "B WQ-433");
      LicensePlate li2 = new LicensePlate("FI", "UXE-465");
      register.Add(li2, "Arto");
      Assert.AreEqual(false, register.Remove(li5), "Remove should return false if a plate is not removed");
    }

    [Test]
    public void ExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        LicensePlate li1 = new LicensePlate("FI", "ABC-123");
        LicensePlate li2 = new LicensePlate("FI", "UXE-465");
        LicensePlate li3 = new LicensePlate("D", "B WQ-431");
        LicensePlate li4 = new LicensePlate("D", "B WQ-432");
        LicensePlate li5 = new LicensePlate("D", "B WQ-433");

        VehicleRegistry register = new VehicleRegistry();

        register.Add(li1, "Arto");
        register.Add(li2, "Arto");
        register.Add(li3, "Jürgen");
        register.Add(li4, "Jürgen");
        register.Add(li5, "Jürgen");

        Console.WriteLine("Plates:");
        register.PrintLicensePlates();

        Console.WriteLine("Owners:");
        register.PrintOwners();

        Console.SetOut(stdout);
        string example = "Plates:\nFI ABC-123\nFI UXE-465\nD B WQ-431\nD B WQ-432\nD B WQ-433\nOwners:\nArto\nJürgen\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The example should work!");
      }
    }
  }
}