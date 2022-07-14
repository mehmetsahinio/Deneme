using System;
using SahinBankApp.Business.Abstract;
using SahinBankApp.Data.Abstract;
using SahinBankApp.Entity;

namespace SahinBankApp.Business.Concrete
{
    public class ActionMoveManager : IActionMoveService
    {
        private IActionMoveRepository _actionMoveRepository;

        public ActionMoveManager(IActionMoveRepository actionMoveRepository)
        {
            _actionMoveRepository = actionMoveRepository;
        }

        public void Create(ActionMove entity)
        {
            _actionMoveRepository.Create(entity);
        }

        public void Delete(ActionMove entity)
        {
            _actionMoveRepository.Delete(entity);
        }

        public List<ActionMove> GetActionMoves()
        {
            return _actionMoveRepository.GetActionMoves();
        }

        public List<ActionMove> GetAll()
        {
            return _actionMoveRepository.GetAll();
        }

        public ActionMove GetById(int id)
        {
            return _actionMoveRepository.GetById(id);
        }

       

        public void Update(ActionMove entity)
        {
            _actionMoveRepository.Update(entity);
        }
    }
}

