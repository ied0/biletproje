﻿using System.ComponentModel.DataAnnotations;

namespace biletproje.ViewModels
{
	public class CheckoutViewModel
	{
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		//[Required]
		//[EmailAddress]
		//public string Email { get; set; }
	}
}
