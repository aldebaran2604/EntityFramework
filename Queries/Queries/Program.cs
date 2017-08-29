using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var context = new PlutoContext();

            var query =
                from c in context.Courses
                where c.Name.Contains("c#")
                orderby c.Name
                select c;

            foreach(var course in query)
            {
                Console.WriteLine(course.Name);
            }

            var courses = context.Courses
                .Where(c => c.Name.Contains("C#"))
                .OrderBy(c => c.Name);

            foreach(var course in courses)
            {
                Console.WriteLine(course.Name);
            }

            Console.Read();*/

            var context = new PlutoContext();

            /*var query =
                from c in context.Courses
                where c.Author.Id == 1
                orderby c.Level descending, c.Name
                select new { Name = c.Name, Author = c.Author.Name };

            foreach(var course in query)
            {
                Console.WriteLine(course.Name);
            }*/

            /*var query =
                from c in context.Courses
                group c by c.Level into g
                select g;

            foreach (var group in query)
            {
                Console.WriteLine("{0} ({1})", group.Key, group.Count());
                foreach (var course in group)
                {
                    Console.WriteLine("\t{0}", course.Name);
                }
            }*/

            /* var query =
                 from c in context.Courses
                 join a in context.Authors on c.AuthorId equals a.Id
                 select new { CourseName = c.Name, AuthorName =  a.Name };
             */

            /*var query =
                from a in context.Authors
                join c in context.Courses on a.Id equals c.AuthorId into g
                select new { AuthorName = a.Name, Courses = g.Count() };

            foreach (var x  in query)
            {
                Console.WriteLine("{0}, ({1})", x.AuthorName, x.Courses);
            }*/

            /*var query =
                from a in context.Authors
                from c in context.Courses
                select new { AuthorName = a.Name, CourseName = c.Name };

            foreach (var x in query)
            {
                Console.WriteLine("{0} - {1}", x.AuthorName, x.CourseName);
            }*/

            /*var courses = context.Courses
                .Where(c => c.Level == 1)
                .OrderByDescending(c => c.Name)
                .ThenBy(c => c.Level)
                .Select(c => c.Tags);

            foreach (var c in courses)
            {
                foreach (var tag in c)
                {
                    Console.WriteLine(tag.Name);
                }
            }*/

            /*var tags = context.Courses
                .Where(c => c.Level == 1)
                .OrderByDescending(c => c.Name)
                .ThenBy(c => c.Level)
                .SelectMany(c => c.Tags)
                .Distinct();

            foreach (var t in tags)
            {
                Console.WriteLine(t.Name);
            }*/

            /*var groups = context.Courses.GroupBy(c => c.Level);

            foreach (var group in groups)
            {
                Console.WriteLine("Key: {0}",group.Key);
                foreach (var course in group)
                {
                    Console.WriteLine("\t {0}", course.Name);
                }
            }*/

            /*context.Courses.Join(
                context.Authors,
                c => c.AuthorId,
                a => a.Id,
                (course, author) => new
                {
                    CourseName = course.Name,
                    AuthorName = author.Name
                }
            );*/

            /*var selectMany = context.Authors.SelectMany(
                a => context.Courses,
                (author, course) => new
                {
                    AuthorName = author.Name,
                    CourseName = course.Name
                }
            );

            foreach (var sm in selectMany)
            {
                Console.WriteLine(
                    "Author: {0}, Course: {1}",
                    sm.AuthorName,
                    sm.CourseName
                );
            }*/

            /*var courses = context.Courses;

            foreach (var c in courses)
            {
                Console.WriteLine(c.Name);
            }*/

            /*IQueryable<Course> courses = context.Courses;
            var filtered = courses.Where(c => c.Level == 1);

            foreach (var course in filtered)
            {
                Console.WriteLine(course.Name);
            }

            IEnumerable<Course> courses = context.Courses;
            var filtered = courses.Where(c => c.Level == 1);

            foreach (var course in filtered)
            {
                Console.WriteLine(course.Name);
            }*/

            /*var course = context.Courses.Single(c => c.Id == 2);

            foreach (var tag in course.Tags)
            {
                Console.WriteLine(tag.Name);
            }*/

            /*var courses = context.Courses.ToList();

            foreach (var course in courses)
            {
                Console.WriteLine(
                    "{0} by {1}",
                    course.Name,
                    course.Author.Name
                );
            }*/

            /*var author = context.Authors.Single(a => a.Id == 1);
            context.Entry(author).Collection(a => a.Courses).Load();

            foreach (var course in author.Courses)
            {
                Console.WriteLine("{0}", course.Name);
            }*/
            /*var author = context.Authors.Single(a => a.Id == 1);
            var course = new Course
            {
                Name = "New Course 2",
                Description = "New Description",
                FullPrice = 19.95f,
                Level = 1,
                Author = author
            };

            context.Courses.Add(course);
            context.SaveChanges();*/

            /*var author = context.Authors.Include(a => a.Courses).Single(a => a.Id == 2);
            context.Courses.RemoveRange(author.Courses);
            context.Authors.Remove(author);
            context.SaveChanges();*/

            /*context.Authors.Add(new Author { Name = "New Author" });

            var author = context.Authors.Find(3);
            author.Name = "Updated";

            var another = context.Authors.Find(4);
            context.Authors.Remove(another);

            var entries = context.ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                //entry.Reload();
                Console.WriteLine(entry.State);
            }*/

            Console.Read();
        }
    }
}
