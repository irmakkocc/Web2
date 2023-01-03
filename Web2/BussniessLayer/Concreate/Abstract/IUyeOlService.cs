using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer.Concreate.Abstract
{
    public interface IUyeOlService
    {
        List<UyeOl> GetList();
        void UyeOlAdd(UyeOl uye);
        UyeOl GetByID(int id);
    }
}
