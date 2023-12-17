using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManageApp.Data;
using StudentManageApp.Model;

namespace StudentManageApp.Pages.Course
{
    public class CreateModel : PageModel
    {
        private readonly StudentManageApp.Data.StudentManageAppContext _context;

        public CreateModel(StudentManageApp.Data.StudentManageAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Courses Courses { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Courses == null || Courses == null)
            {
                return Page();
            }

            _context.Courses.Add(Courses);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
