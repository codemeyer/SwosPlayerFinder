using System.Collections.Generic;
using System.IO;

namespace Manicomio.SwosPlayerFinder.Core
{
    public class DataReader
    {
        private readonly IFileFinder _fileFinder;
        private readonly ITeamDataFileReader _fileReader;

        public DataReader(IFileFinder fileFinder, ITeamDataFileReader fileReader)
        {
            _fileFinder = fileFinder;
            _fileReader = fileReader;
        }

        public DataFileReadResult Read(string dataPath)
        {
            var teams = new List<Team>();
            var players = new List<Player>();

            List<string> filePaths = _fileFinder.ListFiles(dataPath);
            
            foreach (string filePath in filePaths)
            {
                if (!IsRelevant(filePath)) { continue; }

                DataFileReadResult result = _fileReader.Read(filePath);

                teams.AddRange(result.Teams);
                players.AddRange(result.Players);
            }

            return new DataFileReadResult(teams, players);
        }

        private readonly IList<string> _irrelevantFileExtensions =
            new [] { ".068", ".072", ".074", ".080", ".081", ".082", ".083", ".084", ".085" };

        private bool IsRelevant(string filePath)
        {
            string extension = Path.GetExtension(filePath);

            return (!_irrelevantFileExtensions.Contains(extension));

            // 068 = landslag (e.g. CAMEROON)
            // 072 = trams
            // 074 = (gamla) landslag (e.g. SPAIN)
            // 080 = landslag (e.g. SPAIN)
            // 081 = landslag (e.g. CAMEROON)
            // 082 = landslag (e.g. BRAZIL)
            // 083 = landslag (e.g. UNITED STATES)
            // 084 = landslag (e.g. JAPAN)
            // 085 = landslag (e.g. AUSTRALIA, NEW ZEALAND)
        }
    }
}