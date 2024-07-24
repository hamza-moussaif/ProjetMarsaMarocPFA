using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectPFA.Data;
using ProjectPFA.Models.Domain;

namespace ProjectPFA.Pages.Assistant.Affectations
{
    [Authorize(Roles = "Assistant")]
    public class ListModel : PageModel
    {
        private readonly PFADbContext _pFADbContext;

        public List<Affectation> Affectations { get; set; }

        public ListModel(PFADbContext pFADbContext)
        {
            _pFADbContext = pFADbContext;
        }

        public async Task OnGetAsync()
        {
            Affectations = await _pFADbContext.Affectations.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAffectationAsync(Guid id)
        {
            var affectation = await _pFADbContext.Affectations.FindAsync(id);
            if (affectation != null)
            {
                _pFADbContext.Affectations.Remove(affectation);
                await _pFADbContext.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSetDateFinAffectationAsync(Guid id)
        {
            var affectation = await _pFADbContext.Affectations.FindAsync(id);
            if (affectation != null)
            {
                affectation.DateFinAffectation = DateTime.Now;
                _pFADbContext.Affectations.Update(affectation);
                await _pFADbContext.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
