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
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.CourseId);
            builder.HasMany(c => c.StudentCourses).WithOne(SC => SC.Course).HasForeignKey(sc=>sc.CourseId);
            builder.HasMany(c => c.Resources).WithOne(r => r.Course).HasForeignKey(r=>r.CourseId);
            builder.HasMany(c => c.HomeworkSubmissions).WithOne(HMS => HMS.Course).HasForeignKey(HMS=>HMS.CourseId);
            builder.Property(c => c.Name).HasMaxLength(80).IsUnicode(true);
            builder.Property(c => c.Description).IsRequired(false).IsUnicode(true);
        }
    }
}
