﻿using Mic.VetEducation.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mic.VetEducation.Repository
{
    public class BaseRepository<TModel> where TModel : BaseModel, new()
    {
        bool _isLoaded;
        Dictionary<int, TModel> _source;

        public BaseRepository(string fileName)
        {
            FileName = fileName;
            _source = new Dictionary<int, TModel>();
        }

        public string FileName { get; private set; }

        public IEnumerable<TModel> ReadAll()
        {
            if (!_isLoaded)
            {
                _isLoaded = true;

                try
                {
                    _source = XmlHelper
                        .ReadFromXml<TModel>(FileName)
                        .ToDictionary(t => t.ID);
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
            _source.Add(t.ID, t);
        }

        public void SaveChanges()
        {
            XmlHelper.SaveToXml<TModel>(_source.Values.ToList(), FileName);
        }
    }
}
