using System;
using System.IO;
using NUnit.Framework;
using Exercise;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ExerciseTest
{
  public class Tests
  {
    string target = "../../../../../";
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

    [Test]
    public void TestSystemUsing()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.Main(null);

        Console.SetOut(stdout);
        string example = "Can we fix it? Yes we can!\n";
        StringAssert.Contains(example, sw.ToString().Replace("\r\n", "\n"), "You should be able to use bob!");
      }
    }

/*     [Test]
    public void TestAliasFound()
    {
      string code = File.ReadAllText("src/Exercise/Project/MasterProject.cs");
      int count = Regex.Matches(code, "using Builders = MasterProject.BuilderProject.Builders;").Count;

      Assert.GreaterOrEqual(count, 1, "You should create an alias 'Builders' for 'MasterProject.BuilderProject.Builders'!");
    }

    [Test]
    public void TestMasterAliasFound()
    {
      string code = File.ReadAllText("src/Exercise/Program.cs");
      int count = Regex.Matches(code, "using Master").Count;

      Assert.GreaterOrEqual(count, 1, "You should create an alias 'Master' for 'MasterProject.MasterClass'!");
    } */

  }
}
