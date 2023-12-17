using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManageApp.Data;
using StudentManageApp.Model;

namespace StudentManageApp.Pages.Student
{
    public class DetailsModel : PageModel
    {
        private readonly StudentManageApp.Data.StudentManageAppContext _context;

        public DetailsModel(StudentManageApp.Data.StudentManageAppContext context)
        {
            _context = context;
        }

      public Students Students { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var students = await _context.Students.FirstOrDefaultAsync(m => m.Student_ID == id);
            if (students == null)
            {
                return NotFound();
            }
            else 
            {
                Students = students;
            }
            return Page();
        }
    }
}
