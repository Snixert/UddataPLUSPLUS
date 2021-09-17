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
                Console.WriteLine(
                    "\n1. Add Student\n" +
                    "2. Show All Students\n" +
                    "3. Search for Student\n" +
                    "4. Add Teacher\n" +
                    "5. Show All Teachers\n" +
                    "6. Search for Teacher\n"
                    );
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StudentView student = new StudentView();
                        student.AddStudent();
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "6":

                        break;

                    default:
                        break; 
                } 
            } while (true);
        }
    }
}
