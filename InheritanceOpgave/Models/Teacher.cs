using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPLUSPLUS
{
    class Teacher : Subject
    {
        public bool CoffeeClub { get; set; }
        public List<Subject> TeacherSubjects { get; set; }
    }
}
