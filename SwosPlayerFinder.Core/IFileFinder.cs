using System.Collections.Generic;

namespace Manicomio.SwosPlayerFinder.Core
{
    public interface IFileFinder
    {
        List<string> ListFiles(string basePath);
    }
}