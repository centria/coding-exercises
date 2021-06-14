using System;
using System.IO;
using exercise_10;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
    [TestFixture]
    public class TestProgram
    {
        [Test]
        public void TestExercise10()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "Ada",
                "Data Scientist"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.AreEqual("I will tell a story, but I need some information.\nGive a name for main character:\n" +
                "Give the character a profession:\nHere is the story:\n" +
                "Once upon a time there was a Data Scientist called Ada\n" +
                "On her way to work, Ada often pondered what being Data Scientist meant to them.\n" +
                "When you work as a Data Scientist you meet interesting people.\n" +
                "Ada enjoys their work as Data Scientist, The end.\n", sw.ToString().Replace("\r\n", "\n"), "Your story should have name twice and profession 3 times!");
            }
        }

/*         [Test]
        public void TestCountReadLines()
        {
            string code = File.ReadAllText("../../../Program.cs");
            int count = Regex.Matches(code, "Console.ReadLine").Count;

            Assert.AreEqual(2, count, "You were supposed to use Console.ReadLine 2 times.");
        } */
    }
}