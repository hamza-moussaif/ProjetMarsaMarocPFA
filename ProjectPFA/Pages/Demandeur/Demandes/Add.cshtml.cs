using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectPFA.Data;
using ProjectPFA.Models.Domain;
using ProjectPFA.Models.ViewModels;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace ProjectPFA.Pages.Admin.Demandes
{
    [Authorize(Roles = "Demandeur")]

    public class AddModel : PageModel
    {
       

        private readonly PFADbContext pFADbContext;
        private readonly UserManager<User> userManager;
        

        [BindProperty]
        public AddDemande AddDemandeRequest { get; set; }
        public AddModel(PFADbContext pFADbContext ,UserManager<User> userManager)
        {
            this.pFADbContext = pFADbContext;
            this.userManager = userManager;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost() 
        {
            var user = await userManager.GetUserAsync(User);
            var demande = new Demande()
            {
                NBci = AddDemandeRequest.BCI,
                nomdemandeur = AddDemandeRequest.nom,
                Departement = AddDemandeRequest.Departement,
                shift = AddDemandeRequest.shift,
                DateDemande = DateTime.Now,
                Etat = false,
                NbrJours = AddDemandeRequest.time,
                user = user
            };
            await pFADbContext.Demandes.AddAsync(demande);
            await pFADbContext.SaveChangesAsync();
            
            return RedirectToPage("/Demandeur/Demandes/List");
            
           
        }
    }
}
