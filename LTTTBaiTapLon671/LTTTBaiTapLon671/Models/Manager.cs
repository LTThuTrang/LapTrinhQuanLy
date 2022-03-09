﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTTTBaiTapLon671.Models
{
    [Table("Managers")]
    public class Manager
    {
        [Key]
        public string ManagerID { get; set; }
        public string ManagerName { get; set; }
    }
}