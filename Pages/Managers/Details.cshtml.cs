using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Pages.Managers
{
    public class DetailsModel : PageModel
    {
        private readonly TaskManager.Data.TaskManagerContext _context;

        public DetailsModel(TaskManager.Data.TaskManagerContext context)
        {
            _context = context;
        }

        public Manager Manager { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manager = await _context.Manager.FirstOrDefaultAsync(m => m.ID == id);

            if (Manager == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
