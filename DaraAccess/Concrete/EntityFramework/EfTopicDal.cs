using Core.DataAccess;
using DaraAccess.Concrete.Context;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTopicDal : IfEntityRepository<Topic, SocialMediaContext>, ITopicdal
    {

    }
}
