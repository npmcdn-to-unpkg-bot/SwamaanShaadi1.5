﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwamaanShaadi.DomainClasses
{
    public class EmploymentType : IObjectWithState
    {
        public int EmploymentTypeId { get; set; }
        public string Type { get; set; }

        public State State { get; set; }
    }
}
