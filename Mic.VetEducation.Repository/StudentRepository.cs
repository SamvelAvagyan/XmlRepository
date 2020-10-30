using Mic.VetEducation.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mic.VetEducation.Repository
{
    public class StudentRepository
    {
        bool _isLoaded;
        Dictionary<int, Student> _source;

        public StudentRepository() : this("Students.xml") { }

        public StudentRepository(string fileName)
        {
            FileName = fileName;
            _source = new Dictionary<int, Student>();
        }

        public string FileName { get; private set; }

        public IEnumerable<Student> ReadAll()
        {
            if (!_isLoaded)
            {
                _isLoaded = true;
                try
                {
                    _source = XmlHelper
                        .ReadFromXml<Student>(FileName)
                        .ToDictionary(st => st.Id);
                }
                catch(Exception ex)
                {
                    
                }
            }

            return _source.Values;
        }

        public void Add(Student st)
        {
            _source.Add(st.Id, st);
        }

        public bool Remove(int id)
        {
            return _source.Remove(id);
        }

        public List<Student> ReadToList()
        {
            return ReadAll().ToList();
        }

        public void SaveChanges()
        {
            XmlHelper.SaveToXml(_source.Values.ToList(), FileName);
        }
    }
}
