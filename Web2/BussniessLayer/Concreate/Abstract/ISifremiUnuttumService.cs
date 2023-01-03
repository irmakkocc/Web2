using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer.Concreate.Abstract
{
    public interface ISifremiUnuttumService
    {
        List<SifreUnuttum> GetList();
        void SifreUnuttumUpdate(SifreUnuttum sifreUnuttum);
        SifreUnuttum GetByID(int id);
    }
}
