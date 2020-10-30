using Mic.VetEducation.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mic.VetEducation.Repository
{
    public class UserRepository
    {
        bool _isLoaded;
        Dictionary<int, User> _source;

        public UserRepository() : this("Users.xml")
        {

        }

        public UserRepository(string fileName)
        {
            FileName = fileName;
            _source = new Dictionary<int, User>();
        }

        public string FileName { get; private set; }

        public IEnumerable<User> ReadAll()
        {
            if (!_isLoaded)
            {
                _isLoaded = true;

                try
                {
                    _source = XmlHelper
                        .ReadFromXml<User>(FileName)
                        .ToDictionary(u => u.Id);
                }
                catch (Exception ex)
                {

                }
            }

            return _source.Values;
        }

        public List<User> ReadToList()
        {
            return ReadAll().ToList();
        }

        public void Add(User u)
        {
            _source.Add(u.Id, u);
        }

        public void SaveChanges()
        {
            XmlHelper.SaveToXml<User>(_source.Values.ToList(), FileName);
        }
    }
}
