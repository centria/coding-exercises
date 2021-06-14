using System;
using System.IO;
using exercise_117;
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
    public void TestCountReadLines()
    {

      string code = File.ReadAllText("Program.cs");
      int count = Regex.Matches(code, "File.Read").Count;

      Assert.AreEqual(1, count, "You were supposed to read the File only once.");
    } */

    [Test]
    public void TestExercise117DataFileContent()
    {
      using (StringWriter sw = new StringWriter())
      {

        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "data.txt"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Which file should have its contents printed?\nIn a world\nWhere code is built\nThere are magical creatures\nWe call them unicorns\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

    [Test]
    public void TestExercise117SongFileContent()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Force the test to find the data.txt

        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "song.txt"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);
        string song = "No option for duality \nThe old is where we come \nClockspeed is fast, but we'll survive \nThe new will overcome \nWe are challengers, not followers \nWe take the ball to build \nEasy safe services \nAre here to stay\n\nValue for society \nValue for life \nFor you and me \nTieto is here allright!\n";
        // Assert
        Assert.AreEqual("Which file should have its contents printed?\n" + song, sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }
    }

  }
}