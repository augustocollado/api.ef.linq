using System;
using System.Collections.Generic;

namespace api.ef.linq.Models
{
    public partial class AlertGeofence
    {
        public int Id { get; set; }
        public int Grofenceid { get; set; }
        public int Ordering { get; set; }
    }
}
