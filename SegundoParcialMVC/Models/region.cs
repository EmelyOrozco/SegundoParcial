﻿namespace SegundoParcialMVC.Models
{
    public class Region
    {
        public int RegionNo { get; set; }

        public string RegionName { get; set; } = null!;

        public string Street { get; set; } = null!;

        public string City { get; set; } = null!;

        public string StateProv { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string MailCode { get; set; } = null!;

        public string PhoneNo { get; set; } = null!;

        public string RegionCode { get; set; } = null!;
    }
}
