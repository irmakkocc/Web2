using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer.Concreate.Abstract
{
    public interface IYorumlarService
    {
        List<Yorumlar> GetList();
        void YorumlarAdd(Yorumlar yorumlar);
        Yorumlar GetByID(int id);
    }
}
