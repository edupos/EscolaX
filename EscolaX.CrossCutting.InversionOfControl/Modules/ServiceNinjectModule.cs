using EscolaX.Domain.Interfaces.Services;
using EscolaX.Domain.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaX.CrossCutting.InversionOfControl.Modules
{
    public class ServiceNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IUserService>().To<UserService>();
            Bind<IStudentService>().To<StudentService>();
        }
    }
}
