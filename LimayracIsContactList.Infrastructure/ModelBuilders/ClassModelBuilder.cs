using LimayracIsContactList.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LimayracIsContactList.Infrastructure.ModelBuilders
{
    public static class ClassModelBuilder
    {
        public static void CreateClassModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>().HasKey(s => s.Id);
            modelBuilder.Entity<Class>().Property(s => s.Label).IsRequired().HasMaxLength(50);
        }
    }
}
