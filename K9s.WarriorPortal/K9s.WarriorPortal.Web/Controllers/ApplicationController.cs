using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using K9s.WarriorPortal.Models;
using K9s.WarriorPortal.Services.Contracts;

namespace K9s.WarriorPortal.Web.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IWarriorApplicationQueryService _warriorApplicationQueryService;
        private readonly IWarriorApplicationCommandService _warriorApplicationCommandService;

        public ApplicationController(IWarriorApplicationCommandService warriorApplicationCommandService,
            IWarriorApplicationQueryService warriorApplicationQueryService)
        {
            _warriorApplicationCommandService = warriorApplicationCommandService;
            _warriorApplicationQueryService = warriorApplicationQueryService;
        }


        //
        // GET: Application
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        //
        // POST: Application
        [HttpPost]
        public async Task<ActionResult> Index(WarriorApplication application)
        {
            if (!ModelState.IsValid)
            {
                return View(application);
            }

            try
            {
                await _warriorApplicationCommandService.AddWarriorApplicationAsync(application);
            }
            catch
            {
                return RedirectToAction("ApplicationError");
            }

            return RedirectToAction("Success");
        }


        //
        // GET: Success
        [HttpGet]
        public ActionResult Success()
        {
            // TODO.JB - create this view
            return View();
        }


        //
        // GET: Error
        [HttpGet]
        public ActionResult ApplicationError()
        {
            // TODO.JB - create this view
            return View();
        }


        //
        // GET: OpenApplications
        [HttpGet]
        [Authorize]
        public async Task<ActionResult> OpenApplications()
        {
            var openApplications = await _warriorApplicationQueryService.GetOpenApplicationsAsync();

            // TODO.JB - create this view
            return View(openApplications);
        }
    }
}