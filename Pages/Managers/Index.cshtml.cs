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
    public class IndexModel : PageModel
    {
        private readonly TaskManager.Data.TaskManagerContext _context;

        public IndexModel(TaskManager.Data.TaskManagerContext context)
        {
            _context = context;
        }

        public IList<Manager> Manager { get;set; }

        public async Task OnGetAsync()
        {
            Manager = await _context.Manager.ToListAsync();
        }
    }
}
