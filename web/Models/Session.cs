using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public string Name { get; set; }
        public int CarId { get; set; }
        public int TrackId { get; set; }
        public int Laps { get; set; }

        public Track Track { get; set; }
        public Car Car { get; set; }
        public ICollection<Item> Item { get; set; }

    }
}