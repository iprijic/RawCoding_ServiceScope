using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ServiceScope.Services;
using System;
using System.Diagnostics;
using System.Linq;

namespace ServiceScope.Controllers
{
    public class HomeController : Controller
    {
        private ISingletonService _singleton;
        private IScopedService _scoped;
        private ITransientService _transient;

        private ISingletonService1 _singleton1;
        private IScopedService1 _scoped1;
        private ITransientService1 _transient1;

        public HomeController(

            ISingletonService1 singleton1,
            IScopedService1 scoped1,
            ITransientService1 transient1,

            IServiceProvider serviceProvider,

            ISingletonService singleton,
            IScopedService scoped,
            ITransientService transient)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;

            _singleton1 = singleton1;
            _scoped1 = scoped1;
            _transient1 = transient1;


            //for (int i = 0; i < 2; i++)
            //{
            //    ISingletonService1 st1 = serviceProvider.GetServices<ISingletonService1>().FirstOrDefault();
            //    Debug.WriteLine(nameof(st1) + " guid: " + st1.GetGuid());
            //}


            //for (int i = 0; i < 2; i++)
            //{
            //    IScopedService1 scs1 = serviceProvider.GetServices<IScopedService1>().FirstOrDefault();
            //    Debug.WriteLine(nameof(scs1) + " guid: " + scs1.GetGuid());
            //}


            //for (int i = 0; i < 2; i++)
            //{
            //    ITransientService1 ts1 = serviceProvider.GetServices<ITransientService1>().FirstOrDefault();
            //    Debug.WriteLine(nameof(ts1) + " guid: " + ts1.GetGuid());
            //}


        }

        public IActionResult Index()
        {
            return View("Index", _singleton.GetGuid());
        }

        public IActionResult Scoped()
        {
            return View("Scoped", _scoped.GetGuid());
        }

        public IActionResult Transient()
        {
            return View("Transient", _transient.GetGuid());
        }
    }
}
