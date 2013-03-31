using System.IO;
using FluentAssertions;
using Manicomio.SwosPlayerFinder.Core;
using NSubstitute;
using Xunit;

namespace Manicomio.SwosPlayerFinder.Tests.Core
{
    public class DataReaderFacts
    {
        public class Read
        {
            private string _basePath = @"C:\SWOSFAKE\Data\";

            [Fact]
            public void ShouldReadDataFromFoundFiles()
            {
                var dataReader = TestableDataReader.Create(_basePath)
                                                   .WithDataFile("TEAM.123")
                                                   .WithReaderReturningOneTeamAndOnePlayer("TEAM.123");

                dataReader.Read(_basePath);

                string expectedPath = Path.Combine(_basePath, "TEAM.123");
                dataReader.FileReader.Received().Read(expectedPath);
            }

            [Fact]
            public void RetrievedPlayersAndTeamsAreReturned()
            {
                var dataReader = TestableDataReader.Create(_basePath)
                                                   .WithDataFile("TEAM.123")
                                                   .WithReaderReturningOneTeamAndOnePlayer("TEAM.123");

                DataFileReadResult result = dataReader.Read(_basePath);

                result.Players.Count.Should().Be(1);
                result.Teams.Count.Should().Be(1);
            }

            [Fact]
            public void IrrelevantDataFilesAreSkipped()
            {
                var dataReader = TestableDataReader.Create(_basePath)
                                                   .WithDataFile("TEAM.068");

                dataReader.Read(_basePath);

                string expectedPath = Path.Combine(_basePath, "TEAM.068");
                dataReader.FileReader.DidNotReceive().Read(expectedPath);
            }
        }
    }
}
