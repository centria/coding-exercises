using System;
using System.IO;
using exercise_124;
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
    public void TestExerciseException()
    {
      using (StringWriter sw = new StringWriter())
      {
        Assert.Throws<NullReferenceException>(() => Program.Main(null), "Does your program give NullReferenceException?");
      }
    }



  }
}