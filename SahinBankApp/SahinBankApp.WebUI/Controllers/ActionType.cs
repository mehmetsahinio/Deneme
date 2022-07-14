using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SahinBankApp.Business.Abstract;
using SahinBankApp.WebUI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SahinBankApp.WebUI.Controllers
{
    public class ActionType : Controller
    {
        private IActionTypeService _actionTypeService;

        public ActionType(IActionTypeService actionTypeService)
        {
            _actionTypeService = actionTypeService;
        }

        public IActionResult ActionTypeList()
        {
            
            return View(_actionTypeService.GetAll());
        }
        public IActionResult ActionTypeCreate()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ActionTypeCreate(ActionTypeModel model)
        {
            var entity = new SahinBankApp.Entity.ActionType()
            {
                ActionTypeName=model.ActionTypeName,
                ActionTypeDescription=model.ActionTypeDescription
            };
            _actionTypeService.Create(entity);

            return RedirectToAction("ActionTypeList");
        }
        public IActionResult ActionTypeEdit(int id)
        {
            var entity = _actionTypeService.GetById(id);
            ActionTypeModel model = new ActionTypeModel()
            {
               ActionTypeId=entity.ActionTypeId,
                ActionTypeName=entity.ActionTypeName,
                ActionTypeDescription=entity.ActionTypeDescription

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult ActionTypeEdit(ActionTypeModel model)
        {
            var entity = _actionTypeService.GetById(model.ActionTypeId);
            entity.ActionTypeId = model.ActionTypeId;
            entity.ActionTypeName = model.ActionTypeName;
            entity.ActionTypeDescription = model.ActionTypeDescription;
            _actionTypeService.Update(entity);
            return RedirectToAction("ActionTypeList");

        }
        public IActionResult ActionTypeDelete(int id)
        {
            var entity = _actionTypeService.GetById(id);
            _actionTypeService.Delete(entity);
            return RedirectToAction("ActionTypeList");

        }
    }
}

