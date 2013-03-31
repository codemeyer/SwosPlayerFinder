using System.Collections.Generic;
using System.IO;
using Manicomio.SwosPlayerFinder.Core;
using NSubstitute;

namespace Manicomio.SwosPlayerFinder.Tests.Core
{
    public class TestableDataReader : DataReader
    {
        private readonly ITeamDataFileReader _fileReader;
        private string _basePath;
        private List<string> _dataFiles;

        public TestableDataReader(IFileFinder fileFinder, ITeamDataFileReader fileReader, string basePath)
            : base(fileFinder, fileReader)
        {
            _dataFiles = new List<string>();
            fileFinder.ListFiles(basePath).Returns(_dataFiles);
            _fileReader = fileReader;
            _basePath = basePath;
        }

        public ITeamDataFileReader FileReader
        {
            get { return _fileReader; }
        }

        public static TestableDataReader Create(string basePath)
        {
            var finder = Substitute.For<IFileFinder>();
            var fileReader = Substitute.For<ITeamDataFileReader>();

            return new TestableDataReader(finder, fileReader, basePath);
        }

        public TestableDataReader WithDataFile(string fileName)
        {
            string fullPath = Path.Combine(_basePath, fileName);
            _dataFiles.Add(fullPath);
            return this;
        }

        public TestableDataReader WithReaderReturningOneTeamAndOnePlayer(string fileName)
        {
            string fullPath = Path.Combine(_basePath, fileName);
            _fileReader.Read(fullPath)
                       .Returns(new DataFileReadResult
                           {
                               Players = new List<Player> {new Player()},
                               Teams = new List<Team> {new Team()}
                           });
            return this;
        }
    }
}