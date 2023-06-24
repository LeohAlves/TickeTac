using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TickeTac.Models;

namespace TickeTac.ViewModels
{
    public class EventOwnerViewModel
    {
        public List<Event> Events { get; set; }
        public AppUser Owner { get; set; }

    }
}