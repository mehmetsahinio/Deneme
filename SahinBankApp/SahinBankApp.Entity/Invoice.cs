using System;
namespace SahinBankApp.Entity
{
	public class Invoice
	{
        public int InvoiceId { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? InvoiceName { get; set; }
        public DateTime InvoiceDueDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal Price { get; set; }
        public string? InvoiceOwner { get; set; }
        public bool IsPaid { get; set; }


    }
}

