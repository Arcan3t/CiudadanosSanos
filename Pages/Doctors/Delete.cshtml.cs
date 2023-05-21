using Ciudadanos_Sanos.Data;
using Ciudadanos_Sanos.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ciudadanos_Sanos.Pages.Doctors
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly CSContext _context;

        public DeleteModel(CSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Doctor Doctor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Doctors == null)
            {
                return NotFound();
            }

            var category = await _context.Doctors.FirstOrDefaultAsync(m => m.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            else
            {
                Doctor = category;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Doctors == null)
            {
                return NotFound();
            }
            var category = await _context.Doctors.FindAsync(id);

            if (category != null)
            {
                Doctor = category;
                _context.Doctors.Remove(Doctor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
