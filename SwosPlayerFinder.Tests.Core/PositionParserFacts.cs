using FluentAssertions;
using Manicomio.SwosPlayerFinder.Core;
using Xunit;

namespace Manicomio.SwosPlayerFinder.Tests.Core
{
    public class PositionParserFacts
    {
        public class Parse
        {
            [Fact]
            public void GoalkeeperValueReturnsGoalkeeper()
            {
                byte positionValue = 31;
                var parser = new PositionParser();

                Position position = parser.GetPosition(positionValue);

                position.Should().Be(Position.Goalkeeper);
            }

            [Fact]
            public void LeftBackValueReturnsLeftBack()
            {
                byte positionValue = 65;
                var parser = new PositionParser();

                Position position = parser.GetPosition(positionValue);

                position.Should().Be(Position.LeftBack);
            }

            [Fact]
            public void DefenderValueReturnsDefender()
            {
                byte positionValue = 120;
                var parser = new PositionParser();

                Position position = parser.GetPosition(positionValue);

                position.Should().Be(Position.Defender);
            }

            [Fact]
            public void RightBackValueReturnsRightBack()
            {
                byte positionValue = 40;
                var parser = new PositionParser();

                Position position = parser.GetPosition(positionValue);

                position.Should().Be(Position.RightBack);
            }

            [Fact]
            public void LeftWingValueReturnsLeftWing()
            {
                byte positionValue = 160;
                var parser = new PositionParser();

                Position position = parser.GetPosition(positionValue);

                position.Should().Be(Position.LeftWing);
            }

            [Fact]
            public void MidfielderValueReturnsMidfielder()
            {
                byte positionValue = 200;
                var parser = new PositionParser();

                Position position = parser.GetPosition(positionValue);

                position.Should().Be(Position.Midfielder);
            }

            [Fact]
            public void RightWingValueReturnsRightWing()
            {
                byte positionValue = 140;
                var parser = new PositionParser();

                Position position = parser.GetPosition(positionValue);

                position.Should().Be(Position.RightWing);
            }

            [Fact]
            public void AttackerValueReturnsAttacker()
            {
                byte positionValue = 250;
                var parser = new PositionParser();

                Position position = parser.GetPosition(positionValue);

                position.Should().Be(Position.Attacker);
            }
        }
    }
}
