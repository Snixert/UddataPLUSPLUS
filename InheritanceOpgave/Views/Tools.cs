using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPLUSPLUS.Views
{
    class Tools
    {
        public static void WriteAt (int x, int y, string text)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }
        public static List<Subject> ChooseSubjects()
        {
            List<Subject> studentSubjects = new List<Subject>();
            Console.Write("\n1. English\n2. Programming\n3. Geography\nQ. Stop adding subjects");
            CheckSubjectMenuInput(studentSubjects);

            return studentSubjects;
        }

        static List<Subject> CheckSubjectMenuInput(List<Subject> studentSubjects)
        {
            bool canParse = false;
            string subjectAnswer = string.Empty;
            int intMenu = 0;
            Subject tempSubject = new Subject();
            do
            {
                do
                {
                    WriteAt(0, 8, " ".PadRight(Console.WindowWidth,' '));
                    WriteAt(0, 8, "Choose a subject: ");
                    subjectAnswer = Console.ReadLine().ToUpper();
                    canParse = int.TryParse(subjectAnswer, out intMenu);
                    if (canParse == false || intMenu < 1 || intMenu > 3)
                    {
                        WriteAt(1, 12, "Invalid input, please choose between 1 and 3");
                        if (subjectAnswer == "Q")
                        {
                            // Set to true to escape both loops if menu input is Q.
                            canParse = true;
                        }
                    }
                } while (canParse == false);

                //Clear invalid input line if it was triggered.
                WriteAt(0, 12, " ".PadRight(Console.WindowWidth, ' '));
                var enumValue = (Subjects)(intMenu - 1);
                string subjectChosen = enumValue.ToString();
                WriteAt(0, 9, $"{subjectChosen} has been chosen.");

                //Force user to set an int as grade
                int grade = 0;
                do
                {
                    WriteAt(0, 11, " ".PadRight(Console.WindowWidth, ' '));
                    WriteAt(0, 11, "What grade did the student get: ");
                } while (!int.TryParse(Console.ReadLine(), out grade));

                //Add inputs to subject and then add to list
                tempSubject.Id = intMenu;
                tempSubject.Subjects = (Subjects)(intMenu - 1);
//                tempSubject.Name 
                tempSubject.Grade = grade;
                string description = Enumerations.GetEnumDescription((Subjects)subjectChosen);





                WriteAt(0, 13, "[Y] Add another subject    [Q] Stop adding more subjects");
                WriteAt(0, 14, "Do you want to add another subject for the student: ");
                subjectAnswer = Console.ReadLine().ToUpper();
            } while (subjectAnswer != "Q");
            return studentSubjects;
        }

    }
}
