using Mic.VetEducation.Repository.Models;

namespace Mic.VetEducation.Repository
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository() : this("Users.xml")
        { }

        public UserRepository(string fileName)
            : base(fileName)
        { }      
    }
}
