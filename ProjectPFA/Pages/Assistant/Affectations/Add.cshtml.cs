using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectPFA.Data;
using ProjectPFA.Models.Domain;
using ProjectPFA.Models.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPFA.Pages.Assistant.Affectations
{
    [Authorize(Roles = "Assistant")]
    public class AddModel : PageModel
    {
        private readonly PFADbContext _pFADbContext;

        [BindProperty]
        public AddAffectation AddAffectationRequest { get; set; }
        public Demande Demande { get; set; }

        public AddModel(PFADbContext pFADbContext)
        {
            _pFADbContext = pFADbContext;
        }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            Demande = await _pFADbContext.Demandes.FindAsync(id);
            if (Demande == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid id)
        {
            // Fetch the Demande entity using the provided ID
            var demandeToUpdate = await _pFADbContext.Demandes.FindAsync(id);
            if (demandeToUpdate == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                // Handle the validation errors
                var errors = ModelState.Values.SelectMany(v => v.Errors).ToList();
                foreach (var error in errors)
                {
                    ModelState.AddModelError(string.Empty, error.ErrorMessage);
                }
                return Page();
            }

            var affectation = new Affectation()
            {
                Nom = AddAffectationRequest.Nom,
                Prenom = AddAffectationRequest.Prenom,
                Departement = AddAffectationRequest.Departement,
                BCI = AddAffectationRequest.Bci,
                Poste = AddAffectationRequest.Poste,
                Shift = AddAffectationRequest.Shift,
                DateAffectation = DateTime.Now,
                DateFinAffectation = null,
                DemandeId = demandeToUpdate.Id,
               
            };
            

            await _pFADbContext.Affectations.AddAsync(affectation);
            demandeToUpdate.Etat = true;
            await _pFADbContext.SaveChangesAsync();
            return RedirectToPage("/Assistant/Affectations/List");
        }
    }
}
