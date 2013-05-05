using System.Collections.Generic;
using System.IO;
using System.Linq;
using Manicomio.SwosPlayerFinder.Core;

namespace Manicomio.SwosPlayerFinder.Windows
{
    public class SearchPresenter
    {
        private readonly ISearchView _view;
        private List<Player> _allPlayers;

        public SearchPresenter(ISearchView view)
        {
            _view = view;
        }

        public void LoadPlayers(string path)
        {
            if (!Directory.Exists(path))
            {
                _view.DisplayDataDirectoryNotFound();
                return;
            }

            var fileFinder = new FileFinder();
            var fileReader = new TeamDataFileReader();
            var reader = new DataReader(fileFinder, fileReader);

            DataFileReadResult result = reader.Read(path);

            _allPlayers = result.Players;
            
            _view.UpdateLoadedPlayerCount(result.Players.Count);
        }

        public void PerformSearch(Criteria criteria)
        {
            Finder finder = new Finder();
            List<Player> foundPlayers = finder.Find(_allPlayers, criteria);

            _view.DisplaySearchResults(foundPlayers.Take(1000).ToList());
        }

        public void GetLatestFolder()
        {
            string folder = @"C:\Games\SWOS\DATA";
            _view.SetLatestFolder(folder);
        }
    }
}