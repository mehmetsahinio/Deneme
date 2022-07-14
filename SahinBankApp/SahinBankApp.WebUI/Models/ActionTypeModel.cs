using System;
using System.ComponentModel.DataAnnotations;

namespace SahinBankApp.WebUI.Models
{
	public class ActionTypeModel
	{
		public int ActionTypeId { get; set; }
		[Required(ErrorMessage = " Adi boş bırakılamaz")]
		public string? ActionTypeName { get; set; }
		[Required(ErrorMessage = " Adi boş bırakılamaz")]

		public string? ActionTypeDescription { get; set; }
	}
}

