﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QverbITMS.Core.Domain
{
    public class Task : BaseEntity
    {
        public string Name { get; set; }
        public string Descr { get; set; }
    }
}
