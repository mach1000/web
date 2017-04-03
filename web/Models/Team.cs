using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Models
{
    public class Team
    {
        public Team()
        {
            Car = new List<Car>();
            Category = new List<Category>();
            Track = new List<Track>();
        }

        public int TeamId { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }

        public ICollection<Car> Car { get; set; }
        public User User { get; set; }
        public ICollection<Category> Category { get; set; }
        public ICollection<Track> Track { get; set; }
    }
}