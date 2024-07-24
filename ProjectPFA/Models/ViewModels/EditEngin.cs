namespace ProjectPFA.Models.ViewModels
{
    public class EditEngin
    {
        public Guid Id { get; set; }
        public int BCI { get; set; }
        public string Name { get; set; }
        public IFormFile? Image { get; set; }
        public EtatViewModel Etat { get; set; }
    }
}
