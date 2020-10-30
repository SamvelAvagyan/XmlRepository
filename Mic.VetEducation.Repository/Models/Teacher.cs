namespace Mic.VetEducation.Repository.Models
{
    public class Teacher : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
    }
}
