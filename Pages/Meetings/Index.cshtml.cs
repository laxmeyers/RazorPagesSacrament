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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesSacrament.Data.RazorPagesSacramentContext _context;

        public IndexModel(RazorPagesSacrament.Data.RazorPagesSacramentContext context)
        {
            _context = context;
        }

        public IList<Meeting> Meeting { get;set; }

        public async Task OnGetAsync()
        {
            Meeting = await _context.Meeting.ToListAsync();
        }
    }
}
