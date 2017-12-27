using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using solaire.ViewModels;
using solaire.Models;
using Microsoft.AspNetCore.Mvc;

namespace solaire.Controllers{
    [Route("api/[controller]")]
    public class BookingsController : BaseController {
        public BookingsController(IMapper mapper, AppDbContext dbContext) : base (mapper, dbContext){}

        [HttpGet]
        public List<BookingViewModel> GetAll(){
            var bookings = DbContext
                            .Bookings
                            .ToList();

            return Mapper.Map<List<BookingViewModel>>(bookings);
        }
    }
}