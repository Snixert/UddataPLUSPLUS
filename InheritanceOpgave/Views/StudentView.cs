using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPLUSPLUS.Views
{
    class StudentView
    {
        public void AddStudent()
        {
            Console.Clear();
            Student student = new Student();
            Console.Write("Name: ");
            student.Name = Console.ReadLine();

            //Check that amount of warnings is an int
            bool canParse = false;
            do
            {
                Tools.WriteAt(0, 2, " ".PadRight(Console.WindowWidth, ' '));
                Tools.WriteAt(0, 2, "Amount of warnings: ");
                canParse = int.TryParse(Console.ReadLine(), out int warnings);
                student.Warnings = warnings;
            } while (canParse == false);


            Tools.ChooseSubjects();
        }
    }
}
