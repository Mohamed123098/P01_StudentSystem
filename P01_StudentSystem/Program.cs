using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data;
using P01_StudentSystem.Models;
using System;

namespace P01_StudentSystem
{
    internal class Program
    {
        static async Task Main(string[] args)

        {
            Student student = new();
            using(var context = new ApplicationDbContext())
            {
                //DataSeeder.DataSeedOfStudents(context);
                //DataSeeder.DataSeedOfCourses(context);
                //DataSeeder.DataSeedOfStudentCourses(context);
                ////DataSeeder.DataSeedOfResouces(context);
                //DataSeeder.DataSeedOfHMS(context);
                //DataSeeder.DBSaving(context);
                Console.WriteLine("Enter name of Student : ");
                student.Name = Console.ReadLine()!;
                Console.WriteLine("Enter ur phoneNumber");
                student.PhoneNumber = Console.ReadLine()!;
                context.Add(student);
                DataSeeder.DBSaving(context);
            }
            

            Console.WriteLine("Database seeding completed!");
        }


    }
    }
