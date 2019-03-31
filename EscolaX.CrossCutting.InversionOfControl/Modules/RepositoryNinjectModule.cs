using EscolaX.Domain.Interfaces.Repositories;
using EscolaX.Infra.Data.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaX.CrossCutting.InversionOfControl.Modules
{
    public class RepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IUserRepository>().To<UserRepository>();
            Bind<IStudentRepository>().To<StudentRepository>();
        }
    }
}
