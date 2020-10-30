using Mic.VetEducation.Repository.Models;
using System.Collections.Generic;

namespace Mic.VetEducation.Repository
{
    public interface IBaseRepository<TModel> where TModel : BaseModel, new()
    {
        TModel ReadOrDefult(int id);
        TModel Read(int id);
        IEnumerable<TModel> ReadAll();
        List<TModel> ReadToList();
        void Add(TModel t);
        void SaveChanges();
    }
}
