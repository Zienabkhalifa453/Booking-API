﻿using Booking_API.Models;
using Booking_API.Repository.IRepository;

namespace Booking_API.Repository
{
    public class AirlineRepository : Repository<Airline>, IAirlineRepository
    {
        private readonly BookingContext _dbcontext;
        public AirlineRepository(BookingContext dBcontext) : base(dBcontext)
        {
            _dbcontext = dBcontext;
        }
    }
}
