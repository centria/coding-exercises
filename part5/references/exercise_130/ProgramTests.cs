using System;
using System.IO;
using exercise_130;
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
    public void TestBookExists()
    {
      Assert.IsTrue(File.Exists("Book.cs"), "Do not remove the Song.cs");
    }


    [Test]
    public void TestConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("Book.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      Book book = new Book("Novel idea", 2020);

      Assert.AreEqual(book.GetType(), typeof(Book), "The Song should be of type Song!");
    }

    [Test]
    public void TestAreEqual01()
    {
      Book book = new Book("Novel idea", 2020);
      Book book2 = new Book("Novel idea", 2020);
      Assert.AreEqual(book, book2, "Check your Equality!");
    }

    [Test]
    public void TestAreEqual02()
    {
      Book book = new Book("Novel ideas", 2019);
      Book book2 = new Book("Novel ideas", 2019);
      Assert.AreEqual(book, book2, "Check your Equality!");
    }

    [Test]
    public void TestAreNotEqual01()
    {
      Book book = new Book("Novel idea", 2020);
      Book book2 = new Book("Novel ideas", 2020);
      Assert.AreNotEqual(book, book2, "Check your Equality!");
    }

    [Test]
    public void TestAreNotEqual02()
    {
      Book book = new Book("Novel idea", 2020);
      Book book2 = new Book("Novel ideas", 2019);
      Assert.AreNotEqual(book, book2, "Check your Equality!");
    }

    [Test]
    public void TestAreNotEqual03()
    {
      Book book = new Book("Novel idea", 2020);
      Book book2 = new Book("Novel idea", 2019);
      Assert.AreNotEqual(book, book2, "Check your Equality!");
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
                "My Novel",
                "2020",
                "Hot potato",
                "2020",
                "Mein Bokken",
                "2019",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Name (empty will stop):\nPublication year:\nName (empty will stop):\nPublication year:\nName (empty will stop):\nPublication year:\nName (empty will stop):\nThank you! Books added: 3\n", sw.ToString().Replace("\r\n", "\n"), "Remember to add the books to a list and count them!");
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
                "My Novel",
                "2020",
                "My Novel",
                "2020",
                "Mein Bokken",
                "2019",
                "\n"
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null);

        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Name (empty will stop):\nPublication year:\nName (empty will stop):\nPublication year:\nThe book is already on the list. Let's not add the same book again.\nName (empty will stop):\nPublication year:\nName (empty will stop):\nThank you! Books added: 2\n", sw.ToString().Replace("\r\n", "\n"), "Remember to only add unique books!");
      }
    }

  }
}