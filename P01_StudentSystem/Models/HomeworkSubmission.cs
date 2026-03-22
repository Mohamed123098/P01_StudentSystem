using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class HomeworkSubmission
    {
        public int HomeworkId { get; set; }
        public string Name { get; set; }
        [RegularExpression(@"(^https://[a-z]$)|([a-zA-Z]{10,*})")]
        public string Content { get; set; }
        public ContentType ContentType { get; set; }
        public DateTimeOffset SubmissionTime { get; set; } = DateTimeOffset.Now;

        public Course? Course { get; set; }
        public int CourseId{ get; set; }
        public Student? Student { get; set; }
        public int StudentId { get; set; }


    }
}
