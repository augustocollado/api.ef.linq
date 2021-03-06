﻿using System;
using System.Collections.Generic;

namespace api.ef.linq.Models
{
    public partial class Vehiclebrand
    {
        public Vehiclebrand()
        {
            Vehiclemodel = new HashSet<Vehiclemodel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Enterpriseid { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Vehiclemodel> Vehiclemodel { get; set; }
    }
}
