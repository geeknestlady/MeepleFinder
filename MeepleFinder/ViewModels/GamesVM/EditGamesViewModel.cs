using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeepleFinder.Data;
using MeepleFinder.Models;

namespace MeepleFinder.ViewModels.GamesVM
{
    public class EditGamesViewModel
    {
        private readonly RepositoryFactory repositoryFactory;

        public int Id { get; set; }
        public string Title { get; set; }
        public double Weight { get; set; }
        public int PlayTime { get; set; }

        public EditGamesViewModel() { }

        public EditGamesViewModel(int id)
        {
            Games game = repositoryFactory.GetGamesRepository().GetById(id);
                        
            this.Title = game.Title;
            this.Weight = game.Weight;
            this.PlayTime = game.PlayTime;

        }


        public void Update(int id, RepositoryFactory repositoryFactory)
        {
            Games game = new Games
            {
                Id = id,
                Title = this.Title,
                Weight = this.Weight,
                PlayTime = this.PlayTime,

            };
            repositoryFactory.GetGamesRepository().Save(game);
        }
    }
}
