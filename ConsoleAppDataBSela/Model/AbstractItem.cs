﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppDataBSela.Model
{
    public abstract class AbstractItem
    {
        public int ISBN { get; set; }
        public string Name { get; set; }
        public string UriImg { get; set; }
        public double Price { get; set; }
        public int CurrentAmout { get; set; }
        public int StarterAmount { get; set; }
    }
}
