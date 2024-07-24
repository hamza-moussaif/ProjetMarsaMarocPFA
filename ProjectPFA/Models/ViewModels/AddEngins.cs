using ProjectPFA.Models.Domain;

namespace ProjectPFA.Models.ViewModels
{
    public class AddEngins
    {
        public int BCI { get; set; }
        public string Name { get; set; }
        public IFormFile? Image { get; set; }
        public Etat Etat { get; set; }
    }
}
