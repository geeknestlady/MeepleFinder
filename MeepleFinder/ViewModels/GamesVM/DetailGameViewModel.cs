using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeepleFinder.Data;
using MeepleFinder.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MeepleFinder.ViewModels.GamesVM
{
    public class DetailGameViewModel
    {
        public static DetailGameViewModel GetDetails (RepositoryFactory factory, int id)
        {
            Games game = factory.GetGamesRepository()
                .GetById(id);
            List<GameRatings> ratings = factory.GetGameRatingsRepository()
                .GetModels()
                .Where(r => r.GameId == id)
                .ToList();

            return new DetailGameViewModel()
            {
                Title = game.Title,
                Weight = game.Weight,
                Id = game.Id,
                PlayTime = game.PlayTime,
            };
            
               
        }

        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        public string Title { get; set; }
        public double Weight { get; set; }
        public int PlayTime { get; set; }
               
    }
}
