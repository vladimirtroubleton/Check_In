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
        public DbSet<GroupConnectModel> GroupsConnectRecords { get; set; }
        public UserContext(DbContextOptions<UserContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
