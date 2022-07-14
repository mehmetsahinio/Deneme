using System;
using Microsoft.EntityFrameworkCore;
using SahinBankApp.Data.Abstract;
using SahinBankApp.Entity;

namespace SahinBankApp.Data.Concrete.EFCore
{
    public class EfCoreActionMoveRepository : EfCoreGenerictRepository<ActionMove, SahinBankAppDbContext>, IActionMoveRepository
    {
        public List<ActionMove> GetActionMoves()
        {
            using (var context = new  SahinBankAppDbContext())
            {
                return context.Actions.Include(x => x.Invoice).ToList();
            }
        }


      

    }
}

