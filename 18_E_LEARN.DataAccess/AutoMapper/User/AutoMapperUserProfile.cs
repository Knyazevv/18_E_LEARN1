﻿using _18_E_LEARN.DataAccess.Data.Models.User;
using _18_E_LEARN.DataAccess.Data.ViewModels.User;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_E_LEARN.DataAccess.AutoMapper.User
{
    public class AutoMapperUserProfile : Profile
    {
        public AutoMapperUserProfile()
        {
            CreateMap<AppUser, LoginUserVM>();
            CreateMap<LoginUserVM, AppUser>();
            CreateMap<AppUser, RegisterUserVM>();
            CreateMap<RegisterUserVM,AppUser>();
        }
    }
}
