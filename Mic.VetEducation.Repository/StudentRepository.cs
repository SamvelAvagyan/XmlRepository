using Mic.VetEducation.Repository.Models;

namespace Mic.VetEducation.Repository
{
    public class StudentRepository : BaseRepository<Student>
    {
        public StudentRepository() : this("Students.xml") { }

        public StudentRepository(string fileName)
            : base(fileName)
        { }   
    }
}
