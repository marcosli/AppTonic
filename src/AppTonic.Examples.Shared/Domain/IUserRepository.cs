﻿using System;
using System.Threading.Tasks;

namespace AppTonic.Examples.Shared.Domain
{
    public interface IUserRepository : IDisposable
    {
        void Add(User user);
        void Save();
        User GetFirst();
        Task<User> GetFirstAsync();
    }
}