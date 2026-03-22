using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Birthday { get; set; }
        [RegularExpression(@"^1(0|1|2|5)[0-9]{8}$",ErrorMessage ="ErrorMessage Must be 10 Characters")]
        public string PhoneNumber { get; set; }
        public DateTimeOffset ReigsteredOn { get; set; } = DateTimeOffset.Now;
        public List<StudentCourse> ?StudentCourses { get; set; } = [];
        public List<Course> ?Courses { get; set; } = [];
        public List<HomeworkSubmission> ?homeworkSubmissions { get; set; } = [];
    }
}
