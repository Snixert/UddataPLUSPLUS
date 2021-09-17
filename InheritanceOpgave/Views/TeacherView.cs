using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPLUSPLUS.Views
{
    class TeacherView
    {
        public void AddTeacher()
        {
            Console.Clear();
            Teacher teacher = new Teacher();
            Console.Write("Name: ");
            teacher.Name = Console.ReadLine();

            bool isMember = false;
            string memberAnswer = string.Empty;
            do
            {
                Tools.ClearMultipleLines(2, 3);
                Tools.WriteAt(0, 2, "1. Member of the coffee club\n2. Not a member of the coffee club\nSelect 1 or 2: ");
                memberAnswer = Console.ReadLine();
                if (memberAnswer == "1")
                {
                    isMember = true;
                }
                else if (memberAnswer == "2")
                {
                    isMember = false;
                }
            } while (memberAnswer != "1" && memberAnswer != "2");
            teacher.CoffeeClub = isMember;


            ChooseTeacherSubjects();

        }
        public List<Subject> ChooseTeacherSubjects()
        {
            List<Subject> teacherSubjects = new List<Subject>();
            Console.Write("\n1. English\n2. Programming\n3. Geography\nQ. Stop adding subjects");
            CheckTeacherSubjectInput(teacherSubjects);
            return teacherSubjects;
        }
        static List<Subject> CheckTeacherSubjectInput(List<Subject> teacherSubjects)
        {
            bool canParse = false;
            string subjectAnswer = string.Empty;
            int intMenu = 0;
            Subject tempSubject = new Subject();
            do
            {
                do
                {
                    Tools.WriteAt(0, 10, " ".PadRight(Console.WindowWidth, ' '));
                    Tools.WriteAt(0, 10, "Choose a subject: ");
                    subjectAnswer = Console.ReadLine().ToUpper();
                    canParse = int.TryParse(subjectAnswer, out intMenu);
                    if (canParse == false || intMenu < 1 || intMenu > 3)
                    {
                        canParse = false;
                        Tools.WriteAt(0, 12, "Invalid input, please choose between 1 and 3");
                        if (subjectAnswer == "Q")
                        {
                            // Exit the method and return list to ChooseSubjects method
                            return teacherSubjects;
                        }
                    }
                } while (canParse == false);

                //Clear invalid input line if it was triggered.
                Tools.WriteAt(0, 12, " ".PadRight(Console.WindowWidth, ' '));
                var enumValue = (Subjects)(intMenu - 1);
                string subjectChosen = enumValue.ToString();
                Tools.WriteAt(0, 11, $"{subjectChosen} has been chosen.");

                //Add inputs to subject and then add to list
                tempSubject.Id = intMenu;
                tempSubject.Subjects = (Subjects)(intMenu - 1);
                tempSubject.Name = Tools.GetEnumDescription((Subjects)intMenu - 1);

                teacherSubjects.Add(tempSubject);





                Tools.WriteAt(0, 13, "[Y] Add another subject    [Q] Stop adding more subjects");
                Tools.WriteAt(0, 14, "Do you want to add another subject for the teacher: ");
                subjectAnswer = Console.ReadLine().ToUpper();

                //Clear text under 'Choose subject: '
                Tools.ClearMultipleLines(12, 6);
            } while (subjectAnswer != "Q");
            return teacherSubjects;
        }
    }
}
