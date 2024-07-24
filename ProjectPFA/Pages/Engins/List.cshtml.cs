using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectPFA.Data;
using ProjectPFA.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ProjectPFA.Pages.Engins
{
    [Authorize(Roles = "Assistant")]
    public class ListModel : PageModel
    {
        private readonly PFADbContext _dbContext;

        public ListModel(PFADbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Engin> Engins { get; set; }

        public async Task OnGetAsync()
        {
            Engins = await _dbContext.Engins.Include(e => e.Etat).ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync(Guid id)
        {
            var engin = await _dbContext.Engins.FindAsync(id);
            if (engin == null)
            {
                return NotFound();
            }

            _dbContext.Engins.Remove(engin);
            await _dbContext.SaveChangesAsync();

            return RedirectToPage();
        }

    }
}
