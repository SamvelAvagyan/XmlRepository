using System;
using System.Collections.Generic;
using System.Text;

namespace Mic.VetEducation.Repository.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
    }
}
