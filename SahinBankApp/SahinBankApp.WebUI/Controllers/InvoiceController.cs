using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SahinBankApp.Business.Abstract;
using SahinBankApp.WebUI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SahinBankApp.WebUI.Controllesrs
{
    public class Invoice : Controller
    {
        private IInvoiceService _invoiceService;

        public Invoice(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        public IActionResult InvoiceList()
        {

            return View(_invoiceService.GetAll());
        }
        public IActionResult InvoiceCreate()
        {
            return View();

        }
        [HttpPost]
        public IActionResult InvoiceCreate(InvoiceModel model)
        {
            var entity = new SahinBankApp.Entity.Invoice()
            {
                InvoiceId=model.InvoiceId,
                InvoiceNumber=model.InvoiceNumber,
                InvoiceName=model.InvoiceName,
                InvoiceDueDate=model.InvoiceDueDate,
                InvoiceDate=model.InvoiceDate,
                Price=model.Price,
                InvoiceOwner=model.InvoiceOwner,
                IsPaid=model.IsPaid
            };
            _invoiceService.Create(entity);
            return RedirectToAction("InvoiceList");
        }
        public IActionResult InvoiceEdit(int id)
        {
            var entity = _invoiceService.GetById(id);
            InvoiceModel model = new InvoiceModel()
            {
                InvoiceId=entity.InvoiceId,
                InvoiceNumber=entity.InvoiceNumber,
                InvoiceName=entity.InvoiceName,
                InvoiceDueDate=entity.InvoiceDueDate,
                InvoiceDate=entity.InvoiceDate,
                Price=entity.Price,
                InvoiceOwner=entity.InvoiceOwner,
                IsPaid=entity.IsPaid
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult InvoiceEdit(InvoiceModel model)
        {
            var entity = _invoiceService.GetById(model.InvoiceId);
            entity.InvoiceId = model.InvoiceId;
            entity.InvoiceNumber = model.InvoiceNumber;
            entity.InvoiceName = model.InvoiceName;
            entity.InvoiceDueDate = model.InvoiceDueDate;
            entity.InvoiceDate = model.InvoiceDate;
            entity.Price = model.Price;
            entity.InvoiceOwner = model.InvoiceOwner;
            entity.IsPaid = model.IsPaid;
            _invoiceService.Update(entity);
            return RedirectToAction("InvoiceList");
        }
        public IActionResult InvoiceDelete(int id)
        {
            var entity = _invoiceService.GetById(id);
            _invoiceService.Delete(entity);
            return RedirectToAction("InvoiceList");

        }
    }
}

