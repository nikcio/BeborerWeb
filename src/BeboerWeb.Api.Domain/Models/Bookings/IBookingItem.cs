﻿using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models.Bookings
{
    public interface IBookingItem
    {
        int Id { get; set; }
        byte[] RowVersion { get; set; }
        IEnumerable<BookingWindow> BookingWindows { get; set; }
        IEnumerable<Booking> Bookings { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        double Price { get; set; }
    }
}