using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_Lab3.Models;
using System.Web.Mvc;

namespace ASP_Lab3.Util
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<SelectListItem>>().To<StringRepository<SelectListItem>>().InSingletonScope().WithPropertyValue("List", new List<SelectListItem>(new[] 
            {
                new SelectListItem{ Text = "Hello", Value = "1" },
                new SelectListItem{ Text = "World", Value = "2" },
                
            }));
        }

    }
}