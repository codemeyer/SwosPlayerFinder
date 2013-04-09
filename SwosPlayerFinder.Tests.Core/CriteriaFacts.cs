using FluentAssertions;
using Manicomio.SwosPlayerFinder.Core;
using Xunit;

namespace Manicomio.SwosPlayerFinder.Tests.Core
{
    public class CriteriaFacts
    {
        public class New
        {
            [Fact]
            public void NewCriteriaHasWidestPossibleRange()
            {
                var criteria = new Criteria();

                criteria.Name.Should().BeEmpty();

                criteria.PassingFrom.Should().Be(1);
                criteria.PassingTo.Should().Be(8);

                criteria.ShootingFrom.Should().Be(1);
                criteria.ShootingTo.Should().Be(8);

                criteria.HeadingFrom.Should().Be(1);
                criteria.HeadingTo.Should().Be(8);

                criteria.TacklingFrom.Should().Be(1);
                criteria.TacklingTo.Should().Be(8);

                criteria.ControlFrom.Should().Be(1);
                criteria.ControlTo.Should().Be(8);

                criteria.SpeedFrom.Should().Be(1);
                criteria.SpeedTo.Should().Be(8);

                criteria.FinishingFrom.Should().Be(1);
                criteria.FinishingTo.Should().Be(8);

                criteria.ValueFrom.Should().Be(0);
                criteria.ValueTo.Should().Be(16000);
            }
        }
    }
}
