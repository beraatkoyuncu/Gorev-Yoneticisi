using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Pages.Managers
{
    public class CreateModel : PageModel
    {
        private readonly TaskManager.Data.TaskManagerContext _context;

        public CreateModel(TaskManager.Data.TaskManagerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Manager Manager { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Manager.Add(Manager);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
