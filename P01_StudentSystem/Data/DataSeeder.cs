using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    internal static class DataSeeder
    {
        public static  void Seed(ApplicationDbContext dbContext)
        {
            DataSeedOfStudents(dbContext);
            DataSeedOfCourses(dbContext);
            DataSeedOfResouces(dbContext);
            DataSeedOfStudentCourses(dbContext);
            DataSeedOfHMS(dbContext);
            DBSaving(dbContext);
        }

        public static void DBSaving(ApplicationDbContext dbContext)
        {
            dbContext.SaveChanges();
        }

        public static void DataSeedOfHMS(ApplicationDbContext dbContext)
        {
            if (!dbContext.HomeworkSubmissions.Any())
            {
                List<HomeworkSubmission> homeworks = new()
                {
                   new HomeworkSubmission
        {
            Name = "ASP.NET Assignment 1",
            Content = "https://example.com/submit1",
            ContentType = ContentType.Link,
            SubmissionTime = DateTimeOffset.Now,
            CourseId = 3,
            StudentId =2
        },
        new HomeworkSubmission
        {
            Name = "Angular Task",
            Content = "AngularProjectCode",
            ContentType = ContentType.Text,
            SubmissionTime = DateTimeOffset.Now,
            CourseId = 4,
            StudentId = 1

        },
        new HomeworkSubmission
        {
            Name = "Fullstack Final",
            Content = "https://github.com/project/repo",
            ContentType = ContentType.Link,
            SubmissionTime = DateTimeOffset.Now,
            CourseId=5,
            StudentId=2

                }
            };
                dbContext.HomeworkSubmissions.AddRange(homeworks);
            }
        }

        public static void DataSeedOfStudentCourses(ApplicationDbContext dbContext)
        {
            if (!dbContext.StudentCourses.Any())
            {
                List<StudentCourse>? studentCourses = new()
                {
                    new(){CourseId=3, StudentId=1},
                    new(){CourseId=4, StudentId=2},
                    new(){CourseId=5, StudentId=1},
                    new(){CourseId=6, StudentId=2}
                };
                dbContext.StudentCourses.AddRange(studentCourses);
            }
        }

        public static void DataSeedOfResouces(ApplicationDbContext dbContext)
        {
            if (!dbContext.Resources.Any())
            {
                var resources = new List<Resource>
    {
        new Resource
        {
            Name = "ASP.NET Intro Video",
            ResourceType = ResourcesType.Video,
            Url = "https://example.com/aspnet-intro",
            CourseId = dbContext.Courses.FirstOrDefault(c => c.Name.Contains("ASP.NET")).CourseId
        },
        new Resource
        {
            Name = "ASP.NET Slides",
            ResourceType = ResourcesType.Document,
            Url = "/files/aspnet-slides.pdf",
            CourseId = dbContext.Courses.FirstOrDefault(c => c.Name.Contains("ASP.NET")).CourseId
        },
        new Resource
        {
            Name = "Angular Official Docs",
            ResourceType = ResourcesType.Link,
            Url = "https://angular.io/docs",
            CourseId = dbContext.Courses.FirstOrDefault(c => c.Name.Contains("Angular")).CourseId
        },
        new Resource
        {
            Name = "Fullstack Project Repo",
            ResourceType = ResourcesType.Link,
            Url = "https://github.com/example/repo",
            CourseId = dbContext.Courses.FirstOrDefault(c => c.Name.Contains("Full-Stack")).CourseId
        }

        };
                dbContext.AddRange(resources);

            }
        }

        public static void DataSeedOfCourses(ApplicationDbContext dbContext)
        {
            if (!dbContext.Courses.Any())
            {
                var courses = new List<Course>
        {
            new Course
            {
                Name = "ASP.NET Core Fundamentals",
                Description = "Learn backend development with ASP.NET Core",
                Price = 1500,
                StartDate = DateTimeOffset.UtcNow.AddDays(7),
                EndDate = DateTimeOffset.UtcNow.AddMonths(3)
            },
            new Course
            {
                Name = "Angular Frontend Development",
                Description = "Build modern web apps using Angular",
                Price = 1200,
                StartDate = DateTimeOffset.UtcNow.AddDays(10),
                EndDate = DateTimeOffset.UtcNow.AddMonths(2)
            },
            new Course
            {
                Name = "Full-Stack Web Development",
                Description = "Combine ASP.NET Core with Angular",
                Price = 2500,
                StartDate = DateTimeOffset.UtcNow.AddDays(14),
                EndDate = DateTimeOffset.UtcNow.AddMonths(4)
            }
                };
                dbContext.Courses.AddRange(courses);
            }
        }

        public static void DataSeedOfStudents(ApplicationDbContext dbContext)
        {
            if (!dbContext.Students.Any())
            {

                var students = new List<Student>
            {
                new Student
                {
                    Name = "Ahmed Ali",
                    Birthday = new DateTimeOffset(2000, 5, 10, 0, 0, 0, TimeSpan.Zero),
                    PhoneNumber = "1001234567", // valid
                    ReigsteredOn = DateTimeOffset.Now
                },
                new Student
                {
                    Name = "Sara Mohamed",
                    Birthday = new DateTimeOffset(1999, 8, 20, 0, 0, 0, TimeSpan.Zero),
                    PhoneNumber = "1123456789", // valid
                    ReigsteredOn = DateTimeOffset.Now
                },
                new Student
                {
                    Name = "Omar Hassan",
                    Birthday = new DateTimeOffset(2001, 2, 15, 0, 0, 0, TimeSpan.Zero),
                    PhoneNumber = "1259876543", // valid
                    ReigsteredOn = DateTimeOffset.Now
                }
                };
                dbContext.AddRange(students);
            }
        }
    }
}
