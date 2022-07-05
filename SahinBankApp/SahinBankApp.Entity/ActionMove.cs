using System;
namespace SahinBankApp.Entity
{
	public class ActionMove
	{
        public int ActionMoveId { get; set; }
        public string? UserId { get; set; }
        public int ActionTypeId { get; set; }
        public ActionType? ActionType { get; set; }
        public DateTime Date { get; set; }
        public decimal ActionAmount { get; set; }
        public decimal ActionDeduction { get; set; }
        public string? InvoiceNumber { get; set; }
        public Invoice? Invoice { get; set; }
    }
}

