using System;
using SahinBankApp.Business.Abstract;
using SahinBankApp.Entity;

namespace SahinBankApp.Business.Concrete
{
    public class ActionMoveManager : IActionMoveService
    {
        private IActionMoveService _actionMoveService;

        public ActionMoveManager(IActionMoveService actionMoveService)
        {
            _actionMoveService = actionMoveService;
        }

        public void Create(ActionMove entity)
        {
            _actionMoveService.Create(entity);
        }

        public void Delete(ActionMove entity)
        {
            _actionMoveService.Delete(entity);
        }

        public List<ActionMove> GetAll()
        {
            return _actionMoveService.GetAll();
        }

        public ActionMove GetById(int id)
        {
            return _actionMoveService.GetById(id);
        }

        public void Update(ActionMove entity)
        {
            _actionMoveService.Update(entity);
        }
    }
}

