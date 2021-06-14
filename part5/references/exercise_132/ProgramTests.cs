using System;
using System.IO;
using exercise_132;
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

/*     [Test]
    public void TestMainExists()
    {

      string code = File.ReadAllText("Program.cs");
      int count = Regex.Matches(code, @"public static void Main\(string\[\] args\)").Count;

      Assert.AreEqual(1, count, "Do not destroy the Main class from Program.cs!");
    }
 */
    [Test]
    public void TestConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("SimpleDate.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      SimpleDate date = new SimpleDate(1, 1, 1970);

      Assert.AreEqual(date.GetType(), typeof(SimpleDate), "The Date should be of type SimpleDate!");
    }

    [Test]
    public void TestToString()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("SimpleDate.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      SimpleDate date = new SimpleDate(1, 1, 1970);

      Assert.AreEqual("1.1.1970", date.ToString(), "The Constructor should create a new SimpleDate!");
    }

    [Test]
    public void TestAdvance()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("SimpleDate.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      SimpleDate date = new SimpleDate(1, 1, 1970);
      date.Advance();

      Assert.AreEqual("2.1.1970", date.ToString(), "Advance should advance the date by one day!");
    }

    [Test]
    public void TestAdvanceParam()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("SimpleDate.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      SimpleDate date = new SimpleDate(1, 1, 1970);
      date.Advance(31);

      Assert.AreEqual("2.2.1970", date.ToString(), "Advance(31) should advance the date by 31 days!");
    }

        [Test]
    public void TestAdvanceParamMuch()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("SimpleDate.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      SimpleDate date = new SimpleDate(1, 1, 1970);
      date.Advance(360);

      Assert.AreEqual("1.1.1971", date.ToString(), "Advance(360) should advance the date by one year!");
    }

    [Test]
    public void TestAfterDays()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("SimpleDate.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      SimpleDate date = new SimpleDate(1, 1, 1970);
      SimpleDate newDate = date.AfterNumberOfDays(100);

      Assert.AreEqual("11.4.1970", newDate.ToString(), "AfterNumberOfDays should create new SimpleDate Object!");
      Assert.AreEqual("1.1.1970", date.ToString(), "AfterNumberOfDays should not change the original Object's date!");
    }



  }
}