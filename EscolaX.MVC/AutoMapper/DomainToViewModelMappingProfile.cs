﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using EscolaX.MVC.ViewModels;
using EscolaX.Domain.Entities;

namespace EscolaX.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return ("ViewModelToDomainMappings"); }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UserViewModel, User>();
            Mapper.CreateMap<StudentViewModel, Student>();
        }
    }
}