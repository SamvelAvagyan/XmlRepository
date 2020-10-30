namespace Mic.VetEducation.Repository.Models
{
    public class Student : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Mark { get; set; }
    }
}
