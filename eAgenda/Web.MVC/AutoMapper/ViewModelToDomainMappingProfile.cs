using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.MVC.Models;
using Web.MVC.ViewModel;

namespace Web.MVC.AutoMapper
{
    class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<LoginViewModel, Usuario>();
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<PaisViewModel, Pais>();
        }
    }
}