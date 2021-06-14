using System;
using System.IO;
using exercise_131;
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
    public void TestItemExists()
    {
      Assert.IsTrue(File.Exists("Item.cs"), "Do not remove the Song.cs");
    }


    [Test]
    public void TestConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Item.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Item item = new Item("B07H8ND8HH", "He-Man figure");

      Assert.AreEqual(item.GetType(), typeof(Item), "The Song should be of type Song!");
    }

    [Test]
    public void TestAreEqual01()
    {
      Item item = new Item("B07H8ND8HH", "He-Man figure");
      Item item2 = new Item("B07H8ND8HH", "He-Man figurine");
      Assert.AreEqual(item, item2, "Check your Equality!");
    }

    [Test]
    public void TestAreEqual02()
    {
      Item item = new Item("B07H8ND8HH", "He-Man figure");
      Item item2 = new Item("B07H8ND8HH", "Ken doll");
      Assert.AreEqual(item, item2, "Check your Equality!");
    }

    [Test]
    public void TestAreNotEqual01()
    {
      Item item = new Item("B07H8ND8H", "He-Man figure");
      Item item2 = new Item("B07H8ND8HH", "He-Man figure");
      Assert.AreNotEqual(item, item2, "Check your Equality, should be on identifier!");
    }

    [Test]
    public void TestAreNotEqual02()
    {
      Item item = new Item("B07H8ND8HHH", "He-Man figure");
      Item item2 = new Item("B07H8ND8HH", "He-Man figure");
      Assert.AreNotEqual(item, item2, "Check your Equality, should be on identifier!");
    }

    [Test]
    public void TestExercise130Once()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "B07H8ND8HHH",
                "He-Man figure",
                "B07H8ND8HHH",
                "He-Man figurine",
                "B07H8ND8HHH",
                "Barbie fig",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Identifier? (empty will stop):\nName? (empty will stop):\nIdentifier? (empty will stop):\nName? (empty will stop):\nIdentifier? (empty will stop):\nName? (empty will stop):\nIdentifier? (empty will stop):\n==Items==\nB07H8ND8HHH: He-Man figure\n", sw.ToString().Replace("\r\n", "\n"), "Remember to add the books to a list and count them!");
      }
    }

    [Test]
    public void TestExercise130Twice()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "B07H8ND8HHH",
                "He-Man figure",
                "B07H8ND8H",
                "He-Man figure",
                "B07H8ND8HHHJK",
                "He-Man figure",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Identifier? (empty will stop):\nName? (empty will stop):\nIdentifier? (empty will stop):\nName? (empty will stop):\nIdentifier? (empty will stop):\nName? (empty will stop):\nIdentifier? (empty will stop):\n==Items==\nB07H8ND8HHH: He-Man figure\nB07H8ND8H: He-Man figure\nB07H8ND8HHHJK: He-Man figure\n", sw.ToString().Replace("\r\n", "\n"), "Remember to only add unique books!");
      }
    }

  }
}