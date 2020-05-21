using AuthDataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthDataLayer
{
    public class UserContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<GroupModel> Groups { get; set; }
        public UserContext(DbContextOptions<UserContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserModel adminUser = new UserModel {Email = "service123@gmail.com", Login = "Admin",  Password = "AAAAAAA21312441AAA34BNKIJUYGBHH4", Name = "Super", Surname = "Admin" };
            GroupModel groupModel = new GroupModel { Id = Guid.Parse("3777d175-038c-4757-92e8-0c7e1fd677d5"), Name = "Я НЕ ИЗ УРФУ" };
            modelBuilder.Entity<UserModel>().HasData(new UserModel[] { adminUser });
            modelBuilder.Entity<GroupModel>().HasData(new GroupModel[] { groupModel });
            base.OnModelCreating(modelBuilder);
        }
    }
}
