using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTTTBaiThucHanh671.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public string StudnetID { get; set; }
        public string StudnetName { get; set; }
    }
}