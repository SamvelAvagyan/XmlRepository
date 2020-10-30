namespace Mic.VetEducation.Repository.Models
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
    }
}
