using Mic.VetEducation.Repository.Models;

namespace Mic.VetEducation.Repository
{
    public interface ITeacherRepository : IBaseRepository<Teacher>
    {
        void UpdateSalary(int id, decimal value);
    }
}
