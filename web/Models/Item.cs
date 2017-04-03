using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Models
{
    public class Item
    {

        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public Category Category { get; set; }
        public ICollection<Session> Session { get; set; }
    }
}