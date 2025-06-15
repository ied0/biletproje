using System.ComponentModel.DataAnnotations;

namespace biletproje.ViewModels
{
	public class AdminForgotViewModel
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }
	}
}
