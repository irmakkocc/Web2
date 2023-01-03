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
    public class KategoriManager : IKategoriService
    {
        IKategoriDal _kategoriDal;

        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public Kategori GetByID(int id)
        {
            return _kategoriDal.Get(x => x.KategoriID == id);
        }

        public List<Kategori> GetKategoriList()
        {
            return _kategoriDal.List();
        }

        public void KategoriAdd(Kategori kategori)
        {
            _kategoriDal.Insert(kategori);
        }

        public void KategoriDelete(Kategori kategori)
        {
            _kategoriDal.Delete(kategori);
        }

        public void KategoriUpdate(Kategori kategori)
        {
            _kategoriDal.Update(kategori);
        }
    }
}
