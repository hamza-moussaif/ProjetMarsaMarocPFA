using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPFA.Models.Domain
{
	public class Affectation
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		public string Nom { get; set; }

		[Required]
		public string Prenom { get; set; }

		[Required]
		public string Departement { get; set; }

		[Required]
		public string Poste { get; set; }

		[Required]
		public int BCI { get; set; }

		[Required]
		public string Shift { get; set; }

		[Required]
		public DateTime DateAffectation { get; set; }

		public DateTime? DateFinAffectation { get; set; }

		[Required]
		public bool Etat { get; set; }

		// Foreign Key for Demande
		[ForeignKey("Demande")]
		public Guid? DemandeId { get; set; }

		// Navigation Property
		public Demande Demande { get; set; }
	}
}

