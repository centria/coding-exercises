using System;
using System.IO;
using exercise_127;
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
/* 
    [Test]
    public void TestMainExists()
    {

      string code = File.ReadAllText("Program.cs");
      int count = Regex.Matches(code, @"public static void Main\(string\[\] args\)").Count;

      Assert.AreEqual(1, count, "Do not destroy the Main class from Program.cs!");
    }
 */
    [Test]
    public void TestPersonFileExists()
    {
      Assert.IsTrue(File.Exists("Person.cs"), "Do not remove the Person.cs");
    }


    [Test]
    public void TestPersonConstructorType()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Person.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Person lilo = new Person();

      Assert.AreEqual(lilo.GetType(), typeof(Person), "The Counter should be of type Counter!");
    }

    [Test]
    public void TestPersonConstructorWithName()
    {
      Person mike = new Person("Mike");
      Assert.AreEqual("Mike, has a friend called Toothless (dragon)", mike.ToString(), "Modify the ToString and nothing else");
    }

    [Test]
    public void TestPersonConstructorNoParams()
    {
      Person lilo = new Person();
      Assert.AreEqual("Lilo, has a friend called Stitch (blue alien)", lilo.ToString(), "Modify the ToString and nothing else");
    }

    [Test]
    public void TestPersonConstructorAllParams()
    {
      Pet lucy = new Pet("Lucille", "golden dragon");
      Person leo = new Person("Leonard", lucy);
      Assert.AreEqual("Leonard, has a friend called Lucille (golden dragon)", leo.ToString(), "Modify the ToString and nothing else");
    }

  }
}