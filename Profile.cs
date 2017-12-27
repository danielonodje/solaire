using AutoMapper;
using solaire.Models;
using solaire.ViewModels;
using System.Collections.Generic;

namespace solaire{
    public class AppProfile : Profile {
        public AppProfile(){
            CreateMap<Booking,BookingViewModel>();
        }
    }
}