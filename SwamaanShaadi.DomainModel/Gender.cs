﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DomainClasses
{
    public class Gender : IObjectWithState
    {
        public int GenderId { get; set; }
        public string Name { get; set; }

        public State State { get; set; }
    }
}
