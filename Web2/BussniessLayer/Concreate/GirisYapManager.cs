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
    public class GirisYapManager : IGirisYapService
    {
        IGirisYap _girisYap;

        public GirisYapManager(IGirisYap girisYap)
        {
            _girisYap = girisYap;
        }

        public GirisYap GetByID(int id)
        {
            return _girisYap.Get(x => x.ID == id);
        }

        public List<GirisYap> GetList()
        {
            return _girisYap.List();
        }

        public void GirisYapAdd(GirisYap giris)
        {
            _girisYap.Insert(giris);
        }
    }
}
