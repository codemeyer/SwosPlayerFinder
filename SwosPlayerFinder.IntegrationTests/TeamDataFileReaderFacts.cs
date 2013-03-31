using System.IO;
using System.Reflection;
using FluentAssertions;
using Manicomio.SwosPlayerFinder.Core;
using Xunit;

namespace Manicomio.SwosPlayerFinder.IntegrationTests
{
    public class TeamDataFileReaderFacts
    {
        public class Read
        {
            [Fact]
            public void FileShouldContainCorrectNumberOfTeamsAndPlayers()
            {
                string exampleDataPath = GetExampleDataPath();
                var reader = new TeamDataFileReader();

                DataFileReadResult result = reader.Read(exampleDataPath);

                result.Teams.Count.Should().Be(18);
                result.Players.Count.Should().Be(288);
            }

            [Fact]
            public void PlayersShouldBeAssociatedWithCorrectTeamsAndViceVersa()
            {
                string exampleDataPath = GetExampleDataPath();
                var reader = new TeamDataFileReader();

                DataFileReadResult result = reader.Read(exampleDataPath);

                result.Teams[0].Players[0].Should().BeSameAs(result.Players[0]);
                result.Players[0].Team.Should().BeSameAs(result.Teams[0]);
            }

            private static string GetExampleDataPath()
            {
                string assemblyLocation = Assembly.GetExecutingAssembly().Location;
                string assemblyDirectory = Path.GetDirectoryName(assemblyLocation);
                return Path.Combine(assemblyDirectory, @"ExampleData\TEAM.036");
            }
        }
    }
}
