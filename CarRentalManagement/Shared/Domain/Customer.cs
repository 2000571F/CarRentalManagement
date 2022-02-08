﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DrivingLicense { get; set; }
        public string Address { get; set; }
        public int ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}