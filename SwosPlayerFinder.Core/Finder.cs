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

            if (criteria.Passing.HasValue)
            {
                filtered = filtered.Where(p => p.Skills.Passing >= criteria.Passing);
            }

            if (criteria.Shooting.HasValue)
            {
                filtered = filtered.Where(p => p.Skills.Shooting >= criteria.Shooting);
            }

            if (criteria.Heading.HasValue)
            {
                filtered = filtered.Where(p => p.Skills.Heading >= criteria.Heading);
            }
            
            if (criteria.Tackling.HasValue)
            {
                filtered = filtered.Where(p => p.Skills.Tackling >= criteria.Tackling);
            }

            if (criteria.Control.HasValue)
            {
                filtered = filtered.Where(p => p.Skills.Control >= criteria.Control);
            }

            if (criteria.Speed.HasValue)
            {
                filtered = filtered.Where(p => p.Skills.Speed >= criteria.Speed);
            }

            if (criteria.Finishing.HasValue)
            {
                filtered = filtered.Where(p => p.Skills.Finishing >= criteria.Finishing);
            }

            return filtered.ToList();
        }
    }
}