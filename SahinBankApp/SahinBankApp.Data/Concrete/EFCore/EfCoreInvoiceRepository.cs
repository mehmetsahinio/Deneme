using System;
using SahinBankApp.Data.Abstract;
using SahinBankApp.Entity;

namespace SahinBankApp.Data.Concrete.EFCore
{
	public class EfCoreInvoiceRepository:EfCoreGenerictRepository<Invoice,SahinBankAppDbContext>,IInvoiceRepository
	{

	}
}

