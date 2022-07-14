using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SahinBankApp.Business.Abstract;
using SahinBankApp.WebUI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SahinBankApp.WebUI.Controllers
{
    public class ActionMove : Controller
    {
        private IActionMoveService _actionMoveService;
        private IActionTypeService _actionTypeService;
        private IInvoiceService _invoiceService;

        public ActionMove(IActionMoveService actionMoveService, IActionTypeService actionTypeService, IInvoiceService invoiceService)
        {
            _actionMoveService = actionMoveService;
            _actionTypeService = actionTypeService;
            _invoiceService = invoiceService;
        }

        public IActionResult ActionMoveList()
        {
            return View(_actionMoveService.GetAll());
        }
        public IActionResult ActionMoveCreate()
        {
            ViewBag.Invoice = new SelectList(_invoiceService.GetAll(), "InvoiceNumber", "InvoiceName");
            ViewBag.ActionType = new SelectList(_actionTypeService.GetAll(), "ActionTypeId", "ActionTypeName");

            return View();
        }

        [HttpPost]
        public IActionResult ActionMoveCreate(ActionMoveModel model)
        {
            var entity = new SahinBankApp.Entity.ActionMove()
            {
                ActionMoveId=model.ActionMoveId,
                UserId=model.UserId,
                ActionTypeId = model.ActionTypeId,
                ActionType=model.ActionType,
                Date=model.Date,
                ActionAmount=model.ActionAmount,
                ActionDeduction=model.ActionDeduction,
                InvoiceNumber=model.InvoiceNumber
            };
       


            _actionMoveService.Create(entity);
            return RedirectToAction("ActionMoveList");

        }

        public IActionResult ActionMoveEdit(int id)
        {
            var entity = _actionMoveService.GetById(id);
            ViewBag.Invoice = new SelectList(_invoiceService.GetAll(), "InvoiceNumber", "InvoiceName");
            ViewBag.ActionType = new SelectList(_actionTypeService.GetAll(), "ActionTypeId", "ActionTypeName");
            ActionMoveModel model = new ActionMoveModel()
            {
                ActionMoveId = entity.ActionMoveId,
                UserId = entity.UserId,
                ActionTypeId = entity.ActionTypeId,
                ActionType = entity.ActionType,
                Date = entity.Date,
                ActionAmount = entity.ActionAmount,
                ActionDeduction = entity.ActionDeduction,
                InvoiceNumber = entity.InvoiceNumber
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult ActionMoveEdit(ActionMoveModel model)
        {
            var entity = _actionMoveService.GetById(model.ActionMoveId);
            entity.ActionMoveId = model.ActionMoveId;
            entity.UserId = model.UserId;
            entity.ActionTypeId = model.ActionTypeId;
            entity.Date = model.Date;
            entity.ActionAmount = model.ActionAmount;
            entity.ActionDeduction = model.ActionDeduction;
            entity.InvoiceNumber = entity.InvoiceNumber;
            _actionMoveService.Update(entity);
            return RedirectToAction("ActionMoveList");

        }

        public IActionResult ActionMoveDelete(int id)
        {
            var entity = _actionMoveService.GetById(id);
            _actionMoveService.Delete(entity);
            return RedirectToAction("ActionMoveList");

        }
    }
}

