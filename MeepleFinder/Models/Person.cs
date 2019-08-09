using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeepleFinder.Models;

namespace MeepleFinder.Models
{
    public class Person : IModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string AboutMe { get; set; }

        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        
        public virtual List<GameRatings> GameRatings { get; set; }
    }
}
