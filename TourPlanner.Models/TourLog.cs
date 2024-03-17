using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourPlanner.Models
{
    public class TourLog
    {
        public string difficultyText { get; set; } = null;
        public string ratingText { get; set; } = null;
        public string durationText { get; set; } = null;
        public string distanceText { get; set; } = null;
        public string dateTimeText { get; set; } = null;
        public string commentText { get; set; } = null;
        public TourLog()
        {
            
        }

        public TourLog(string difficultyText, string ratingText, string durationText, string distanceText, string dateTimeText, string commentText)
        {
            this.difficultyText = difficultyText;
            this.ratingText = ratingText;
            this.durationText = durationText;
            this.distanceText = distanceText;
            this.dateTimeText = dateTimeText;
            this.commentText = commentText;
        }

    }
}
