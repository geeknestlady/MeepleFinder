using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeepleFinder.Data;
using MeepleFinder.Models;
using MeepleFinder.ViewModels.GamesVM;

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
            List<ListGamesViewModel> games = ListGamesViewModel.GetGames(repositoryFactory);
            return View(games);
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