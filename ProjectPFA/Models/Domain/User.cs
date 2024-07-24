using Microsoft.AspNetCore.Identity;

namespace ProjectPFA.Models.Domain
{
	public class User:IdentityUser
	{
		public string Nom { get; set; } = "";
		public string Prenom { get; set; } = "";
		public DateTime CreatedAt { get; set; }
		
	}
}
