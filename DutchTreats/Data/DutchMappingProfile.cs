using AutoMapper;
using DutchTreat.Data.Entities;
using DutchTreats.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreats.Data
{
    public class DutchMappingProfile : Profile
    {
        public DutchMappingProfile()
        {
            CreateMap<Order, OrderViewModel>()
                 .ForMember(o => o.OrderID, ex => ex.MapFrom(o => o.Id))
                 .ReverseMap(); // create a map in the oposite order using the member mapping above

            CreateMap<OrderItem, OrderItemViewModel>()
                .ReverseMap();
        }
    }
}
