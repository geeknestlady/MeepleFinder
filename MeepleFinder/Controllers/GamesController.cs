using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeepleFinder.Data;
using MeepleFinder.Models;
using MeepleFinder.ViewModels.Games;

namespace MeepleFinder.Controllers
{
    public class GamesController : Controller
    {
        private RepositoryFactory repositoryFactory;

        public GamesController(RepositoryFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {

            CreateGamesViewModel model = new CreateGamesViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateGamesViewModel model)
        {
            
            model.Persist(repositoryFactory);
            return RedirectToAction(actionName: nameof(Index));
        }

        
    }
}