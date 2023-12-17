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
    public class IndexModel : PageModel
    {
        private readonly StudentManageApp.Data.StudentManageAppContext _context;

        public IndexModel(StudentManageApp.Data.StudentManageAppContext context)
        {
            _context = context;
        }

        public IList<Students> Students { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                Students = await _context.Students.ToListAsync();
            }
        }
    }
}
