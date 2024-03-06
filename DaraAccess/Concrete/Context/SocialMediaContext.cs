using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaraAccess.Concrete.Context
{
    public class SocialMediaContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JQ57QTS;Database=SocialMedia;Trusted_connection=true;TrustServerCertificate=true;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> userOperationClaims { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
