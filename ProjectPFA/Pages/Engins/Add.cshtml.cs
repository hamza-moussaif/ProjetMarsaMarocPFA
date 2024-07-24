using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectPFA.Data;
using ProjectPFA.Models.Domain;
using ProjectPFA.Models.ViewModels;

namespace ProjectPFA.Pages.Engins
{
    [Authorize(Roles = "Assistant")]

    public class AddModel : PageModel
    {
        private readonly PFADbContext _pFADbContext;

        [BindProperty]
        public AddEngins AddEnginRequest { get; set; }

        public AddModel(PFADbContext pFADbContext)
        {
            _pFADbContext = pFADbContext;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).ToList();
                foreach (var error in errors)
                {
                    ModelState.AddModelError(string.Empty, error.ErrorMessage);
                }
                return Page();
            }

            byte[] imageData = null;

            if (AddEnginRequest.Image != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await AddEnginRequest.Image.CopyToAsync(memoryStream);
                    imageData = memoryStream.ToArray();
                }
            }

            var engin = new Engin
            {
                Id = Guid.NewGuid(),
                BCI = AddEnginRequest.BCI,
                Name = AddEnginRequest.Name,
                Image = imageData,
                Etat = AddEnginRequest.Etat
            };

            _pFADbContext.Engins.Add(engin);
            await _pFADbContext.SaveChangesAsync();

            return RedirectToPage("List");
        }
    }
}
