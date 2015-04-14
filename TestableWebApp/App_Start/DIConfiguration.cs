using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestableWebApp.Models;
using TestableWebApp.Models.Repository;
using TestableWebApp.Presenters;

namespace TestableWebApp.App_Start
{
    public class DIConfiguration
    {
        public static void SetupDI(IKernel kernel)
        {
            kernel.Bind<IPresenter<GuestResponse>>().To<RSVPPresenter>();
            kernel.Bind<IPresenter<IEnumerable<GuestResponse>>>().To<RSVPPresenter>();
            kernel.Bind<IRepository>().To<MemoryRepository>().InSingletonScope();
        }
    }
}