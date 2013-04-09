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
            public void SearchingForPlayersWithPassingBetweenFourAndSevenOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { PassingFrom = 4, PassingTo = 7 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Passing >= 4 && p.Skills.Passing <= 7));
            }

            [Fact]
            public void SearchingForPlayersWithShootingAtLeastEightOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { ShootingFrom = 8, ShootingTo = 8 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Shooting == 8));
            }

            [Fact]
            public void SearchingForPlayersWithHeadingAtLeastFiveOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { HeadingFrom = 5, HeadingTo = 8 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Heading >= 5));
            }

            [Fact]
            public void SearchingForPlayersWithTacklingAtLeastSixOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { TacklingFrom = 6, TacklingTo = 8 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Tackling >= 6));
            }

            [Fact]
            public void SearchingForPlayersWithControlAtLeastSixOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { ControlFrom = 6, ControlTo = 8 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Control >= 6));
            }

            [Fact]
            public void SearchingForPlayersWithSpeedAtLeastSixOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { SpeedFrom = 6, SpeedTo = 8 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Speed >= 6));
            }

            [Fact]
            public void SearchingForPlayersWithFinishingAtLeastSixOnlyReturnsPlayerMatchingSkill()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { FinishingFrom = 6, FinishingTo = 8 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Skills.Finishing >= 6));
            }

            [Fact]
            public void SearchingForPlayersWithValueReturnsPlayerMatchingValue()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { ValueFrom = 100, ValueTo = 500 };

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Value >= 100 && p.Value <= 500));
            }

            [Fact]
            public void SearchingForPlayerWhereAllSkillsAreAboveThreeOnlyReturnsThosePlayers()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria
                    {
                        ControlFrom = 3,
                        FinishingFrom = 3,
                        HeadingFrom = 3,
                        PassingFrom = 3,
                        ShootingFrom = 3,
                        SpeedFrom = 3,
                        TacklingFrom = 3
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

            [Fact]
            public void SearchingForGoalkeepersOnlyReturnsGoalkeepers()
            {
                List<Player> players = GetSearchSampleData();
                var finder = new Finder();
                var criteria = new Criteria { Positions = new List<Position> { Position.Goalkeeper }};

                List<Player> result = finder.Find(players, criteria);

                result.Should().Match(r => r.All(p => p.Position == Position.Goalkeeper));
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

                    if (random.Next(1, 4) == 1)
                    {
                        player.Position = Position.Goalkeeper;
                    }
                    else
                    {
                        player.Position = Position.Attacker;
                    }

                    player.Skills.Passing = random.Next(1, 8);
                    player.Skills.Shooting = random.Next(1, 8);
                    player.Skills.Heading = random.Next(1, 8);
                    player.Skills.Tackling = random.Next(1, 8);
                    player.Skills.Control = random.Next(1, 8);
                    player.Skills.Speed = random.Next(1, 8);
                    player.Skills.Finishing = random.Next(1, 8);

                    player.Value = random.Next(0, 16000);

                    players.Add(player);
                }

                return players;
            }
        }
    }
}
