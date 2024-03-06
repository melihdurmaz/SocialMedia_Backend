﻿using Core.DataAccess;
using DaraAccess.Concrete.Context;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : IfEntityRepository<Article, SocialMediaContext>, IArticledal
    {

    }
}
