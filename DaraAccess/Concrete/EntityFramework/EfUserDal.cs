using Core.DataAccess;
using Core.Entities;
using DaraAccess.Concrete.Context;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal: IfEntityRepository<User,SocialMediaContext>,IUserdal
    {

    }
}
