using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManageApp.Data;
using StudentManageApp.Model;

namespace StudentManageApp.Pages.Course
{
    public class DetailsModel : PageModel
    {
        private readonly StudentManageApp.Data.StudentManageAppContext _context;

        public DetailsModel(StudentManageApp.Data.StudentManageAppContext context)
        {
            _context = context;
        }

      public Courses Courses { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses.FirstOrDefaultAsync(m => m.Course_ID == id);
            if (courses == null)
            {
                return NotFound();
            }
            else 
            {
                Courses = courses;
            }
            return Page();
        }
    }
}
