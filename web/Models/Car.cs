using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Models
{
    public class Car
    {
        public Car()
        {
            Session = new List<Session>();
        }

        public int CarId { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }

        public Team Team { get; set; }
        ICollection<Session> Session {get; set;}

    }
}