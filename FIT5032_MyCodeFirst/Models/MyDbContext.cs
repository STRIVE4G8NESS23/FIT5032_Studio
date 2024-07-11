using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FIT5032_MyCodeFirst.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // 配置主键
            modelBuilder.Entity<Student>().HasKey(s => s.Id);
            modelBuilder.Entity<Unit>().HasKey(u => u.Id);

            // 配置外键关系
            modelBuilder.Entity<Unit>()
                .HasRequired(u => u.Student)
                .WithMany(s => s.Units)
                .HasForeignKey(u => u.StudentId);
        }
    }
}