using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeepleFinder.Data;
using MeepleFinder.Models;

namespace MeepleFinder.ViewModels.Games
{
    public class CreateGamesViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Weight { get; set; }
        public int PlayTime { get; set; }
        public List<Category> Categories { get; set; }
        public List<Mechanism> Mechanism { get; set; }


        public int PersonId { get; set; }

        public CreateGamesViewModel() { }

      


        public void Persist(RepositoryFactory repositoryFactory)
        {
            Models.Games games = new Models.Games
            {
                Title = this.Title,
                Weight = this.Weight,
                PlayTime = this.PlayTime,
                Categories = this.Categories,
                Mechanism = this.Mechanism,
            };
                      
            repositoryFactory.GetGamesRepository().Save(games);
        }
    }

}
