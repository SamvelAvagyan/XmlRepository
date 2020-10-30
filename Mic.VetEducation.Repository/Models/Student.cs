using System;
using System.Collections.Generic;
using System.Text;

namespace Mic.VetEducation.Repository.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Mark { get; set; }
    }
}
