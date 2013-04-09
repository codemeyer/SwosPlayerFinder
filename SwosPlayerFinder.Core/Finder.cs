using System.Collections.Generic;
using System.Linq;

namespace Manicomio.SwosPlayerFinder.Core
{
    public class Finder
    {
        public List<Player> Find(List<Player> allPlayers, Criteria criteria)
        {
            var filtered = allPlayers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(criteria.Name))
            {
                filtered = filtered.Where(p => p.Name.ToLowerInvariant().Contains(criteria.Name.ToLowerInvariant()));
            }

            if (!string.IsNullOrWhiteSpace(criteria.TeamName))
            {
                filtered = filtered.Where(p => p.Team.Name.ToLowerInvariant().Contains(criteria.TeamName.ToLowerInvariant()));
            }

            filtered = filtered.Where(p => p.Skills.Passing >= criteria.PassingFrom && 
                                           p.Skills.Passing <= criteria.PassingTo);

            filtered = filtered.Where(p => p.Skills.Shooting >= criteria.ShootingFrom &&
                                           p.Skills.Shooting <= criteria.ShootingTo);

            filtered = filtered.Where(p => p.Skills.Heading >= criteria.HeadingFrom &&
                                           p.Skills.Heading <= criteria.HeadingTo);

            filtered = filtered.Where(p => p.Skills.Tackling >= criteria.TacklingFrom &&
                                           p.Skills.Tackling <= criteria.TacklingTo);

            filtered = filtered.Where(p => p.Skills.Control >= criteria.ControlFrom &&
                                           p.Skills.Control <= criteria.ControlTo);

            filtered = filtered.Where(p => p.Skills.Speed >= criteria.SpeedFrom &&
                                           p.Skills.Speed <= criteria.SpeedTo);

            filtered = filtered.Where(p => p.Skills.Finishing >= criteria.FinishingFrom &&
                                           p.Skills.Finishing <= criteria.FinishingTo);

            filtered = filtered.Where(p => p.Value >= criteria.ValueFrom &&
                                           p.Value <= criteria.ValueTo);

            if (criteria.Positions.Any())
            {
                filtered = filtered.Where(p => criteria.Positions.Contains(p.Position));
            }

            return filtered.ToList();
        }
    }
}