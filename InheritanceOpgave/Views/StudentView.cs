using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPLUSPLUS.Views
{
    class StudentView
    {
        public Student AddStudent()
        {
            Console.Clear();
            Student student = new Student();
            Console.Write("Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Amount of warnings: ");

            //Missing input check here
            int.TryParse(Console.ReadLine(), out int warnings);
            student.Warnings = warnings;

            
            Tools.ChooseSubjects();

            return student;
        }
    }
}
