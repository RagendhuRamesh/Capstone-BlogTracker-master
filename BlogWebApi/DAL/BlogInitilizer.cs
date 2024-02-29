using DAL;
using System.Collections.Generic;
using System;
using System.Data.Entity;
using BlogWebApi.Models;

namespace DAL
{
    public class BlogInitilizer : DropCreateDatabaseIfModelChanges<BlogDbContext>
    {
        protected override void Seed(BlogDbContext blogDbContext)
        {
            List<AdminInfo> admins = new List<AdminInfo>()
            {
                new AdminInfo() {EmailId="admin@gmail.com",Password="admin123"},
                new AdminInfo(){EmailId="admin",Password="admin@123"}
            };
            blogDbContext.AdminsInfo.AddRange(admins);
            blogDbContext.SaveChanges();

            List<EmpInfo> employees = new List<EmpInfo>()
            {
                new EmpInfo() {EmailId="ragendhu@gmail.com",Name="Ragendhu Ramesh",DateOfJoining=new DateTime(2023,9,26),PassCode=25457 },
                new EmpInfo() {EmailId="sureshreddy@gmail.com",Name="suresh Reddy",DateOfJoining=new DateTime(2023,9,26),PassCode=25829 },
                new EmpInfo() {EmailId="Naresh@gmail.com",Name="Naresh",DateOfJoining=new DateTime(2023,9,26),PassCode=25698 }
            };
            blogDbContext.EmpInfo.AddRange(employees);
            blogDbContext.SaveChanges();
            List<BlogInfo> blogs = new List<BlogInfo>()
            {
                new BlogInfo(){BlogInfoId=new Random().Next(100,900),Subject="MS.Net",Title="Blog1",BlogUrl="https://www.thes30.com/",DateOfCreation=new DateTime(2024,10,12),EmpEmailId="admin@gmail.com"}
            };
            blogDbContext.BlogInfo.AddRange(blogs); blogDbContext.SaveChanges();

            base.Seed(blogDbContext);

        }
    }
}