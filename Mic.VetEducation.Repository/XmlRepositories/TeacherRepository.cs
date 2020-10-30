using Mic.VetEducation.Repository.Models;

namespace Mic.VetEducation.Repository.XmlRepositories
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository() : this("Teachers.xml")
        { }

        public TeacherRepository(string fileName)
            : base(fileName)
        { }

        public void UpdateSalary(int id, decimal value)
        {
            var uni = ReadOrDefult(id);
            uni.Salary = value;
        }
    }
}
