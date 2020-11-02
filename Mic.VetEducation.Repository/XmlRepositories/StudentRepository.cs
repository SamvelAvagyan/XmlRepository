using Mic.VetEducation.Repository.Models;
using Serilog;

namespace Mic.VetEducation.Repository.XmlRepositories
{
    public class StudentRepository : BaseRepository<Student>
    { 
        public StudentRepository(string fileName, ILogger logger)
            : base(fileName, logger)
        { }   
    }
}
