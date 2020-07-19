﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Detail_Printer_Before
{
    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }
    }
}