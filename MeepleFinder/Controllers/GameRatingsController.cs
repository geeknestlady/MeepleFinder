using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeepleFinder.ViewModels.GameRatingsVM;
using MeepleFinder.Data;

namespace MeepleFinder.Controllers
{
    public class GameRatingsController : Controller

    {
        private RepositoryFactory repositoryFactory;

        public GameRatingsController(RepositoryFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(int gameId)
        {
            CreateGameRatingsViewModel model = new CreateGameRatingsViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(int gameId, CreateGameRatingsViewModel model)
        {
            model.Persist(repositoryFactory);
            return RedirectToAction(actionName: nameof(Index));
        }
    }
}