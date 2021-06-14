using System;
using System.IO;
using exercise_129;
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

 /*    [Test]
    public void TestMainExists()
    {

      string code = File.ReadAllText("Program.cs");
      int count = Regex.Matches(code, @"public static void Main\(string\[\] args\)").Count;

      Assert.AreEqual(1, count, "Do not destroy the Main class from Program.cs!");
    }
 */
    [Test]
    public void TestSongExists()
    {
      Assert.IsTrue(File.Exists("Song.cs"), "Do not remove the Song.cs");
    }


    [Test]
    public void TestConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Song.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);

      Assert.AreEqual(jackSparrow.GetType(), typeof(Song), "The Song should be of type Song!");
    }

    [Test]
    public void TestAreEqual01()
    {
      Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
      Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
      Assert.AreEqual(jackSparrow, anotherSparrow, "Check your Equality!");
    }

    [Test]
    public void TestAreEqual02()
    {
      Song jackSparrow = new Song("The Lonely Islanders", "Jack Sparrows", 1960);
      Song anotherSparrow = new Song("The Lonely Islanders", "Jack Sparrows", 1960);
      Assert.AreEqual(jackSparrow, anotherSparrow, "Check your Equality!");
    }

    [Test]
    public void TestAreNotEqual01()
    {
      Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 197);
      Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
      Assert.AreNotEqual(jackSparrow, anotherSparrow, "Check your Equality!");
    }

    [Test]
    public void TestAreNotEqual02()
    {
      Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
      Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrows", 196);
      Assert.AreNotEqual(jackSparrow, anotherSparrow, "Check your Equality!");
    }

    [Test]
    public void TestAreNotEqual03()
    {
      Song jackSparrow = new Song("The Lonely Island", "Jack Sparrows", 196);
      Song anotherSparrow = new Song("The Lonely Islands", "Jack Sparrows", 196);
      Assert.AreNotEqual(jackSparrow, anotherSparrow, "Check your Equality!");
    }

  }
}