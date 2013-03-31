using FluentAssertions;
using Manicomio.SwosPlayerFinder.Core;
using Xunit;

namespace Manicomio.SwosPlayerFinder.Tests.Core
{
    public class TeamParserFacts
    {
        public class Parse
        {
            [Fact]
            public void TeamHasCorrectName()
            {
                byte[] data = ExampleData();

                Team team = TeamParser.Parse(data);

                team.Name.Should().Be("BAYERN");
            }

            [Fact]
            public void TeamHasCorrectNationality()
            {
                byte[] data = ExampleData();

                Team team = TeamParser.Parse(data);

                team.Nationality.Should().Be("GERMANY");
            }

            private static byte[] ExampleData()
            {
                return new byte[] {
                    14,   // nation
                    0, 0, 0, 0,
                    66, 65, 89, 69, 82, 78, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,   // name
                    0, 0,  // tactics, division
                    0, 0, 0, 0, 0,  // first kit
                    0, 0, 0, 0, 0,  // second kit
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,   // coach name
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            }
        }
    }
}
