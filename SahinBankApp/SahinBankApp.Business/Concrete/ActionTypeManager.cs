using System;
using SahinBankApp.Business.Abstract;
using SahinBankApp.Data.Abstract;
using SahinBankApp.Entity;

namespace SahinBankApp.Business.Concrete
{
    public class ActionTypeManager : IActionTypeService
    {
        private IActionTypeRepository _actionTypeRepository;

        public ActionTypeManager(IActionTypeRepository actionTypeRepository)
        {
            _actionTypeRepository = actionTypeRepository;
        }

        public void Create(ActionType entity)
        {
            _actionTypeRepository.Create(entity);
        }

        public void Delete(ActionType entity)
        {
            _actionTypeRepository.Delete(entity);
        }

        public List<ActionType> GetAll()
        {
            return _actionTypeRepository.GetAll();
        }

        public ActionType GetById(int id)
        {
           return _actionTypeRepository.GetById(id);
        }

        public void Update(ActionType entity)
        {
            _actionTypeRepository.Update(entity);
        }
    }
}

