﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookishApp
{
    class CheckOuts
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime DueDate { get; set; }
        public bool BeenReturned { get; set; }
    }
}
