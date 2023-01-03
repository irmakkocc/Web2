using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer.Concreate.Abstract
{
    public interface IKategoriService
    {
        List<Kategori> GetKategoriList();
        void KategoriAdd(Kategori kategori);
        Kategori GetByID(int id);
        void KategoriDelete(Kategori kategori);
        void KategoriUpdate(Kategori kategori);

    }
}
