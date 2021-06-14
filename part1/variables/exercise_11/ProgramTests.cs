using System;
using System.IO;
using exercise_11;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
    [TestFixture]
    public class TestProgram
    {
        [Test]
        public void TestExercise11()
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
                Assert.AreEqual("Days to summer:\n200\nHours to lunch:\n"+3.5+"\nCoding is fun:\nIt sure is!\n", sw.ToString().Replace("\r\n", "\n"), "Change the variable values!");
            }
        }

/*                 [Test]
        public void TestCountWriteLines()
        {
            string code = File.ReadAllText("../../../Program.cs");
            int count = Regex.Matches(code, "Console.WriteLine").Count;

            StringAssert.Contains("Console.WriteLine(\"Days to summer:\");", code, "You were not supposed to change the WriteLines!");
            StringAssert.Contains("Console.WriteLine(dayCount);", code, "You were not supposed to change the WriteLines!");
            StringAssert.Contains("Console.WriteLine(\"Hours to lunch:\");", code, "You were not supposed to change the WriteLines!");
            StringAssert.Contains("Console.WriteLine(hoursToLunch);", code, "You were not supposed to change the WriteLines!");
            StringAssert.Contains("Console.WriteLine(\"Coding is fun:\");", code, "You were not supposed to change the WriteLines!");
            StringAssert.Contains("Console.WriteLine(statement);", code, "You were not supposed to change the WriteLines!");

            Assert.AreEqual(6, count, "You were not supposed to change the WriteLines!");
        } */
    }
}