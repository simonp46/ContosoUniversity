using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();
             //Buscar estudiantes 
             if (context.Students.Any())
            {
                return; //Creación de la base de datos
            }

            var students = new Student[]
               {new Student{FirstMidName="Elon",LastName="Musk",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Jeff",LastName="Bezos",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Alan",LastName="Turing",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Bill",LastName="Gates",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Mark",LastName="Zuckerberg",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Steve",LastName="Jobs",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Sundar",LastName="Pichai",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Jack",LastName="Dorsey",EnrollmentDate=DateTime.Parse("2005-09-01")}
           };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Quimica",Credits=3},
            new Course{CourseID=4022,Title="Microeconomia",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomia",Credits=3},
            new Course{CourseID=1045,Title="Calculo",Credits=4},
            new Course{CourseID=3141,Title="Trigonometria",Credits=4},
            new Course{CourseID=2021,Title="Composicion",Credits=3},
            new Course{CourseID=2042,Title="Literatura",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
