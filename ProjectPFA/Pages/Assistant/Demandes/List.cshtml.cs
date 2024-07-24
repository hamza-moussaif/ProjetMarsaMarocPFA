using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectPFA.Data;
using ProjectPFA.Models.Domain;

namespace ProjectPFA.Pages.Assistant.Demandes
{
    public class ListModel : PageModel
    {
        private readonly PFADbContext pFADbContext;

        public ListModel(PFADbContext pFADbContext)
        {
            this.pFADbContext = pFADbContext;
        }

        public IList<Demande> Demandes { get; set; }

        public async Task OnGetAsync()
        {
            Demandes = await pFADbContext.Demandes.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(Guid demandeId)
        {
            var demande = await pFADbContext.Demandes.FindAsync(demandeId);
            if (demande != null)
            {
                pFADbContext.Demandes.Remove(demande);
                await pFADbContext.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
