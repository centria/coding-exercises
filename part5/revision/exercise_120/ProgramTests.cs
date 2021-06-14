using System;
using System.IO;
using exercise_120;
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
    } */

    [Test]
    public void TestCubeFileExists()
    {
      Assert.IsTrue(File.Exists("Cube.cs"), "The Cube.cs file is not yet created.");
    }


    [Test]
    public void TestCubeConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Cube.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Cube cube = new Cube(2);

      Assert.AreEqual(cube.GetType(), typeof(Cube), "The Cube should be a cube!");
    }

    [Test]
    public void TestCubeVolume()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Cube.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Cube cube = new Cube(3);

      Assert.AreEqual(27, cube.Volume(), "The volume of Cube should be edgeLength squared");
    }

    [Test]
    public void TestHugeCubeVolume()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Cube.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Cube cube = new Cube(42);

      Assert.AreEqual(74088, cube.Volume(), "The volume of Cube should be edgeLength squared");
    }

    [Test]
    public void TestRandomCubeVolume()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Cube.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Random rnd = new Random();
      int rand = rnd.Next(1, 100);
      Cube cube = new Cube(rand);

      Assert.AreEqual( (rand*rand*rand), cube.Volume(), "Called new Cube({0}), The volume of Cube should be edgeLength squared", rand);
    }

    [Test]
    public void TestCubeToString()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Cube.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Cube cube = new Cube(4);
      Assert.AreEqual("The length of the edge is " + 4 + " and the volume " + 64, cube.ToString(), "The ToString should contain both edgeLength and volume (in the form given in the exercise).");
    }

  }
}
