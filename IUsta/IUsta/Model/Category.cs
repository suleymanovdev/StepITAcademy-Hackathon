﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUsta.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string categoryName { get; set; }
    }
}
