﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AncestorData.Models
{
    public class Database
    {
        public int DatabaseId { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}