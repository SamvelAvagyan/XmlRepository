using System;
using System.Collections.Generic;
using System.Text;

namespace Mic.VetEducation.Repository.Migrations
{
    public static class StudentMigration
    {
        public static void AddInStudent()
        {
            var repo = new StudentRepository();
            var source = repo.ReadToList();
            var rnd = new Random();
            for (int i = 0; i < source.Count; i++)
            {
                source[i].ID = i + 1;
                source[i].Mark = (byte)rnd.Next(1, 21);
            }
            repo.SaveChanges();
        }
    }
}
