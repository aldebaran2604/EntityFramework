﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var dbContext = new PlutoDBContext();
            //dbContext.GetAuthorCourses();
            var courses = dbContext.GetCourses();
            foreach (var c in courses)
            {
                Console.WriteLine(c.Title);
            }*/
            /*var cours = new Cours();
            cours.Level = CourseLevel.Beginner;*/
            var dbContext = new VidzyEntities();
            dbContext.spAddVideo("Prueba 7", DateTime.Now, "Horror", (int)Classification.Platinum);
        }
    }
}
