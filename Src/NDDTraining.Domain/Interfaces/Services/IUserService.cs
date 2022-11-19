﻿using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Models;

namespace NDDTraining.Domain.Interfaces.Services
{
    public interface IUserService
    {
        User GetByToken(string token);
        void InsertUser(UserDTO newUser);
        String VerifyLogin (LoginDTO loginDTO);
    }
}
