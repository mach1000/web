using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int TeamId { get; set; }

        public Team Team { get; set; }
        public Session Session { get; set; }

    }
}