using Mic.VetEducation.Repository.Models;
using Serilog;

namespace Mic.VetEducation.Repository.XmlRepositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(string fileName, ILogger logger)
            : base(fileName, logger)
        { }      
    }
}
