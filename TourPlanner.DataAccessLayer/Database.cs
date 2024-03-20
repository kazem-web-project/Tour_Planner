using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.Models;

namespace TourPlanner.DataAccessLayer
{    
    class Database : IDataAccess
    {
        private string connectionString;
        private List<TourLog> mediaItems;

        public Database()
        {
            // get connection from config file
            connectionString = "...";
            // establish connection with db
            this.mediaItems = new List<TourLog>()
            {
                new TourLog(){commentText= "good route 1", difficultyText="Medium",ratingText="5",dateTimeText="2024.3.2 13:00",durationText="2:23", distanceText="2km"},
                new TourLog(){commentText = "romantic route 1", difficultyText="Easy",ratingText="3",dateTimeText="2024.3.12 13:00",durationText="3:13", distanceText="2.2km"},
                new TourLog(){commentText = "hard route 1", difficultyText = "Hard",ratingText="4",dateTimeText="2024.2.22 13:00",durationText="1:43", distanceText="1km"},
                new TourLog(){commentText = "die route 1", difficultyText = "Very Hard", ratingText = "5",dateTimeText="2024.6.2 13:00",durationText="4:25", distanceText="20km"},
                new TourLog(){commentText = "fun route 1", difficultyText = "Easy", ratingText = "4.3",dateTimeText="2024.7.22 13:00",durationText="2:45", distanceText="12km"}
            };
        }

        public void addItem(TourLog newTourLog)
        {
            // TODO: change it with the database!
            this.mediaItems.Add(new TourLog(){commentText = newTourLog.commentText});
        }

        public List<TourLog> GetItems()
        {/*
            this.mediaItems = new List<MediaItem>()
            {
                new MediaItem(){Name = "Item1"},
                new MediaItem(){Name = "Item2"},
                new MediaItem(){Name = "Another"},
                new MediaItem(){Name = "SWE"},
                new MediaItem(){Name = "FHTW"}
            };
            */
            return this.mediaItems; 

            
        }

        public void removeItem(TourLog tourLog)
        {
            this.mediaItems.Remove(tourLog);
        }
    }
}
