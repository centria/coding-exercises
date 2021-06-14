using System;
using System.IO;
using exercise_97;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestFileWhistleExists()
    {
      Assert.IsTrue(File.Exists("../../../Whistle.cs"), "You haven't created the file yet");
    }
/* 
    [Test]
    public void TestFindPrivateStringCode()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Whistle.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "private string sound;").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class 'private string sound'!");
    }

    [Test]
    public void TestFindConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Whistle.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, @"public Whistle\(string whistleSound\)").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class a constructor!");
    }
 */
   [Test]
    public void TestExerciseWhistleCreation()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Whistle Whistle = new Whistle("test");

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual(Whistle.GetType(), typeof(Whistle), "The Whistle should be able to be created with constructor call!");
      }
    }

       [Test]
    public void TestExerciseWhistleSound()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        new Whistle("whistleblower").Sound();

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("whistleblower\n", sw.ToString().Replace("\r\n", "\n"), "The Whistle should have a Sound() !");
      }
    }

  }
}
