using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer.Concreate.Abstract
{
    public interface IDizilerService
    {
        List<Diziler> GetList();
        void DizilerAdd(Diziler diziler);
        void DizilerUpdate(Diziler diziler);
        void DizilerDelete(Diziler diziler);
        Diziler GetByID(int id);
    }
}
