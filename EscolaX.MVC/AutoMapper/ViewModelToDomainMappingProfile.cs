using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using EscolaX.MVC.ViewModels;
using EscolaX.Domain.Entities;

namespace EscolaX.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return ("DomainToViewModelMappings"); }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<User, UserViewModel>();
            Mapper.CreateMap<Student, StudentViewModel>();
        }
    }
}