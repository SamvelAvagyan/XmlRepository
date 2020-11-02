using Mic.VetEducation.Repository.Models;
using Mic.VetEducation.Repository.XmlRepositories;
using Serilog;
using System;
using System.Collections.Generic;

namespace Mic.VetEducation.Repository.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger log = new LoggerConfiguration()
                        .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
                        .CreateLogger();         

            var repo = new StudentRepository(Files.Student, log);
            var res = repo.ReadToList();

            //repo.Add(new Student { ID = 1, FirstName = "A1", LastName = "A1yan" });
            //repo.Add(new Student { ID = 2, FirstName = "A2", LastName = "A2yan" });

            //repo.SaveChanges();
            //var res1 = repo.ReadToList();
            //StudentMigration.AddInStudent();

            //repo.Add(new Student { ID = 3, FirstName = "A3", LastName = "A3yan", Mark = 18 });
            //repo.Add(new Student { ID = 4, FirstName = "A4", LastName = "A4yan", Mark = 19 });
            //repo.Add(new Student { ID = 5, FirstName = "A5", LastName = "A5yan", Mark = 20 });
            //repo.SaveChanges();          

            //var teachRepo = new TeacherRepository();

            /*teachRepo.Add(new Teacher { Id = 1, FirstName = "A1", LastName = "A1yan" });
            teachRepo.Add(new Teacher { Id = 2, FirstName = "A2", LastName = "A2yan" });
            teachRepo.Add(new Teacher { Id = 3, FirstName = "A3", LastName = "A3yan" });

            teachRepo.SaveChanges();*/

            //var res3 = teachRepo.ReadToList();

            //var usersRepo = new UserRepository();

            /*usersRepo.Add(new User { ID = 1, FirstName = "A1", LastName = "A1yan", Age = 24 });
            usersRepo.Add(new User { ID = 2, FirstName = "A2", LastName = "A2yan", Age = 50 });
            usersRepo.Add(new User { ID = 3, FirstName = "A3", LastName = "A3yan", Age = 25 });

            usersRepo.SaveChanges();*/

            //var res3 = usersRepo.ReadToList();


        }

        static IEnumerable<Student> CreateStudents(int count)
        {
            var source = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                yield return new Student
                {
                    FirstName = $"A{i}",
                    LastName = $"A{i}yan"
                };
            }
        }

        static IEnumerable<Teacher> CreateTeachers(int count)
        {
            var source = new List<Teacher>();

            for (int i = 0; i < count; i++)
            {
                yield return new Teacher
                {
                    Id = i + 1,
                    FirstName = $"A{i}",
                    LastName = $"A{i}yan"
                };
            }
        }

        static IEnumerable<User> CreateUsers(int count)
        {
            var rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                yield return new User
                {
                    Id = i + 1,
                    FirstName = $"A{i}",
                    LastName = $"A{i}yan",
                    Age = (byte)rnd.Next(18, 70)
                };
            }
        }
    }


}
