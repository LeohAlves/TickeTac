using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TickeTac.Models;

namespace TickeTac.ViewModels
{
    public class DetailsViewModel
    {
        public Event Events { get; set; }
        public Category Categories { get; set; }
        public City Cities { get; set; }
        public EventOwner Owners { get; set; }
        public List<EventReviews> Reviews { get; set; }

    }
}
