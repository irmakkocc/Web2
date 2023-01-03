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
    public class FilmlerManager : IFilmlerService
    {
        IFilmler _filmler;

        public FilmlerManager(IFilmler filmler)
        {
            _filmler = filmler;
        }

        public void FilmlerAdd(Filmler filmler)
        {
            _filmler.Insert(filmler);
        }

        public void FilmlerDelete(Filmler filmler)
        {
            _filmler.Delete(filmler);
        }

        public void FilmlerUpdate(Filmler filmler)
        {
            _filmler.Update(filmler);
        }

        public Filmler GetByID(int id)
        {
            return _filmler.Get(x => x.FilmID == id);
        }

        public List<Filmler> GetList()
        {
            return _filmler.List();
        }
    }
}
