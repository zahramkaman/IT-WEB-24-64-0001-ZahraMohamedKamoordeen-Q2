using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentDatabase.Repository;
using StudentDatabase.Repository.Models;

namespace StudentDatabase.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly StudentDatabase.Repository.StudentDbContext _context;

        public IndexModel(StudentDatabase.Repository.StudentDbContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Course = await _context.Courses.ToListAsync();
        }
    }
}
