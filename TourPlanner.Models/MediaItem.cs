using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourPlanner.Models
{
    public class MediaItem
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime CreateTime { get; set; }
        public TourLog TourLog { get; set; }
        public Tour Tour { get; set; }

    }
}
