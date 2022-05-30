using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTTTBaiThucHanh671.Models
{
    public partial class ThuchanhDbcontext : DbContext
    {
        public ThuchanhDbcontext()
            : base("name=ThuchanhDbcontext")
        {
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
