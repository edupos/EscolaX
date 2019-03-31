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
    public class StudentService : ServiceBase<Student>, IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
            : base(studentRepository)
        {
            _studentRepository = studentRepository;
        }
    }
}
