using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IuserService
    {
        List<User> GetAll();
        User getById(int id);
        void add(User user);
        User update(User user);
        User delete(int id);


    }
}
