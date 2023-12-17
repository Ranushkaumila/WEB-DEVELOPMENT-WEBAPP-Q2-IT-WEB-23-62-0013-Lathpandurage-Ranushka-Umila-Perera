using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManageApp.Model;

namespace StudentManageApp.Data
{
    public class StudentManageAppContext : DbContext
    {
        public StudentManageAppContext (DbContextOptions<StudentManageAppContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManageApp.Model.Students> Students { get; set; } = default!;

        public DbSet<StudentManageApp.Model.Courses>? Courses { get; set; }
    }
}
