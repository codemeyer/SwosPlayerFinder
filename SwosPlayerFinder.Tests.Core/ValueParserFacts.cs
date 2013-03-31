using FluentAssertions;
using Manicomio.SwosPlayerFinder.Core;
using Xunit;

namespace Manicomio.SwosPlayerFinder.Tests.Core
{
    public class ValueParserFacts
    {
        public class Parse
        {
            [Fact]
            public void ReturnsExpectedValues()
            {
                var parser = new ValueParser();
                parser.GetValue(0).Should().Be(0);
                parser.GetValue(11).Should().Be(150);
            }
        }
    }
}
