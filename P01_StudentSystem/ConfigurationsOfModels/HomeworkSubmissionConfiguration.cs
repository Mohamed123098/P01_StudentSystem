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
    internal class HomeworkSubmissionConfiguration : IEntityTypeConfiguration<HomeworkSubmission>
    {
        public void Configure(EntityTypeBuilder<HomeworkSubmission> builder)
        {
            builder.HasKey(HMS => HMS.HomeworkId);
            builder.Property(HMS => HMS.Content).IsUnicode(false);
        }
    }
}
