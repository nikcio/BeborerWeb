﻿using BeboerWeb.Api.Domain.Models.Bookings;
using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public class Tenant : ITenant
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public virtual IEnumerable<Booking> Bookings { get; set; }
        public virtual IEnumerable<LeasePeriod> LeasePeriods { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
