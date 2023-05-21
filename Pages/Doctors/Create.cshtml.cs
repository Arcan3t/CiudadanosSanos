using Ciudadanos_Sanos.Data;
using Ciudadanos_Sanos.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ciudadanos_Sanos.Pages.Doctors
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly CSContext _context;
        public CreateModel(CSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Doctor Doctor { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Doctors == null || Doctor == null)
            {
                return Page();
            }
            _context.Doctors.Add(Doctor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
