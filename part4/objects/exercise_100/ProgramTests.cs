using System;
using System.IO;
using exercise_100;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {


    [Test]
    public void TestPrintBalance()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Debt debt = new Debt(1000000.00, 1.2);
        debt.PrintBalance();

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("1000000\n".Replace(",", "."), sw.ToString().Replace(",", ".").Replace("\r\n", "\n"), "PrintBalance should print the current balance!");
      }
    }

    [Test]
    public void TestPrintBalanceWithInterest()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Debt debt = new Debt(1000000.00, 1.2);
        debt.WaitOneYear();
        debt.WaitOneYear();
        debt.PrintBalance();

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("1440000\n".Replace(",", "."), sw.ToString().Replace(",", ".").Replace("\r\n", "\n"), "PrintBalance should print the current balance!");
      }
    }

    [Test]
    public void TestFileDebtExists()
    {
      Assert.IsTrue(File.Exists("../../../Debt.cs"), "You haven't created the file yet");
    }

/*     [Test]
    public void TestFindPrivateDoubleInterestRate()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Debt.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "private double interestRate;").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class 'private double interestRate'!");
    } */

/*     [Test]
    public void TestFindPrivateDoubleBalance()
    {
      string code = "";
      try
      {
        code = File.ReadAllText("../../../Debt.cs");
      }
      catch
      {
        Console.WriteLine("Your file is not there yet!");
      }
      int count = Regex.Matches(code, "private double balance;").Count;

      Assert.AreEqual(1, count, "You were supposed to give the class 'private double balance'!");
    }
 */
  }
}
