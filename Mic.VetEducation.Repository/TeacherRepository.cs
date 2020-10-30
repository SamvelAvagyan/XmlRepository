using Mic.VetEducation.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mic.VetEducation.Repository
{
    public class TeacherRepository
    {
        bool _isLoaded;
        Dictionary<int, Teacher> _source;

        public TeacherRepository() : this("Teachers.xml")
        {

        }

        public TeacherRepository(string fileName)
        {
            FileName = fileName;
            _source = new Dictionary<int, Teacher>();
        }

        public string FileName { get; private set; }

        public IEnumerable<Teacher> ReadAll()
        {
            if (!_isLoaded)
            {
                _isLoaded = true;

                try
                {
                    _source = XmlHelper
                        .ReadFromXml<Teacher>(FileName)
                        .ToDictionary(t => t.ID);
                }
                catch (Exception ex)
                {

                }
            }

            return _source.Values;
        }

        public List<Teacher> ReadToList()
        {
            return ReadAll().ToList();
        }

        public void Add(Teacher t)
        {
            _source.Add(t.ID, t);
        }

        public void SaveChanges()
        {
            XmlHelper.SaveToXml<Teacher>(_source.Values.ToList(), FileName);
        }


    }
}
