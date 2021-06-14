using System;
using System.IO;
using exercise_104;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestExample()
    {
      Multiplier multiplyByThree = new Multiplier(3);
      int result = multiplyByThree.Multiply(2);

      Assert.AreEqual(6, result, "Three times two should be six!");
    }

    [Test]
    public void TestExample2()
    {
      Multiplier multiplyByFour = new Multiplier(4);
      int result = multiplyByFour.Multiply(2);

      Assert.AreEqual(8, result, "Three times two should be six!");
    }

    [Test]
    public void TestBig()
    {
      Multiplier multiplyByFour = new Multiplier(53);
      multiplyByFour.Multiply(2);
      int result = multiplyByFour.Multiply(14);
      Assert.AreEqual(1484, result, "Three times two should be six!");
    }

    [Test]
    public void TestBig2()
    {
      Multiplier multiplyByFour = new Multiplier(532);
      multiplyByFour.Multiply(27);
      int result = multiplyByFour.Multiply(141);
      Assert.AreEqual(2025324, result, "Three times two should be six!");
    }

    [Test]
    public void TestFileMultiplyExists()
    {
      Assert.IsTrue(File.Exists("../../../Multiplier.cs"), "You haven't created the file yet");
    }

/*     [Test]
    public void TestFindMethodFull()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Multiplier.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "public int Multiply").Count;

      Assert.AreEqual(1, count, "Remember to create method Multiply!");
    } */

  }
}
