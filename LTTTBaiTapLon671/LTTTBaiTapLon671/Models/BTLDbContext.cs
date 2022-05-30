
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LTTTBaiTapLon671.Models
{
    public partial class BTLDbContext : DbContext
    {
        public BTLDbContext() : base("name=BTLDbContext") { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
    }
}