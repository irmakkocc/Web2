using BussniessLayer.Concreate.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer.Concreate
{
    public class IMDBManager : IIMDBService
    {
        IIMDB _ımdb;
        public IMDB GetByID(int id)
        {
            return _ımdb.Get(x=>x.IMDBID==id);
        }

        public List<IMDB> GetList()
        {
            return _ımdb.List();
        }

        public void IMDBAdd(IMDB ımdb)
        {
            _ımdb.Insert(ımdb);
        }

        public void IMDBUpdate(IMDB ımdb)
        {
            _ımdb.Update(ımdb);
        }
    }
}
