using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPLUSPLUS.Views
{
    class MenuView
    {
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.Write(
                    "\n1. Add Student\n" +
                    "2. Add Teacher\n\n" +
                    "Choose a service from the menu: "
                    );
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StudentView student = new StudentView();
                        student.AddStudent();
                        break;
                    case "2":
                        TeacherView teacher = new TeacherView();
                        teacher.AddTeacher();
                        break;
                } 
            } while (true);
        }
    }
}
