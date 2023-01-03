using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer.Concreate.Abstract
{
    public interface IGirisYapService
    {
        List<GirisYap> GetList();
        void GirisYapAdd(GirisYap giris);
        GirisYap GetByID(int id);
    }
}
