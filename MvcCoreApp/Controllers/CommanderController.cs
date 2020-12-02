using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCoreApp.Data;
using MvcCoreApp.Models;

namespace MvcCoreApp.Controllers
{
    public class CommanderController : Controller
    {
        private readonly ICommanderRepo _repo;

        public CommanderController(ICommanderRepo repo)
        {
            _repo = repo;
        }

        // GET: CommanderController
        public ActionResult Index()
        {
            return View(_repo.GetCommands());
        }

        // GET: CommanderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CommanderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommanderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Command cmd)
        {
            _repo.AddCommand(cmd);
            _repo.saveChanges();
            
            return RedirectToAction(nameof(Index));  
        }

        // GET: CommanderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CommanderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommanderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommanderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
