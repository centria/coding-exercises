using System;
using System.IO;
using exercise_95;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestFileDogExists()
    {
      Assert.IsTrue(File.Exists("../../../Dog.cs"), "You haven't created the file yet");
    }

/*     [Test]
    public void TestFindPrivateStringName()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Dog.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "private string name;").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class 'private string name'!");
    }

    [Test]
    public void TestFindPrivateStringBreed()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Dog.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "private string breed;").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class 'private string breed'!");
    }

    [Test]
    public void TestFindPrivateIntAge()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Dog.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "private int age;").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class 'private int age'!");
    }
 */
  }
}
