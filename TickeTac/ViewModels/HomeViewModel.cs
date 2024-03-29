using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TickeTac.Models;

namespace TickeTac.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Event> Events { get; set; }
        public List<Category> Categories { get; set; }
        public List<City> Cities { get; set; }
        public List<AppUser> Users { get; set; }
        public List<StatusEvent> StatusEvents { get; set; }

        public string SearchCity { get; set; }
        public string SearchCategory { get; set; }
        public string SearchWords { get; set; }
    }
}