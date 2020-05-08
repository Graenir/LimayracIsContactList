using LimayracIsContactList.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LimayracIsContactList.Infrastructure.ModelBuilders
{
    public static class StudentModelBuilder
    {
        public static void CreateStudentModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(s => s.Id);
            modelBuilder.Entity<Student>().Property(s => s.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Student>().Property(s => s.Surname).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Student>().Property(s => s.Email1).IsRequired().HasMaxLength(250);
            modelBuilder.Entity<Student>().Property(s => s.Email2).HasMaxLength(250);
            modelBuilder.Entity<Student>().Property(s => s.Phone1).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Student>().Property(s => s.Phone2).HasMaxLength(20);
            modelBuilder.Entity<Student>().Property(s => s.IsActive).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Student>().HasOne(m => m.Class);
        }
    }
}
