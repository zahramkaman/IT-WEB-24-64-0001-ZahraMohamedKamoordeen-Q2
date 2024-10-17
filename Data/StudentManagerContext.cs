using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManager.Model;

namespace StudentManager.Data
{
    public class StudentManagerContext : DbContext
    {
        public StudentManagerContext (DbContextOptions<StudentManagerContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManager.Model.Student> Student { get; set; } = default!;
        public DbSet<StudentManager.Model.Course> Course { get; set; } = default!;
    }
}
