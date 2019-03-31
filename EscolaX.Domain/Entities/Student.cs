using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaX.Domain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
