using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TickeTac.Models;

namespace TickeTac.ViewModels
{
    public class UserViewModel
    {
        public List<Event> Events { get; set; }
        public List<Category> Categories { get; set; }
        public List<City> Cities { get; set; }
        public List<EventOwner> Owners { get; set; }
        public List<StatusEvent> StatusEvents { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}