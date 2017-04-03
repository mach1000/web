using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name{ get; set; }
        public int TeamId { get; set; }

        public Team Team { get; set; }
        public Item Item { get; set; }
    }
}