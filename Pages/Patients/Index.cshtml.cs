using Ciudadanos_Sanos.Data;
using Ciudadanos_Sanos.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ciudadanos_Sanos.Pages.Patients
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly CSContext _context;
        public IndexModel(CSContext context)
        {
            _context = context;
        }
        public IList<Patient> Patients { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Patients != null)
            {
                Patients = await _context.Patients.ToListAsync();
            }
        }
    }
}
