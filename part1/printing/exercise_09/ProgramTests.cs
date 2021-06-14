using System;
using System.IO;
using exercise_09;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
    [TestFixture]
    public class TestProgram
    {
        [Test]
        public void TestExercise09()
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
                "Fine, thanks",
                "Not now"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.AreEqual("Hello, how are you?\nThat's interesting, tell me more\nThank you for sharing!\n", sw.ToString().Replace("\r\n", "\n"), "Remember to tell hello!");
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