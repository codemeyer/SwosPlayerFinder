namespace Manicomio.SwosPlayerFinder.Core
{
    public interface ITeamDataFileReader
    {
        DataFileReadResult Read(string dataPath);
    }
}