using System;
using SahinBankApp.Data.Abstract;
using SahinBankApp.Entity;

namespace SahinBankApp.Data.Concrete.EFCore
{
	public class EfCoreActionMoveRepository:EfCoreGenerictRepository<ActionMove,SahinBankAppDbContext>,IActionMoveRepository
	{
		
	}
}

