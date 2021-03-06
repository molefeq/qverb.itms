﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace QverbITMS.Core.Domain
{
    public class TaskCategory : BaseEntity
    {
        [Required]
        [Display(Name = "Category")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Descr { get; set; }
        [Required]
        public bool Active { get; set; }
    }
}
