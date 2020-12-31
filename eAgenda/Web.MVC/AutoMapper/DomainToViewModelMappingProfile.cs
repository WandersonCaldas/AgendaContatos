using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.MVC.Models;
using Web.MVC.ViewModel;

namespace Web.MVC.AutoMapper
{
    class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, LoginViewModel>();
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Pais, PaisViewModel>();
        }
    }
}