﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeepleFinder.Models
{
    public class Category : IModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
