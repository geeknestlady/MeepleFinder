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
        public Location Location { get; set; }
        public Games Games { get; set; }
        
    }
}
