namespace TourPlanner.Models
{
    public class TourLog
    {
        public string difficultyText { get; set; }
        public string ratingText { get; set; } 
        public string durationText { get; set; }
        public string distanceText { get; set; }
        public string dateTimeText { get; set; }
        public string commentText { get; set; } 
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
