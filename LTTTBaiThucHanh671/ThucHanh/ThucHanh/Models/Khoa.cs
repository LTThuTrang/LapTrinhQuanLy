﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThucHanh.Models
{
    [Table("Khoas")]
    public class Khoa
    {
        [Key]
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
    }
}