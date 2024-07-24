using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectPFA.Data;
using ProjectPFA.Models.Domain;

namespace ProjectPFA.Pages.Demandeur.Demandes
{
    [Authorize(Roles = "Demandeur")]

    public class EditModel : PageModel
    {
		private readonly PFADbContext pFADbContext;
        [BindProperty]
        public Demande demande { get; set; }
        public EditModel(PFADbContext pFADbContext)
        {
			this.pFADbContext = pFADbContext;
		}
        public async Task OnGet(Guid id)
        {
           demande=await pFADbContext.Demandes.FindAsync(id);

        }
        public async Task<IActionResult> OnPostEdit()
        {
            var demandeToUpdate = await pFADbContext.Demandes.FindAsync(demande.Id);
            if (demandeToUpdate != null)
            {
                demandeToUpdate.NBci =demande.NBci ;
                demandeToUpdate.nomdemandeur = demande.nomdemandeur;
                demandeToUpdate.Departement = demande.Departement;
                demandeToUpdate.shift = demande.shift;
                demandeToUpdate.DateDemande = DateTime.Now;
                demandeToUpdate.NbrJours = demande.NbrJours;
                
            }
            await pFADbContext.SaveChangesAsync();
            return RedirectToPage("/Demandeur/Demandes/List");
        }
		public async Task<IActionResult> OnPostDelete(Guid id)
		{
			var demandeToDelete = await pFADbContext.Demandes.FindAsync(id);
			if (demandeToDelete != null && demandeToDelete.Etat == false)
			{
				pFADbContext.Demandes.Remove(demandeToDelete);
				await pFADbContext.SaveChangesAsync();
			    return RedirectToPage("/Demandeur/Demandes/List");
			}
            return Page(); 
		}


	}
}
