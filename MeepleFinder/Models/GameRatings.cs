using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeepleFinder.Models
{
    public class GameRatings : IModel
    {
        public int Id { get; set; }
        public bool Ownership { get; set; }
        public bool PlayAgain { get; set; }
        public int Rating { get; set; }
        public int TimesPlayed { get; set; }
    }
}
