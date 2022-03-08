using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTTTBaiThucHanh671.Models
{
    public partial class LtqlDbContext : DbContext
    {
        public LtqlDbContext()
            : base("name=LtqlDbContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
