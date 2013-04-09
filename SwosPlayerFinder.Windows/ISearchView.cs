using System.Collections.Generic;
using Manicomio.SwosPlayerFinder.Core;

namespace Manicomio.SwosPlayerFinder.Windows
{
    public interface ISearchView
    {
        void DisplaySearchResults(List<Player> foundPlayers);
        void UpdateLoadedPlayerCount(int count);
        void SetLatestFolder(string folder);
    }
}