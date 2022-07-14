using System;
using SahinBankApp.Entity;

namespace SahinBankApp.Data.Abstract
{
	public interface IActionMoveRepository:IRepository<ActionMove>
	{
		public List<ActionMove> GetActionMoves();

	}
}

