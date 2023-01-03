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
    public class DizilerManager : IDizilerService
    {
        IDiziler _diziler;

        public DizilerManager(IDiziler diziler)
        {
            _diziler = diziler;
        }

        public void DizilerAdd(Diziler diziler)
        {
            _diziler.Insert(diziler);
        }

        public void DizilerDelete(Diziler diziler)
        {
            _diziler.Delete(diziler);
        }

        public void DizilerUpdate(Diziler diziler)
        {
            _diziler.Update(diziler);
        }

        public Diziler GetByID(int id)
        {
            return _diziler.Get(x => x.DiziID == id);
        }

        public List<Diziler> GetList()
        {
            return _diziler.List();
        }
    }
}
