using System;
using SahinBankApp.Entity;

namespace SahinBankApp.Business.Abstract
{
	public interface IActionMoveService:IRepository<ActionMove>
	{
		List<ActionMove> GetActionMoves();


	}
}

