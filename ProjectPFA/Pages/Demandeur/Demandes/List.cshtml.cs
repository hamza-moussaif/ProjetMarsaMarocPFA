using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectPFA.Data;
using ProjectPFA.Models.Domain;

namespace ProjectPFA.Pages.Demandeur.Demandes
{
    [Authorize(Roles = "Demandeur")]

    public class ListModel : PageModel
    {
        private readonly PFADbContext pFADbContext;
        private readonly UserManager<User> userManager;
        public List<Demande> Demandes { get; set;}
		

		public ListModel(PFADbContext pFADbContext,UserManager<User> userManager)
        {
            this.pFADbContext = pFADbContext;
			this.userManager = userManager;
		}
        public async Task OnGetAsync()
        {
			var userId = userManager.GetUserId(User);

			// Filter demandes by the current user
			Demandes = await pFADbContext.Demandes
				.Where(d => d.user.Id == userId) // Assuming `user` is a navigation property to `User`
				.ToListAsync();
		}
       
    }
}
