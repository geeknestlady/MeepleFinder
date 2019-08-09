using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeepleFinder.Models;

namespace MeepleFinder.Data
{
    public class RepositoryFactory
    {
        private ApplicationDbContext context;

        public RepositoryFactory(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IRepository<Games> GetGamesRepository()
        {
            return new BaseRepository<Games>(context);
        }
        public IRepository<GameRatings> GetGameRatingsRepository()
        {
            return new BaseRepository<GameRatings>(context);
        }
      
    }
}
