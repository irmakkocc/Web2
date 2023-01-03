using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniessLayer.Concreate.Abstract
{
    public interface IAdminService
    {
        List<AdminGiris> GetList();
        void AdminAdd(AdminGiris admin);
        AdminGiris GetByID(int id);
    }
}
