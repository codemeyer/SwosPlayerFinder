using System.Collections.Generic;
using System.IO;

namespace Manicomio.SwosPlayerFinder.Core
{
    public class FileFinder : IFileFinder
    {
        public List<string> ListFiles(string basePath)
        {
            string[] files = Directory.GetFiles(basePath, "TEAM.0*");

            return new List<string>(files);
        }
    }
}