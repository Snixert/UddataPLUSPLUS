using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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
                        canParse = false;
                        WriteAt(0, 12, "Invalid input, please choose between 1 and 3");
                        if (subjectAnswer == "Q")
                        {
                            // Exit the method and return list to ChooseSubjects method
                            return studentSubjects;
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
                tempSubject.Name  = GetEnumDescription((Subjects)intMenu - 1);
                tempSubject.Grade = grade;

                studentSubjects.Add(tempSubject);





                WriteAt(0, 13, "[Y] Add another subject    [Q] Stop adding more subjects");
                WriteAt(0, 14, "Do you want to add another subject for the student: ");
                subjectAnswer = Console.ReadLine().ToUpper();

                //Clear text under 'Choose subject: '
                ClearMultipleLines(9, 6);
            } while (subjectAnswer != "Q");
            return studentSubjects;
        }
        public static string GetEnumDescription(Enum value)
        {
            // Gets the description of enum, used for setting subject.name
            try
            {
                FieldInfo fi = value.GetType().GetField(value.ToString());

                DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

                if (attributes != null && attributes.Any())
                {
                    return attributes.First().Description;
                }

                return value.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR:  {e.Message}");
                return string.Empty;
            }
        }
        public static void ClearMultipleLines(int y, int n)
        {
            //n is the amount of lines to be cleared, y is the linenumber to start clearing from.
            for (int i = 0; i < n; i++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write(" ".PadRight(Console.WindowWidth, ' '));
                y++;
            }
        }

    }
}
