using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPFA.Models.Domain
{
    public class Demande
    {
        public Guid Id { get; set; }
        public int NBci { get; set; }
        public string nomdemandeur { get; set; }
        public string Departement { get; set; }
        public DateTime DateDemande { get; set; }
        public string shift { get; set; }
        public bool? Etat { get; set; }
        public int NbrJours { get; set; }

        public User user { get; set; }
        public Affectation? Affectation { get; set; }
    }
}
