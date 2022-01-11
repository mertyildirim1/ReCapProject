﻿using Core.Entities.Concrete;
using Core.Utilities.Result;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email); //kullanıcı daha önce kayıt olmuşsa kızmak için
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
