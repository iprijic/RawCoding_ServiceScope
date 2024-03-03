using System;

namespace ServiceScope.Services
{

    public interface ITransientService1 : IService { }

    public class TransientService1 : ITransientService1
    {
        private string _guid;

        public TransientService1(/*ISingletonService1 singleton1*/ /*,IScopedService1 scoped1*/)
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
