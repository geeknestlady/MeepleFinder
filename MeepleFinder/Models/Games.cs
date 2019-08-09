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
        public int PlayTime { get; set; }
        public virtual List<Category> Categories { get; set; }
        public virtual List<Mechanism> Mechanism { get; set; }
        

        public int PersonId { get; set; }
    }
}
