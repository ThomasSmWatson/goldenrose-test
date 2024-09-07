
using GildedRoseKata;

using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using VerifyXunit;

using Xunit;

namespace GildedRoseTests
{
    public class ApprovalTest
    {
        [Fact]
        public Task ThirtyDays()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { "30" });
            var output = fakeoutput.ToString();
            return Verifier.Verify(output);
        }


        [Fact]
        public void GoldenMasterComparison()
        {
            string goldenMasterOutputFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "original_output.txt");
            var goldenMasterOutput = File.ReadAllText(goldenMasterOutputFilePath);

            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { "30" });
            var output = fakeoutput.ToString();

            Assert.Equal(goldenMasterOutput, output);
        }
    }
}
