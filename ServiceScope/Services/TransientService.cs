﻿using System;

namespace ServiceScope.Services
{
    public interface ITransientService : IService { }

    public class TransientService : ITransientService
    {
        private string _guid;

        public TransientService(ISingletonService1 singleton1,IScopedService1 scoped1, ITransientService1 transient1)
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
