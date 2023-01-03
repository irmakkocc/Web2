using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer.Concreate.Abstract
{
    public interface IFilmlerService
    {
        List<Filmler> GetList();
        void FilmlerAdd(Filmler filmler);
        void FilmlerUpdate(Filmler filmler);
        void FilmlerDelete(Filmler filmler);
        Filmler GetByID(int id);
    }
}
