﻿namespace BeboerWeb.Api.Models.DTOs.PropertyManagement
{
    public class LeaseDto
    {
        public int Id { get; set; }
        public int Story { get; set; }
        public string Apartment { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
