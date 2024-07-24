using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectPFA.Data;
using ProjectPFA.Models.Domain;
using ProjectPFA.Models.ViewModels;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPFA.Pages.Engins
{
    [Authorize(Roles = "Assistant")]
    public class EditModel : PageModel
    {
        private readonly PFADbContext _context;

        [BindProperty]
        public EditEngin EditEngin { get; set; }

        public EditModel(PFADbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            var engin = await _context.Engins
                .Include(e => e.Etat)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (engin == null)
            {
                return NotFound();
            }

            EditEngin = new EditEngin
            {
                Id = engin.Id,
                BCI = engin.BCI,
                Name = engin.Name,
                Etat = new EtatViewModel
                {
                    klaxon = engin.Etat.klaxon,
                    Sallette_Tracteur = engin.Etat.Sallette_Tracteur,
                    Flexible_Air_Tracteur = engin.Etat.Flexible_Air_Tracteur,
                    Extincteur = engin.Etat.Extincteur,
                    Verins_Translation_Fourches = engin.Etat.Verins_Translation_Fourches,
                    Eclairage = engin.Etat.Eclairage,
                    gyrophares = engin.Etat.gyrophares,
                    Vitres = engin.Etat.Vitres,
                    Carosserie = engin.Etat.Carosserie
                }
            };

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var engin = await _context.Engins
                .Include(e => e.Etat)
                .FirstOrDefaultAsync(e => e.Id == EditEngin.Id);

            if (engin == null)
            {
                return NotFound();
            }

            engin.BCI = EditEngin.BCI;
            engin.Name = EditEngin.Name;

            if (EditEngin.Image != null && EditEngin.Image.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await EditEngin.Image.CopyToAsync(memoryStream);
                    engin.Image = memoryStream.ToArray();
                }
            }

            engin.Etat.klaxon = EditEngin.Etat.klaxon;
            engin.Etat.Sallette_Tracteur = EditEngin.Etat.Sallette_Tracteur;
            engin.Etat.Flexible_Air_Tracteur = EditEngin.Etat.Flexible_Air_Tracteur;
            engin.Etat.Extincteur = EditEngin.Etat.Extincteur;
            engin.Etat.Verins_Translation_Fourches = EditEngin.Etat.Verins_Translation_Fourches;
            engin.Etat.Eclairage = EditEngin.Etat.Eclairage;
            engin.Etat.gyrophares = EditEngin.Etat.gyrophares;
            engin.Etat.Vitres = EditEngin.Etat.Vitres;
            engin.Etat.Carosserie = EditEngin.Etat.Carosserie;

            await _context.SaveChangesAsync();

            return RedirectToPage("List");
        }
    }
}
