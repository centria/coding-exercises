using System;
using System.IO;
using exercise_96;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestFileRoomExists()
    {
      Assert.IsTrue(File.Exists("../../../Room.cs"), "You haven't created the file yet");
    }

/*     [Test]
    public void TestFindPrivateStringCode()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Room.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "private string code;").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class 'private string code'!");
    }

    [Test]
    public void TestFindPrivateIntSeats()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Room.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "private int seats;").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class 'private int seats'!");
    }

    [Test]
    public void TestFindConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Room.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, @"public Room\(string classCode, int numberOfSeats\)").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class a constructor!");
    } */

   [Test]
    public void TestExerciseRoomCreation()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Room room = new Room("test", 12);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual(room.GetType(), typeof(Room), "The room should be able to be created with constructor call!");
      }
    }

  }
}
