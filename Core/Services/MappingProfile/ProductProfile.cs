using AutoMapper;
using Domain.Modules;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MappingProfile
{
    public class ProductProfile:Profile
    {

        public ProductProfile() {

            CreateMap<Product, ProductToReturnDto>();
        
        }
    }
}
