using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTimeOffset StartDate { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset EndDate { get; set; } = DateTimeOffset.MaxValue;
        public List<StudentCourse> ?StudentCourses { get; set; } = [];

        public List<Student>? Students { get; set; } = [];

        public List<Resource>? Resources { get; set; } = [];
        public List<HomeworkSubmission>? HomeworkSubmissions { get; set; } = [];

    }
}
