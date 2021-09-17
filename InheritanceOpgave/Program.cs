using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using UddataPLUSPLUS.Views;

namespace UddataPLUSPLUS
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuView menu = new MenuView();
            menu.Menu();


            //Student jimmy = new Student()
            //{
            //    Id = 1,
            //    Name = "Jimmy Wolthers Nielsen",
            //    Warnings = 4,
            //    StudentSubjects = new List<Subject>()
            //{
            //    new Subject() { Id = 1, Name = "English", Subjects = Subjects.ENG, Grade = 12},
            //    new Subject() { Id = 2, Name = "Programming", Subjects = Subjects.PROG, Grade = 12},
            //    new Subject() { Id = 3, Name = "Geography", Subjects = Subjects.GEO, Grade = 7},
            //}   
            //};

            //Teacher henrik = new Teacher()
            //{
            //    Id = 1,
            //    Name = "Henrik Vincent Poulsen",
            //    CoffeeClub = true,
            //    TeacherSubjects = new List<Subject>()
            //{
            //    new Subject() { Id = 1, Name = "English", Subjects = Subjects.ENG},
            //    new Subject() { Id = 2, Name = "Programming", Subjects = Subjects.PROG},
            //    new Subject() { Id = 3, Name = "Geography", Subjects = Subjects.GEO},
            //}
            //};

            //foreach (var stuSubject in jimmy.StudentSubjects)
            //{
            //    Console.WriteLine("Subject: " + stuSubject.Name + "Grade: " + stuSubject.Grade);
            //}

        }
    }
}
