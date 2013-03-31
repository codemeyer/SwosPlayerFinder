using FluentAssertions;
using Manicomio.SwosPlayerFinder.Core;
using Xunit;

namespace Manicomio.SwosPlayerFinder.Tests.Core
{
    public class PlayerParserFacts
    {
        public class Parse
        {
            [Fact]
            public void ParsedPlayerGetsCorrectNationality()
            {
                byte[] data = ExampleData();

                Player player = PlayerParser.Parse(data);

                player.Nationality.Should().Be("SWEDEN");
            }

            [Fact]
            public void ParsedPlayerGetsCorrectName()
            {
                byte[] data = ExampleData();

                Player player = PlayerParser.Parse(data);

                player.Name.Should().Be("ZLATAN");
            }

            [Fact]
            public void ParsedPlayerGetsCorrectPosition()
            {
                byte[] data = ExampleData();

                Player player = PlayerParser.Parse(data);

                player.Position.Should().Be(Position.Attacker);
            }

            [Fact]
            public void ParsedPlayerGetsCorrectSkills()
            {
                byte[] data = ExampleData();
 
                Player player = PlayerParser.Parse(data);

                player.Skills.Passing.Should().Be(6);
                player.Skills.Shooting.Should().Be(6);
                player.Skills.Heading.Should().Be(8);
                player.Skills.Tackling.Should().Be(6);
                player.Skills.Control.Should().Be(8);
                player.Skills.Speed.Should().Be(6);
                player.Skills.Finishing.Should().Be(8);
            }

            [Fact]
            public void ParsedPlayerGetsCorrectValue()
            {
                byte[] data = ExampleData();

                Player player = PlayerParser.Parse(data);

                player.Value.Should().Be(8000);
            }

            private static byte[] ExampleData()
            {
                return new byte[] {
                    33,
                    0, 0,
                    90, 76, 65, 84, 65, 78, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,   // name
                    250, 0,           // position/etc + unk
                    5, 95, 95, 95, 44,  // skills + value
                    0, 0, 0, 0, 0 };
            }
        }
    }
}
