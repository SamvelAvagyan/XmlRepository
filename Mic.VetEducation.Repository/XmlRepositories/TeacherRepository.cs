using Mic.VetEducation.Repository.Models;

namespace Mic.VetEducation.Repository.XmlRepositories
{
    public class TeacherRepository : BaseRepository<Teacher>
    {
        public TeacherRepository() : this("Teachers.xml")
        { }

        public TeacherRepository(string fileName)
            : base(fileName)
        { }
    }
}
