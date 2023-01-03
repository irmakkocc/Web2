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
    public class AdminManager : IAdminService
    {
        IAdminGiris _adminDal;

        public AdminManager(IAdminGiris adminDal)
        {
            _adminDal = adminDal;
        }

        public void AdminAdd(AdminGiris admin)
        {
            _adminDal.Insert(admin);
        }

        public AdminGiris GetByID(int id)
        {
            return _adminDal.Get(x => x._Id == id);
        }

        public List<AdminGiris> GetList()
        {
            return _adminDal.List();
        }

        AdminGiris IAdminService.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<AdminGiris> IAdminService.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
