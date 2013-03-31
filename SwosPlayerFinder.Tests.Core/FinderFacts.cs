using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Manicomio.SwosPlayerFinder.Core;
using Xunit;

namespace Manicomio.SwosPlayerFinder.Tests.Core
{
    public class FinderFacts
    {
        public class Find
        {
            [Fact]
            public void SearchingForPlayersByNameReturnsPlayersWhereNameMatchesCriteria()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { Name = "AYER 1" };   // should match "Player 1", "Player 10" ... "Player 19"

                List<Player> result = finder.Find(players, criteria);

                result.Count.Should().Be(11);
            }

            [Fact]
            public void SearchingForPlayersByTeamNameReturnsPlayersWhereTeamNameMatchesCriteria()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { TeamName = "EAM 12" };

                List<Player> result = finder.Find(players, criteria);

                result.Count.Should().Be(1);
            }

            [Fact]
            public void SearchingForPlayersWithPassingAtLeastTwoOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { Passing = 2 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Passing >= 2));
            }

            [Fact]
            public void SearchingForPlayersWithShootingAtLeastEightOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { Shooting = 8 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Shooting >= 8));
            }

            [Fact]
            public void SearchingForPlayersWithHeadingAtLeastFiveOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { Heading = 5 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Heading >= 5));
            }

            [Fact]
            public void SearchingForPlayersWithTacklingAtLeastSixOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { Tackling = 6 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Tackling >= 6));
            }

            [Fact]
            public void SearchingForPlayersWithControlAtLeastSixOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { Control = 6 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Control >= 6));
            }

            [Fact]
            public void SearchingForPlayersWithSpeedAtLeastSixOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { Speed = 6 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Speed >= 6));
            }

            [Fact]
            public void SearchingForPlayersWithFinishingAtLeastSixOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { Finishing = 6 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Finishing >= 6));
            }

            [Fact]
            public void SearchingForPlayerWhereAllSkillsAreAboveThreeOnlyReturnsThosePlayers()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria
                    {
                        Control = 3,
                        Finishing = 3,
                        Heading = 3,
                        Passing = 3,
                        Shooting = 3,
                        Speed = 3,
                        Tackling = 3
                    };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p =>
                                                 p.Skills.Control >= 3 &&
                                                 p.Skills.Finishing >= 3 &&
                                                 p.Skills.Heading >= 3 &&
                                                 p.Skills.Passing >= 3 &&
                                                 p.Skills.Shooting >= 3 &&
                                                 p.Skills.Speed >= 3 &&
                                                 p.Skills.Tackling >= 3
                                               ));
            }

            private List<Player> GetSearchSampleData()
            {
                var players = new List<Player>();
                var random = new Random();

                for (int i = 0; i <= 19; i++)
                {
                    var player = new Player();
                    player.Name = string.Format("PLAYER {0}", i);
                    player.Team.Name = string.Format("TEAM {0}", i);

                    player.Skills.Passing = random.Next(1, 8);
                    player.Skills.Shooting = random.Next(1, 8);
                    player.Skills.Heading = random.Next(1, 8);
                    player.Skills.Tackling = random.Next(1, 8);
                    player.Skills.Control = random.Next(1, 8);
                    player.Skills.Speed = random.Next(1, 8);
                    player.Skills.Finishing = random.Next(1, 8);

                    players.Add(player);
                }

                return players;
            }
        }
    }
}
