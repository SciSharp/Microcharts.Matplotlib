using System;
using Xunit;
using Xunit.Abstractions;
using Microcharts.Matplotlib;

namespace Test
{
    public class MainTest
    {
        private ITestOutputHelper _output;

        public MainTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestBarChart()
        {
            _output.WriteLine(MicrochartsBuilder.CreateBarChart(new [] { "C#", "Python", "Java", "Javascript" }, new [] {10, 8, 7, 9}).Show().ToString());
        }
    }
}
