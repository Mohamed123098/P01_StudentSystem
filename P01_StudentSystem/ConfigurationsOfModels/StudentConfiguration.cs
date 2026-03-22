using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.ConfigurationsOfModels
{
    internal class StudentConfiguration() : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.StudentId);//primary key
            //builder.HasMany(s => s.Courses).WithMany(c => c.Students);//m:m relationShip
            builder.HasMany(s => s.StudentCourses).WithOne(sc => sc.Student).HasForeignKey(sc=>sc.StudentId);//m:1 relationShip
            builder.HasMany(s => s.homeworkSubmissions).WithOne(HMS => HMS.Student).HasForeignKey(HMS=>HMS.StudentId);//M:1 relationShip
            builder.Property(s => s.Name).HasMaxLength(100).IsUnicode();
            builder.Property(s => s.PhoneNumber).IsUnicode(false).IsRequired(false);
            //builder.Property(s => s.Birthday).IsRequired(false);



        }
    }
}
