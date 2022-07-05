using System;
using SahinBankApp.Data.Abstract;
using SahinBankApp.Entity;

namespace SahinBankApp.Data.Concrete.EFCore
{
	public class EfCoreActionTypeRepository:EfCoreGenerictRepository<ActionType,SahinBankAppDbContext>,IActionTypeRepository
	{
		
	}
}

