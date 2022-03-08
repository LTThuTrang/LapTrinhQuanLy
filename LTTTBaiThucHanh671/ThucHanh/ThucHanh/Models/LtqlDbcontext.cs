using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ThucHanh.Models
{
    public partial class LtqlDbcontext:DbContext
    {
        public LtqlDbcontext(): base("name=LtqlDbcontext") { }
        public virtual DbSet<Khoa> Khoas { get; set; }
    }
}