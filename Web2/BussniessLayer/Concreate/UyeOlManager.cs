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
    public class UyeOlManager : IUyeOlService
    {
        IUyeOl _uyeOl;

        public UyeOlManager(IUyeOl uyeOl)
        {
            _uyeOl = uyeOl;
        }

        public UyeOl GetByID(int id)
        {
            return _uyeOl.Get(x => x.Id == id);
        }

        public List<UyeOl> GetList()
        {
            return _uyeOl.List();
        }

        public void UyeOlAdd(UyeOl uye)
        {
            _uyeOl.Insert(uye);
        }
    }
}
