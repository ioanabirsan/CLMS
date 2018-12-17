﻿using System;
using System.Collections.Generic;
using Users.API.Models;

namespace Users.API.Repository.Read
{
    public interface IReadUserRepository
    {
        User GetById(Guid id);
        IReadOnlyList<User> GetAll();
        bool Exists(Guid id);
        void SaveChanges();
    }
}