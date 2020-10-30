using Mic.VetEducation.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mic.VetEducation.Repository.XmlRepositories
{
    public class BaseRepository<TModel> : IBaseRepository<TModel>
        where TModel : BaseModel, new() 
    {
        private bool _isLoaded;
        private Dictionary<int, TModel> _source;

        public BaseRepository(string fileName)
        {
            FileName = fileName;
            _source = new Dictionary<int, TModel>();
        }

        public string FileName { get; private set; }

        public TModel ReadOrDefult(int id)
        {
            _source.TryGetValue(id, out TModel model);
            return model;            
        }

        public TModel Read(int id)
        {
            if(!_source.TryGetValue(id, out TModel model))
            {
                throw new Exception($"There is no {typeof(TModel).Name} with {id} Id");
            }

            return model;
        }

        public IEnumerable<TModel> ReadAll()
        {
            if (!_isLoaded)
            {
                _isLoaded = true;

                try
                {
                    _source = XmlHelper
                        .ReadFromXml<TModel>(FileName)
                        .ToDictionary(t => t.Id);
                }
                catch (Exception ex)
                {

                }
            }

            return _source.Values;
        }

        
        public List<TModel> ReadToList()
        {
            return ReadAll().ToList();
        }

        public void Add(TModel t) 
        {
            _source.Add(t.Id, t);
        }

        public void SaveChanges()
        {
            XmlHelper.SaveToXml<TModel>(_source.Values.ToList(), FileName);
        }
    }
}
