using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SahinBankApp.Business.Abstract;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SahinBankApp.WebUI.Controllers
{
    public class ActionMove : Controller
    {
        private IActionMoveService _actionMoveService;

        public ActionMove(IActionMoveService actionMoveService)
        {
            _actionMoveService = actionMoveService;
        }

        public IActionResult ActionMoveList()
        {
            return View(_actionMoveService.GetAll());
        }
    }
}

