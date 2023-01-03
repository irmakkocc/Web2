using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer.Concreate.Abstract
{
    public interface IIMDBService
    {
        List<IMDB> GetList();
        void IMDBAdd(IMDB ımdb);
        IMDB GetByID(int id);
        void IMDBUpdate(IMDB ımdb);

    }
}
