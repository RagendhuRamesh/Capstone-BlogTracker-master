using BlogWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BlogDbContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public BlogDbContext() : base("name=BlogDbContext")
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            Database.SetInitializer<BlogDbContext>(new BlogInitilizer());
        }
        public virtual DbSet<AdminInfo> AdminsInfo { get; set; }
        public virtual DbSet<EmpInfo> EmpInfo { get; set; }
        public virtual DbSet<BlogInfo> BlogInfo { get; set; }
    }

}