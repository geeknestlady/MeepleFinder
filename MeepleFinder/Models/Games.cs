using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeepleFinder.Models
{
    public class Games : IModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Weight { get; set; }
        public DateTime PlayTime { get; set; }
        public List<String> Categories { get; set; }
        public List<String> Mechanism { get; set; }
    }
}
