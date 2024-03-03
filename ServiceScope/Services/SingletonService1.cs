using System;

namespace ServiceScope.Services
{
    public interface ISingletonService1 : IService { }

    public class SingletonService1 : ISingletonService1
    {
        private string _guid;

        public SingletonService1()
        {
            _guid = Guid.NewGuid().ToString();
        }
        
        public string GetGuid()
        {
            return _guid;
        }
    }
}
