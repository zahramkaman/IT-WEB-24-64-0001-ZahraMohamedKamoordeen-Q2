using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentDatabase.Repository;
using StudentDatabase.Repository.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentDatabase.Pages.Students
{
    public class StudentCoursesModel : PageModel
    {
        private readonly StudentDbContext _context;

        public StudentCoursesModel(StudentDbContext context)
        {
            _context = context;
        }

        public IList<Student> Students { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Students = await _context.Students
                                     .Include(s => s.Course)
                                     .ToListAsync();
        }
    }
}
