using System;
using System.IO;
using exercise_02;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
    [TestFixture]
    public class TestProgram
    {
        [Test]
        public void TestPartsOfTextExist()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                // Call student's code
                Program.Main(null);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                StringAssert.Contains("Once upon a time", sw.ToString().Replace("\r\n", "\n"), "You're supposed to write the lyrics using 3 Console.Writelines.");
                StringAssert.Contains("I was falling in love", sw.ToString().Replace("\r\n", "\n"), "You're supposed to write the lyrics using 3 Console.Writelines.");
                StringAssert.Contains("Now I'm only falling apart", sw.ToString().Replace("\r\n", "\n"), "You're supposed to write the lyrics using 3 Console.Writelines.");
            }
        }

        [Test]
        public void TestStringMatch()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                // Call student's code
                Program.Main(null);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                StringAssert.AreEqualIgnoringCase("Once upon a time\nI was falling in love\nNow I'm only falling apart\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

/*         [Test]
        public void TestCountWriteLines()
        {
            string code = File.ReadAllText("../../../Program.cs");
            int count = Regex.Matches(code, "Console.WriteLine").Count;

            Assert.AreEqual(3, count, "You were supposed to use Console.WriteLine 3 times.");
        } */

    }
}