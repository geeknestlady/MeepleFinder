using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeepleFinder.Data;
using MeepleFinder.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeepleFinder.ViewModels.GamesVM
{
    public class ListGamesViewModel
    {
        public static List<ListGamesViewModel> GetGames(RepositoryFactory factory)
        {
            return factory.GetGamesRepository()
                .GetModels()
                .Select(m => new ListGamesViewModel(m))
                .ToList();

        }

        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        public string Title { get; set; }
        public double Weight { get; set; }
        public int PlayTime { get; set; }
        public List<Category> Categories { get; set; }
        public List<Mechanism> Mechanism { get; set; }

        public ListGamesViewModel(Games game)
        {
            this.Id = game.Id;
            this.Title = game.Title;
            this.Weight = game.Weight;
            this.PlayTime = game.PlayTime;
            this.Categories = game.Categories;

        }
    }
}
