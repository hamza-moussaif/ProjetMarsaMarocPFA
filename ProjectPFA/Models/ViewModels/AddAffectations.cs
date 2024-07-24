using System.ComponentModel.DataAnnotations;

namespace ProjectPFA.Models.ViewModels
{
	public class AddAffectation
	{
		[Required(ErrorMessage = "Nom is required")]
		public string Nom { get; set; }

		[Required(ErrorMessage = "Prenom is required")]
		public string Prenom { get; set; }

		[Required(ErrorMessage = "Departement is required")]
		public string Departement { get; set; }

		[Required(ErrorMessage = "BCI is required")]
		public int Bci { get; set; }

		[Required(ErrorMessage = "Poste is required")]
		public string Poste { get; set; }

		[Required(ErrorMessage = "Shift is required")]
		public string Shift { get; set; }
	}
}
