using System;
using System.IO;
using exercise_126;
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
    public void TestTimerFileExists()
    {
      Assert.IsTrue(File.Exists("PaymentCard.cs"), "Do not remove the PaymentCard.cs");
    }


    [Test]
    public void TestCardAddMoney()
    {
      PaymentCard card = new PaymentCard(10);
      card.AddMoney(5);

      Assert.AreEqual(15, card.balance, "AddMoney should increase the balance by the amount!");
    }


    [Test]
    public void TestCardTakeMoneyBalance()
    {
      PaymentCard card = new PaymentCard(10);
      card.TakeMoney(8);

      Assert.AreEqual(2, card.balance, "TakeMoney should decrease the balance by the amount!");
    }

    [Test]
    public void TestCardTakeTooMuchMoneyBalance()
    {
      PaymentCard card = new PaymentCard(2);
      card.TakeMoney(8);

      Assert.AreEqual(2, card.balance, "TakeMoney should not decrease the balance if there isn't enough!");
    }

    [Test]
    public void TestCardTakeTooMuchMoneyBoolean()
    {
      PaymentCard card = new PaymentCard(2);
      Assert.AreEqual(false, card.TakeMoney(8), "TakeMoney should return false if there isn't enough!");
    }

    [Test]
    public void TestCardTakeMoneyBoolean()
    {
      PaymentCard card = new PaymentCard(20);
      Assert.AreEqual(true, card.TakeMoney(8), "TakeMoney should return true if there is enough to take!");
    }

    [Test]
    public void TestTerminalConstructor()
    {
      PaymentTerminal terminal = new PaymentTerminal();
      Assert.AreEqual(1000, terminal.money, "Terminal should start with 1000 cash!");
      Assert.AreEqual(0, terminal.coffeeAmount, "Terminal should start with 0 coffees sold");
      Assert.AreEqual(0, terminal.lunchAmount, "Terminal should start with 0 lunches sold");
    }

    [Test]
    public void TestDrinkCoffeeFromCard()
    {
      PaymentTerminal terminal = new PaymentTerminal();
      PaymentCard card = new PaymentCard(5);
      terminal.DrinkCoffee(card);
      Assert.AreEqual(Math.Round(Convert.ToDouble("2.5", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(card.balance, 2), "Buying coffee should decrease tha amount by 2.5!");
    }

    [Test]
    public void TestDrinkCoffeeFromCardBooleanTrue()
    {
      PaymentTerminal terminal = new PaymentTerminal();
      PaymentCard card = new PaymentCard(5);
      Assert.AreEqual(true, terminal.DrinkCoffee(card), "Buying coffee should return true if balance is enough");
    }

    [Test]
    public void TestDrinkCoffeeFromCardBooleanFalse()
    {
      PaymentTerminal terminal = new PaymentTerminal();
      PaymentCard card = new PaymentCard(2);
      Assert.AreEqual(false, terminal.DrinkCoffee(card), "Buying coffee should return false if balance is not enough");
    }

    [Test]
    public void TestEatLunchFromCardBooleanFalse()
    {
      PaymentTerminal terminal = new PaymentTerminal();
      PaymentCard card = new PaymentCard(2);
      Assert.AreEqual(false, terminal.EatLunch(card), "Buying coffee should return false if balance is not enough");
    }

    [Test]
    public void TestEatLunchFromCardBooleanTrue()
    {
      PaymentTerminal terminal = new PaymentTerminal();
      PaymentCard card = new PaymentCard(11);
      Assert.AreEqual(true, terminal.EatLunch(card), "Buying coffee should return true if balance is enough");
    }


    [Test]
    public void TestEatLunchFromCard()
    {
      PaymentTerminal terminal = new PaymentTerminal();
      PaymentCard card = new PaymentCard(11);
      terminal.EatLunch(card);
      Assert.AreEqual(Math.Round(Convert.ToDouble("0.7", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(card.balance, System.Globalization.CultureInfo.InvariantCulture), 2), "Lunch should decrease the balance by 10.3!");
    }

    [Test]
    public void TestEatLunchFromCardNotEnoughMoney()
    {
      PaymentTerminal terminal = new PaymentTerminal();
      PaymentCard card = new PaymentCard(10);
      terminal.EatLunch(card);
      Assert.AreEqual(10, card.balance, "Lunch should not decrease the balance if there is not enough money!");
    }

    [Test]
    public void TestAddMoneyToBalances()
    {
      PaymentTerminal terminal = new PaymentTerminal();
      PaymentCard card = new PaymentCard(10);
      terminal.AddMoneyToCard(card, 10);
      Assert.AreEqual(20, card.balance, "Adding money should increase the balance of the card!");
      Assert.AreEqual(1010, terminal.money, "Adding money should increase the money of the terminal!");
    }

  }
}