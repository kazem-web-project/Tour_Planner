using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureProject.Models
{
    public class Tour
    {
        public string _name { get; set; }
        public string _description { get; set; }

        public string _from { get; set; }
        public string _to { get; set; }
        public string _vehicle { get; set; }
        public float _distance { get; set; }
        public TimeSpan _duration { get; set; }
        public string? _routeImageURL { get; set; }

    }
}
