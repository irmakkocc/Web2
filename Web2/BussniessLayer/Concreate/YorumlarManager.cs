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
    public class YorumlarManager : IYorumlarService
    {
        IYorumlar _yorumlar;

        public YorumlarManager(IYorumlar yorumlar)
        {
            _yorumlar = yorumlar;
        }

        public Yorumlar GetByID(int id)
        {
            return _yorumlar.Get(x => x.YorumID == id);
        }

        public List<Yorumlar> GetList()
        {
            return _yorumlar.List();
        }

        public void YorumlarAdd(Yorumlar yorumlar)
        {
            _yorumlar.Insert(yorumlar);
        }
    }
}
