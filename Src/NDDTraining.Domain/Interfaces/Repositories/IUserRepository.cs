﻿using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDTraining.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User GetByEmail(string email);
        public User CheckUserByEmail(string email);
        public User CheckUserByCPF(string cpf);
        void Insert (User recordUser);
        User VerifyLogin(Login login);
        User CheckResetEmail(string email);
    }
}
