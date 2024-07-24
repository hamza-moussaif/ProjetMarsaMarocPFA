namespace ProjectPFA.Models.Domain
{
    public class Etat
    {
        public Guid Id { get; set; }
        public bool klaxon { get; set; }
        public bool Sallette_Tracteur { get; set; }
        public bool Flexible_Air_Tracteur { get; set; }
        public bool Extincteur { get; set; }
        public bool Verins_Translation_Fourches { get; set; }
        public bool Eclairage { get; set; }
        public bool gyrophares { get; set; }
        public bool Vitres { get; set; }
        public bool Carosserie { get; set; }
    }
}
