using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTTTBaiTapLon671.Models
{
    [Table("Admins")]
    public class Admin
    {
        [Key]
        public string AdminID { get; set; }
        public string AdminName { get; set; }
    }
}