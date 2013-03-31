using FluentAssertions;
using Manicomio.SwosPlayerFinder.Core;
using Xunit;

namespace Manicomio.SwosPlayerFinder.Tests.Core
{
    public class SkillsParserFacts
    {
        public class Parse
        {
            [Fact]
            public void ReturnsZeroForAllSkillsWhenRawDataIsAllZeroes()
            {
                var parser = new SkillsParser();

                Skills skills = parser.Parse(0, 0, 0, 0);

                skills.Passing.Should().Be(1);
            }

            [Fact]
            public void ReturnsPassingFiveWhenFirstByteIsFive()
            {
                var parser = new SkillsParser();

                Skills skills = parser.Parse(5, 0, 0, 0);

                skills.Passing.Should().Be(6);
            }

            [Fact]
            public void ReturnsShootingFiveWhen()
            {
                var parser = new SkillsParser();

                Skills skills = parser.Parse(0, 95, 0, 0);

                skills.Shooting.Should().Be(6);
            }

            [Fact]
            public void ReturnsHeadingFiveWhen()
            {
                var parser = new SkillsParser();

                Skills skills = parser.Parse(0, 133, 0, 0);

                skills.Heading.Should().Be(6);
            }

        }
    }


    //  1 = nationality
    //  1
    // 23 = namn
    //  1 = position/head
    //  1
    //  1 = passing + något mer
    //  1 = shooting + heading
    //  1 = tackling + control
    //  1 = speed + finishing

    //  1 = value
    //  5 = career-stuff ?
}
