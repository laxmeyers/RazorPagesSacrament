using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesSacrament.Data;
using RazorPagesSacrament.Models;

namespace RazorPagesSacrament.Pages.Meetings
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesSacrament.Data.RazorPagesSacramentContext _context;

        public DetailsModel(RazorPagesSacrament.Data.RazorPagesSacramentContext context)
        {
            _context = context;
        }

        public Meeting Meeting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Meeting = await _context.Meeting.FirstOrDefaultAsync(m => m.ID == id);

            if (Meeting == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
