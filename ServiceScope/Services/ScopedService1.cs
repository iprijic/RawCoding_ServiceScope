using System;

namespace ServiceScope.Services
{
    public interface IScopedService1 : IService { }

    public class ScopedService1 : IScopedService1
    {
        private string _guid;

        public ScopedService1(/*ISingletonService1 singleton1, IScopedService scoped, ITransientService1 transient1*/)
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
