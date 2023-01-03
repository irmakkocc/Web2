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
    public class SifremiUnuttumManager : ISifremiUnuttumService
    {
        ISifreUnuttum _sifreUnuttum;

        public SifremiUnuttumManager(ISifreUnuttum sifreUnuttum)
        {
            _sifreUnuttum = sifreUnuttum;
        }

        public SifreUnuttum GetByID(int id)
        {
            return _sifreUnuttum.Get(x => x.Id == id);
        }

        public List<SifreUnuttum> GetList()
        {
            return _sifreUnuttum.List();
        }

        public void SifreUnuttumUpdate(SifreUnuttum sifreUnuttum)
        {
            _sifreUnuttum.Update(sifreUnuttum);
        }
    }
}
