using EscolaX.Domain.Entities;
using EscolaX.Domain.Interfaces.Repositories;
using EscolaX.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaX.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService 
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) 
            : base(userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
