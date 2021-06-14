using System;
using System.IO;
using exercise_125;
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
    public void TestTimerFileExists()
    {
      Assert.IsTrue(File.Exists("HealthStation.cs"), "Do not remove the HealthStation.cs");
    }


    [Test]
    public void TestHealthStationConstructor()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("HealthStation.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      HealthStation station = new HealthStation();

      Assert.AreEqual(station.GetType(), typeof(HealthStation), "The HealthStation should be of type HealthStation!");
    }

    [Test]
    public void TestPersonConstructor()
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
      Person mannen = new Person("Heikki", 15, 110, 185);

      Assert.AreEqual(mannen.GetType(), typeof(Person), "The Counter should be of type Counter!");
    }

    [Test]
    public void TestHealthStationWeighing()
    {
      Person mannen = new Person("Superman", 35, 200, 300);
      HealthStation station = new HealthStation();

      Assert.AreEqual(200, station.Weigh(mannen), "Station.Weigh(Person) should return the weight of the person!");
    }

        [Test]
    public void TestHealthStationWeighingAnother()
    {
      Person mannen = new Person("Master Blaster", 500, 3000, 300);
      HealthStation station = new HealthStation();

      Assert.AreEqual(3000, station.Weigh(mannen), "Station.Weigh(Person) should return the weight of the person!");
    }

    [Test]
    public void TestHealthStationFeeding()
    {
      Person mannen = new Person("Superman", 35, 200, 300);
      HealthStation station = new HealthStation();
      station.Feed(mannen);

      Assert.AreEqual(201, station.Weigh(mannen), "Station.Feed(Person) should increase the weight of the person by one!");
    }

    [Test]
    public void TestHealthStationFeedingMore()
    {
      Person mannen = new Person("Superman", 35, 200, 300);
      HealthStation station = new HealthStation();
      station.Feed(mannen);
      station.Feed(mannen);
      station.Feed(mannen);
      station.Feed(mannen);

      Assert.AreEqual(204, station.Weigh(mannen), "Station.Feed(Person) should increase the weight of the person by one!");
    }

        [Test]
    public void TestHealthStationWeighingCounter()
    {
      Person mannen = new Person("Superman", 35, 200, 300);
      HealthStation station = new HealthStation();
      station.Weigh(mannen);
      station.Weigh(mannen);
      station.Weigh(mannen);
      station.Weigh(mannen);

      Assert.AreEqual(4, station.weighings, "Station.Weigh(Person) should increase the weight and the 'int weighings' by one!");
    }

  }
}