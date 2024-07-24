namespace ProjectPFA.Models.Domain
{
    public class Engin
    {
        public Guid Id { get; set; }
        public int BCI { get; set; }
        public string Name { get; set; }
        public byte[]? Image { get; set; }
       
        public Etat Etat { get; set; }
    }
}
