using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPLUSPLUS
{
    class Student : Subject
    {
        public int Warnings { get; set; }
        public List<Subject> StudentSubjects{ get; set; }
    }
}
