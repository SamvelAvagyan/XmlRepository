using Mic.VetEducation.Repository.Models;
using Serilog;

namespace Mic.VetEducation.Repository.XmlRepositories
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(string fileName, ILogger logger)
            : base(fileName, logger)
        { }

        public void UpdateSalary(int id, decimal value)
        {
            var uni = ReadOrDefult(id);
            uni.Salary = value;
        }
    }
}
