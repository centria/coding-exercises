using System;
using System.IO;
using exercise_134;
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
    public void TestAverageOfPoints()
    {
      GradeRegister register = new GradeRegister();
      register.AddGradeBasedOnPoints(51);
      register.AddGradeBasedOnPoints(50);
      register.AddGradeBasedOnPoints(49);
      Assert.AreEqual(50, register.AverageOfPoints(), "The average should be from all the grades");
    }

    [Test]
    public void TestAverageOfPointsLarger()
    {
      GradeRegister register = new GradeRegister();
      register.AddGradeBasedOnPoints(51);
      register.AddGradeBasedOnPoints(50);
      register.AddGradeBasedOnPoints(51);
      register.AddGradeBasedOnPoints(50);
      register.AddGradeBasedOnPoints(51);
      register.AddGradeBasedOnPoints(50);
      register.AddGradeBasedOnPoints(51);
      register.AddGradeBasedOnPoints(50);
      register.AddGradeBasedOnPoints(49);
      Assert.AreEqual(Math.Round(Convert.ToDouble("50.33", System.Globalization.CultureInfo.InvariantCulture), 2), register.AverageOfPoints(), "The average should be rounded to two decimals");
    }

    [Test]
    public void TestAverageOfGrades()
    {
      GradeRegister register = new GradeRegister();
      register.AddGradeBasedOnPoints(51);
      register.AddGradeBasedOnPoints(50);
      register.AddGradeBasedOnPoints(49);
      Assert.AreEqual(Math.Round(Convert.ToDouble("0.67", System.Globalization.CultureInfo.InvariantCulture), 2), register.AverageOfGrades(), "The average should be from all the grades");
    }


    [Test]
    public void TestAverageOfGradesLarger()
    {
      GradeRegister register = new GradeRegister();
      register.AddGradeBasedOnPoints(151);
      register.AddGradeBasedOnPoints(80);
      register.AddGradeBasedOnPoints(89);
      register.AddGradeBasedOnPoints(99);
      register.AddGradeBasedOnPoints(89);
      register.AddGradeBasedOnPoints(79);
      register.AddGradeBasedOnPoints(61);
      register.AddGradeBasedOnPoints(50);
      register.AddGradeBasedOnPoints(49);
      Assert.AreEqual(Math.Round(Convert.ToDouble("3.11", System.Globalization.CultureInfo.InvariantCulture), 2), register.AverageOfGrades(), "The average should be from all the grades");
    }

  }
}