using Mic.VetEducation.Repository.Models;

namespace Mic.VetEducation.Repository
{
    public class UniversityRepository : BaseRepository<University>
    {
        public UniversityRepository() : this("University.xml") { }

        public UniversityRepository(string fileName)
            : base(fileName)
        { }
    }
}
