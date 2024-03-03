using System;

namespace ServiceScope.Services
{
    public interface IScopedService : IService { }

    public class ScopedService : IScopedService
    {
        private string _guid;

        public ScopedService(ISingletonService1 singleton1, IScopedService1 scoped1, ITransientService1 transient1)
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
