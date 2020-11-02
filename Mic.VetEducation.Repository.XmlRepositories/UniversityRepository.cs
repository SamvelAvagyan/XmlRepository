using Mic.VetEducation.Repository.Models;
using Serilog;

namespace Mic.VetEducation.Repository.XmlRepositories
{
    public class UniversityRepository : BaseRepository<University>
    {
        public UniversityRepository(string fileName, ILogger logger)
            : base(fileName, logger)
        { }
    }
}
