using System;
using System.IO;
using exercise_101;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestPrintExample()
    {
      using (StringWriter sw = new StringWriter())
      {

        Dalmatian spotty = new Dalmatian("Spot", 306);
        string test = spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur";

        // Assert
        Assert.AreEqual("Spot is a very good dog. He has 306 darker spots in his fur", test, "The name and spots should be callable from Main!");
      }
    }

    [Test]
    public void TestMultipleDogs()
    {
      using (StringWriter sw = new StringWriter())
      {

        Dalmatian spotty = new Dalmatian("Spot", 306);
        string test1 = spotty.name + spotty.spots;

        // Assert
        Assert.AreEqual("Spot306", test1, "The name and spots should be callable from Main!");


        Dalmatian spotty2 = new Dalmatian("Spotty", 101);
        string test2 = spotty2.name + spotty2.spots;

        // Assert
        Assert.AreEqual("Spotty101", test2, "The name and spots should be callable from Main!");
      }
    }

    [Test]
    public void TestFileDalmatianExists()
    {
      Assert.IsTrue(File.Exists("../../../Dalmatian.cs"), "You haven't created the file yet");
    }
/* 
    [Test]
    public void TestFindPublicStringName()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Dalmatian.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "public string name").Count;

      Assert.AreEqual(1, count, "Remember to make the name public!");
    }

    [Test]
    public void TestFindPublicIntSpots()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Dalmatian.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "public int spots").Count;

      Assert.AreEqual(1, count, "Remember to make spots public!");
    }
 */
/*     [Test]
    public void TestFindConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Dalmatian.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, @"public Dalmatian\(string name, int spots\)").Count;

      Assert.AreEqual(1, count, "Remember to create the constructor!");
    }
 */
  }
}
