﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MeepleFinder.Data;
using MeepleFinder.Models;

namespace MeepleFinder.ViewModels.GameRatingsVM
{
    public class CreateGameRatingsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "I own this game.")]
        public bool Ownership { get; set; } 

        [Display(Name = "I would want to play this game again.")]
        public bool PlayAgain { get; set; }

        [Display(Name = "My rating for the game.")]
        public int Rating { get; set; }

        [Display(Name = "How many times I played this game.")]
        public int TimesPlayed { get; set; }
        public string GameTitle { get; set; }
        //public virtual Games Games { get; set; }

        public int PersonId { get; set; }
        public int GameId { get; set; }

        public static CreateGameRatingsViewModel GetGameTitle(int gameId, RepositoryFactory repositoryFactory)
        {
            Games game = repositoryFactory.GetGamesRepository()
                .GetById(gameId);

            CreateGameRatingsViewModel gT = new CreateGameRatingsViewModel
            {
                GameTitle = game.Title,
            };

            return gT;           
         
        }


        internal void Persist(RepositoryFactory repositoryFactory)
        {
            GameRatings rating = new GameRatings
            {
                PersonId = this.PersonId,
                GameId = this.GameId,
                Ownership = this.Ownership,
                PlayAgain = this.PlayAgain,
                Rating = this.Rating,
                TimesPlayed = this.TimesPlayed,
            };
            repositoryFactory.GetGameRatingsRepository().Save(rating);
        }
    }
}